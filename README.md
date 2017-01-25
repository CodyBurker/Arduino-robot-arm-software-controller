# Arduino-robot-arm-software-controller
Desktop software written in C# to control an Arduino robot arm via USB serial

##What is it?
This software is intended to be paired with the EEZYbotARM found [here] (http://www.thingiverse.com/thing:1015238).The desktop software, written in C# in Visual Studio, is meant to control an arduino (running the included sketch) via USB Serial, to allow the user to provide a set of positions to the arm, along with the timing of the positions. This is acheived two ways. The user can control the arm in real-time via the desktop interface to set the actions and then play back the set frames (with timing) while still connected to the desktop. Or the user can set the actions with timings and export them to Arduino code, that can be played back independently of the desktop.
