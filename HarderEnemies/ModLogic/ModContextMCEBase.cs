using HarderEnemies.Config;
using TabletopTweaks.Core.ModLogic;
using static UnityModManagerNet.UnityModManager;

namespace HarderEnemies.ModLogic {
    internal class ModContextMCEBase : ModContextBase {
        public AbilityChanges AbilityChanges;
        public Prebuffs Prebuffs;
        public HPChanges HPChanges;
        public ModContextMCEBase(ModEntry ModEntry) : base(ModEntry) {
            LoadAllSettings();
#if DEBUG
            Debug = true;
#endif
        }
        public override void LoadAllSettings() {
            LoadSettings("AbilityChanges.json", "HarderEnemies.Config", ref AbilityChanges);
            LoadSettings("Prebuffs.json", "HarderEnemies.Config", ref Prebuffs);
            LoadSettings("HPChanges.json", "HarderEnemies.Config", ref HPChanges);
            LoadBlueprints("HarderEnemies.Config", Main.HEContext);
            LoadLocalization("HarderEnemies.Localization");
        }

        public override void AfterBlueprintCachePatches() {
            base.AfterBlueprintCachePatches();
        }

        public override void SaveAllSettings() {
            base.SaveAllSettings();
            SaveSettings("AbilityChanges.json", AbilityChanges);
            SaveSettings("Prebuffs.json", Prebuffs);
            SaveSettings("HPChanges.json", HPChanges);
        }
    }
}
