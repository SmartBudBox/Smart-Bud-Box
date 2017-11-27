EESchema Schematic File Version 2
LIBS:sbb-rescue
LIBS:power
LIBS:device
LIBS:transistors
LIBS:conn
LIBS:linear
LIBS:regul
LIBS:74xx
LIBS:cmos4000
LIBS:adc-dac
LIBS:memory
LIBS:xilinx
LIBS:microcontrollers
LIBS:dsp
LIBS:microchip
LIBS:analog_switches
LIBS:motorola
LIBS:texas
LIBS:intel
LIBS:audio
LIBS:interface
LIBS:digital-audio
LIBS:philips
LIBS:display
LIBS:cypress
LIBS:siliconi
LIBS:opto
LIBS:atmel
LIBS:contrib
LIBS:valves
LIBS:wemos_mini
LIBS:ams1117
LIBS:sbb-cache
EELAYER 25 0
EELAYER END
$Descr A4 11693 8268
encoding utf-8
Sheet 1 1
Title ""
Date ""
Rev ""
Comp ""
Comment1 ""
Comment2 ""
Comment3 ""
Comment4 ""
$EndDescr
$Comp
L Screw_Terminal_1x02 J2
U 1 1 5901E432
P 4050 6150
F 0 "J2" H 4050 6400 50  0000 C TNN
F 1 "SCL -- GND" V 3900 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 4050 5925 50  0001 C CNN
F 3 "" H 4025 6150 50  0001 C CNN
	1    4050 6150
	0    -1   -1   0   
$EndComp
$Comp
L Screw_Terminal_1x02 J1
U 1 1 5901E5E4
P 3150 6150
F 0 "J1" H 3150 6400 50  0000 C TNN
F 1 "DHT -- SDA" V 3000 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 3150 5925 50  0001 C CNN
F 3 "" H 3125 6150 50  0001 C CNN
	1    3150 6150
	0    -1   -1   0   
$EndComp
$Comp
L Screw_Terminal_1x02 J3
U 1 1 5901E65A
P 4950 6150
F 0 "J3" H 4950 6400 50  0000 C TNN
F 1 "+5V -- EXHAUST" V 4800 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 4950 5925 50  0001 C CNN
F 3 "" H 4925 6150 50  0001 C CNN
	1    4950 6150
	0    -1   -1   0   
$EndComp
$Comp
L Screw_Terminal_1x02 J5
U 1 1 5901E6D0
P 7300 6150
F 0 "J5" H 7300 6400 50  0000 C TNN
F 1 "+12 VIN -- GND" V 7150 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 7300 5925 50  0001 C CNN
F 3 "" H 7275 6150 50  0001 C CNN
	1    7300 6150
	0    -1   -1   0   
$EndComp
$Comp
L Screw_Terminal_1x02 J4
U 1 1 5901E7BC
P 5950 6150
F 0 "J4" H 5950 6400 50  0000 C TNN
F 1 "FAN -- +12 V" V 5800 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 5950 5925 50  0001 C CNN
F 3 "" H 5925 6150 50  0001 C CNN
	1    5950 6150
	0    -1   -1   0   
$EndComp
$Comp
L Screw_Terminal_1x02 J6
U 1 1 5901E80B
P 8200 6150
F 0 "J6" H 8200 6400 50  0000 C TNN
F 1 "LIGHT_GND -- PUMP_GND" V 8050 6150 50  0000 C TNN
F 2 "Connectors_Terminal_Blocks:TerminalBlock_Pheonix_MKDS1.5-2pol" H 8200 5925 50  0001 C CNN
F 3 "" H 8175 6150 50  0001 C CNN
	1    8200 6150
	0    -1   -1   0   
$EndComp
$Comp
L BC547 Q1
U 1 1 5901F188
P 6950 2450
F 0 "Q1" H 7150 2525 50  0000 L CNN
F 1 "BC547" H 7150 2450 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-92_Molded_Narrow" H 7150 2375 50  0001 L CIN
F 3 "" H 6950 2450 50  0001 L CNN
	1    6950 2450
	1    0    0    -1  
