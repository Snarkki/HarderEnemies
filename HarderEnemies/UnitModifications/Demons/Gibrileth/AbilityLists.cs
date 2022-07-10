using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Features;
using HarderEnemies.AI_Mechanics.Brains;
using HarderEnemies.AI_Mechanics.Actions;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.UnitModifications.Demons.Gibrileth {
    internal class AbilityLists {

        public static BlueprintUnitFactReference[] LowLevelGibrilethAbilities = {
            Abilities.UnholyBlight.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidicSpray.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] HighLevelGibrilethAbilities = {
            Abilities.AcidFog.ToReference<BlueprintUnitFactReference>(),
            Abilities.CausticEruption.ToReference<BlueprintUnitFactReference>(),
        };

    }
}
