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
        private static BlueprintBrain CleaveMinotaurBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "CleaveMinotaurBrain");
        private static BlueprintBrain ChargingMinotaurBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "ChargingMinotaurBrain");
        private static BlueprintBrain BlasterMinotaurBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "BlasterMinotaurBrain");
        private static BlueprintBrain ClericMinotaurBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "ClericMinotaurBrain");


        public static void Handler() {
            AdjustHP();
            HandleAbilities();
            HandleBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.MinotaurList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void HandleAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("MinotaurAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonMeleeMinotaurList) {
                if (thisUnit.CR <= 6) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR5);
                } else if (thisUnit.CR > 6 && thisUnit.CR <= 11) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR10);
                } else if (thisUnit.CR > 11 && thisUnit.CR <= 16) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR15);
                } else if (thisUnit.CR > 16) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.CleavingMeleeMinotaurAbilitiesCR20);
                }
                thisUnit.m_Brain = CleaveMinotaurBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };

            }
            foreach (BlueprintUnit thisUnit in UnitLists.RushingMinotaursList) {
                if (thisUnit.CR <= 19) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.RushingMeleeMinotaurAbilitiesNormal);
                } else if (thisUnit.CR > 20) {
                    Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.RushingMeleeMinotaurAbilitiesMythic);
                }
                thisUnit.m_Brain = ChargingMinotaurBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            UnitLists.MinotaurGhost_Boss.AddComponent<AddStatBonus>(c => {
                c.Value = -5;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });

            UnitLists.MinotaurGhost_BossNoExp.AddComponent<AddStatBonus>(c => {
                c.Value = -5;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });


            // MINOTAUR CASTERS - CLERICS & SORCERERS
            UnitLists.CR14_MinotaurCleric.m_Brain = ClericMinotaurBrain.ToReference<BlueprintBrainReference>();
            UnitLists.CR14_MinotaurCleric.AlternativeBrains = new BlueprintBrainReference[0] { };

            foreach (BlueprintUnit thisUnit in UnitLists.MinotaurBlasters) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.MinotaurBlasterAbilities);
                thisUnit.m_Brain = BlasterMinotaurBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }

            HEContext.Logger.LogHeader("Updated Minotaur Abilities");

        }

        private static void HandleBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("MinotaurBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonMeleeMinotaurList) {
                if (thisUnit.CR <= 15) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit,BuffLists.MeleeMinotaurBuffs);
                } else {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.HighLevelMeleeMinotaursAlternative);
                }
            }
            foreach (BlueprintUnit thisUnit in UnitLists.RushingMinotaursList) {
                if (thisUnit.CR <= 15) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.MeleeMinotaurBuffs);
                } else {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.HighLevelMeleeMinotaurs);
                }
            }
            HEContext.Logger.LogHeader("Updated Minotaur Buffs");
        }

    }
}
