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
    internal class MinotaurAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain MinotaurStandardBrainNew = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MinotaurStandardBrainNew");


        public static void Handler() {
            AdjustHP();
            BabauAbilities();
            BabauBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonMeleeMinotaurList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void BabauAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("MinotaurAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonMeleeMinotaurList) {
                if (thisUnit.CR <= 6) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR5);

                    // BRAINIT TÄHÄ
                } else if (thisUnit.CR > 6 && thisUnit.CR <= 11) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR10);

                    // BRAINIT TÄHÄ
                } else if (thisUnit.CR > 11 && thisUnit.CR <= 16) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR15);
                } else if (thisUnit.CR > 16) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR20);
                }
            }
            foreach (BlueprintUnit thisUnit in UnitLists.RushingMinotaursList) {

            }

            UnitLists.MinotaurGhost_Boss.AddComponent<AddStatBonus>(c => {
                c.Value = -4;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });
            UnitLists.MinotaurGhost_Boss.AddComponent<AddStatBonus>(c => {
                c.Value = -4;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });


            HEContext.Logger.LogHeader("Updated Babau Abilities");

        }

        private static void BabauBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("MinotaurBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonMeleeMinotaurList) {

            }
            HEContext.Logger.LogHeader("Updated BabauBuffs");
        }

    }
}
