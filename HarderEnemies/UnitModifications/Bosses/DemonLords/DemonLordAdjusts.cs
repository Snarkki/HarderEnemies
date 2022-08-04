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

namespace HarderEnemies.UnitModifications.Bosses.DemonLords {
    internal class DemonLordAdjusts {

        
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        private static BlueprintBrain DeskariBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DeskariBrain");
        private static BlueprintBrain NocticulaBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NocticulaBrain");
        private static BlueprintBrain AreeluBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "AreeluBrain");

        public static void Handler() {
            HandleHPBuff();
            DemonLordAbilities();
            DemonLordBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.DemonLordList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }


        private static void DemonLordAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("DemonLordChanges")) { return; }



            // NOCTICULA
            foreach (BlueprintUnit thisUnit in UnitLists.NocticulaList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.NocticulaAbilityList);
                thisUnit.m_Brain = NocticulaBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }


            // DESKARI
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.DemonLordDeskari, AbilityLists.DeskariAbilityList);
            UnitLists.DemonLordDeskari.m_Brain = DeskariBrain.ToReference<BlueprintBrainReference>();
            UnitLists.DemonLordDeskari.AlternativeBrains = new BlueprintBrainReference[0] { };





            //CR30_AreshkagalBoss, ehkä ei mitään...
            Utils.CustomHelpers.AddFactsToUnit(UnitLists.CR30_AreshkagalBoss, AbilityLists.CR30_AreshkagalAbilities);



            //AREELU 
            foreach (BlueprintUnit thisUnit in UnitLists.AreeluList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.AreeluAbilityList);
                thisUnit.m_Brain = AreeluBrain.ToReference<BlueprintBrainReference>();
                thisUnit.AlternativeBrains = new BlueprintBrainReference[0] { };
            }


        }


        private static void DemonLordBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("DemonLordBuffs")) { return; }

            //NOCTICULA
            foreach (BlueprintUnit thisUnit in UnitLists.NocticulaList) {
                // this takes care of MOST of the buffs, has ascendant elements, all low lvl buffs etc. The combatprebuff has haste, blur etc (visuals)
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, BuffLists.NocticulaBuffList);
            }

            //DESKARI
            UnitLists.CR30_AreshkagalBoss.m_AddFacts = UnitLists.CR30_AreshkagalBoss.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                        FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
                Utils.CustomHelpers.AddFactListsToUnit(UnitLists.CR30_AreshkagalBoss, BuffLists.DeskariBuffList);
            

            //CR30_AreshkagalBoss
            UnitLists.CR30_AreshkagalBoss.m_AddFacts = UnitLists.CR30_AreshkagalBoss.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.CR30_AreshkagalBoss, BuffLists.CR30_AreshkagalBossBuffs);


            //AREELU 
            UnitLists.AreeluDemonicForm.m_AddFacts = UnitLists.AreeluDemonicForm.m_AddFacts.AppendToArray(FeatureList.CR22_AxiomiteCaster_Feature_Prebuff.ToReference<BlueprintUnitFactReference>(),
                                    FeatureList.CR22_AxiomiteCaster_Feature_CombatPrebuff.ToReference<BlueprintUnitFactReference>()
                    );
            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.AreeluDemonicForm,  BuffLists.AreeluBuffList);

        }
    }
}
