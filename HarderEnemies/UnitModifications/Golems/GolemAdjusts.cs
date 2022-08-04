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

namespace HarderEnemies.UnitModifications.Golems {
    internal class GolemAdjusts {


        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            AdjustHP();
            HandleGolemAbilities();
            HandleGolemBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustGolemHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.GolemList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Golem HP");
        }

        private static void HandleGolemAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("GolemChanges")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.GolemList) {
                if (thisUnit.CR >= 0 && thisUnit.CR <= 15) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR15.ToReference<BlueprintUnitFactReference>());
                    thisUnit.AddComponent<AddStatBonus>(c => {
                        c.Value = -4;
                        c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                        c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
                    });
                } else {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.DR30.ToReference<BlueprintUnitFactReference>());
                    thisUnit.AddComponent<AddStatBonus>(c => {
                        c.Value = -6;
                        c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                        c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
                    });
                }
            }
            HEContext.Logger.LogHeader("Updated Golems Abilities");
        }

        private static void HandleGolemBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("GolemBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.GolemList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.GolemBuffs);
            }
            HEContext.Logger.LogHeader("Updated Golems Buffs");
        }

    }
}
