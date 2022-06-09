using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;
using Kingmaker.Blueprints.Items.Weapons;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using HarderEnemies.Units.Adjustments;

namespace HarderEnemies.Units {

    public class ModifyBosses {

        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        public static void HandleChanges() {

            // ADDS SUPER TOUGHNESS TO ALL!
            AdjustBossHP();
            // Specific modifications
            AdjustBalors.HandleBalors();
            AdjustCorruptedAngels.HandleCorruptedAngels();
            AdjustDemonLords.HandleDemonLords();
            AdjustJerribeth.HandleJerribetth();
            AdjustMinagho.HandleMinagho();
            AdjustRandomBosses.HandleRandomBosses();
        }
        private static void AdjustBossHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) { return; }
            
            foreach (BlueprintUnit thisUnit in Bosses.MinaghoList ) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.DemonLordList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.NocticulaList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.DeskariList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.BalorList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.JerribethList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.MutafasenList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Bosses.CorruptHeraldsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Boss HP");
        }

    }
}
