# BackgroundServiceDemo

## Introduction
This project provide a sample that shows how to implement a **Background Service** in .Net 6.  
I also wrote an article in the following address that completely explains **Background Services**:  
https://www.linkedin.com/   

## Structure of soution
The solution contains one Console App project which is written in Visual Studio. The project contains a **Worker** class which runs in the background and generate strings with random numbers. It raise an event almost every 1 second and deliver the message. In Program.cs, our Worker class is registered and also subscribed to receive event and write it down to the console. Please note how I used **Singleton Registeration** technique.

## Technology stack
- OS: Windows 10 Enterprise - 64 bits
- IDE: Visual Studio Enterprise 2022 (64 bits) - version 17.2.5
- Framework: .Net 6
- Language: C#

## How to run
Open the solution in Visual Studio and run it using F5. You will see the output in a console.
Press Ctrl+C to exit the program.


