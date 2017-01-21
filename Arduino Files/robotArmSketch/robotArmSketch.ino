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
  Serial.begin(9600 );
  servo0.attach(A0);
  servo1.attach(A1);
  servo2.attach(A2);
  servo3.attach(A3);
  servo4.attach(A4);
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
    }
    servo0.write(servos[0].toInt());
    servo1.write(servos[1].toInt());
    servo2.write(servos[2].toInt());
    servo3.write(servos[3].toInt());
    servo4.write(servos[4].toInt());
    readString = "";
  }
}
