# RimWorld-Mod-Template
A template for creating RimWorld mods with Harmony.

## Multi-version mods
Starting from a mod's root directory, RimWorld checks a sequence of subfolders in order and loads files from all of them:
- (...) (skipped if any folder above was found)
- /1.3 (skipped if any folder above was found)
- /1.2 (skipped if any folder above was found)
- /1.1 (skipped if any folder above was found)
- /1.0 (skipped if any folder above was found)
- /Common (always checked)
- / (always checked)

If the same file is present in several of these folders, the first one checked will take precedence and the others will be ignored.

The About folder should always be in the mod's root directory.

When sharing files between versions, the Common folder should be used.

To gain finer control over how mod files are loaded, you can make a file called "LoadFolders.xml" in the mod's root directory. For example:
```xml
<?xml version="1.0" encoding="utf-8"?>

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
		<li IfModActive="Ludeon.RimWorld.Ideology, Ludeon.RimWorld.Royalty">AnyExpansions</li>
		<li IfModNotActive="Ludeon.RimWorld.Ideology">NoIdeology</li>
	</v1.3>
</loadFolders>
```

When using the format above, the *last* folder in the list takes precedence.

RimWorld 1.0 does not support the load folder system, but it does support loading Defs, Patches, and Assemblies from a folder named "1.0". It will always look for Textures, Translations, and Sounds in the mod's root directory. If you define a folder named "1.0", RimWorld version 1.0 will not look for Defs, Patches, and Assemblies in the root directory.
