using HarderEnemies.Features;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using HarderEnemies.Units.BuffLists;

namespace HarderEnemies.Units {
    public class ModifyEliteCasters {

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperiorMaximizedMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorMaximizedMetaMagicFeature");
        private static BlueprintFeature SuperiorBolsteredMetaMagicFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorBolsteredMetaMagicFeature");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");


        private static BlueprintBrain EliteCasterAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "EliteCasterAltBrain");
        private static BlueprintBrain SemiEliteCasterAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "SemiEliteCasterAltBrain");

        private static BlueprintAbility ErineysSummon = BlueprintTools.GetModBlueprint<BlueprintAbility>(HEContext, "ErineysSummon");

        public static void HandleChanges() {
            ModifyEliteCasters.AdjustHP();
            HandleEliteCasterAbilities();
            HandleEliteCasterBuffs();
        }

        private static void AdjustHP() {
            if (HEContext.HPChanges.HPBoosts.IsDisabled("AdjustEliteCasterHp")) { return; }

            foreach (BlueprintUnit thisUnit in Lists.EliteCasters.AllEliteCastersList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            HEContext.Logger.LogHeader("Adjusted Elite Caster HP");
        }



        private static void HandleEliteCasterAbilities() {

            foreach (BlueprintUnit thisUnit in Lists.EliteCasters.SemiEliteCasterList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = EliteCasterList.SemiEliteCasterAbilities;
                });
            }

            Lists.EliteCasters.AlderpashLich25.AddComponent<AddFacts>(c => {
                c.CasterLevel = 25;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = EliteCasterList.EliteCasterAbilities;
            });
            HEContext.Logger.LogHeader("Updated EliteCasters Abilities");
        }

        private static void HandleEliteCasterBuffs() {

            foreach (BlueprintUnit thisUnit in Lists.EliteCasters.SemiEliteCasterList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = EliteCasterList.SemiEliteCasterBuffs;
                });
            }


            Lists.EliteCasters.AlderpashLich25.AddComponent<AddFacts>(c => {
                c.CasterLevel = 25;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                c.m_Facts = EliteCasterList.EliteCasterBuffs;
            });

            HEContext.Logger.LogHeader("Updated EliteCasters Buffs");

        }

    }
}

