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
using Kingmaker.UnitLogic.Abilities.Blueprints;

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

        public static void AddMemorizedSpellsAndBrains(BlueprintUnit thisUnit, BlueprintCharacterClass CharacterClass, BlueprintBrain newBrain, BlueprintAbilityReference[] NewSpellList ) {
            var charClass = thisUnit.GetComponent<AddClassLevels>(c => c.m_CharacterClass.Equals(CharacterClass.ToReference<BlueprintCharacterClassReference>()));

            if (charClass != null) {

                charClass.m_MemorizeSpells = new BlueprintAbilityReference[0] { };
                charClass.m_SelectSpells = new BlueprintAbilityReference[0] { };

                //charClass.m_MemorizeSpells = NewSpellList.ToArray();


                if (NewSpellList != null) {
                foreach (var spell in NewSpellList) {
                        charClass.m_MemorizeSpells = charClass.m_MemorizeSpells.AppendToArray(spell);
                        if (!charClass.m_SelectSpells.Contains(spell)) {
                            charClass.m_SelectSpells = charClass.m_SelectSpells.AppendToArray(spell);
                        }
                    }
                }

                // Clear alternative brains
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = newBrain.ToReference<BlueprintBrainReference>();
                HEContext.Logger.LogHeader("Added " + thisUnit.ToString() + " Spells and Brain");
            }
        }



    }
}
