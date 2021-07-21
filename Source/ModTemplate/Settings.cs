using Verse;

namespace ModTemplate {
	public class Settings : ModSettings {
		public float exampleSetting = 1;

		public override void ExposeData() {
			Scribe_Values.Look(ref this.exampleSetting, "exampleSetting");

			base.ExposeData();
		}
	}
}
