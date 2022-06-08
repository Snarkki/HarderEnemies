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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustDemonLords {
        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell SummonMonsterViiAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonMonsterViiAiSpell");
        private static BlueprintAiCastSpell FearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FearAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintItemWeapon HolyEvilBane5Sword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "HolyEvilBane5Sword");

        private static BlueprintAbility GreaterSwarmSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GreaterSwarmSummon");
        private static BlueprintAbility GateSpell = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "GateSpell");

        private static BlueprintBrain NocticulaAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NocticulaAltBrain");
        private static BlueprintBrain DeskariAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DeskariAltBrain");


        //Balor weapons
        private static BlueprintItemWeapon BalorNewSword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "BalorNewSword");
        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");
        private static BlueprintAiCastSpell PullingStrikeAiAction = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PullingStrikeAiAction");

        private static BlueprintUnitFactReference[] DemonLordBuffsList =  {
                        Abilities.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.FlamesOfTheAbyssBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.BloodHaze.ToReference<BlueprintUnitFactReference>(),
                        Abilities.BoneShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.DR15.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.AlwaysAChange.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.ThunderingBlows.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.DestructiveShockwave.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.AscendentElementFire.ToReference<BlueprintUnitFactReference>(),
                        SuperToughness.ToReference<BlueprintUnitFactReference>()
        };

        public static void HandleDemonLords() {
            DemonLordAbilities();
            DemonLordBuffs();
        }


        private static void DemonLordAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("DemonLordChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.NocticulaList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.WindsOfVengeanceBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
                        Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
                        Abilities.RiftOfRuin.ToReference<BlueprintUnitFactReference>(),
                        Abilities.Firestorm.ToReference<BlueprintUnitFactReference>(),
                        SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                        SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
                    };
                });
                thisUnit.AlternativeBrains = thisUnit.AlternativeBrains.AppendToArray(NocticulaAltBrain.ToReference<BlueprintBrainReference>());
            }

            foreach (BlueprintUnit thisUnit in Bosses.DeskariList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        GreaterSwarmSummon.ToReference<BlueprintUnitFactReference>(),
                        Abilities.EdictOfInvulnerability.ToReference<BlueprintUnitFactReference>(),
                    };
                });
                thisUnit.AlternativeBrains = thisUnit.AlternativeBrains.AppendToArray(DeskariAltBrain.ToReference<BlueprintBrainReference>());
            }



            //CR30_AreshkagalBoss, ehkä ei mitään...


            Bosses.AreeluDemonicForm.AddComponent<AddFacts>(c => {
                c.CasterLevel = Bosses.AreeluDemonicForm.CR;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.OverwhelmingPresence.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
                        Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
                        Abilities.CommandGreaterFall.ToReference<BlueprintUnitFactReference>(),
                        SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                        SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>(),
                        GateSpell.ToReference<BlueprintUnitFactReference>(),
                    };
            });
            Bosses.AreeluDemonicForm.AlternativeBrains = Bosses.AreeluDemonicForm.AlternativeBrains.AppendToArray(DeskariAltBrain.ToReference<BlueprintBrainReference>());
        }


        private static void DemonLordBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("DemonLordBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.DemonLordList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = DemonLordBuffsList;
                });
            }
        }
    }
}
