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

namespace HarderEnemies.UnitModifications.Demons.Glabrezu {
    internal class GlabrezuAdjusts {




        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");

        public static void Handler() {
            AdjustHP();
            GlabrezuAbilities();
            GlabrezuBuffs();
        }


        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDemonsHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Demons HP");
        }

        private static void GlabrezuAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("GlabrezuAbilities")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbilityLists.GlabrezuAbilities);
            }
            BrainList.GlabrezuBrainStandard.m_Actions = BrainList.GlabrezuBrainStandard.m_Actions.AppendToArray(
                AiCastSpellList.MinotaurCleric_DispelMagicAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.NixieConfusionAiAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Glabrezu_AiAction_PowerWordStun.ToReference<BlueprintAiActionReference>()
            );

            "nää pitäs splittaa vähintää kahteen ryhmään. low lvl ja high lvl ja sen mukaan abilityt"


            HEContext.Logger.LogHeader("Updated GlabrezuListA");
        }

        private static void GlabrezuBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("GlabrezuBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.DemonGlabrezuList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(BuffLists.GlabrezuBuffs);
            }
            HEContext.Logger.LogHeader("Updated GlabrezuListB");
        }

    }
}