$EndComp
$Comp
L IRLB8721PBF Q3
U 1 1 5901F260
P 8450 2100
F 0 "Q3" H 8700 2175 50  0000 L CNN
F 1 "IRLB8721PBF" H 8700 2100 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 8700 2025 50  0001 L CIN
F 3 "" H 8450 2100 50  0001 L CNN
	1    8450 2100
	1    0    0    -1  
$EndComp
$Comp
L IRLB8721PBF Q4
U 1 1 5901F313
P 8450 4000
F 0 "Q4" H 8700 4075 50  0000 L CNN
F 1 "IRLB8721PBF" H 8700 4000 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-220_Vertical" H 8700 3925 50  0001 L CIN
F 3 "" H 8450 4000 50  0001 L CNN
	1    8450 4000
	1    0    0    -1  
$EndComp
$Comp
L BC547 Q2
U 1 1 5901F346
P 6950 4400
F 0 "Q2" H 7150 4475 50  0000 L CNN
F 1 "BC547" H 7150 4400 50  0000 L CNN
F 2 "TO_SOT_Packages_THT:TO-92_Molded_Narrow" H 7150 4325 50  0001 L CIN
F 3 "" H 6950 4400 50  0001 L CNN
	1    6950 4400
	1    0    0    -1  
$EndComp
$Comp
L D D1
U 1 1 59020A0F
P 8150 5300
F 0 "D1" H 8150 5400 50  0000 C CNN
F 1 "D" H 8150 5200 50  0000 C CNN
F 2 "Diodes_THT:D_5W_P10.16mm_Horizontal" H 8150 5300 50  0001 C CNN
F 3 "" H 8150 5300 50  0001 C CNN
	1    8150 5300
	1    0    0    -1  
$EndComp
$Comp
L R R4
U 1 1 59020AE0
P 7050 3800
F 0 "R4" V 7130 3800 50  0000 C CNN
F 1 "4k7" V 7050 3800 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 6980 3800 50  0001 C CNN
F 3 "" H 7050 3800 50  0001 C CNN
	1    7050 3800
	1    0    0    -1  
$EndComp
$Comp
L R R6
U 1 1 59020BD3
P 7600 4050
F 0 "R6" V 7680 4050 50  0000 C CNN
F 1 "100" V 7600 4050 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 7530 4050 50  0001 C CNN
F 3 "" H 7600 4050 50  0001 C CNN
	1    7600 4050
	0    1    1    0   
$EndComp
$Comp
L R R2
U 1 1 59020C6A
P 6350 4400
F 0 "R2" V 6430 4400 50  0000 C CNN
F 1 "560" V 6350 4400 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 6280 4400 50  0001 C CNN
F 3 "" H 6350 4400 50  0001 C CNN
	1    6350 4400
	0    1    1    0   
$EndComp
$Comp
L R R1
U 1 1 59020CE7
P 6350 2450
F 0 "R1" V 6430 2450 50  0000 C CNN
F 1 "560" V 6350 2450 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 6280 2450 50  0001 C CNN
F 3 "" H 6350 2450 50  0001 C CNN
	1    6350 2450
	0    1    1    0   
$EndComp
$Comp
L R R3
U 1 1 59020D1A
P 7050 1900
F 0 "R3" V 7130 1900 50  0000 C CNN
F 1 "4k7" V 7050 1900 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 6980 1900 50  0001 C CNN
F 3 "" H 7050 1900 50  0001 C CNN
	1    7050 1900
	1    0    0    -1  
$EndComp
$Comp
L R R5
U 1 1 59020D4F
P 7600 2150
F 0 "R5" V 7680 2150 50  0000 C CNN
F 1 "100" V 7600 2150 50  0000 C CNN
F 2 "Resistors_THT:R_Axial_DIN0207_L6.3mm_D2.5mm_P10.16mm_Horizontal" V 7530 2150 50  0001 C CNN
F 3 "" H 7600 2150 50  0001 C CNN
	1    7600 2150
	0    1    1    0   
