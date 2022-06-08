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

        private static BlueprintFeature SuperiorQuickenMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorQuickenMetaMagicFeature");
        private static BlueprintFeature SuperiorEmpowerMetaFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperiorEmporedMetaMagicFeature");
        private static BlueprintFeature SuperToughness = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "SuperToughnessFeature");
        private static BlueprintBrain DragonAltBrain = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "DragonAltBrain");


        
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
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            foreach (BlueprintUnit thisUnit in Dragons.LesserDragonsList) {
                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(SuperToughness.ToReference<BlueprintUnitFactReference>());
            }
            
            HEContext.Logger.LogHeader("Adjusted Dragon HP");
        }

        private static void DragonAbilities() {

        }

        private static void DragonBuffs() {

            foreach (BlueprintUnit thisUnit in Dragons.DragonList) {
                thisUnit.AddComponent<AddFacts>(c => {
                    c.CasterLevel = thisUnit.CR;
                    c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Daring;
                    c.m_Facts = new BlueprintUnitFactReference[] {
                        Abilities.FrigtfulAspectBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.SeamantleBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.DeathWardBuff.ToReference<BlueprintUnitFactReference>(),
                        Abilities.FreedomOfMovementBuff.ToReference<BlueprintUnitFactReference>(),
                    };
                });

                thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(
                    SuperiorQuickenMetaFeature.ToReference<BlueprintUnitFactReference>(),
                    Abilities.DispelGreater.ToReference<BlueprintUnitFactReference>(),
                    Abilities.StinkingCloud.ToReference<BlueprintUnitFactReference>(),
                    Abilities.Stormbolts.ToReference<BlueprintUnitFactReference>(),
                    Abilities.Blasphemy.ToReference<BlueprintUnitFactReference>(),
                    Abilities.UnholyBlight.ToReference<BlueprintUnitFactReference>(),
                    SuperiorEmpowerMetaFeature.ToReference<BlueprintUnitFactReference>()
                );
                thisUnit.AlternativeBrains = thisUnit.AlternativeBrains.AppendToArray(DragonAltBrain.ToReference<BlueprintBrainReference>());
            }
        }

        private static void LesserDragonAbilities() {

        }

        private static void LesserDragonBuffs() {
            foreach (BlueprintUnit thisUnit in Dragons.LesserDragonsList) {


            }
            HEContext.Logger.LogHeader("Updated Dragons");
        }


    }
}

