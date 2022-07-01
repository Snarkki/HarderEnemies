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
    internal class Level7 {

        public static void Handler() {
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
        }
    }
}
