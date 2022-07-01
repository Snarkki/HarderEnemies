using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Features;
using HarderEnemies.AI_Mechanics.Brains;
using HarderEnemies.AI_Mechanics.Actions;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.UnitModifications.VescavorAndDerakni {
    internal class VescavorAndDerakniAdjusts {


        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain DerakniNewStandardBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DerakniNewStandardBrain");
        public static void Handler() {
            AdjustHP();
            HandleVescavorAbilities();
            HandleVescavorBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustVescavorDerakniHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.VescavorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in UnitLists.DerakniList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Vescavor&Derakni HP");

        }


        public static void HandleVescavorAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("VescavorChanges")) { return; }
            //VESCAVORS
            foreach (BlueprintUnit thisUnit in UnitLists.VescavorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.RemoveFromArray(FeatureList.VescavorQueenGibberAbility.ToReference<BlueprintUnitFactReference>());
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.TripBite.ToReference<BlueprintUnitFactReference>());
            }

            // add sunder armor action to acid spit
            var acidSpit = Abilities.VescavorGuardSpitAcidAbility.GetComponent<AbilityEffectRunAction>();
            acidSpit.Actions.Actions = acidSpit.Actions.Actions.AppendToArray(Helpers.Create<ContextActionCombatManeuver>(c => {
                c.Type = Kingmaker.RuleSystem.Rules.CombatManeuver.SunderArmor;
            }));

            // DERAKNIS -> teleport -> strike -> trip / confuse
            foreach (BlueprintUnit thisUnit in UnitLists.DerakniList) {
                if (!thisUnit.AddFacts.Contains(Abilities.DimensionDoorHell.ToReference<BlueprintUnitFactReference>())) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(Abilities.DimensionDoorHell.ToReference<BlueprintUnitFactReference>());
                }
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.TripBite.ToReference<BlueprintUnitFactReference>());
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
                thisUnit.m_Brain = DerakniNewStandardBrain.ToReference<BlueprintBrainReference>();
            }
            HEContext.Logger.LogHeader("Updated Vescavor/Derakni Abilities");
        }

        public static void HandleVescavorBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("VescavorBuffs")) { return; }

            HEContext.Logger.LogHeader("Updated Vescavor/Derakni Buffs");
        }

    }
}