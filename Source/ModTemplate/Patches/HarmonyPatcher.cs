using HarmonyLib;
using Verse;

namespace ModTemplate.Patches {
	[StaticConstructorOnStartup]
	public class HarmonyPatcher {
		static HarmonyPatcher() => new Harmony("Lakuna.ModTemplate").PatchAll();
	}
}
