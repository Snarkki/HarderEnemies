using TabletopTweaks.Core.UMMTools;
using UnityModManagerNet;

namespace HarderEnemies {
    internal static class UMMSettingsUI {
        private static int selectedTab;
        public static void OnGUI(UnityModManager.ModEntry modEntry) {
            UI.AutoWidth();
            UI.TabBar(ref selectedTab,
                    () => UI.Label("SETTINGS WILL NOT BE UPDATED UNTIL YOU RESTART YOUR GAME.".yellow().bold()),
                    new NamedAction("Ability Changes", () => SettingsTabs.AbilityChanges()),
                    new NamedAction("Prebuffs", () => SettingsTabs.Prebuffs()),
                    new NamedAction("HP Boosts", () => SettingsTabs.HPChanges())
            );
        }
    }

    internal static class SettingsTabs {

        public static void AbilityChanges() {
            var TabLevel = SetttingUI.TabLevel.Zero;
            var AddedContent = Main.HEContext.AbilityChanges;
            UI.Div(0, 15);
            using (UI.VerticalScope()) {
                UI.Toggle("New Settings On By Default".bold(), ref AddedContent.NewSettingsOffByDefault);
                UI.Space(25);
                SetttingUI.SettingGroup("Enemy Changes", TabLevel, AddedContent.DemonChanges);
            }
        }

        public static void Prebuffs() {
            var TabLevel = SetttingUI.TabLevel.Zero;
            var Fixes = Main.HEContext.Prebuffs;
            UI.Div(0, 15);
            using (UI.VerticalScope()) {
                UI.Toggle("New Settings On By Default".bold(), ref Fixes.NewSettingsOffByDefault);
                UI.Space(25);

                SetttingUI.SettingGroup("P", TabLevel, Fixes.Miscellaneous);
            }
        }

        public static void HPChanges() {
            var TabLevel = SetttingUI.TabLevel.Zero;
            var HPChanges = Main.HEContext.HPChanges;
            UI.Div(0, 15);
            using (UI.VerticalScope()) {
                UI.Toggle("New Settings On By Default".bold(), ref HPChanges.NewSettingsOffByDefault);
                UI.Space(25);
                SetttingUI.SettingGroup("Boss HP Boost", TabLevel, HPChanges.HPBoosts);
            }
        }
    }
}