$EndComp
$Comp
L C C2
U 1 1 59020DA8
P 7950 2350
F 0 "C2" H 7975 2450 50  0000 L CNN
F 1 "100pF" H 7975 2250 50  0000 L CNN
F 2 "Capacitors_THT:C_Disc_D3.0mm_W2.0mm_P2.50mm" H 7988 2200 50  0001 C CNN
F 3 "" H 7950 2350 50  0001 C CNN
	1    7950 2350
	1    0    0    -1  
$EndComp
$Comp
L C C3
U 1 1 59020E43
P 7950 4250
F 0 "C3" H 7975 4350 50  0000 L CNN
F 1 "100pF" H 7975 4150 50  0000 L CNN
F 2 "Capacitors_THT:C_Disc_D3.0mm_W2.0mm_P2.50mm" H 7988 4100 50  0001 C CNN
F 3 "" H 7950 4250 50  0001 C CNN
	1    7950 4250
	1    0    0    -1  
$EndComp
Text GLabel 5050 5900 1    60   Input ~ 0
D8
Text GLabel 3950 2750 2    60   Input ~ 0
D8
Text GLabel 5850 5900 1    60   Input ~ 0
D7
Text GLabel 3950 2850 2    60   Input ~ 0
D7
$Comp
L GND #PWR03
U 1 1 59023FF3
P 8550 2350
F 0 "#PWR03" H 8550 2100 50  0001 C CNN
F 1 "GND" H 8550 2200 50  0000 C CNN
F 2 "" H 8550 2350 50  0001 C CNN
F 3 "" H 8550 2350 50  0001 C CNN
	1    8550 2350
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR04
U 1 1 5902402F
P 7950 2550
F 0 "#PWR04" H 7950 2300 50  0001 C CNN
F 1 "GND" H 7950 2400 50  0000 C CNN
F 2 "" H 7950 2550 50  0001 C CNN
F 3 "" H 7950 2550 50  0001 C CNN
	1    7950 2550
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR05
U 1 1 5902406B
P 7050 2700
F 0 "#PWR05" H 7050 2450 50  0001 C CNN
F 1 "GND" H 7050 2550 50  0000 C CNN
F 2 "" H 7050 2700 50  0001 C CNN
F 3 "" H 7050 2700 50  0001 C CNN
	1    7050 2700
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR06
U 1 1 5902433B
P 7050 4650
F 0 "#PWR06" H 7050 4400 50  0001 C CNN
F 1 "GND" H 7050 4500 50  0000 C CNN
F 2 "" H 7050 4650 50  0001 C CNN
F 3 "" H 7050 4650 50  0001 C CNN
	1    7050 4650
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR07
U 1 1 59024377
P 7950 4450
F 0 "#PWR07" H 7950 4200 50  0001 C CNN
F 1 "GND" H 7950 4300 50  0000 C CNN
F 2 "" H 7950 4450 50  0001 C CNN
F 3 "" H 7950 4450 50  0001 C CNN
	1    7950 4450
	1    0    0    -1  
$EndComp
$Comp
L GND #PWR08
U 1 1 590243B3
P 8550 4250
F 0 "#PWR08" H 8550 4000 50  0001 C CNN
F 1 "GND" H 8550 4100 50  0000 C CNN
F 2 "" H 8550 4250 50  0001 C CNN
F 3 "" H 8550 4250 50  0001 C CNN
	1    8550 4250
	1    0    0    -1  
