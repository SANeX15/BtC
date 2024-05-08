![btc cover art](https://github.com/SANeX15/BtC/assets/83059735/f125b041-0357-4875-bfe2-1469db33a85d)

# BtC

Bluetooth Control or BtC is a DotNet Framework based application for controlling appliances upto 8 ports on Uno R3 or [more boards](https://github.com/SANeX15/BtC/releases/tag/2.0.0) via a Serial-to-Bluetooth connection on a Windows-based device.

## Screenshots

## Features
 - Modifiable button names (Button Settings, Screenshot #2).
 - Modifiable ON/OFF commands (Button Settings, Screenshot #2).
 - Activation by numpad/number key press.
 - Easy-To-Use User Interface (Screenshots above).
 - Automatic connection ability (Screenshots above).

## Requirements
 - A Windows 7+ device with Bluetooth.
 - DotNet Framework 4.8 runtime.
 - HC05 bluetooth connection setup on a Serial Port.
 - UNO R3 or other boards, with appropriate code, setup with a HC05 or any other bluetooth module and linked to preferred appliances.
 - (TIP) Code for the Arduino UNO R3 is included in the release [v2.0.0](https://github.com/SANeX15/BtC/releases/tag/2.0.0) as BtC_UNOR#_sketch.ino.

## Instructions
 1. Turn on Bluetooth, connect to HC05 and link it to a Serial Port. -(details will be uploaded soon)
 2. Start BtC and select previously linked Serial Port.
 3. Wait till connection suceeds (when the text turns green and shows 'Connected').
 4. Use Buttons 1-8 to toggle appliances connected to Arduino Uno R3.

 E. Right Click any buttons from 1-8 and select Button Settings to change their name and ON/OFF commands. (Button Settings, Screenshot #2)


**IMPORTANT NEWS : As BtC is now usable on boards much better than the UNO R3 board which was previously used, I think that BtC has reach its final stage and doesn't require to be updated anymore.So, till _something interesting happens_, I am calling of further development of BtC but bugs will still be solved.**

*Thank you for reading this and using my application. I hope it aids you with ease of access to your appliances*
