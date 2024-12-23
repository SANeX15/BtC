![btc cover art](https://github.com/SANeX15/BtC/assets/83059735/f125b041-0357-4875-bfe2-1469db33a85d)

# BtC

Bluetooth Control or BtC is a DotNet Framework based application for controlling appliances upto 8 ports on Uno R3 or [more boards](https://github.com/SANeX15/BtC/releases/tag/2.0.0) via a Serial-to-Bluetooth connection on a Windows-based device.

## Screenshots
![btc-main](https://github.com/user-attachments/assets/874685de-24aa-4fbe-a58c-ae09d9856d46)

Main Layout.

![btc settings](https://github.com/user-attachments/assets/17eca4b7-17be-4af7-a75e-9a3c9408d91d)

Button Settings


## Features
 - Modifiable button names (Button Settings, Screenshot #2).
 - Modifiable ON/OFF commands (Button Settings, Screenshot #2).
 - Activation by numeric pad/number key press.
 - Easy-To-Use User Interface (Screenshots #1).
 - Automatic connection ability (Screenshots #1).

## Prerequisites / Requirements
 - A Windows 7+ device with Bluetooth.
 - DotNet Framework 4.8 runtime. ([click to download](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net48-offline-installer))
 - HC05 bluetooth connection setup on a Serial Port.
 - UNO R3 or other boards, with appropriate code, setup with a HC05 or any other bluetooth module and linked to preferred appliances.
 - (TIP) Code for the Arduino UNO R3 is released as [BtC 4 UNO](https://github.com/SANeX15/BtC/releases/tag/BOARDCODE).

## Instructions
 1. Turn on Bluetooth, connect to HC05 and link it to a Serial Port. -(details will be uploaded soon)
 2. Start BtC and select previously linked Serial Port.
 3. Wait till connection suceeds (when the buttons are enabled and their text colors turn white).
 4. Use Buttons 1-8 to toggle appliances connected to the board.

 E. Right Click any buttons from 1-8 and select Button Settings to change their name and ON/OFF commands. (Button Settings, Screenshot #2)


IMPORTANT NEWS : As BtC is now usable on boards much better than the UNO R3 board which was previously used, I think that BtC has reach its final stage and doesn't require to be updated anymore.So, till _something interesting happens_, I am halting further development of BtC.

*Thank you for reading this and using my application. I hope it aids you with ease of access to your appliances*
