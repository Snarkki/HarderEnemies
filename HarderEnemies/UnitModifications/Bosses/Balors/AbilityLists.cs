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
        private static BlueprintFeature DarrazandQuickenFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "DarrazandQuickenFeature");
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
            DarrazandQuickenFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

        public static BlueprintUnitFactReference[] BalorAbilities = {
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverwhelmingPresence.ToReference<BlueprintUnitFactReference>(),
            Abilities.ShoutGreater.ToReference<BlueprintUnitFactReference>(),
            FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
            SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
        };

    }
}