$EndComp
Text GLabel 8300 5950 1    60   Input ~ 0
Q3D
Text GLabel 8550 1850 1    60   Input ~ 0
Q3D
Text GLabel 8550 3750 1    60   Input ~ 0
Q4D
Text GLabel 8100 5950 1    60   Input ~ 0
Q4D
Text GLabel 3250 5900 1    60   Input ~ 0
D2
Text GLabel 2850 3050 0    60   Input ~ 0
D2
Text GLabel 2850 2950 0    60   Input ~ 0
D3
Text GLabel 2850 3150 0    60   Input ~ 0
D1
Text GLabel 3950 5900 1    60   Input ~ 0
D1
Text GLabel 4150 5900 1    60   Input ~ 0
GND
Text GLabel 2850 2750 0    60   Input ~ 0
GND
Text GLabel 3050 5900 1    60   Input ~ 0
D3
Text GLabel 2850 2650 0    60   Input ~ 0
5V
Text GLabel 4850 5900 1    60   Input ~ 0
5V
Text GLabel 7400 5900 1    60   Input ~ 0
GND
$Comp
L WeMos_mini U1
U 1 1 5980CF13
P 3400 3000
F 0 "U1" H 3400 3500 60  0000 C CNN
F 1 "WeMos_mini" H 3400 2500 60  0000 C CNN
F 2 ".pretty:wemos_d1_mini" H 3950 2300 60  0001 C CNN
F 3 "" H 3950 2300 60  0000 C CNN
	1    3400 3000
	1    0    0    -1  
$EndComp
Wire Wire Line
	5650 2450 6200 2450
Wire Wire Line
	5650 4400 6200 4400
Wire Wire Line
	6500 4400 6750 4400
Wire Wire Line
	6500 2450 6750 2450
Wire Wire Line
	7050 2250 7050 2050
Wire Wire Line
	7050 4200 7050 3950
Wire Wire Line
	7450 4050 7050 4050
Connection ~ 7050 4050
Wire Wire Line
	7450 2150 7050 2150
Connection ~ 7050 2150
Wire Wire Line
	7750 2150 8250 2150
Connection ~ 7950 2150
Wire Wire Line
	7750 4050 8250 4050
Connection ~ 7950 4050
Wire Wire Line
	2900 2950 2850 2950
Wire Wire Line
	2850 3050 2900 3050
Wire Wire Line
	2900 3150 2850 3150
Wire Wire Line
	3950 2850 3900 2850
Wire Wire Line
	3900 2750 3950 2750
Wire Wire Line
	7050 2700 7050 2650
Wire Wire Line
	7050 1750 7050 1700
Wire Wire Line
	7950 2200 7950 2150
Wire Wire Line
	7950 2500 7950 2550
Wire Wire Line
	8550 2350 8550 2300
Wire Wire Line
	8550 1900 8550 1850
Wire Wire Line
	7050 3650 7050 3600
Wire Wire Line
	7950 4100 7950 4050
Wire Wire Line
	7950 4450 7950 4400
Wire Wire Line
	8550 4250 8550 4200
Wire Wire Line
	8550 3800 8550 3750
Wire Wire Line
	7050 4650 7050 4600
Wire Wire Line
	5850 5950 5850 5900
Wire Wire Line
	4850 5950 4850 5900
Wire Wire Line
	4150 5950 4150 5900
Wire Wire Line
	3950 5950 3950 5900
Wire Wire Line
	3250 5950 3250 5900
Wire Wire Line
	3050 5950 3050 5900
Wire Wire Line
	3900 2950 5650 2950
Wire Wire Line
	5650 2950 5650 2450
Wire Wire Line
	5650 4400 5650 3050
Wire Wire Line
	5650 3050 3900 3050
Wire Wire Line
	7200 5950 6050 5950
Wire Wire Line
	2900 2650 2850 2650
Wire Wire Line
	2900 2750 2850 2750
Wire Wire Line
	5050 5950 5050 5900
Wire Wire Line
	7400 5950 7400 5900
Wire Wire Line
	7200 5950 7200 5300
Wire Wire Line
	7200 5300 8000 5300
Wire Wire Line
	8300 5300 8500 5300
Wire Wire Line
	8500 5300 8500 5950
Wire Wire Line
	8500 5950 8300 5950
Text GLabel 7050 3600 1    60   Input ~ 0
5V
Text GLabel 7050 1700 1    60   Input ~ 0
5V
$EndSCHEMATC
