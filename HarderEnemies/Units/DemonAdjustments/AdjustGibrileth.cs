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


namespace HarderEnemies.Units.DemonAdjustments {
    internal class AdjustGibrileth {

        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");


        public static void GibrilethHandler() {
            GibrilethAbilities();
            GibrilethBuffs();
        }

        private static void GibrilethAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GibrilethAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.GibrilithAbilities);
            }
            BrainList.GibrilethStandardBrain.m_Actions = BrainList.GibrilethStandardBrain.m_Actions.AppendToArray(AiCastSpellList.StinkingCloudAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Minagho_WavesOfFatigueAiAction.ToReference<BlueprintAiActionReference>(),
                UnholyBlightAiSpell.ToReference<BlueprintAiActionReference>()
                );
            HEContext.Logger.LogHeader("Updated GibrilethListAbililties");

        }

        private static void GibrilethBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GibrilethBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Demons.DemonGibrilethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.GibrilithBuffs);
            }

            HEContext.Logger.LogHeader("Updated GibrilethListBuuffs");
        }

    }
}
