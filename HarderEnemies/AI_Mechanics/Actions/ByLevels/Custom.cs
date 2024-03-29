﻿using Kingmaker.AI.Blueprints;
using Kingmaker.AI.Blueprints.Considerations;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Actions.ByLevels {
    internal class Custom {

        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");
        public static void Handler() {

            var ThreatenedAiAttack = AiCastSpellList.AttackAiAction.CreateCopy(HEContext, "ThreatenedAiAttack", bp => {
                //SwiftActionCooldown.ToReference<ConsiderationReference>()
                bp.BaseScore = 5.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoSwarmDiminutiveConsideration.ToReference<ConsiderationReference>(),
                };
            });

            var PullingStrikeAiAction = AiCastSpellList.SunderArmorAiAction.CreateCopy(HEContext, "PullingStrikeAiAction", bp => {
                //SwiftActionCooldown.ToReference<ConsiderationReference>()
                bp.BaseScore = 15.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D2);
                bp.m_Ability = PullingStrikeAbility.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.TacticalConsideration_ClosestButNotInMelee.ToReference<ConsiderationReference>(),
                };
            });
            var EdictOfInvulnerabilityAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "EdictOfInvulnerabilityAiSpell", bp => {
                bp.BaseScore = 12.0f;
                bp.StartCooldownRounds = 5;
                bp.CombatCount = 3;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(2, DiceType.D6);
                bp.m_Ability = Abilities.EdictOfInvulnerability.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });
            var SummonErineyesAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "SummonErineyesAiSpell", bp => {
                var ErineysSummonAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "ErineysSummon");
                bp.BaseScore = 15.0f;
                bp.StartCooldownRounds = 5;
                bp.CombatCount = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = ErineysSummonAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var CreateMythicSwarmsAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "CreateMythicSwarmsAiSpell", bp => {
                var GreaterSwarmSummonAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "GreaterSwarmSummon");
                bp.BaseScore = 15.0f;
                bp.StartCooldownRounds = 5;
                bp.CombatCount = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = GreaterSwarmSummonAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var OpenGateAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "OpenGateAiSpell", bp => {
                var gateAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "GateSpell");
                bp.BaseScore = 15.0f;
                bp.StartCooldownRounds = 5;
                bp.CombatCount = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = gateAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var BrimorakBreathAiSpell = AiCastSpellList.BrimorakBreathWeaponAiAction.CreateCopy(HEContext, "BrimorakBreathAiSpell", bp => {
                bp.BaseScore = 3.5f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D2);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var MinotaurTrampleAiSpell = AiCastSpellList.LabyrinthMinotaur_AiAction_Trample.CreateCopy(HEContext, "MinotaurTrampleAiSpell", bp => {
                bp.BaseScore = 2.5f;
                bp.CombatCount = 0;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var MinotaurBullRushAiSpell = AiCastSpellList.Hepzamirah_BullRushAIAction.CreateCopy(HEContext, "MinotaurBullRushAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.CombatCount = 1;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });

            var GreaterVitalStrikeAiSpell = AiCastSpellList.Gallu_AiAction_VitalStrike.CreateCopy(HEContext, "GreaterVitalStrikeAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.m_Ability = Abilities.VitalStrikeAbilityGreater.ToReference<BlueprintAbilityReference>();
            });

            var DimensionDoorHellAiSpell = AiCastSpellList.Derakni_AiAction_BacklineTeleportation.CreateCopy(HEContext, "DimensionDoorHellAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D2);
            });

            // Custom droning wings for coloxus, basescore lowered
            var ColoxusDroningWingsAiSpell = AiCastSpellList.Derakni_AiAction_BacklineTeleportation.CreateCopy(HEContext, "ColoxusDroningWingsAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D2);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
            });


        }
    }
}
