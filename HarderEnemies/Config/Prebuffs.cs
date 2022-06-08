using TabletopTweaks.Core.Config;

namespace HarderEnemies.Config {
    public class Prebuffs : IUpdatableSettings {
        public bool NewSettingsOffByDefault = false;
        public SettingGroup Miscellaneous = new();
        public SettingGroup DemonBuffs = new SettingGroup();
        public SettingGroup OtherBuffs = new SettingGroup();

        public void Init() {
        }

        public void OverrideSettings(IUpdatableSettings userSettings) {
            var loadedSettings = userSettings as Prebuffs;
            NewSettingsOffByDefault = loadedSettings.NewSettingsOffByDefault;
            DemonBuffs.LoadSettingGroup(loadedSettings.DemonBuffs, NewSettingsOffByDefault);
            OtherBuffs.LoadSettingGroup(loadedSettings.OtherBuffs, NewSettingsOffByDefault);
        }
    }
}
