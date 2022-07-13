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


namespace HarderEnemies.AI_Mechanics.Brains.Bosses {

    internal class DemonLords {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell EdictOfInvulnerabilityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "EdictOfInvulnerabilityAiSpell");
        private static BlueprintAiCastSpell CreateMythicSwarmsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateMythicSwarmsAiSpell");
        private static BlueprintAiCastSpell OpenGateAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OpenGateAiSpell");
        private static BlueprintAiCastSpell WailOfBansheeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "WailOfBansheeAiSpell");
        private static BlueprintAiCastSpell OverwhelmingPresenceAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingPresenceAiSpell");
        private static BlueprintAiCastSpell CommandGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CommandGreaterAiSpell");
        private static BlueprintAiCastSpell WeirdAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "WeirdAiSpell");
        private static BlueprintAiCastSpell HealAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HealAiSpellSwift");


        public static void Handler() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("DemonLordChanges")) { return; }
            CreateNocticulaBrain();
            CreateDeskariBrain();
            CreateAreeluBrain();
        }

        private static void CreateNocticulaBrain() {

            AiCastSpellList.Nocticula_AiAction_Domination.BaseScore = 10.0f;
            AiCastSpellList.Nocticula_AiAction_QDomination.BaseScore = 10.0f;
            AiCastSpellList.Nocticula_AiAction_Confusion.BaseScore = 10.0f;
            AiCastSpellList.Nocticula_AiAction_HoldMonsterMass.BaseScore = 10.0f;
            AiCastSpellList.Nocticula_AiAction_MindFog.BaseScore = 10.0f;
            AiCastSpellList.Nocticula_AiAction_HoldMonster.BaseScore = 10.0f;

            var NocticulaBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "NocticulaBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.Nocticula_AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.NocticulaPriestess_AiAction_CombatInstantPrecast.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_Domination.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_QDomination.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_Confusion.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_HoldMonsterMass.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_MindFog.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Nocticula_AiAction_HoldMonster.ToReference<BlueprintAiActionReference>(),
                   HealAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                   GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                   StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                   CreateRiftOfRuinAiSpell.ToReference<BlueprintAiActionReference>(),
                   FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                   WailOfBansheeAiSpell.ToReference<BlueprintAiActionReference>(),
                   WailOfBansheeAiSpell.ToReference<BlueprintAiActionReference>(),
               };
            });

        }
        private static void CreateDeskariBrain() {
            var DeskariBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "DeskariBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Deskari_InstantInfestation.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Deskari_BreathWeapon.ToReference<BlueprintAiActionReference>(),
                   AiCastSpellList.Deskari_DispelMagic.ToReference<BlueprintAiActionReference>(),
                   EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                   CreateMythicSwarmsAiSpell.ToReference<BlueprintAiActionReference>(),

               };
            });
        }

        private static void CreateAreeluBrain() {
            var AreeluBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "AreeluBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                   AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>(),
                    OpenGateAiSpell.ToReference<BlueprintAiActionReference>(),
                    CommandGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    WeirdAiSpell.ToReference<BlueprintAiActionReference>(),
                    HealAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_VineTrap_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_Tsunami_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_Sunburst_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_Sunbeam_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_RiftOfRuin_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_ResonatingWord_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_PrismaticSpray_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_PolarRay_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_PolarMidnight_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_HellfireRay_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_FireStrom_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_Disintegrate_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_DemonTeleport_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_DeathHex_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_ClashingRocks_AiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.FisrtStage_Areelu_ChainLightining_AiAction.ToReference<BlueprintAiActionReference>(),
               };

            });
        }
    }
}
