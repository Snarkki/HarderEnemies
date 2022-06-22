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
    internal class AdjustDemonLords {

        private static BlueprintAiCastSpell GreaterDispelAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterDispelAiSpellSwift");
        private static BlueprintAiCastSpell CreateRiftOfRuinAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateRiftOfRuinAiSpell");
        private static BlueprintAiCastSpell StormBoltAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "StormBoltAiSpell");
        private static BlueprintAiCastSpell CreateMythicSwarmsAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "CreateMythicSwarmsAiSpell");
        private static BlueprintAiCastSpell FirestormEmpoweredAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "FirestormEmpoweredAiSpell");
        private static BlueprintAiCastSpell EdictOfInvulnerabilityAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "EdictOfInvulnerabilityAiSpell");
        private static BlueprintAiCastSpell OpenGateAiSpell = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "OpenGateAiSpell");

        public static void HandleDemonLords() {
            DemonLordAbilities();
            DemonLordBuffs();
        }


        private static void DemonLordAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("DemonLordChanges")) { return; }


            foreach (BlueprintUnit thisUnit in Bosses.NocticulaList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 40, BuffLists.DemonLordBuffLists.NocticulaAbilityList);
            }


            foreach (BlueprintUnit thisUnit in Bosses.DeskariList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 40, BuffLists.DemonLordBuffLists.DeskariAbilityList);

            }



            //CR30_AreshkagalBoss, ehkä ei mitään...
            Utils.CustomHelpers.AddFactListsToUnit(Bosses.CR30_AreshkagalBoss, 40, BuffLists.DemonLordBuffLists.CR30_AreshkagalAbilities);



            //AREELU 
            Utils.CustomHelpers.AddFactListsToUnit(Bosses.AreeluDemonicForm, 40, BuffLists.DemonLordBuffLists.AreeluAbilityList);


            // BRAINS
            BrainList.Nocticula_Brain.m_Actions = BrainList.Nocticula_Brain.m_Actions.AppendToArray(
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                FirestormEmpoweredAiSpell.ToReference<BlueprintAiActionReference>(),
                StormBoltAiSpell.ToReference<BlueprintAiActionReference>()
                );
            BrainList.Deskari_Brain.m_Actions = BrainList.Deskari_Brain.m_Actions.AppendToArray(
                CreateMythicSwarmsAiSpell.ToReference<BlueprintAiActionReference>(),
                EdictOfInvulnerabilityAiSpell.ToReference<BlueprintAiActionReference>()
                );
            BrainList.Areelu_Brain.m_Actions = BrainList.Areelu_Brain.m_Actions.AppendToArray(
                OpenGateAiSpell.ToReference<BlueprintAiActionReference>(),
                GreaterDispelAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                StormBoltAiSpell.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.ColyphyrBaphomet_CommandGreater_AIAction.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.Baphomet_OverwhelmingPresence_AIAction.ToReference<BlueprintAiActionReference>()
                );
        }


        private static void DemonLordBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("DemonLordBuffs")) { return; }

            //NOCTICULA
            foreach (BlueprintUnit thisUnit in Bosses.NocticulaList) {
                // this takes care of MOST of the buffs, has ascendant elements, all low lvl buffs etc. The combatprebuff has haste, blur etc (visuals)
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>() 
                    );
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 40, BuffLists.DemonLordBuffLists.NocticulaBuffList);
            }

            //DESKARI
            foreach (BlueprintUnit thisUnit in Bosses.DeskariList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                        FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, 40, BuffLists.DemonLordBuffLists.DeskariBuffList);
            }

            //CR30_AreshkagalBoss
            Bosses.CR30_AreshkagalBoss.m_AddFacts = Bosses.CR30_AreshkagalBoss.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
            Utils.CustomHelpers.AddFactListsToUnit(Bosses.CR30_AreshkagalBoss, 40, BuffLists.DemonLordBuffLists.CR30_AreshkagalBossBuffs);


            //AREELU 
            Bosses.AreeluDemonicForm.m_AddFacts = Bosses.AreeluDemonicForm.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
            Utils.CustomHelpers.AddFactListsToUnit(Bosses.AreeluDemonicForm, 40, BuffLists.DemonLordBuffLists.AreeluBuffList);

        }
    }
}
