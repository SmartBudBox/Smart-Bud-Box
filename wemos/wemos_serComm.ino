/*
   SETUP HERE


   wemos pinout: https://wiki.wemos.cc/products:d1:d1_mini
   wemos driver https://wiki.wemos.cc/downloads

   install wemos board to ide: https://learn.sparkfun.com/tutorials/esp8266-thing-hookup-guide/installing-the-esp8266-arduino-addon

   install the 
   DHT Sensor Libary
   ArduinoJSon
   Adafruit Unified Sensor
   
    from "Sktech - Include Libary - Manage Libarys"

*/
//const long sensor_submission_interval = 10000; // interval for sensor data submission in ms: 60000 for 60 secound

  Wire.begin();
  writeI2CRegister8bit(0x20, 6);
  delay(100);
  dht1.begin();



  // give soil sensor time to switch into sensor mode
  int i = 0;
  while(i < 10){ 
    writeI2CRegister8bit(0x20, 3);
    readI2CRegister16bit(0x20, 4);
    i++;
    delay(100);
  }

//*********************************************************************************
//Hier sind die Credentials die vom Setup Tool kommen                *
//*********************************************************************************
String ssid;                         //Speicherplatz beginnt bei 10  Lï¿½nge Speicherplatz 1
String pass;                         //Speicherplatz beginnt bei 40  Lï¿½nge Speicherplatz 2
String host;                         //Speicherplatz beginnt bei 70  Lï¿½nge Speicherplatz 3
String httpPort;                     //Speicherplatz beginnt bei 100  Lï¿½nge Speicherplatz 4
String host_url;                     //Speicherplatz beginnt bei 107  Lï¿½nge Speicherplatz 5
String api_password;                 //Speicherplatz beginnt bei 137 Lï¿½nge Speicherplatz 6
String sensor_submission_interval;   //Speicherplatz beginnt bei 167 Lï¿½nge Speicherplatz 7
String incoming;                     //EmpfÃ¤nger Variable fÃ¼r Serielle Schnittstelle
int CredentialsOK;
////Hat so la la Funktioniert ----------------------------------------------
char incomingBytes[80]; // = 0;
int lf = 13;
////Hat so la la Funktioniert ----------------------------------------------
//*********************************************************************************

/*
   SETUP END


   setup finished, do not change any thing here if u dont know what u are doing
*/

//************************************************************************
//Hier ist der INCLUDE BEREICH                                           *
//************************************************************************
#include "ESP8266WiFi.h"  //WIFI Board                                   *
#include <Wire.h>                                                        *
#include <DHT.h>          //Feuchte Sensoren                             *
#include <ArduinoJson.h>  //Libary für die Sensoren                      *
#include <EEPROM.h>       //Schreiben und Lesen aus / in EEPROM          *
//************************************************************************


//************************************************************************
//Hier ist der Definde BEREICH                                           *
//************************************************************************
#define FAN 13      // D7
#define EXHAUST 15  // D8
#define PUMPE 14    // D5
#define LICHT 12    // D6
#define DHT_1 0     // D3
#define SOIL_SCL D1  // D1
#define SOIL_SDA D2  // D2
//************************************************************************


DHT dht1(DHT_1, DHT22);

int status_light = 0;
int status_fan = 1024;
int status_exhaust = 1024;
String website_data = "";
unsigned long sensor_submission_last = 0;



//************************************************************************
// start reading from the first byte (address 0) of the EEPROM
//************************************************************************
byte value;
//************************************************************************


int inByte;
char inText[300];
int index2;


