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

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");

        public static void HandleMinagho() {
            MinaghoAbilities();
            MinaghoBuffs();
        }

        private static void MinaghoAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("MinaghoChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.MinaghoList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = 18;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                    Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
                    SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                    Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>()
                };
                });
            }

            BrainList.MinaghoBrain.m_Actions = BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            BrainList.Alushinyrra_MinaghoBrain.m_Actions = BrainList.Alushinyrra_MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            BrainList.Minagho_DrezenCitadel_BossBrain.m_Actions = BrainList.Minagho_DrezenCitadel_BossBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }

        private static void MinaghoBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("MinaghoBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.MinaghoList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = 18;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                    Abilities.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.MindBlankBuff.ToReference<BlueprintUnitFactReference>(),
                    Abilities.TrueSeeingBuff.ToReference<BlueprintUnitFactReference>(),
                    SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                    Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>()
                };
                });
            }

            BrainList.MinaghoBrain.m_Actions = BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            BrainList.Alushinyrra_MinaghoBrain.m_Actions = BrainList.Alushinyrra_MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            BrainList.Minagho_DrezenCitadel_BossBrain.m_Actions = BrainList.Minagho_DrezenCitadel_BossBrain.m_Actions.AppendToArray(GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>());
            //BrainList.MinaghoBrain.m_Actions.AppendToArray(GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>());
            HEContext.Logger.LogHeader("Updated Minaghos");
        }
    }
}
