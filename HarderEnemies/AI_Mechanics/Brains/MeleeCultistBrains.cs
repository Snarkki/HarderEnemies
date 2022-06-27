using HarderEnemies.Blueprints;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;


namespace HarderEnemies.AI_Mechanics.Brains {
    internal class MeleeCultistBrains {

        private static BlueprintAiCastSpell HoldPersonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonAiSpell");
        private static BlueprintAiCastSpell CommandAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandAiSpell");
        private static BlueprintAiCastSpell CauseFearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CauseFearAiSpell");
        private static BlueprintAiCastSpell SoundBurstAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SoundBurstAiSpell");
        private static BlueprintAiCastSpell BoneshakerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BoneshakerAiSpell");

        public static void BrainHandler() {
            LowLevelCultistBrains();
        }

        private static void LowLevelCultistBrains() {
            var LowLevelClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "LowLevelClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
