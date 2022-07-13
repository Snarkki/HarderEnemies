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
using Kingmaker.UnitLogic.Abilities.Blueprints;

namespace HarderEnemies.UnitModifications.Bosses.Balors {
    internal class AbilityLists {
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        //Balor weapons
        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");




        public static BlueprintUnitFactReference[] DarrazandAbilities = {
            Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            Abilities.LegendaryProportions.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.MirrorImage.ToReference<BlueprintUnitFactReference>(),
            Abilities.MindBlank.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            PullingStrikeAbility.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] MeleeBalorAbilities = {
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.MindBlank.ToReference<BlueprintUnitFactReference>(),
            Abilities.LegendaryProportions.ToReference<BlueprintUnitFactReference>(),
            Abilities.MirrorImage.ToReference<BlueprintUnitFactReference>(),
            Abilities.DemonTeleport.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] CasterBalorAbilities = {
            Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            Abilities.LegendaryProportions.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.MirrorImage.ToReference<BlueprintUnitFactReference>(),
            Abilities.MindBlank.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            PullingStrikeAbility.ToReference<BlueprintUnitFactReference>(),
            Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.ShoutGreater.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] MythicBalorAbilities = {
            Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
            Abilities.LegendaryProportions.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.MirrorImage.ToReference<BlueprintUnitFactReference>(),
            Abilities.MindBlank.ToReference<BlueprintUnitFactReference>(),
            Abilities.DemonTeleport.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.VitalStrikeFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.VitalStrikeFeatureGreater.ToReference<BlueprintUnitFactReference>(),
            FeatureList.VitalStrikeFeatureImproved.ToReference<BlueprintUnitFactReference>(),
            FeatureList.VitalStrikeMythicFeat.ToReference<BlueprintUnitFactReference>(),
        };

    }
}
