

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
const char* ssid = "wlan"; // name of your wlan ssid
const char* pass = "password";    // wlan wpa password or key for wep
const char* host = "site.com"; // hostname, ip adresses wont work, example: host.com
const int httpPort = 80;
const char* host_url = ""; // folder without slash at end, example: /your/folder or blank for main dir
const char* api_password = "123456"; // password for interface wich defined at config.inc.php
const long sensor_submission_interval = 10000; // interval for sensor data submission in ms: 60000 for 60 secound
/*
   SETUP END


   setup finished, do not change any thing here if u dont know what u are doing
*/



#include "ESP8266WiFi.h"
#include <Wire.h>
#include <DHT.h>
#include <ArduinoJson.h>




#define FAN 13      // D7
#define EXHAUST 15  // D8
#define PUMPE 14    // D5
#define LICHT 12    // D6
#define DHT_1 0     // D3
#define SOIL_SCL D1  // D1
#define SOIL_SDA D2  // D2

DHT dht1(DHT_1, DHT22);

int status_light = 0;
int status_fan = 1024;
int status_exhaust = 1024;
String website_data = "";
unsigned long sensor_submission_last = 0;


void setup()
{
  analogWriteFreq(31300);
  
  Serial.begin(115200);
  Wire.begin();
  writeI2CRegister8bit(0x20, 6);
  delay(100);
  dht1.begin();

  
  pinMode(BUILTIN_LED, OUTPUT);  // initialize onboard LED as output
  pinMode(LICHT, OUTPUT);
  pinMode(PUMPE, OUTPUT);
  digitalWrite(LICHT, HIGH);
  digitalWrite(PUMPE, HIGH);

  // give soil sensor time to switch into sensor mode
  int i = 0;
  while(i < 10){ 
    writeI2CRegister8bit(0x20, 3);
    readI2CRegister16bit(0x20, 4);
    i++;
    delay(100);
  }
  digitalWrite(BUILTIN_LED, HIGH);

  Serial.println("connecting to wifi ap");

  WiFi.mode(WIFI_STA);
  WiFi.begin(ssid, pass);

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
  url =  String(host_url) + "/index.php?page=wemos&action=" + String(url);
  Serial.print("connecting to ");
  Serial.println(host);

  // Use WiFiClient class to create TCP connections
  WiFiClient client;
  if (!client.connect(host, httpPort)) {
    Serial.println("connection failed");
    return;
  }

  // We now create a URI for the request
  url = url + "&box=" + String(ESP.getChipId()) + "&password=" + api_password;

  Serial.print("requesting adress: ");
  Serial.println(host + url);

  // This will send the request to the server
  client.print(String("GET ") + url + " HTTP/1.1\r\n" +
               "Host: " + host + "\r\n" +
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
  if (currentMillis - sensor_submission_last >= sensor_submission_interval) {
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


