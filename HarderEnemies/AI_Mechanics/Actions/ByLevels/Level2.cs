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

namespace HarderEnemies.AI_Mechanics.Actions.ByLevels {
    internal class Level2 {

        public static void Handler() {

            var HideousLaughterAiSpell = AiCastSpellList.HideousLaughterAiAction.CreateCopy(HEContext, "HideousLaughterAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });



            var ScareAiSpell = AiCastSpellList.ScareAiAction.CreateCopy(HEContext, "ScareAiSpell", bp => {
                bp.BaseScore = 2.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
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

            var HoldPersonAiSpell = AiCastSpellList.CultistHoldPersonAiAction.CreateCopy(HEContext, "HoldPersonAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
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
            var BurningArcAiSpell = AiCastSpellList.BurningArcAiAction.CreateCopy(HEContext, "BurningArcAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });

            var ScorchingRayAiSpell = AiCastSpellList.ScorchingRayAiAction.CreateCopy(HEContext, "ScorchingRayAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var AcidArrowAiSpell = AiCastSpellList.ScorchingRayAiAction.CreateCopy(HEContext, "AcidArrowAiSpell", bp => {
                bp.BaseScore = 2.5f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.AcidArrow.ToReference<BlueprintAbilityReference>();
            });

            var SoundBurstAiSpell = AiCastSpellList.ThundercallerSoundBurstAiAction.CreateCopy(HEContext, "SoundBurstAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
                bp.m_Ability = Abilities.SoundBurst.ToReference<BlueprintAbilityReference>();
            });
            var BoneshakerAiSpell = AiCastSpellList.BoneshakerAiAction.CreateCopy(HEContext, "BoneshakerAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
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

            var SenseVitalsAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "SenseVitalsAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_Ability = Abilities.SenseVitals.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffSenseVitals.ToReference<ConsiderationReference>(),
                };
            });

            var SwiftScorchingRayAiSpell = AiCastSpellList.ScorchingRayAiAction.CreateCopy(HEContext, "SwiftScorchingRayAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.SwiftActionOffCooldown.ToReference<ConsiderationReference>(),
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });
        }
    }
}
