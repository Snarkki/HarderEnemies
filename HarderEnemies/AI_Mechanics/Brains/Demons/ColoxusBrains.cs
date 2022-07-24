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

namespace HarderEnemies.AI_Mechanics.Brains.Demons {
    internal class ColoxusBrains {
        private static BlueprintAiCastSpell ContagionBubonicAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ContagionBubonicAiSpell");
        private static BlueprintAiCastSpell ColoxusDroningWingsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ColoxusDroningWingsAiSpell");
        private static BlueprintAiCastSpell HasteAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HasteAiSpell");
        private static BlueprintAiCastSpell MindFogAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MindFogAiSpell");
        private static BlueprintAiCastSpell ConfusionAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ConfusionAiSpell");
        private static BlueprintAiCastSpell OverwhelmingPresenceAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingPresenceAiSpell");
        private static BlueprintAiCastSpell SongOfDiscordAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SongOfDiscordAiSpell");
        private static BlueprintAiCastSpell InsanityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InsanityAiSpell");
        private static BlueprintAiCastSpell LitanyOfMadnessAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "LitanyOfMadnessAiSpell");




        public static void Handler() {
            CreateNormalColoxusBrain();
            CreateDiscordColoxusBrain();
            CreateCasterColoxusBrain();
        }

        private static void CreateNormalColoxusBrain() {

            var NormalColoxusBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "NormalColoxusBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Coloxus_AiAction_QInvisibility.ToReference<BlueprintAiActionReference>(),
                    ContagionBubonicAiSpell.ToReference<BlueprintAiActionReference>(),
                    ColoxusDroningWingsAiSpell.ToReference<BlueprintAiActionReference>(),
                    HasteAiSpell.ToReference<BlueprintAiActionReference>(),
                    MindFogAiSpell.ToReference<BlueprintAiActionReference>(),
                    ConfusionAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        private static void CreateDiscordColoxusBrain() {

            var DiscordColoxusBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DiscordColoxusBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Coloxus_AiAction_QInvisibility.ToReference<BlueprintAiActionReference>(),
                    ContagionBubonicAiSpell.ToReference<BlueprintAiActionReference>(),
                    ColoxusDroningWingsAiSpell.ToReference<BlueprintAiActionReference>(),
                    HasteAiSpell.ToReference<BlueprintAiActionReference>(),
                    MindFogAiSpell.ToReference<BlueprintAiActionReference>(),
                    ConfusionAiSpell.ToReference<BlueprintAiActionReference>(),
                    SongOfDiscordAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        private static void CreateCasterColoxusBrain() {

            var CasterColoxusBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "CasterColoxusBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Coloxus_AiAction_QInvisibility.ToReference<BlueprintAiActionReference>(),
                    ContagionBubonicAiSpell.ToReference<BlueprintAiActionReference>(),
                    ColoxusDroningWingsAiSpell.ToReference<BlueprintAiActionReference>(),
                    HasteAiSpell.ToReference<BlueprintAiActionReference>(),
                    MindFogAiSpell.ToReference<BlueprintAiActionReference>(),
                    ConfusionAiSpell.ToReference<BlueprintAiActionReference>(),
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    SongOfDiscordAiSpell.ToReference<BlueprintAiActionReference>(),
                    InsanityAiSpell.ToReference<BlueprintAiActionReference>(),
                    LitanyOfMadnessAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
