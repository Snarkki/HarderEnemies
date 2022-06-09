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
                UI.Space(25);
                SetttingUI.SettingGroup("Enemy Changes", TabLevel, AddedContent.DemonChanges);
                SetttingUI.SettingGroup("Boss Changes", TabLevel, AddedContent.BossChanges);
                SetttingUI.SettingGroup("Other Changes", TabLevel, AddedContent.OtherChanges);
            }
        }

        public static void Prebuffs() {
            var TabLevel = SetttingUI.TabLevel.Zero;
            var Prebuffs = Main.HEContext.Prebuffs;
            UI.Div(0, 15);
            using (UI.VerticalScope()) {
                UI.Space(25);
                SetttingUI.SettingGroup("Demon Buffs", TabLevel, Prebuffs.DemonBuffs);
                SetttingUI.SettingGroup("Boss Buffs", TabLevel, Prebuffs.BossBuffs);
                SetttingUI.SettingGroup("Other Buffs", TabLevel, Prebuffs.OtherBuffs);
            }
        }

        public static void HPChanges() {
            var TabLevel = SetttingUI.TabLevel.Zero;
            var HPChanges = Main.HEContext.HPChanges;
            UI.Div(0, 15);
            using (UI.VerticalScope()) {
                UI.Space(25);
                SetttingUI.SettingGroup("HP Boosts", TabLevel, HPChanges.HPBoosts);
            }
        }
    }
}
