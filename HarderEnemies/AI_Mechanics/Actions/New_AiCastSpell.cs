using Kingmaker.AI.Blueprints;
using Kingmaker.AI.Blueprints.Considerations;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Actions {
    public class New_AiCastSpell {
        public static void CreateNew() {
            ByLevels.Level1.Handler();
            ByLevels.Level2.Handler();
            ByLevels.Level3.Handler();
            ByLevels.Level4.Handler();
            ByLevels.Level5.Handler();
            ByLevels.Level6.Handler();
            ByLevels.Level7.Handler();
            ByLevels.Level8.Handler();
            ByLevels.Level9.Handler();
            ByLevels.Custom.Handler();
        }
    }
}


