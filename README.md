# Discord-Disco [![Build Status](https://travis-ci.org/tryallthethings/Discord-Disco.svg?branch=master)](https://travis-ci.org/tryallthethings/Discord-Disco) ![Downloads](https://img.shields.io/github/downloads/tryallthethings/Discord-Disco/total.svg?style=flat) [![Latest Release](https://img.shields.io/github/v/release/tryallthethings/Discord-Disco.svg?logo=github)](https://github.com/tryallthethings/Discord-Disco/releases)
## TL;DR
This tool sets the Discord priority from low to high and sometimes farts.

<kbd><img src="screenshot.png"></kbd>

## Long version
This little tool started out as a quick and fun solution for a common issue a friend had with Discord. 
Every time you minimize Discord it sets its own CPU priority to low and your voice chat would start lagging when you're playing a game or anything else would use a lot of CPU resources.
Discord-Disco will, once started, scan the various Discord processes every 5 seconds for any one that has a CPU priority set of _low_. The counter will increase by one every time Discord priority was changed.
The executable is rather larger due to the embedded sound file and MetroFramework libraries.

If you're curious (or paranoid - which is totally fine with executables requiring administrative permissions) you can check the VirusTotal file scan on the release page.

# Usage
Download the .exe from the [releases](https://github.com/tryallthethings/Discord-Disco/releases) to any place you like and start. If your PC has UAC enabled (which any Windows PC has by default) you'll see one or several warnings (depending on your Windows version) which you need to accept. Discord-Disco requires to be run with administrative permissions to be able to set the CPU priority of other processes.
Once you press the button "Start the Disco" it will start doing its thing. "Stop the disco" or closing the app will stop it.
Fart sound has a 50% chance of triggering if the tool set the priority successful. :smirk:

I'll release version without fart sound but with additional options later and link it here.


# Resources used in this project
- App Icon: https://emoji.gg/emoji/1587_Derp
- Fart sound: https://www.myinstants.com/instant/fart-button/
- MetroFramework Modern UI: https://github.com/dennismagno/metroframework-modern-ui
