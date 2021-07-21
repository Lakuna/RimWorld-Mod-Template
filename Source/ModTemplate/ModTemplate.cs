using UnityEngine;
using Verse;

namespace ModTemplate {
	public class ModTemplate : Mod {
		public static ModTemplate Instance;

		public Settings settings;

		public ModTemplate(ModContentPack content) : base(content) {
			if (ModTemplate.Instance == null) {
				ModTemplate.Instance = this;
			}

			this.settings = this.GetSettings<Settings>();
		}

		public override void DoSettingsWindowContents(Rect rect) {
			Listing_Standard listingStandard = new Listing_Standard();
			listingStandard.Begin(rect);
			_ = listingStandard.Label("Example setting");
			this.settings.exampleSetting = listingStandard.Slider(this.settings.exampleSetting, 0, 100);
			listingStandard.End();

			base.DoSettingsWindowContents(rect);
		}
	}
}
