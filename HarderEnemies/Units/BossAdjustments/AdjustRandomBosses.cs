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
    internal class AdjustRandomBosses {
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

        public static void HandleRandomBosses() {
            RandomBossAbilities();
            RandomBossBuffs();
        }

        private static void RandomBossAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("RandomBossChanges")) { return; }


        }
        private static void RandomBossBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("RandomBossBuffs")) { return; }

            Bosses.FakeHellknightGlabrezuBoss.m_AddFacts = Bosses.FakeHellknightGlabrezuBoss.m_AddFacts.AppendToArray(Abilities.UnholyAura.ToReference<BlueprintUnitFactReference>());
            Bosses.LostChapel_GargoyleMiniboss.m_AddFacts = Bosses.LostChapel_GargoyleMiniboss.m_AddFacts.AppendToArray(Abilities.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>());

            Bosses.Maugla.AddComponent<AddFacts>(c => {
                c.CasterLevel = Bosses.Maugla.CR;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>()
                    };
            });

            foreach (BlueprintUnit thisUnit in Bosses.MutafasenList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = 17;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>()

                    };
                });
            }


            Bosses.Mutasafen.AddComponent<AddFacts>(c => {
                c.CasterLevel = 20;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.InvisibilityGreater.ToReference<BlueprintUnitFactReference>(),
                        Abilities.LegendaryProportionsBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.EchoLocationbuff.ToReference<BlueprintUnitFactReference>(),
                        FeatureList.AscendentElementAcid.ToReference<BlueprintUnitFactReference>(),
                        SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                    };

                BrainList.Mutasafen_Brain.m_Actions = BrainList.Mutasafen_Brain.m_Actions.AppendToArray(
                        GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>()
                    );
            });


            Bosses.XanthirPhase1.AddComponent<AddFacts>(c => {
                c.CasterLevel = 20;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
                    };
            });
        }
    }
}
