# /Defs

This folder contains XML files with definitions for each thing added by the mod.

## File Contents

The standard structure of one of these XML files is as follows:

```xml
<?xml version="1.0" encoding="UTF-8" ?>

<Defs>
	<!-- "Name" defines the name of the definition. Set "Abstract" to "True" if a thing of this type cannot be created. -->
	<Def Name="ExampleParentDefName" Abstract="True">
	</Def>

	<!-- ParentName defines the Name of the parent definition. -->
	<Def Name="ExampleChildDefName" ParentName="ExampleParentDefName">
	</Def>

	<!-- If you don't want to inherit values from the parent, set "Inherit" to "False". -->
	<Def Name="ExampleChildDefNoInheritName" ParentName="ExampleParentDefName" Inherit="False">
	</Def>

	<!-- Most definitions will use a subclass of "Def" instead (i.e. "ThingDef"). -->
	<ThingDef Name="ExampleThingDefName">
	</ThingDef>
</Defs>
```

## File Structure

There is no clear naming convention for the contents of the `Defs` folder, but it is advisable that you follow RimWorld's structure as closely as possible.
You could include all of your definitions in one file if you wanted to, but it would make it more difficult for others to find definitions.

### Example

Here is an example Defs folder structure (from RimWorld 1.3):

- `Defs`
	- `ThingDefs_Buildings`
		- `Buildings_Ancient.xml`
		- `Buildings_Art.xml`
		- `Buildings_Base.xml`
	- `ThingDefs_Items`
		- `Items_Artifacts.xml`
		- `Items_Exotic.xml`
		- `Items_Food.xml`
	- `ThoughtDefs`
		- `Thoughts_Anesthetic.xml`
		- `Thoughts_Memory_Death.xml`
		- `Thoughts_Memory_Debug.xml`
