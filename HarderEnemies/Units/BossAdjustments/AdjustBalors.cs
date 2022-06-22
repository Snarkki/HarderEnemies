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
using static HarderEnemies.Main;
using HarderEnemies.Blueprints;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.Mechanics.Actions;

namespace HarderEnemies.Units.Adjustments {
    internal class AdjustBalors {

        //Balor weapons
        private static BlueprintItemWeapon BalorNewSword = BlueprintTools.GetModBlueprint<BlueprintItemWeapon>(HEContext, "BalorNewSword");
        private static BlueprintAiCastSpell PullingStrikeAiAction = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "PullingStrikeAiAction");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell BlasphemyAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "BlasphemyAiSpell");
        private static BlueprintAiCastSpell NewFlameStrikeAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "NewFlameStrikeAiSpell");
        private static BlueprintAiCastSpell MirrorImageAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MirrorImageAiSpell");
        private static BlueprintAiCastSpell InvisibilityGreaterAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "InvisibilityGreaterAiSpell");
        private static BlueprintAiCastSpell MindBlankAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "MindBlankAiSpell");
        private static BlueprintAiCastSpell LegendaryProportionsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "LegendaryProportionsAiSpell");
        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell OverwhelmingPresenceAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OverwhelmingPresenceAiSpell");
        private static BlueprintAiCastSpell HoldPersonMassAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "HoldPersonMassAiSpell");
        private static BlueprintAiCastSpell GreaterShoutAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterShoutAiSpell");

        
        private static BlueprintAiAttack ThreatenedAiAttack = BlueprintTools.GetModBlueprint<BlueprintAiAttack>(HEContext, "ThreatenedAiAttack");
        

        public static void HandleBalors() {
            BalorAbilities();
            BalorBuffs();
        }

        private static void BalorAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("BalorChanges")) { return; }

            foreach (BlueprintUnit thisUnit in Bosses.BalorList) {
                if (thisUnit == Bosses.Darrazand) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 35, BuffLists.BossBuffLists.DarrazandAbilities);
                }
                else if (thisUnit == Bosses.BalorLeader ||
                    thisUnit == Bosses.CR20_BalorStandard ||
                    thisUnit == Bosses.CR20_BalorStandard_RE ||
                    thisUnit == Bosses.CR21_BalorAdvanced ||
                    thisUnit == Bosses.CR21_BalorAdvanced_RE ||
                    thisUnit == Bosses.CR26_BalorMythicBloodrager ||
                    thisUnit == Bosses.CR26_BalorMythicBloodrager_RE ||
                    thisUnit == Bosses.CR28M_BalorMythicFighter ||
                    thisUnit == Bosses.CR28M_BalorMythicFighter_RE 
                    ) {
                    Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 35, BuffLists.BossBuffLists.BalorAbilities);
                    thisUnit.Body.m_PrimaryHand = BalorNewSword.ToReference<BlueprintItemEquipmentHandReference>();
                }
                else if (thisUnit == Bosses.Alushynirra_BalorNocticulaGuard) {
                    thisUnit.Body.m_PrimaryHand = BalorNewSword.ToReference<BlueprintItemEquipmentHandReference>();
                }

                // BRAIN APPEND
                BrainList.DarrazandBrain.m_Actions = new BlueprintAiActionReference[] {
                        AiCastSpellList.AttackAiAction.ToReference<BlueprintAiActionReference>(),
                        ThreatenedAiAttack.ToReference<BlueprintAiActionReference>(),
                        PullingStrikeAiAction.ToReference<BlueprintAiActionReference>(),
                        BlasphemyAiSpell.ToReference<BlueprintAiActionReference>(),
                        NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                        FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                        StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                        MirrorImageAiSpell.ToReference<BlueprintAiActionReference>(),
                        InvisibilityGreaterAiSpell.ToReference<BlueprintAiActionReference>(),
                        MindBlankAiSpell.ToReference<BlueprintAiActionReference>(),
                        LegendaryProportionsAiSpell.ToReference<BlueprintAiActionReference>(),
                        GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                    };
                BrainList.BalorBrain.m_Actions = BrainList.BalorBrain.m_Actions.AppendToArray(
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterShoutAiSpell.ToReference<BlueprintAiActionReference>()
                    );
                BrainList.BalorMythic6_BloodragerBrain.m_Actions = BrainList.BalorMythic6_BloodragerBrain.m_Actions.AppendToArray(
                    OverwhelmingPresenceAiSpell.ToReference<BlueprintAiActionReference>(),
                    NewFlameStrikeAiSpell.ToReference<BlueprintAiActionReference>(),
                    FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                    HoldPersonMassAiSpell.ToReference<BlueprintAiActionReference>(),
                    GreaterShoutAiSpell.ToReference<BlueprintAiActionReference>()
                    );
            }
            HEContext.Logger.LogHeader("Updated Balors");
        }

        private static void BalorBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("BalorBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Bosses.BalorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>());
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 35, BuffLists.BossBuffLists.BalorBuffsList);
            }
       }




    }
}