void setup()
{
  analogWriteFreq(31300);
  
  Serial.begin(115200);       
  Serial.println("SBB Controller gestartet");
  EEPROM.begin(512);

  pinMode(BUILTIN_LED, OUTPUT);  // initialize onboard LED as output
  pinMode(LICHT, OUTPUT);
  pinMode(PUMPE, OUTPUT);
  digitalWrite(LICHT, HIGH);
  digitalWrite(PUMPE, HIGH);
 
//************************************************************************
//Laden der Credentials mit 20 Sekunden WarteZeit
//Falls die Credentials über das Setup geändert werden sollen
//************************************************************************
memset(incomingBytes, 0, sizeof(incomingBytes));
Serial.println("Warte auf Credentials Change");
int counter = 0;
for (int counter = 0; counter < (20); ++counter)
{

 if (Serial.available() > 0) {
    
    // read the incoming byte:
    //incomingByte = Serial.read();
    Serial.readBytesUntil(lf, incomingBytes, 80);
  
    // say what you received in ASCII
    //Serial.print("I received: ");
    Serial.println(incomingBytes);
    CheckData(incomingBytes);
    memset(incomingBytes, 0, sizeof(incomingBytes));
    
    }
delay(1000);
}
//************************************************************************
CredentialsOK = 0;
sensor_submission_interval = GETsensor_submission_interval();


//
////WIEDER LÖSCHEN ODER DEAKTIVIEREN
//ClearEEPROM();                 //*

memset(incomingBytes, 0, sizeof(incomingBytes));
//--------------------------------
 while (CredentialsOK != 1) 
 {
    delay(500);
    //Serial.println("Warte auf Daten");
    //Serial.println(CredentialsOK);


//Hat so la la Funktioniert ----------------------------------------------
  if (Serial.available() > 0) {
    
    // read the incoming byte:
    //incomingByte = Serial.read();
    Serial.readBytesUntil(lf, incomingBytes, 80);
  
    // say what you received in ASCII
    //Serial.print("I received: ");
    Serial.println(incomingBytes);
    CheckData(incomingBytes);
    memset(incomingBytes, 0, sizeof(incomingBytes));
    
    }
//Hat so la la Funktioniert ----------------------------------------------


  
 }


  ssid = GETssid();
  pass = GETpass();
  host = GEThost();
  httpPort = GEThttpPort();
  host_url = GEThost_url();
  api_password = GETapi_password();
  sensor_submission_interval = GETsensor_submission_interval();
 
  
   
  digitalWrite(BUILTIN_LED, HIGH);
  Serial.println("connecting to wifi ap");

  WiFi.mode(WIFI_STA);
  WiFi.begin(ssid.c_str(), pass.c_str());

  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  Serial.println("");
  Serial.println("wifi connected");

  read_website_data("clear_transmissions");
}

void writeI2CRegister8bit(int addr, int value) {
  Wire.beginTransmission(addr);
  Wire.write(value);
  Wire.endTransmission();
}

unsigned int readI2CRegister16bit(int addr, int reg) {
  Wire.beginTransmission(addr);
  Wire.write(reg);
  Wire.endTransmission();
  delay(20);
  Wire.requestFrom(addr, 2);
  unsigned int t = Wire.read() << 8;
  t = t | Wire.read();
  return t;
}

/**
   in url u give the action parameters and other get parameters, like: submit&value=1
   index.php?page... will be done automatically
*/

void read_website_data(String url)
{
  website_data = "";
  url =  String(host_url.c_str()) + "/index.php?page=wemos&action=" + String(url);
  Serial.print("connecting to ");
  Serial.println(host);
  //Serial.print("DEBUG Verbinden zu" + url);

  // Use WiFiClient class to create TCP connections
  WiFiClient client;
  if (!client.connect(host.c_str(), httpPort.toInt())) {
    Serial.println("connection failed");
    return;
  }

  // We now create a URI for the request
  url = url + "&box=" + String(ESP.getChipId()) + "&password=" + api_password.c_str();

  Serial.print("requesting adress: ");
  Serial.println(host + url);

  // This will send the request to the server
  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host.c_str() + "\r\n" +
               "Connection: close\r\n\r\n");
  unsigned long timeout = millis();
  while (client.available() == 0) {
    if (millis() - timeout > 10000) {
      Serial.println(">>> Client Timeout !");
      client.stop();
      return;
    }
  }
  // Read all the lines of the reply from server and print them to Serial

  int x = 0;
  while (client.available()) {
    String line = client.readStringUntil('\r');
    
    line.trim();

    if (line.startsWith("{")) {
      website_data += line;
    }
    else if (x == 15) {
      website_data += line;
    }
    x++;
    
  }

  Serial.print("parsed content: ");
  Serial.println(website_data);

  delay(300);

  return;
}

