# /Languages
This folder contains translation data for your mod.

Here is an example Languages folder structure (from RimWorld 1.3):
- Languages
	- DefInjected
		- ConceptDef
			- Example_Concepts.xml
		- TraitDef
			- Example_Traits.xml
	- Keyed
		- Alerts.xml
		- Credits.xml
		- Dates.xml
		- (...)
	- Strings
		- Names
			- Animal_Female.txt
			- Animal_Male.txt
			- Animal_Unisex.txt
			- (...)
		- WordParts
			- CapitalLetters.txt
			- PlaceEndings.txt
			- Syllables_Byzantinian.txt
			- (...)
		- (...)
	- About.txt
	- LangIcon.png
	- LanguageInfo.xml

XML files in the "Keyed" directory contain keys that can be referred to in C#. For example:
```xml
<?xml version="1.0" encoding="utf-8"?>

<LanguageData>
	<ExampleStringWithMultipleWords>Example string with multiple words</ExampleStringWithMultipleWords>
</LanguageData>
```
```c#
"ExampleStringWithMultipleWords".Translate();
```

XML files in the "DefInjected" directory contain translations for XML definitions. For example (from RimWorld 1.3):
```xml
<?xml version="1.0" encoding="utf-8"?>

<LanguageData>
	<WorldCameraMovement.helpTexts.0>Test translation.</WorldCameraMovement.helpTexts.0>
</LanguageData>
```

Text files in the "Strings" directory can contain lists with a word on every line, which can then be used in XML to randomly get words from a bank.
