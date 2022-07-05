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

namespace HarderEnemies.UnitModifications.Demons.Brimorak {
    internal class AbilityLists {

        private static BlueprintFeature SuperiorBolsteredMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorBolsteredMetaMagicFeature");

        public static BlueprintUnitFactReference[] BrimorakAbilities = {
            Abilities.DragonsBreath.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidArrow.ToReference<BlueprintUnitFactReference>(),
            Abilities.BurningArc.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PointBlankShot.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PreciseShot.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] BrimorakAbilitiesWithMetamagic = {
            Abilities.DragonsBreath.ToReference<BlueprintUnitFactReference>(),
            Abilities.AcidArrow.ToReference<BlueprintUnitFactReference>(),
            Abilities.BurningArc.ToReference<BlueprintUnitFactReference>(),
            SuperiorBolsteredMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PointBlankShot.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PreciseShot.ToReference<BlueprintUnitFactReference>(),
        };

    }
}