void loop()
{



  // read sensordata and submit to api action: sensordata if interval reached
  unsigned long currentMillis = millis();
  if (currentMillis - sensor_submission_last >= sensor_submission_interval.toInt()) {
      digitalWrite(BUILTIN_LED, LOW);
      delay(500);
      digitalWrite(BUILTIN_LED, HIGH);
    int soil = readI2CRegister16bit(0x20, 0);    
    read_website_data("sensordata&temp=" + String(dht1.readTemperature()) + "&humi=" + String(dht1.readHumidity()) + "&soil=" + soil);
    sensor_submission_last = currentMillis;
  }


  // submit current status
  read_website_data("boxstatus&light=" + String(status_light) + "&fan=" + String(status_fan) + "&exhaust=" + String(status_exhaust));

  // read new jobs
  read_website_data("read_transmission_json");
  StaticJsonBuffer<200> jsonBuffer;
  JsonObject& root = jsonBuffer.parseObject(website_data);

  if (!root.success())
  {
    Serial.println("parseObject() failed");
    return;
  }

  const char* command = "";
  const char* value = "";

  command   = root["command"];
  value     = root["value"];

  if (strcmp (command, "switch_light") == 0)
  {
    status_light = atoi(value);

    Serial.print("switching light from ");
    Serial.print(status_light);
    Serial.print(" to ");
    Serial.println(value);

    if (status_light == 1)
    {
      digitalWrite(LICHT, LOW);
    }
    else
    {
      digitalWrite(LICHT, HIGH);
    }

  }

  if (strcmp (command, "set_exhaust") == 0)
  {
    status_exhaust = atoi(value);

    Serial.print("set exhaust from ");
    Serial.print(status_exhaust);
    Serial.print(" to ");
    Serial.println(value);


    analogWrite(EXHAUST, status_exhaust);
  }

  if (strcmp (command, "set_fan") == 0)
  {
    status_fan = atoi(value);

    Serial.print("set fan from ");
    Serial.print(status_fan);
    Serial.print(" to ");
    Serial.println(value);


    analogWrite(FAN, status_fan);
  }

  if (strcmp (command, "watering") == 0)
  {
    int runtime = atoi(value);

    Serial.print("watering with pump runtime of ");
    Serial.println(runtime);

    if (status_light == 1)
    {
      digitalWrite(LICHT, HIGH);
    }

    delay(500);
    digitalWrite(PUMPE, LOW);
    delay(runtime);
    digitalWrite(PUMPE, HIGH);
    delay(500);

    if (status_light == 1)
    {
      digitalWrite(LICHT, LOW);
    }
  }

  delay(100);
}


//**********************************************************************************************
//Hier Beginnt Bereich für die Serielle Kommunikation mit dem SBB Setup TOOL
//**********************************************************************************************
String GETssid()
{
  //Lese auf dem EEPROM die SSID Lï¿½nge
  int iMax;
  iMax = EEPROM.read(1);
  int Start = 10;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM ssid");
  String esid;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    esid += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  //Serial.print("SSID: ");
  ssid = esid;
  Serial.println("SSID:" + ssid);
  return ssid;  
}
//**********************************************************************************************
String GETpass()
{
  //Lese auf dem EEPROM die SSID Lï¿½nge
  int iMax;
  iMax = EEPROM.read(2);
  int Start = 40;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM WLAN KEY");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("Key: ");
  pass = string;
  Serial.println(pass);
  return pass;
}
//**********************************************************************************************
String GEThost()
{
  //Lese auf dem EEPROM 
  int iMax;
  //HOST Lï¿½nge Speicher PLatz 3
  iMax = EEPROM.read(3);
  //Ab 70
  int Start = 70;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM HOST");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("HOST: ");
  host = string;
  Serial.println(host);
  return host;
}
//**********************************************************************************************
String GEThttpPort()
{
  //Lese auf dem EEPROM 
  int iMax;
  //HOST Lï¿½nge Speicher PLatz 4
  iMax = EEPROM.read(4);
  //Ab 100
  int Start = 100;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM HTTP PORT");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("PORT: ");
  httpPort = string;
  Serial.println(httpPort);
  return httpPort;
}
//**********************************************************************************************
String GEThost_url()
{
  //Lese auf dem EEPROM 
  int iMax;
  //HOST Lï¿½nge Speicher PLatz 5
  iMax = EEPROM.read(5);
  //Ab 97
  int Start = 107;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM URL");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("URL: ");
  host_url = string;
  Serial.println(host_url);
  return host_url;
  
}
//**********************************************************************************************
String GETapi_password()
{
  //Lese auf dem EEPROM 
  int iMax;
  //API Lï¿½nge Speicher PLatz 6
  iMax = EEPROM.read(6);
  //Ab 97
  int Start = 137;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM API");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("API: ");
  api_password = string;
  Serial.println(api_password);
  return api_password;
}
//**********************************************************************************************
String GETsensor_submission_interval()
{
  //Lese auf dem EEPROM 
  int iMax;
  //SEN Lï¿½nge Speicher PLatz 7
  iMax = EEPROM.read(7);
  //Ab 97
  int Start = 167;
  // read eeprom for ssid and pass
  //Serial.println("Reading EEPROM SEN");
  String string;
  for (int i = 0; i < (iMax + 1); ++i)
  {
    string += char(EEPROM.read(Start));
    Start = Start + 1;
  }
  Serial.print("INTERVALL: ");
  sensor_submission_interval = string;
  Serial.println(sensor_submission_interval);
  if (sensor_submission_interval != "") {
    CredentialsOK = 1;
  }
  return sensor_submission_interval;
}
//**********************************************************************************************
void ClearEEPROM()
{
  Serial.println("CLEARING EEPROM");

  for (int i = 0; i < 190; ++i)
  {
    EEPROM.write(i, 0);
  }
  EEPROM.commit();
  Serial.println("EEPROM GELÖSCHT");
}
//**********************************************************************************************


