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
    internal class Level3 {

        public static void Handler() {

            var PrayerAiSpell = AiCastSpellList.CultistPrayerAiAction.CreateCopy(HEContext, "PrayerAiSpell", bp => {
                bp.BaseScore = 3.0f;
            });

            var DeepSlumberAiSpell = AiCastSpellList.Svendack_AiAction_CommandGreater.CreateCopy(HEContext, "DeepSlumberAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_Ability = Abilities.DeepSlumber.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var SlowAiSpell = AiCastSpellList.SlowAiAction.CreateCopy(HEContext, "SlowAiSpell", bp => {
                bp.BaseScore = 3.5f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
            });

            var HasteAiSpell = AiCastSpellList.HasteAiAction.CreateCopy(HEContext, "HasteAiSpell", bp => {
                bp.BaseScore = 15.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffHaste.ToReference<ConsiderationReference>(),
                };

            });

            var StinkingCloudAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "StinkingCloudAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
            });

            var AnimateDeadAiSpell = AiCastSpellList.Xantir_SummonMonsterVIAIAction.CreateCopy(HEContext, "AnimateDeadAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 5;
                bp.CooldownDice = new DiceFormula(2, DiceType.D4);
                bp.m_Ability = Abilities.AnimateDead.ToReference<BlueprintAbilityReference>();
                bp.m_Variant = null;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var FireballAiSpell = AiCastSpellList.FireballAiAction.CreateCopy(HEContext, "FireballAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });
            var VampiricTouchAiSpell = AiCastSpellList.Cyborg_SuccubusSorcVampiricTouchAiAction.CreateCopy(HEContext, "VampiricTouchAiSpell", bp => {
                bp.BaseScore = 3.5f;
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var TargetedDispelAiSpell = AiCastSpellList.MinotaurCleric_DispelMagicAiAction.CreateCopy(HEContext, "TargetedDispelAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 1;
                bp.CooldownDice = new DiceFormula(1, DiceType.D2);
            });

            var ContagionBubonicAiSpell = AiCastSpellList.Coloxus_AiAction_ContagionBubonicPlague.CreateCopy(HEContext, "ContagionBubonicAiSpell", bp => {
                bp.BaseScore = 5.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 1;
                bp.CooldownDice = new DiceFormula(1, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AttackTargetsPriority.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
