﻿using Kingmaker.AI.Blueprints;
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
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorBolsteredMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorBolsteredMetaMagicFeature");

        // MELEE RUSHING MINOTAURS

        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesNormal = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
        };

        public static BlueprintUnitFactReference[] RushingMeleeMinotaurAbilitiesMythic = {
            FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>(),
            FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>(),
            Abilities.OverrunAbility.ToReference<BlueprintUnitFactReference>(),
            FeatureList.BullRushMythicFeat.ToReference<BlueprintUnitFactReference>(),
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


        // MINOTAUR BLASTERS

        public static BlueprintUnitFactReference[] MinotaurBlasterAbilities = {
            SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
            SuperiorBolsteredMetaMagicFeature.ToReference<BlueprintUnitFactReference>(),
            Abilities.SenseVitals.ToReference<BlueprintUnitFactReference>(),
            Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
            Abilities.ScorchingRay.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PreciseShot.ToReference<BlueprintUnitFactReference>(),
            FeatureList.PointBlankShot.ToReference<BlueprintUnitFactReference>(),
        };
    }
}
