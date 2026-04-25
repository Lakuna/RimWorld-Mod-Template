# /Languages

This folder contains translation data for the mod.

## File Contents

### Keyed

XML files in the `Keyed` directory contain keys that can be referred to in C#. For example:

```xml
<?xml version="1.0" encoding="UTF-8" ?>

<LanguageData>
	<ExampleStringWithMultipleWords>Example string with multiple words</ExampleStringWithMultipleWords>
</LanguageData>
```

```c#
"ExampleStringWithMultipleWords".Translate();
```

### DefInjected

XML files in the `DefInjected` directory contain translations for XML definitions. For example (from RimWorld 1.3):

```xml
<?xml version="1.0" encoding="UTF-8" ?>

<LanguageData>
	<WorldCameraMovement.helpTexts.0>Test translation.</WorldCameraMovement.helpTexts.0>
</LanguageData>
```

### Strings

Text files in the `Strings` directory can contain lists with a word on every line, which can then be used in XML to randomly get words from a bank.

## File Structure

The contents of the `Languages` folder should match the structure below, with subfolders having no specific naming convention:

- `DefInjected`
- `Keyed`
- `Strings`

### Example

Here is an example Languages folder structure (from RimWorld 1.3):

- `Languages`
  - `DefInjected`
    - `ConceptDef`
      - `Example_Concepts.xml`
    - `TraitDef`
      - `Example_Traits.xml`
  - `Keyed`
    - `Alerts.xml`
    - `Credits.xml`
    - `Dates.xml`
  - `Strings`
    - `Names`
      - `Animal_Female.txt`
      - `Animal_Male.txt`
      - `Animal_Unisex.txt`
    - `WordParts`
      - `CapitalLetters.txt`
      - `PlaceEndings.txt`
      - `Syllables_Byzantinian.txt`
  - `About.txt`
  - `LangIcon.png`
  - `LanguageInfo.xml`

## Translation Arguments

To use a keyed translation in C#, use `Verse.Translator.Translate`. This is an extension method on strings. The string will be used as the translation key, and the arguments to `Translate` will be used in the translation according to the translated string.

Keyed strings can take arguments by using zero-indexed integers in curly braces like so:

```xml
<UpgradeImplant>Upgrade {0} to level {1}</UpgradeImplant>
```

In cases where objects are passed as arguments, certain properties of the object can be inserted according to the logic in `Verse.GrammarResolverSimple.TryResolveSymbol`.

```xml
<MeleeAttackToDeath>Melee attack {1_labelShort} to death</MeleeAttackToDeath>
```

In other cases, arguments can be identified by a label rather than by an index.

```xml
<NoMedicineMatchingCategory>No medicine for restriction '{CATEGORY}'.</NoMedicineMatchingCategory>
```

In this case, the argument can be labeled with `Verse.NamedArgumentUtility.Named`, which is an extension method on objects.
