using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.ElementsSystem;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.UnitLogic.FactLogic;
using Kingmaker.AI.Blueprints;

namespace HarderEnemies.Utils {
    public static class CustomHelpers {


        public static void AddFactListsToUnit(this BlueprintUnit unit, int casterlevel, BlueprintUnitFactReference[] buffList) {
            unit.AddComponent<AddFacts>(c => {
                c.CasterLevel = casterlevel;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Story;
                c.m_Facts = buffList;
            });
        }

        public static void AddFactsToUnit(this BlueprintUnit thisUnit, BlueprintUnitFactReference[] factList) {
            foreach (var fact in factList) {
                if (!thisUnit.m_AddFacts.Contains(fact)) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(fact);
                }
            }
            HEContext.Logger.LogHeader("Added " + thisUnit.ToString() + " facts");
        }

        public static void AddMemorizedSpellsAndBrains(BlueprintUnit thisUnit, BlueprintCharacterClass CharacterClass, BlueprintAbilityReference[] SpellList, BlueprintBrain newBrain) {
            var memorizedSpells = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass.Equals(CharacterClass.ToReference<BlueprintCharacterClassReference>()))?.m_MemorizeSpells;
            //HEContext.Logger.LogHeader(clericClass.m_CharacterClass.ToString());
            if (memorizedSpells != null) {

                memorizedSpells = SpellList;

                // Clear alternative brains
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = newBrain.ToReference<BlueprintBrainReference>();
                HEContext.Logger.LogHeader("Added " + thisUnit.ToString() + " Spells and Brain");
            }
        }



    }
}
