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

namespace HarderEnemies.UnitModifications.Demons.Babau {
    internal class AbilityLists {

        private static BlueprintFeature BabauDispellingStrike = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "BabauDispellingStrike");

        public static BlueprintUnitFactReference[] BabauAbilities = {
            FeatureList.Outflank.ToReference<BlueprintUnitFactReference>(),
            BabauDispellingStrike.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
