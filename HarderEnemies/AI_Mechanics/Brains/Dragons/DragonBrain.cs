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

namespace HarderEnemies.AI_Mechanics.Brains.Dragons {
    internal class DragonBrain {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell CreateAcitPitAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateAcitPitAiSpell");
        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");

        public static void Handler() {
            CreateBlackDragonBrain();
        }

        private static void CreateBlackDragonBrain() {
            var NewBlackDragonBrain = Helpers.CreateBlueprint<BlueprintBrain>(HEContext, "NewBlackDragonBrain", bp => {
                bp.m_Actions = new BlueprintAiActionReference[]
               {
                    AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.AncientBlackDragon_AiAction_BreathWeapon.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.AncientBlackDragon_AiAction_FrightfulPresenseAiAction.ToReference<BlueprintAiActionReference>(),
                    GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                    CreateAcitPitAiSpell.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Horzalah_AiAction_HoldPersonMass.ToReference<BlueprintAiActionReference>(),
                    GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.AcidicSprayAiAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.BalorNocticulaGuard_AiAction_Sirocco.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.Xantir_SlowAIAction.ToReference<BlueprintAiActionReference>(),
                    AiCastSpellList.GlabrezuQuickenedMirrorImageAiAction.ToReference<BlueprintAiActionReference>(),
               };
            });
        }
    }
}


