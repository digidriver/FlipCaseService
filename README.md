# FlipCaseService
A test WCF web service. Users access the web service through a basic Http binding-enabled console. They will enter a string.

The web service will take their string, flip the case on it (e.g. Automobile will become aUTOMOBILE) and return it to the user.

If you download and want to run this, just make sure the console application has a service reference to the web service. (Theoretically, you COULD separate the console application from the web service and deploy it remotely, but you would need to reference the web service remotely at that point. I trust you know how to do that.)

This was part of a running start I took at WCF web services thanks to Microsoft's "Jump Start" program on Developing Windows Azure and Web Services. It was available on YouTube here (https://www.youtube.com/watch?v=GQ1EiMwbEds&list=PLIoX3-mcY80h8VDE-UixTEmi5OR5k7t_a) at the time this repository was uploaded.

2016-04-15
