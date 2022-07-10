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

namespace HarderEnemies.UnitModifications.Demons.Glabrezu {
    internal class AbilityLists {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");

        public static BlueprintUnitFactReference[] AdvancedGlabrezuAbilities = {
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] MythicGlabrezuAbilities = {
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.PrismaticSpray.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
