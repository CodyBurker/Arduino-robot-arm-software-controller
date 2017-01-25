# Arduino-robot-arm-software-controller
Desktop software written in C# to control an Arduino robot arm via USB serial

##What is it?
This software is intended to be paired with the EEZYbotARM found [here] (http://www.thingiverse.com/thing:1015238). The desktop software, written in C# in Visual Studio, can control an Arduino running the included sketch via USB Serial, in order to create a sequence of positions for five servos.

##Features
* Connect to Arduino via serial USB
* Choose which serial prot to connect over
* Send position of 5 servos to arduino via serial in realtime
* Save, edit, delete, frames containing positions of servos and duration of frames
* Save sequence of frames to a file
* Open and load saved sequences
* Playback and loop timed sequences of frames over serial
* Export sequences to standalone Arduino code

##Screenshot
![Screenshot of Software](/Screen Shot 2017-01-25 at 12.31.22 PM.png)
