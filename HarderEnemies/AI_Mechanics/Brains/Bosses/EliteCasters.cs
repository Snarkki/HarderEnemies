using System;
using System.Collections.Generic;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;


namespace HarderEnemies.AI_Mechanics.Brains.Bosses {
    internal class EliteCasters {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell EdictOfInvulnerabilityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "EdictOfInvulnerabilityAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintAiCastSpell SummonErineyesAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "SummonErineyesAiSpell");
        private static BlueprintAiCastSpell CreateAcitPitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateAcitPitAiSpell");
        private static BlueprintAiCastSpell DisintregrateMaximized = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "DisintregrateMaximized");
        private static BlueprintAiCastSpell HellFireMaximized = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HellFireMaximized");

        public static void Handler() {
            CreateEliteCasterBrains();
            CreateSemiEliteCasterBrains();
        }

        private static void CreateEliteCasterBrains() {

            var EliteCasterAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "EliteCasterAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    Blueprints.AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.NocticulaPriestess_AiAction_OverwhelmingPrescence.ToReference<BlueprintAiActionReference>(),
                    SummonErineyesAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    HellFireMaximized.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.FullCasterBoss_AiAction_WailOfBanshee.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.Xorges_HorridWilting_AiAction.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_WavesOfExhastion.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_PhantasmalWeb.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_PhantasmalPutrefaction1.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_Soulreaver.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_ConeOfCold.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_Boneshatter.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_MagicMissile.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_Destruction.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_IcyPrison.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.AlderpashLich_PolarMidnight.ToReference<BlueprintAiActionReference>(),
               };
            });
        }

        private static void CreateSemiEliteCasterBrains() {
            var SemiEliteCasterAltBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "SemiEliteCasterAltBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   Blueprints.AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   Blueprints.AiCastSpellList.MageWithAHundredFaces_Sirocco_AiAction.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateAcitPitAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    DisintregrateMaximized.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.ControlledFireballAiAction.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.FlameStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                    Blueprints.AiCastSpellList.BurningArcAiAction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}
