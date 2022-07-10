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

namespace HarderEnemies.AI_Mechanics.Brains.Cyborgs {
    internal class CyborgDemonBrains {
        private static BlueprintAiCastSpell CommandGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandGreaterAiSpell");
        private static BlueprintAiCastSpell SlowAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SlowAiSpell");
        private static BlueprintAiCastSpell OverwhelmingGriefAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingGriefAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell BoneshatterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BoneshatterAiSpell");
        private static BlueprintAiCastSpell VampiricTouchAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "VampiricTouchAiSpell");

        public static void Handler() {
            CreateIncubusAssasinBrain();
            CreateKalavakusBrain();
            CreateSuccubusSorcererBrain();
        }
        public static void CreateKalavakusBrain() {
            var KalavakusBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "KalavakusBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Kalavakus_AiAction_EnslaveSoul.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.ChargeAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Kalavakus_AiAction_Haste.ToReference<BlueprintAiActionReference>(),
                    CommandGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Kalavakus_AiAction_Trip.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateSuccubusSorcererBrain() {
            var SuccubusSorcererBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "SuccubusSorcererBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    OverwhelmingGriefAiSpell.ToReference<BlueprintAiActionReference>(),
                    SlowAiSpell.ToReference<BlueprintAiActionReference>(),
                    InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    BoneshatterAiSpell.ToReference<BlueprintAiActionReference>(),
                    VampiricTouchAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateIncubusAssasinBrain() {

            var IncubusAssassinBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "IncubusAssassinBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Incubul_AiAction_CrushingDespair.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Incubul_AiAction_HideInPlainSight.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Incubul_AiAction_DeathAttack.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
