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


namespace HarderEnemies.AI_Mechanics.Brains.Demons {
    internal class GlabrezuBrains {
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell TargetedDispelAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "TargetedDispelAiSpell");
        private static BlueprintAiCastSpell GreaterDispelAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpell");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell PowerWordStunAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PowerWordStunAiSpell");
        private static BlueprintAiCastSpell ConfusionAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "ConfusionAiSpell");
        private static BlueprintAiCastSpell PrismaticSprayAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PrismaticSprayAiSpell");




        public static void Handler() {
            CreateStandardGlabrezuBrain();
            CreateAdvancedGlabrezuBrain();
            CreateMythicGlabrezuBrain();
        }

        public static void CreateStandardGlabrezuBrain() {
            var StandardGlabrezuBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "StandardGlabrezuBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Glabrezu_RemoveSelfPolymorfOnTouch_AiAction.ToReference<BlueprintAiActionReference>(), // i think this is requried thta cultist transform?
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    TargetedDispelAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        // advanced glabrezu > mirror image, confusion,  greater dispel magic, powerwordstun & hit
        public static void CreateAdvancedGlabrezuBrain() {
            var AdvancedGlabrezuBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AdvancedGlabrezuBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Glabrezu_RemoveSelfPolymorfOnTouch_AiAction.ToReference<BlueprintAiActionReference>(), // i think this is requried thta cultist transform?
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpell.ToReference<BlueprintAiActionReference>(),
                    PowerWordStunAiSpell.ToReference<BlueprintAiActionReference>(),
                    ConfusionAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
        public static void CreateMythicGlabrezuBrain() {
            var MythicGlabrezuBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "MythicGlabrezuBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Glabrezu_RemoveSelfPolymorfOnTouch_AiAction.ToReference<BlueprintAiActionReference>(), // i think this is requried thta cultist transform?
                    MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    PowerWordStunAiSpell.ToReference<BlueprintAiActionReference>(),
                    ConfusionAiSpell.ToReference<BlueprintAiActionReference>(),
                    PrismaticSprayAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
