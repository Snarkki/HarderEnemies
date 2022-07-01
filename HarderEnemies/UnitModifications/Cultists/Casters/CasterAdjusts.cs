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

namespace HarderEnemies.UnitModifications.Cultists.Casters {
    internal class CasterAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain CR4DamageWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR4DamageWizardBrain");
        private static BlueprintBrain CR4SummonWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR4SummonWizardBrain");
        private static BlueprintBrain CR6DamageWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR6DamageWizardBrain");
        private static BlueprintBrain CR6SummonWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR6SummonWizardBrain");
        private static BlueprintBrain CR8DamageWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR8DamageWizardBrain");
        private static BlueprintBrain CR8SummonWizardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR8SummonWizardBrain");

        public static void Handler() {
            HandleHPBuff();
            HandleAbilities();
            HandleBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustCultistCastersHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistDamageCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistSummonCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistDamageCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistSummonCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistDamageCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistSummonCasterList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                UnitLists.CR17_Cultist_Areshkagal_DamageFullCaster.m_AddFacts = UnitLists.CR17_Cultist_Areshkagal_DamageFullCaster.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());          
            }
        }

        private static void HandleAbilities() {

            //Modify Abilities including brains
            if (!HEContext.AbilityChanges.OtherChanges.IsDisabled("CultistCasterChanges")) {
                // CR4
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistDamageCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR4DamageWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR4DamageWizardBrain.ToReference<BlueprintBrainReference>();
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistSummonCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR4SummonWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR4SummonWizardBrain.ToReference<BlueprintBrainReference>();
                }


                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistDamageCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR6DamageWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR6DamageWizardBrain.ToReference<BlueprintBrainReference>();
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistSummonCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR6SummonWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR6SummonWizardBrain.ToReference<BlueprintBrainReference>();
                }



                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistDamageCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR8DamageWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR8DamageWizardBrain.ToReference<BlueprintBrainReference>();
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistSummonCasterList) {
                    // Adjust memorized spells
                    var wizardClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.WizardClass.ToReference<BlueprintCharacterClassReference>());
                    wizardClass.m_MemorizeSpells = AbilityLists.CR8SummonWizardSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR8SummonWizardBrain.ToReference<BlueprintBrainReference>();
                }
            }
        }
        private static void HandleBuffs() {
            // Create prebuffs

            if (!HEContext.Prebuffs.OtherBuffs.IsDisabled("CultistCasterBuffs")) {
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistDamageCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR4WizardBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR4CultistSummonCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR4WizardBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistDamageCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR6WizardBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6CultistSummonCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR6WizardBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistDamageCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR8WizardBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8CultistSummonCasterList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR8WizardBuffs);
                }

            }
        }


    }
}
