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
    internal class Level4 {

        public static void Handler() {

            var FearAiSpell = AiCastSpellList.Minagho_WavesOfFatigueAiAction.CreateCopy(HEContext, "FearAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
                };
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Ability = Abilities.Fear.ToReference<BlueprintAbilityReference>();
            });

            var CreateAcitPitAiSpell = AiCastSpellList.StinkingCloudAiAction.CreateCopy(HEContext, "CreateAcitPitAiSpell", bp => {
                bp.BaseScore = 3.0f;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_Ability = Abilities.AcidPit.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                   AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_TargetConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.AoE_AvoidSelf.ToReference<ConsiderationReference>(),
                    AiConsiderationList.AoE_ChooseMoreEnemies.ToReference<ConsiderationReference>()
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
            var InvisibilityGreaterAiSpell = AiCastSpellList.CultistDivineFavorAiAction.CreateCopy(HEContext, "InvisibilityGreaterAiSpell", bp => {
                bp.BaseScore = 10.0f;
                bp.CooldownRounds = 1;
                bp.StartCooldownRounds = 0;
                bp.m_Ability = Abilities.InvisibilityGreater.ToReference<BlueprintAbilityReference>();
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.NoBuffInvisibilityGreater.ToReference<ConsiderationReference>(),
                };
            });

            var DivinePowerAiSpell = AiCastSpellList.DivinePowerAiAction.CreateCopy(HEContext, "DivinePowerAiSpell", bp => {
                bp.BaseScore = 6.0f;
                bp.CooldownRounds = 1;
            });

            var FireDragonsBreathAiSpell = AiCastSpellList.MongrelmanWitch_DragonsBreathAIAction.CreateCopy(HEContext, "FireDragonsBreathAiSpell", bp => {
                bp.BaseScore = 3.5f;
                bp.StartCooldownRounds = 0;
                bp.CooldownRounds = 3;
                bp.CooldownDice = new DiceFormula(2, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var GreenDragonsBreathAiSpell = AiCastSpellList.MongrelmanWitch_DragonsBreathAIAction.CreateCopy(HEContext, "GreenDragonsBreathAiSpell", bp => {
                bp.BaseScore = 3.5f;
                bp.StartCooldownRounds = 0;
                bp.CooldownRounds = 3;
                bp.CooldownDice = new DiceFormula(2, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
                bp.m_Variant = Abilities.DragonsBreathGreen.ToReference<BlueprintAbilityReference>();
            });

            var OverwhelmingGriefAiSpell = AiCastSpellList.Nurah_AiAction_OverwhelmingGrief.CreateCopy(HEContext, "OverwhelmingGriefAiSpell", bp => {
                bp.BaseScore = 4.5f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 1;
                bp.CooldownDice = new DiceFormula(2, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var BoneshatterAiSpell = AiCastSpellList.Cyborg_SuccubusSorc_Boneshatter_AiAction.CreateCopy(HEContext, "BoneshatterAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.StartCooldownRounds = 1;
                bp.CooldownRounds = 1;
                bp.CooldownDice = new DiceFormula(1, DiceType.D4);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>()
                };
            });

            var ConfusionAiSpell = AiCastSpellList.Glabrezu_AiAction_Confusion.CreateCopy(HEContext, "ConfusionAiSpell", bp => {
                bp.BaseScore = 4.0f;
                bp.StartCooldownRounds = 1;
                bp.CombatCount = 1;
                bp.CooldownRounds = 2;
                bp.CooldownDice = new DiceFormula(1, DiceType.D3);
                bp.m_ActorConsiderations = new ConsiderationReference[] {
                    AiConsiderationList.ChaoticBehaviour.ToReference<ConsiderationReference>(),
                    AiConsiderationList.NoThreateningUnitsConsideration.ToReference<ConsiderationReference>()
                };
            });
        }
    }
}
