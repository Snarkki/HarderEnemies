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
using Kingmaker.UnitLogic.Abilities.Blueprints;

namespace HarderEnemies.UnitModifications.EliteCasters {
    internal class EliteCasterAdjusts {

        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");


        private static BlueprintBrain EliteCasterAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "EliteCasterAltBrain");
        private static BlueprintBrain SemiEliteCasterAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "SemiEliteCasterAltBrain");

        public static void Handler() {
            AdjustHP();
            HandleEliteCasterAbilities();
            HandleEliteCasterBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustEliteCasterHp")) { return; }

            foreach (BlueprintUnit thisUnit in UnitLists.AllEliteCastersList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Elite Caster HP");
        }



        private static void HandleEliteCasterAbilities() {
            if (HEContext.AbilityChanges.OtherChanges.IsDisabled("EliteCasterChanges")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.SemiEliteCasterList) {
                Utils.CustomHelpers.AddFactsToUnit(thisUnit, AbilityLists.SemiEliteCasterAbilities);
                thisUnit.m_Brain = SemiEliteCasterAltBrain.ToReference<BlueprintBrainReference>();
            }


            Utils.CustomHelpers.AddFactsToUnit(UnitLists.AlderpashLich25, AbilityLists.EliteCasterAbilities);

            UnitLists.AlderpashLich25.m_Brain = EliteCasterAltBrain.ToReference<BlueprintBrainReference>();
            HEContext.Logger.LogHeader("Updated EliteCasters Abilities");
        }

        private static void HandleEliteCasterBuffs() {
            if (HEContext.Prebuffs.OtherBuffs.IsDisabled("EliteCasterBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in UnitLists.SemiEliteCasterList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit,  BuffLists.SemiEliteCasterBuffs);
            }

            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.AlderpashLich25, BuffLists.EliteCasterBuffs);


            HEContext.Logger.LogHeader("Updated EliteCasters Buffs");

        }

    }
}
