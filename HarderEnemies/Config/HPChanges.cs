using TabletopTweaks.Core.Config;

namespace HarderEnemies.Config {
    public class HPChanges : IUpdatableSettings {
        public bool NewSettingsOffByDefault = false;
        public SettingGroup HPBoosts = new();

        public void Init() {
        }

        public void OverrideSettings(IUpdatableSettings userSettings) {
            var loadedSettings = userSettings as HPChanges;
            NewSettingsOffByDefault = loadedSettings.NewSettingsOffByDefault;
            HPBoosts.LoadSettingGroup(loadedSettings.HPBoosts, NewSettingsOffByDefault);
        }
    }
}
