# RimWorld Mod Template

A template for creating RimWorld mods.

## File Structure Overview

RimWorld mods are folders which contain subfolders and files with specific names.

- `/About` contains meta information about the mod.
- `/Assemblies` contains C# assemblies for the mod.
- `/Defs` contains XML files with definitions for each thing added by the mod.
- `/Languages` contains translation data for the mod.
- `/Patches` contains XML files with modifications to the definitions of things added by other mods.
- `/Sounds` contains audio files supplied by the mod.
- `/Textures` contains image files supplied by the mod.

## Multi-Version Mods

Starting from a mod's root directory, RimWorld checks a sequence of subfolders in order and loads files from all of them:

- `/1.5` (skipped if any folder above was found)
- `/1.4` (skipped if any folder above was found)
- `/1.3` (skipped if any folder above was found)
- `/1.2` (skipped if any folder above was found)
- `/1.1` (skipped if any folder above was found)
- `/1.0` (skipped if any folder above was found)
- `/Common` (always checked)
- `/` (always checked)

If the same file name is present in several of these folders, the first one checked will take precedence and the others will be ignored.

The `About` folder should always be in the mod's root directory. It cannot differ between game versions.

When sharing files between versions, the `Common` folder should be used.

To gain finer control over how mod files are loaded, you can make a file called `LoadFolders.xml` in the mod's root directory. For example:

```xml
<?xml version="1.0" encoding="UTF-8" ?>

<loadFolders>
	<v1.1>
		<li>Common</li>
		<li>1.1</li>
	</v1.1>
	<v1.2>
		<li>Common</li>
		<li>1.2</li>
		<!-- IfModActive and IfModNotActive can contain comma-separated (treated like an OR operator) package IDs of mods. The folder will only be loaded if the condition is met. -->
		<li IfModActive="Ludeon.RimWorld.Royalty">RoyaltySpecific</li>
	</v1.2>
	<v1.3>
		<li>Common</li>
		<li>1.3</li>
		<li IfModActive="Ludeon.RimWorld.Ideology,Ludeon.RimWorld.Royalty">AnyExpansions</li>
		<li IfModNotActive="Ludeon.RimWorld.Ideology">NoIdeology</li>
	</v1.3>
</loadFolders>
```

When using the format above, the last folder in the list takes precedence.

RimWorld version 1.0 does not support the load folder system, but it does support loading `Defs`, `Patches`, and `Assemblies` from `/1.0`. It will always look for `Textures`, `Translations`, and `Sounds` in the mod's root directory. If you create `/1.0`, RimWorld version 1.0 will not look for `Defs`, `Patches`, and `Assemblies` in the root directory.

## Documentation

RimWorld is not well-documented. When RimWorld is downloaded through Steam on Windows, the default directory of the `RimWorld` folder is `C:\Program Files (x86)\Steam\steamapps\common\RimWorld`. For XML documentation, `RimWorld/Data` and `RimWorld/Source` will contain a variety of examples from the base game. For C# documentation, the relevant code can be decompiled (such as with [ILSpy](https://github.com/icsharpcode/ILSpy)) from `RimWorld/RimWorld*_Data/Managed` (especially `Assembly-CSharp.dll` and `UnityEngine.CoreModule.dll`). It is a good idea to find a mod which does something similar to what you're attempting to do and look at the code for that mod. There is a modding tutorial available on the [RimWorld Wiki](https://rimworldwiki.com/wiki/Modding). A list of tutorials and resources is available on [spdskatr's website](https://spdskatr.github.io/RWModdingResources/). If you can't find something, ask for help on the [Ludeon Forums](https://ludeon.com/forums/).

## Harmony

If your mod uses [Harmony](https://github.com/pardeike/Harmony):

- RimWorld versions 1.0 and below require Harmony versions less than 2 (the recommended version is 1.3.0.1). For these versions, `0Harmony.dll` must be included in `Assemblies`.
- RimWorld versions 1.1 and above should instead depend on the Harmony mod. `0Harmony.dll` should not be included in `Assemblies`.
  - The recommended Harmony version is 2.2.2 for RimWorld versions 1.1 through 1.4 and 2.3.1.1 for RimWorld versions 1.5 and above.