//**********************************************************************************************
//Hier ist der Bereich für die Serielle Kommunikation mit EMPFANGSAUSWERTUNG
//**********************************************************************************************
void CheckData(String incoming) {
  //=======================================================
  // Abfrage das es der WLAN SSID ist
  //=======================================================
  if (incoming.startsWith("SSID"))
  {
    String serWLAN_SSID = incoming.substring(4);
    Serial.println("WLAN SSID erkannt: " + serWLAN_SSID);
    Serial.println("Schreibe ins eeprom SSID:" + serWLAN_SSID);
    int Start = 10;
    for (int i = 0; i < serWLAN_SSID.length() + 1; ++i)
    {
      EEPROM.write(Start, serWLAN_SSID[i]);
      Start = Start + 1;
    }
    EEPROM.write(1, serWLAN_SSID.length() + 1);
    EEPROM.commit();
    //Entleere
    serWLAN_SSID = "";

     Blinken();
  }
  //=======================================================
  


  //=======================================================
  //Abfrage ob es der WLAN Schlï¿½ssel ist
  //=======================================================
  if (incoming.startsWith("PASS"))
  {
    String serPassword = incoming.substring(4);
    Serial.println("WLAN Password: " + serPassword);
    Serial.println("Schreibe ins eeprom WLAN KEY:" + serPassword);
    // WLAN Key Beginnt bei Speicherplatz 40
    int Start = 40;
    for (int i = 0; i < serPassword.length() + 1; ++i)
    {
      EEPROM.write(Start, serPassword[i]);
      Start = Start + 1;
    }
    EEPROM.write(2, serPassword.length());
    EEPROM.commit();
    //Entleere 
    serPassword = "";

    Blinken();
    
  }
  //=======================================================



  //=======================================================
  //Abfrage ob es der HOST ist
  //=======================================================
  if (incoming.startsWith("HOST"))
  {
    String serHOST = incoming.substring(4);
    Serial.println("HOST: " + serHOST);
    Serial.println("Schreibe ins eeprom HOST:" + serHOST);
    // HOST Beginnt bei Speicherplatz 70
    int Start = 70;
    for (int i = 0; i < serHOST.length() + 1; ++i)
    {
      EEPROM.write(Start, serHOST[i]);
      Start = Start + 1;
    }
    //Speicherplatz Lï¿½nge 3
    EEPROM.write(3, serHOST.length());
    EEPROM.commit();
    //Entleere 
    serHOST = "";
     Blinken();
  }
  //=======================================================



  //=======================================================
  //Abfrage ob es der http Port ist
  //=======================================================
  if (incoming.startsWith("HTTP"))
  {
    String serHTTPPort = incoming.substring(4);
    Serial.println("HTTPPort: " + serHTTPPort);
    Serial.println("Schreibe ins eeprom PORT:" + serHTTPPort);
    // PORT Beginnt bei Speicherplatz 100
    int Start = 100;
    for (int i = 0; i < serHTTPPort.length() + 1; ++i)
    {
      EEPROM.write(Start, serHTTPPort[i]);
      Start = Start + 1;
    }
    //Speicherplatz Lï¿½nge 4
    EEPROM.write(4, serHTTPPort.length());
    EEPROM.commit();

    //Entleere
    serHTTPPort = "";
     Blinken();
  }
  //=======================================================



  //=======================================================
  //Abfrage ob es der URL ist
  //=======================================================
  if (incoming.startsWith("URL"))
  {
    String serURL = incoming.substring(3);
    Serial.println("HOST URL: " + serURL);
    Serial.println("Schreibe ins eeprom HOST:" + serURL);
    // PORT Beginnt bei Speicherplatz 107
    int Start = 107;
    for (int i = 0; i < serURL.length() + 1; ++i)
    {
      EEPROM.write(Start, serURL[i]);
      Start = Start + 1;
    }
    //Speicherplatz Lï¿½nge 5
    EEPROM.write(5, serURL.length());
    EEPROM.commit();

    //Entleere 
    serURL = "";
     Blinken();
  }
  //=======================================================



  //=======================================================
  //Abfrage API Passwort
  //=======================================================
  if (incoming.startsWith("API"))
  {
    String serAPI = incoming.substring(3);
    Serial.println("API Passwort: " + serAPI);
    Serial.println("Schreibe ins eeprom API:" + serAPI);
    // PORT Beginnt bei Speicherplatz 137
    int Start = 137;
    for (int i = 0; i < serAPI.length() + 1; ++i)
    {
      EEPROM.write(Start, serAPI[i]);
      Start = Start + 1;
    }
    //Speicherplatz Lï¿½nge 6
    EEPROM.write(6, serAPI.length());
    EEPROM.commit();

    //Entleere 
    serAPI = "";
     Blinken();
  }
  //=======================================================



  //=======================================================
  //Abfrage INTERVALL
  //=======================================================
  if (incoming.startsWith("SEN"))
  {
    String serSen = incoming.substring(3);
    Serial.println("Abfrage: " + serSen);
    Serial.println("Schreibe ins eeprom API:" + serSen);
    // PORT Beginnt bei Speicherplatz 167
    int Start = 167;
    for (int i = 0; i < serSen.length() + 1; ++i)
    {
      EEPROM.write(Start, serSen[i]);
      Start = Start + 1;
    }
    //Speicherplatz Lï¿½nge 6
    EEPROM.write(7, serSen.length());
    EEPROM.commit();
    CredentialsOK = 1;

    //Entleere 
    serSen = "";
     Blinken();
  }
  //=======================================================



  //=======================================================
  //Lade WLAN_SSID aus EEPROM
  //=======================================================
  if (incoming.startsWith("ReadSSID"))
  {
    GETssid();
  }
  //=======================================================


  //=======================================================
  //Lade WLAN_KEY as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadWLANKEY"))
  {
    GETpass();
  }
  //=======================================================


  //=======================================================
  //Lade HOST as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadHOST"))
  {
    GEThost();
  }
  //=======================================================

  //=======================================================
  //Lade PORT as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadPORT"))
  {
    GEThttpPort();
  }
  //=======================================================

  //=======================================================
  //Lade URL as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadURL"))
  {
    GEThost_url();
  }
  //=======================================================

  //=======================================================
  //Lade API as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadAPI"))
  {
    GETapi_password();
  }
  //=======================================================

  //=======================================================
  //Lade INTERVALL as EEPROM
  //=======================================================
  if (incoming.startsWith("ReadSEN"))
  {
    GETsensor_submission_interval();
  }
  //=======================================================


  //=======================================================
  //LÖSCHE DEN EEPROM
  //=======================================================
  if (incoming.startsWith("CLEAREEPROM"))
  {
    ClearEEPROM();
  }
  //=======================================================

}

void Blinken() {
     delay(200);
     digitalWrite(BUILTIN_LED, LOW);

    
     delay(200);
     digitalWrite(BUILTIN_LED, HIGH);

    
     delay(200);
     digitalWrite(BUILTIN_LED, LOW);

     delay(200);
     digitalWrite(BUILTIN_LED, HIGH);

      delay(200);
     digitalWrite(BUILTIN_LED, LOW);
}


