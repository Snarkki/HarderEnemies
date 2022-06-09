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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustMinagho {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell PowerWordBlindAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PowerWordBlindAiSpell");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");

        public static void HandleMinagho() {
            MinaghoAbilities();
            MinaghoBuffs();
        }

        private static void MinaghoAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("MinaghoChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.MinaghoList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BossBuffLists.MinaghoAbilities);
            }


 
            BrainList.Alushinyrra_Minagho_Brain.m_Actions = BrainList.Alushinyrra_Minagho_Brain.m_Actions.AppendToArray(
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Minagho_PhantasmalPutrefactionAIAction.ToReference<BlueprintAiActionReference>(),
                PowerWordBlindAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.FireStormAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.ChainLightningAiAction.ToReference<BlueprintAiActionReference>(),
                CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>()
                );


            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }

        private static void MinaghoBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("MinaghoBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.MinaghoList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.BossBuffLists.MinaghoBuffs);
            }

            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }
    }
}
