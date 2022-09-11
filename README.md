# UnityExtensions
This is a repository to keep usual extensions for Unity

You probable dont want to clone this project because it will contain dependencies to private plugins that maybe you dont have.
Just download the package in wich you are interested

# Unity Timeline Extensions for Atoms
This a extension to integrate Unity Atoms (https://unity-atoms.github.io/unity-atoms/) into the Unity native Timeline. I needed to integrate dialogs and events for a cinematic production.

## Dependencies
Its oviously dependent on Unity Atoms (have a look to their web to install) and Unity timeline package.

## How to install this package
Download the integration package and open or just copy the folder "Assets/vr4content/TimelineExtensions" from this repo in to your project

## How to use
1. Create a timeline asset with the right click on your project assets.
2. Create a GameObject in your scene and drag the timeline created before in to the GameObject
3. Open the Unity Timeline window and select your GameObject in the hierarchy
4. Add a Unity Atom Track to the timeline
5. Create a corresponding unity Atom entity an associate to the track (right now I have only StringEvent, StringVariable and IntVariable, but you can clone the scripts for what ever you need)
6. Mith the right click on the track, create Clips in the timeline and fill them with the values you need.

## Example
There is a folder with a basic example.
![image](https://user-images.githubusercontent.com/83698979/189541639-9b4d4401-3800-4449-b988-ef801083deb4.png)
