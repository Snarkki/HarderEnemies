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

namespace HarderEnemies.UnitModifications.Demons.Brimorak {
    internal class BrimorakAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain BrimorakBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "BrimorakBrain");

        public static void Handler() {
            AdjustHP();
            BrimorakAbilities();
            BrimorakBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonBrimorakList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void BrimorakAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("BrimorakAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonBrimorakList) {
                if (thisUnit.CR < 6) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, AbilityLists.BrimorakAbilities);
                } else {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, AbilityLists.BrimorakAbilitiesWithMetamagic);
                }
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = BrimorakBrain.ToReference<BlueprintBrainReference>();

            }
        }

        private static void BrimorakBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("BrimorakBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonBrimorakList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BrimorakBuffs);
            }
            HEContext.Logger.LogHeader("Updated Brimorak Buffs");
        }

    }
}
