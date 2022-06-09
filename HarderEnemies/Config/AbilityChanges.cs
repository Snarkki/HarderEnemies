using TabletopTweaks.Core.Config;

namespace HarderEnemies.Config {
    public class AbilityChanges : IUpdatableSettings {
        public bool NewSettingsOffByDefault = true;
        public SettingGroup BossChanges = new SettingGroup();
        public SettingGroup DemonChanges = new SettingGroup();
        public SettingGroup OtherChanges = new SettingGroup();

        public void Init() {
        }

        public void OverrideSettings(IUpdatableSettings userSettings) {
            var loadedSettings = userSettings as AbilityChanges;
            NewSettingsOffByDefault = loadedSettings.NewSettingsOffByDefault;
            BossChanges.LoadSettingGroup(loadedSettings.BossChanges, NewSettingsOffByDefault);
            DemonChanges.LoadSettingGroup(loadedSettings.DemonChanges, NewSettingsOffByDefault);
            OtherChanges.LoadSettingGroup(loadedSettings.OtherChanges, NewSettingsOffByDefault);
        }
    }
}
