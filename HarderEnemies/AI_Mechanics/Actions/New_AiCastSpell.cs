using Kingmaker.AI.Blueprints;
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

namespace HarderEnemies.AI_Mechanics.Actions {
    public class New_AiCastSpell {

        private static BlueprintAbility PullingStrikeAbility = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "PullingStrikeAbility");
        private static BuffConsideration NoMindBlankConsideration = BlueprintTools.GetModBlueprint<BuffConsideration>(HEContext, "NoMindBlankConsideration");


        public static void CreateNew() {
            CreatePullingAttack();
            CreateSwiftSpells();
            CreateDamageSpells();
            CreateSummonSpells();
            CreateAreaControlSpells();
            CreateBuffSpells();
            CreateSingleTargetSpells();
            CreateRangedAttack();
            ThreatenedAiAttack();
        }

        private static void CreateRangedAttack() {


        }

        private static void ThreatenedAiAttack() {
            var ThreatenedAiAttack = AiCastSpellList.AttackAiAction.CreateCopy(HEContext, "ThreatenedAiAttack", bp => {
                //SwiftActionCooldown.ToReference<ConsiderationReference>()
                bp.BaseScore = 25.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoSwarmDiminutiveConsideration.ToReference<ConsiderationReference>(),
                };
            });

        }


        public static void CreatePullingAttack() {

            var PullingStrikeAiAction = AiCastSpellList.SunderArmorAiAction.CreateCopy(HEContext, "PullingStrikeAiAction", bp => {
                //SwiftActionCooldown.ToReference<ConsiderationReference>()
                bp.BaseScore = 15.0f;
                bp.CooldownRounds = 2;
                bp.StartCooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_Ability = PullingStrikeAbility.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.TacticalConsideration_ClosestButNotInMelee.ToReference<ConsiderationReference>(),
                };
            });
        }

        public static void CreateSwiftSpells() {

            var GreaterDispelAiSpellSwift = AiCastSpellList.CR27ColoxusDLC1_AiAction_GreaterDispel.CreateCopy(HEContext, "GreaterDispelAiSpellSwift", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 3;
                bp.StartCooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(1, DiceType.D2);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.SwiftActionOffCooldown.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var GreaterInvisibilityAiSpellSwift = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "GreaterInvisibilityAiSpellSwift", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_Ability = Abilities.InvisibilityGreater.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.SwiftActionOffCooldown.ToReference<ConsiderationReference>(),
                   AiConsiderationList.NoBuffInvisibilityGreater.ToReference<ConsiderationReference>()
                };
            });

            //BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("b9be852b03568064b8d2275a6cf9e2de"),    // GreaterDispelArea,
            //BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f0f761b808dc4b149b08eaf44b99f633"),    // DispelMagicGreater,
        }
        private static void CreateSingleTargetSpells() {
            var PowerWordBlindAiSpell = AiCastSpellList.Glabrezu_AiAction_PowerWordStun.CreateCopy(HEContext, "PowerWordBlindAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                    };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                        AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                    };
                bp.m_Ability = Abilities.PowerWordBlind.ToReference<BlueprintAbilityReference>();
            });
        }
        public static void CreateBuffSpells() {

            var EdictOfInvulnerabilityAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "EdictOfInvulnerabilityAiSpell", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 8;
                bp.StartCooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.EdictOfInvulnerability.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });


            var LegendaryProportionsAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "LegendaryProportionsAiSpell", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 5;
                bp.StartCooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.LegendaryProportions.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffLegendaryProportions.ToReference<ConsiderationReference>(),
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var MindBlankAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "MindBlankAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 5;
                bp.StartCooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.MindBlank.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    NoMindBlankConsideration.ToReference<ConsiderationReference>(),
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var InvisibilityGreaterAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "InvisibilityGreaterAiSpell", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_Ability = Abilities.InvisibilityGreater.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffInvisibilityGreater.ToReference<ConsiderationReference>(),
                };
            });

            var MirrorImageAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "MirrorImageAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_Ability = Abilities.MirrorImage.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffMirrorImage.ToReference<ConsiderationReference>(),
                };
            });

            var DivinePowerAiSpell = AiCastSpellList.DivinePowerAiAction.CreateCopy(HEContext, "DivinePowerAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.CooldownRounds = 1;
            });

            //BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("b9be852b03568064b8d2275a6cf9e2de"),    // GreaterDispelArea,
            //BlueprintTools.GetBlueprintReference<BlueprintAbilityReference>("f0f761b808dc4b149b08eaf44b99f633"),    // DispelMagicGreater,
        }

        public static void CreateDamageSpells() {


            var BoneshakerAiSpell = AiCastSpellList.BoneshakerAiAction.CreateCopy(HEContext, "BoneshakerAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var SoundBurstAiSpell = AiCastSpellList.ThundercallerSoundBurstAiAction.CreateCopy(HEContext, "SoundBurstAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
                bp.m_Ability = Abilities.SoundBurst.ToReference<BlueprintAbilityReference>();
            });

            var BlasphemyAiSpell = AiCastSpellList.Vavakia_AiAction_Blasphemy.CreateCopy(HEContext, "BlasphemyAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.CombatCount = 1;
                bp.CooldownRounds = 6;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
            });

            var UnholyBlightAiSpell = AiCastSpellList.Baphomet_UnholyBlightAIAction.CreateCopy(HEContext, "UnholyBlightAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 6;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var NewFlameStrikeAiSpell = AiCastSpellList.FlameStrikeAiAction.CreateCopy(HEContext, "NewFlameStrikeAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
            });

            var StormBoltAiSpell = AiCastSpellList.Mielara_AiAction_Stormbolts.CreateCopy(HEContext, "StormBoltAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 8;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.IsThreatedConsideration.ToReference<ConsiderationReference>()
                };
            });

            var FirestormEmpoweredAiSpell = AiCastSpellList.Mielara_AiAction_Stormbolts.CreateCopy(HEContext, "FirestormEmpoweredAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CombatCount = 3;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Firestorm.ToReference<BlueprintAbilityReference>();
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var DisintregrateMaximized = AiCastSpellList.DLC2_Wizard_Empowered_MagicMissle_AiAction.CreateCopy(HEContext, "DisintregrateMaximized", bp => {
                bp.BaseScore = 6.0f;
                bp.CombatCount = 2;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Disintegrate.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });


            var HellFireMaximized = AiCastSpellList.DLC2_Wizard_Empowered_MagicMissle_AiAction.CreateCopy(HEContext, "HellFireMaximized", bp => {
                bp.BaseScore = 6.0f;
                bp.CombatCount = 2;
                bp.CooldownRounds = 8;
                bp.CheckCasterDistance = true;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_Ability = Abilities.HellfireRay.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var ColdIceStrikeAiSpell = AiCastSpellList.CultistEvokerFireSnakeAiAction.CreateCopy(HEContext, "ColdIceStrikeAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.m_Ability = Abilities.ColdIceStrike.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            MagicMissileAiSpell
            BurningArcAiSpell
            ScorchingRayAiSpell
            FireballAiSpell
            var ColdIceStrikeAiSpell = AiCastSpellList.CultistEvokerFireSnakeAiAction.CreateCopy(HEContext, "ColdIceStrikeAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.m_Ability = Abilities.ColdIceStrike.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
        }


        public static void CreateSummonSpells() {
            var SummonMonsterViiAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "SummonMonsterViiAiSpell", bp => {
                bp.BaseScore = 7.0f;
                bp.CombatCount = 0;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D6);
                bp.m_Ability = Abilities.SummonMonsterVII.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = Abilities.SummonMonsterVIId3.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var OpenGateAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "OpenGateAiSpell", bp => {
                var gateAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "GateSpell");
                bp.BaseScore = 10.0f;
                bp.CombatCount = 0;
                bp.CooldownRounds = 20;
                bp.CooldownDice = new DiceFormula(3, DiceType.D8);
                bp.m_Ability = gateAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var CreateMythicSwarmsAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "CreateMythicSwarmsAiSpell", bp => {
                var GreaterSwarmSummonAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "GreaterSwarmSummon");
                bp.BaseScore = 10.0f;
                bp.CombatCount = 0;
                bp.CooldownRounds = 20;
                bp.CooldownDice = new DiceFormula(3, DiceType.D8);
                bp.m_Ability = GreaterSwarmSummonAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var AnimateDeadAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "AnimateDeadAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(2, DiceType.D4);
                bp.m_Ability = Abilities.AnimateDead.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var SummonErineyesAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "SummonErineyesAiSpell", bp => {
                var ErineysSummonAbility = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "ErineysSummon");
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 20;
                bp.CooldownDice = new DiceFormula(2, DiceType.D8);
                bp.m_Ability = ErineysSummonAbility.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
        }


        public static void CreateAreaControlSpells() {
            var GreaseAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "GreaseAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.CooldownRounds = 4;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.Grease.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var CreatePitAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "CreatePitAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.CooldownRounds = 4;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.CreatePit.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var CreateRiftOfRuinAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "CreateRiftOfRuinAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.CooldownRounds = 6;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.RiftOfRuin.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var CreateAcitPitAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "CreateAcitPitAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_Ability = Abilities.AcidPit.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var FearAiSpell = AiCastSpellList.Minagho_WavesOfFatigueAiAction.CreateCopy(HEContext, "FearAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.Fear.ToReference<BlueprintAbilityReference>();
            });

            var OverwhelmingPresenceAiSpell = AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.CreateCopy(HEContext, "OverwhelmingPresenceAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var HoldPersonMassAiSpell = AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.CreateCopy(HEContext, "HoldPersonMassAiSpell", bp => {
                bp.BaseScore = 8.0f;
                bp.CooldownRounds = 6;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.HoldPersonMass.ToReference<BlueprintAbilityReference>();
            });


            var GreaterShoutAiSpell = AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.CreateCopy(HEContext, "GreaterShoutAiSpell", bp => {
                bp.BaseScore = 7.0f;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(3, DiceType.D4);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.ShoutGreater.ToReference<BlueprintAbilityReference>();
            });

            var HoldPersonAiSpell = AiCastSpellList.CultistHoldPersonAiAction.CreateCopy(HEContext, "HoldPersonAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var CauseFearAiSpell = AiCastSpellList.CauseFearAiAction.CreateCopy(HEContext, "CauseFearAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var CommandAiSpell = AiCastSpellList.CultistHoldPersonAiAction.CreateCopy(HEContext, "CommandAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.Command.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = Abilities.CommandFall.ToReference<BlueprintAbilityReference>();
            });

            var CommandGreaterAiSpell = AiCastSpellList.Svendack_AiAction_CommandGreater.CreateCopy(HEContext, "CommandGreaterAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var BlindnessAiSpell = AiCastSpellList.CultistHoldPersonAiAction.CreateCopy(HEContext, "BlindnessAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.Blindess.ToReference<BlueprintAbilityReference>();
            });

            var PrayerAiSpell = AiCastSpellList.CultistPrayerAiAction.CreateCopy(HEContext, "PrayerAiSpell", bp => {
                bp.BaseScore = 3.0f;
            });

        }
    }
}
//var GreaterDispelAiSpell = Helpers.CreateBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpell", bp => {
//    bp.m_Variant = null;
//    bp.BaseScore = 50.0f;
//    bp.CombatCount = 1;
//    bp.m_Ability = Phantasmal.ToReference<BlueprintAbilityReference>(); // "f0f761b808dc4b149b08eaf44b99f633" dispel
//    bp.CooldownRounds = 0;
//    bp.StartCooldownRounds = 0;
//    bp.m_TargetConsiderations = new ConsiderationReference[]
//    {
//        AttackTargetsPriority.ToReference<ConsiderationReference>()
//    };
//    bp.Components = Array.Empty<BlueprintComponent>();
//    bp.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Casual;
//    bp.m_ForceTargetEnemy = true;
//    bp.m_VariantsSet = Array.Empty<BlueprintAbilityReference>();
//    bp.Locators = Array.Empty<EntityReference>();
//    bp.m_ActorConsiderations = new ConsiderationReference[0];
//    bp.CheckCasterDistance = false;
//});