# /Patches

This folder contains XML files with modifications to the definitions of things added by other mods. These XML `PatchOperation`s are available for versions of RimWorld from Alpha 17 onward.

## File Contents

An example XML `PatchOperation` is below:

```xml
<?xml version="1.0" encoding="UTF-8" ?>

<Patch>
	<!-- See below. -->
	<Operation Class="PatchOperationReplace">
		<!-- xpath follows the structure of the XML nodes; it completely ignores folder structure. -->
		<xpath>/Defs/TerrainDef[defName="WaterDeep"]/texturePath</xpath>

		<!-- The value to use in the patch. -->
		<value>
			<texturePath>Textures/NewWaterDeepTexture</texturePath>
		</value>

		<!-- See below. -->
		<success>Normal</success>
	</Operation>
</Patch>
```

The `Class` attribute must be one of the following:

- `PatchOperationAdd` adds a child node.
- `PatchOperationInsert` adds a sibling node.
- `PatchOperationRemove` deletes a node.
- `PatchOperationReplace` replaces a node.
- `PatchOperationAttributeAdd` adds an attribute if the name is not already present.
- `PatchOperationAttributeSet` sets an attribute, overwriting the old value if it already exists.
- `PatchOperationAttributeRemove` removes an attribute.
- `PatchOperationAddModExtension` adds a `ModExtension`.
- `PatchOperationSetName` changes a name.
- `PatchOperationSequence` contains a set of other `PatchOperation`s and aborts if any of them fail.
- `PatchOperationTest` tests nodes.
- `PatchOperationConditional` tests nodes and can perform different operations depending on the result.
- `PatchOperationFindMod` tests for the presence of another mod, and can perform different operations depending on the result.

The `success` tag defines whether or not to consider the patch a success, and must be one of the following:

- `Always` always succeeds.
- `Normal` succeeds if the patch succeeded.
- `Invert` succeeds if the patch failed.
- `Never` always fails.
