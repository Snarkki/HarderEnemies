using HarmonyLib;
using HarderEnemies.ModLogic;
using TabletopTweaks.Core.Utilities;
using UnityModManagerNet;

namespace HarderEnemies {
    static class Main {
        public static bool Enabled;
        public static ModContextMCEBase HEContext;
        static bool Load(UnityModManager.ModEntry modEntry) {
            var harmony = new Harmony(modEntry.Info.Id);
            HEContext = new ModContextMCEBase(modEntry);
            HEContext.LoadAllSettings();
            HEContext.ModEntry.OnSaveGUI = OnSaveGUI;
            HEContext.ModEntry.OnGUI = UMMSettingsUI.OnGUI;
            harmony.PatchAll();
            PostPatchInitializer.Initialize(HEContext);
            return true;
        }

        static void OnSaveGUI(UnityModManager.ModEntry modEntry) {
            HEContext.SaveAllSettings();
        }
    }
}
