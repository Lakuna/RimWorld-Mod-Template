# /Assemblies
This directory contains the .dll files for mods which use C#.

0Harmony.dll should **not** be included in your mod release for RimWorld versions 1.1+.

This template contains a copy of Harmony v2.1.0.0 as an example. You should download the latest compatible version of Harmony [here](https://github.com/pardeike/Harmony/releases/latest). Make sure that you update the Harmony reference in your C# project if you do so.

RimWorld versions up to and including 1.0 require Harmony < 2 (latest: 1.2.0.1). Make sure to build your assembly for each version of Harmony you plan on supporting.
