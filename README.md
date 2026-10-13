# Galaxy Strike Shooter

Galaxy Strike Shooter is a Unity 3D space-combat prototype. Fly through the level, aim with the mouse, shoot enemy ships, and earn points for destroying them.

## Requirements

- Unity **6000.0.72f1** (see `ProjectSettings/ProjectVersion.txt`)
- A desktop platform with a keyboard and mouse

## Getting started

1. Open Unity Hub and choose **Add project from disk**.
2. Select this repository's root folder.
3. Open the project with Unity 6000.0.72f1 and allow Unity to import its assets and packages.
4. Open `Assets/Scenes/Main Level.unity` and press **Play**.

The main level is configured as the project's build scene.

## Controls

| Action | Control |
| --- | --- |
| Move the ship | **W**, **A**, **S**, **D** |
| Aim | Move the mouse |
| Fire | Hold the **left mouse button** |

## Project structure

- `Assets/Scenes/` — the main level and the ships scene
- `Assets/Scripts/` — player movement and weapons, enemy collision, scoring, and dialog behaviour
- `Assets/Input/PlayerControls.inputactions` — player movement and firing input bindings
- `Packages/manifest.json` — Unity package dependencies
- `ProjectSettings/` — Unity editor and project configuration

Unity's `Library`, `Temp`, and other generated files are local editor/build data. They are excluded from version control; Unity recreates them when the project is opened.
