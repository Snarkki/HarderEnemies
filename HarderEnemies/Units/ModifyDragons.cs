using HarderEnemies.Features;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarderEnemies.Blueprints;
using TabletopTweaks.Core.Utilities;

using static HarderEnemies.Main;


namespace HarderEnemies.Units {
    public class ModifyDragons {

        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");
        private static BlueprintBrain NewBlackDragonBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "NewBlackDragonBrain");


        
        public static void HandleChanges() {
            AdjustHP();
            DragonAbilities();
            DragonBuffs();
            LesserDragonAbilities();
            LesserDragonBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustDragonHp")) { return; }

            foreach (BlueprintUnit thisUnit in Dragons.DragonList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Dragons.LesserDragonsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            
            HEContext.Logger.LogHeader("Adjusted Dragon HP");
        }

        private static void DragonAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("DragonChanges")) { return; }
        }

        private static void DragonBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("DragonBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Dragons.DragonList) {           
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.DragonBuffsLists.GreaterDragonBuffs);
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.DragonBuffsLists.GreaterDragonAbilities);
            }
            Dragons.CR16_BlackDragonAncient.m_Brain = NewBlackDragonBrain.ToReference<BlueprintBrainReference>();
        }

        private static void LesserDragonAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("LesserDragonChanges")) { return; }
        }

        private static void LesserDragonBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("LesserDragonBuffs")) { return; }

            foreach (BlueprintUnit thisUnit in Dragons.LesserDragonsList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.DragonBuffsLists.LesserDragonBuffs);

            }
            HEContext.Logger.LogHeader("Updated Dragons");
        }


    }
}

