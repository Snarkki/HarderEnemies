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

namespace HarderEnemies.UnitModifications.Bosses.RandomBosses {
    internal class RandomBossesAdjusts {


        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");
        private static BlueprintFeature AbyssalToughnessFeature = BlueprintTools.GetModBlueprint<BlueprintFeature>(HEContext, "AbyssalToughnessFeature");

        public static void Handler() {
            HandleHPBuff();
            RandomBossAbilities();
            RandomBossBuffs();
        }

        private static void HandleHPBuff() {
            //Adjust HP if enabled
            if (!HEContext.HPChanges.HPBoosts.IsDisabled("AdjustBossHp")) {
                foreach (BlueprintUnit thisUnit in UnitLists.MutafasenList) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(AbyssalToughnessFeature.ToReference<BlueprintUnitFactReference>());
                }
            }
        }

        private static void RandomBossAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("RandomBossChanges")) { return; }

            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.Mutasafen, UnitLists.Mutasafen.CR, AbilityLists.MutasafenAbilities);

            BrainList.Mutasafen_Brain.m_Actions = BrainList.Mutasafen_Brain.m_Actions.AppendToArray(
                GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.MythicShadow_Demon_LegendaryProportions_AiAction.ToReference<BlueprintAiActionReference>()
            );


            // This should be the priestress fight in midnight fane, party level should be 15~ 
            //MidnightFane_NocticulaPriestess

        }
        private static void RandomBossBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("RandomBossBuffs")) { return; }


            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.Maugla, 25, BuffLists.MauglaBuffs);


            foreach (BlueprintUnit thisUnit in UnitLists.MutafasenList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR + 8, BuffLists.MutasafenGangBuffs);
            }


            Utils.CustomHelpers.AddFactListsToUnit(UnitLists.XanthirPhase1, 27, BuffLists.XanthirBuffs);

        }
    }
}
