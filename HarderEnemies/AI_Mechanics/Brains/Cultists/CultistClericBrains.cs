using Kingmaker.Blueprints;
using Kingmaker.AI.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Brains.Cultists {
    internal class CultistClericBrains {
        private static BlueprintAiCastSpell HoldPersonAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonAiSpell");
        private static BlueprintAiCastSpell CommandAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandAiSpell");
        private static BlueprintAiCastSpell CauseFearAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CauseFearAiSpell");
        private static BlueprintAiCastSpell SoundBurstAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SoundBurstAiSpell");
        private static BlueprintAiCastSpell BoneshakerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BoneshakerAiSpell");
        private static BlueprintAiCastSpell BlindnessAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlindnessAiSpell");
        private static BlueprintAiCastSpell PrayerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PrayerAiSpell");
        private static BlueprintAiCastSpell DivinePowerAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DivinePowerAiSpell");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintAiCastSpell CommandGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandGreaterAiSpell");
        private static BlueprintAiCastSpell ColdIceStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ColdIceStrikeAiSpell");

        public static void CreateCultistClericBrains() {
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

            var CR6ClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR6ClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var CR8ClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CR8ClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   HoldPersonAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandAiSpell.ToReference<BlueprintAiActionReference>(),
                   CauseFearAiSpell.ToReference<BlueprintAiActionReference>(),
                   BoneshakerAiSpell.ToReference<BlueprintAiActionReference>(),
                   SoundBurstAiSpell.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
                   DivinePowerAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

            var HighLevelClericBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "HighLevelClericBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.CultistChannelAiAction.ToReference<BlueprintAiActionReference>(),
                   BlindnessAiSpell.ToReference<BlueprintAiActionReference>(),
                   PrayerAiSpell.ToReference<BlueprintAiActionReference>(),
                   NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                   CommandGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                   ColdIceStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
