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

namespace HarderEnemies.UnitModifications.Demons.Gibrileth {
    internal class GibrilethAdjusts {

        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");
        private static BlueprintAiCastSpell StinkingCloudAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StinkingCloudAiSpell");
        private static BlueprintAiCastSpell WavesOfFatigueAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "WavesOfFatigueAiSpell");


        public static void Handler() {
            AdjustHP();
            GibrilethAbilities();
            GibrilethBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void GibrilethAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GibrilethAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbilityLists.GibrilithAbilities);
            }
            BrainList.GibrilethStandardBrain.m_Actions = BrainList.GibrilethStandardBrain.m_Actions.AppendToArray(
                StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                WavesOfFatigueAiSpell.ToReference<BlueprintAiActionReference>(),
                UnholyBlightAiSpell.ToReference<BlueprintAiActionReference>()
                );
            HEContext.Logger.LogHeader("Updated GibrilethListAbililties");
        }

        private static void GibrilethBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GibrilethBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.GibrilithBuffs);
            }

            HEContext.Logger.LogHeader("Updated GibrilethListBuuffs");
        }

    }
}
