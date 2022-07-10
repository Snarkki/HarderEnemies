using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Brains.DemonsByType {
    internal class GibrilithBrains {
        private static BlueprintAiCastSpell StinkingCloudAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StinkingCloudAiSpell");
        private static BlueprintAiCastSpell WavesOfFatigueAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "WavesOfFatigueAiSpell");
        private static BlueprintAiCastSpell UnholyBlightAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "UnholyBlightAiSpell");
        private static BlueprintAiCastSpell AcidicSprayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AcidicSprayAiSpell");
        private static BlueprintAiCastSpell AcidFogAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AcidFogAiSpell");
        private static BlueprintAiCastSpell CausticEruptionAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "AcidicSprayAiSpell");



        public static void Handler() {
            CreateLowLevelGibrilithBrain();
            CreateHighLevelGibrilithBrain();
        }
        public static void CreateLowLevelGibrilithBrain() {
            var LowLevelGibrilithBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "LowLevelGibrilithBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                    WavesOfFatigueAiSpell.ToReference<BlueprintAiActionReference>(),
                    UnholyBlightAiSpell.ToReference<BlueprintAiActionReference>(),
                    AcidicSprayAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateHighLevelGibrilithBrain() {

            // attack, stinkingcloud, wavesoffatigue,acid fog, causting erupution
            var HighLevelGibrilithBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "HighLevelGibrilithBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    StinkingCloudAiSpell.ToReference<BlueprintAiActionReference>(),
                    WavesOfFatigueAiSpell.ToReference<BlueprintAiActionReference>(),
                    AcidFogAiSpell.ToReference<BlueprintAiActionReference>(),
                    CausticEruptionAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

    }
}
