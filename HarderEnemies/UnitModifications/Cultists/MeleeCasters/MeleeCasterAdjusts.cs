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

namespace HarderEnemies.UnitModifications.Cultists.MeleeCasters {
    internal class MeleeCasterAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain LowLevelClericBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "LowLevelClericBrain");
        private static BlueprintBrain CR6ClericBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR6ClericBrain");
        private static BlueprintBrain CR8ClericBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CR8ClericBrain");
        private static BlueprintBrain HighLevelClericBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "HighLevelClericBrain");

        public static void Handler() {
            HandleHPBuff();
            HandleAbilities();
            HandleBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustCultistCastersHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.LowLevelClericList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6ClericList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8ClericList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                foreach (BlueprintUnit thisUnit in UnitLists.HighLevelClericList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
                }
                UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.m_AddFacts = UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
        }

        private static void HandleAbilities() {

            //Modify Abilities including brains
            if (!HEContext.AbilityChanges.OtherChanges.IsDisabled("CultistCasterChanges")) {
                // CR3&¤
                foreach (BlueprintUnit thisUnit in UnitLists.LowLevelClericList) {
                    // Adjust memorized spells
                    var clericClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.ClericClass.ToReference<BlueprintCharacterClassReference>());
                    clericClass.m_MemorizeSpells = AbilityLists.LowLevelCultistClericMemorizedSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = LowLevelClericBrain.ToReference<BlueprintBrainReference>();
                }

                foreach (BlueprintUnit thisUnit in UnitLists.CR6ClericList) {
                    // Adjust memorized spells
                    var clericClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.ClericClass.ToReference<BlueprintCharacterClassReference>());
                    clericClass.m_MemorizeSpells = AbilityLists.CR6ClericMemorizedSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR6ClericBrain.ToReference<BlueprintBrainReference>();
                }

                foreach (BlueprintUnit thisUnit in UnitLists.CR8ClericList) {
                    // Adjust memorized spells
                    var clericClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.ClericClass.ToReference<BlueprintCharacterClassReference>());
                    clericClass.m_MemorizeSpells = AbilityLists.CR8ClericMemorizedSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = CR8ClericBrain.ToReference<BlueprintBrainReference>();
                }

                foreach (BlueprintUnit thisUnit in UnitLists.HighLevelClericList) {
                    // Adjust memorized spells
                    var clericClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.ClericClass.ToReference<BlueprintCharacterClassReference>());
                    clericClass.m_MemorizeSpells = AbilityLists.HighLevelClericMemorizedSpells;

                    // Clear alternative brains
                    thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                    thisUnit.m_Brain = HighLevelClericBrain.ToReference<BlueprintBrainReference>();
                }


                // thiis  seems to have high level abilities ready
                //var clericClassVar = UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.GetComponent<AddClassLevels>(c => c.m_CharacterClass == CharacterClass.ClericClass.ToReference<BlueprintCharacterClassReference>());
                //clericClassVar.m_MemorizeSpells = AbilityLists.HighLevelClericMemorizedSpells;

                //// Clear alternative brains
                //UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.AlternativeBrains = new BlueprintBrainReference[0] { };
                //UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.m_Brain = HighLevelClericBrain.ToReference<BlueprintBrainReference>();

                //UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.m_AddFacts = UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
        }
        private static void HandleBuffs() {
            // Create prebuffs

            if (!HEContext.Prebuffs.OtherBuffs.IsDisabled("CultistCasterBuffs")) {
                foreach (BlueprintUnit thisUnit in UnitLists.LowLevelClericList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.LowLevelClericBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR6ClericList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR6ClericBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.CR8ClericList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.CR8ClericBuffs);
                }
                foreach (BlueprintUnit thisUnit in UnitLists.HighLevelClericList) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.HighLevelClericBuffs);
                }

                Utils.CustomHelpers.AddFactListsToUnit(UnitLists.CR19_Cultist_Areshkagal_MeleeCaster, UnitLists.CR19_Cultist_Areshkagal_MeleeCaster.CR, BuffLists.HighLevelClericBuffs);
            }
        }


    }
}
