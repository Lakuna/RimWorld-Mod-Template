# /Patches
This folder contains an XML file for each thing modified by your mod. These XML PatchOperations are available for versions of RimWorld from Alpha 17 onward.

An example XML PatchOperation is below:
```xml
<?xml version="1.0" encoding="utf-8"?>

<Patch>
	<!--
		The "Class" attribute must be one of the following:
		- PatchOperationAdd adds a child node.
		- PatchOperationInsert adds a sibling node.
		- PatchOperationRemove deletes a node.
		- PatchOperationReplace replaces a node.
		- PatchOperationAttributeAdd adds an attribute if the name is not already present.
		- PatchOperationAttributeSet sets an attribute, overwriting the old value if it already exists.
		- PatchOperationAttributeRemove removes an attribute.
		- PatchOperationAddModExtension adds a ModExtension.
		- PatchOperationSetName changes the name.
		- PatchOperationSequence contains a set of other PatchOperations and aborts if any of them fail.
		- PatchOperationTest tests nodes.
		- PatchOperationConditional tests nodes and can do different operations depending on the result.
		- PatchOperationFindMod tests for the presence of another mod, and can do different operations depending on the result.
	-->
	<Operation Class="PatchOperationReplace">
		<!-- XPath follows the structure of the XML nodes; it completely ignores folder structure. -->
		<xpath>/Defs/TerrainDef[defName="WaterDeep"]/texturePath</xpath>

		<!-- The value to use in the patch. -->
		<value>
			<texturePath>Textures/NewWaterDeepTexture</texturePath>
		</value>

		<!--
			Whether or not to consider this patch a success. Must contain one of the following:
			- Always always succeeds.
			- Normal succeeds if the patch succeeded.
			- Invert succeeds if the patch failed.
			- Never always fails.
		-->
		<success>Normal</success>
	</Operation>
</Patch>
```
