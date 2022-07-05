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

namespace HarderEnemies.UnitModifications.Demons.Minotaur {
    internal class AbilityLists {

        // MELEE RUSHING MINOTAURS

        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesCR5 = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesCR10 = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesCR15 = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesCR20 = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
        };


        // MELEE CLEAVING MINOTAURS


        // cr 5-6
        public static BlueprintUnitFactReference[] CleavingMeleeMinotaurAbilitiesCR5 = {
            FeatureList.CleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.GreatCleaveFeature.ToReference<BlueprintUnitFactReference>(),
        };
        // cr 10
        public static BlueprintUnitFactReference[] CleavingMeleeMinotaurAbilitiesCR10 = {
            FeatureList.CleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.GreatCleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CleavingFinish.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedCleavingFinish.ToReference<BlueprintUnitFactReference>(),
        };
        // cr 11 - 15
        public static BlueprintUnitFactReference[] CleavingMeleeMinotaurAbilitiesCR15 = {
            FeatureList.CleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.GreatCleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CleavingFinish.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedCleavingFinish.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CornugonSmash.ToReference<BlueprintUnitFactReference>(),
            FeatureList.IntimidatingProwess.ToReference<BlueprintUnitFactReference>(),
            FeatureList.SkillFocusDiplomacy.ToReference<BlueprintUnitFactReference>(),
        };
        // cr 16-20++
        public static BlueprintUnitFactReference[] CleavingMeleeMinotaurAbilitiesCR20 = {
            FeatureList.CleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.GreatCleaveFeature.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CleavingFinish.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedCleavingFinish.ToReference<BlueprintUnitFactReference>(),
            FeatureList.CornugonSmash.ToReference<BlueprintUnitFactReference>(),
            FeatureList.IntimidatingProwess.ToReference<BlueprintUnitFactReference>(),
            FeatureList.SkillFocusDiplomacy.ToReference<BlueprintUnitFactReference>(),
            FeatureList.DreadfulCarnage.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
