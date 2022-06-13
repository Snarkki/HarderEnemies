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
    internal class AdjustRandomBosses {

        private static BlueprintAiCastSpell GreaterInvisibilityAiSpellSwift = BlueprintTools.GetModBlueprint<BlueprintAiCastSpell>(HEContext, "GreaterInvisibilityAiSpellSwift");


        public static void HandleRandomBosses() {
            RandomBossAbilities();
            RandomBossBuffs();
        }

        private static void RandomBossAbilities() {
            if (HEContext.AbilityChanges.BossChanges.IsDisabled("RandomBossChanges")) { return; }

            Utils.CustomHelpers.AddFactListsToUnit(Bosses.Mutasafen, Bosses.Mutasafen.CR, BuffLists.RandomBossBuffLists.MutasafenAbilities);

            BrainList.Mutasafen_Brain.m_Actions = BrainList.Mutasafen_Brain.m_Actions.AppendToArray(
                GreaterInvisibilityAiSpellSwift.ToReference<BlueprintAiActionReference>(),
                AiCastSpellList.MythicShadow_Demon_LegendaryProportions_AiAction.ToReference<BlueprintAiActionReference>()
            );


            // This should be the priestress fight in midnight fane, party level should be 15~ 
            //MidnightFane_NocticulaPriestess

        }
        private static void RandomBossBuffs() {
            if (HEContext.Prebuffs.BossBuffs.IsDisabled("RandomBossBuffs")) { return; }


            Utils.CustomHelpers.AddFactListsToUnit(Bosses.Maugla, Bosses.Maugla.CR, BuffLists.RandomBossBuffLists.MauglaBuffs);


            foreach (BlueprintUnit thisUnit in Bosses.MutafasenList) {
                Utils.CustomHelpers.AddFactListsToUnit(thisUnit, thisUnit.CR, BuffLists.RandomBossBuffLists.MutasafenGangBuffs);
            }


            Utils.CustomHelpers.AddFactListsToUnit(Bosses.XanthirPhase1, Bosses.XanthirPhase1.CR, BuffLists.RandomBossBuffLists.XanthirBuffs);

        }
    }
}
