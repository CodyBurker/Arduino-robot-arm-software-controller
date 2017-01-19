#include <Servo.h>

Servo servo0;
Servo servo1;
Servo servo2;
Servo servo3;
Servo servo4;
Servo servo5;

String readString, servos[5];

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);
  Serial.println("Testing...");
  servo0.attach(3);
}

void loop() {
  while (Serial.available()) {
    delay(3); //allow buffer to fill
    if (Serial.available() > 0) { //gets a single byte from serial buffer
      char c = Serial.read(); //makes the string readString
      readString += c;
    }
  }
  if (readString.length() > 0) {
    //expect a string like 123123123123123 where each '123' is a servo position to be parsed
    Serial.println("Read:");
    for (int i = 0; i <= 4; i++) {
      servos[i] = readString.substring(3 * i, 3 * i + 3);
      Serial.print("Servo#");
      Serial.print(i+1);
      Serial.print(": ");
      Serial.println(servos[i]);
    }
    servo0.write(map(servos[0].toInt(),0,100,20,160));
    readString = "";
  }
}