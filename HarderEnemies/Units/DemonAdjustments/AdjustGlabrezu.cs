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
    internal class AdjustGlabrezu {


        public static void GlabrezuHandler() {
            GlabrezuAbilities();
            GlabrezuBuffs();
        }

        private static void GlabrezuAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GlabrezuAbilities")) { return; }

            foreach (BlueprintUnit thisUnit in Demons.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.GibrilithAbilities);
            }
            BrainList.GlabrezuBrainStandard.m_Actions = BrainList.GlabrezuBrainStandard.m_Actions.AppendToArray(AiCastSpellList.MinotaurCleric_DispelMagicAiAction.ToReference<BlueprintAiActionReference>(),
            AiCastSpellList.NixieConfusionAiAction.ToReference<BlueprintAiActionReference>(),
            AiCastSpellList.Glabrezu_AiAction_PowerWordStun.ToReference<BlueprintAiActionReference>()
            );
            HEContext.Logger.LogHeader("Updated GlabrezuListA");
        }

        private static void GlabrezuBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GlabrezuBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.DemonBuffLists.GibrilithAbilities);
            }
            HEContext.Logger.LogHeader("Updated GlabrezuListB");
        }

    }
}
