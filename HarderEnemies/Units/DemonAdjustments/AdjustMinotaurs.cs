﻿using Kingmaker.AI.Blueprints;
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


namespace HarderEnemies.Units.DemonAdjustments {
    internal class AdjustMinotaur {

        private static BlueprintBrain MinotaurStandardBrainNew = BlueprintTools.GetModBlueprint<BlueprintBrain>(HEContext, "MinotaurStandardBrainNew");


        public static void MinaotaurHandler() {
            BabauAbilities();
            BabauBuffs();
        }

        private static void BabauAbilities() {
            if (HEContext.AbilityChanges.DemonChanges.IsDisabled("MinotaurAbilities")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonMeleeMinotaurList) {
                if (!thisUnit.m_AddFacts.Contains(FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>())) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.ImprovedBullRush.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_Brain = MinotaurStandardBrainNew.ToReference<BlueprintBrainReference>();
                };
                if (thisUnit.CR > 12 && !thisUnit.m_AddFacts.Contains(FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>()) ) {
                    thisUnit.m_AddFacts = thisUnit.m_AddFacts.AppendToArray(FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>());
                    thisUnit.m_Brain = MinotaurStandardBrainNew.ToReference<BlueprintBrainReference>();
                };
                if (thisUnit.m_AddFacts.Contains(FeatureList.GreaterBullRush.ToReference<BlueprintUnitFactReference>())) {
                    thisUnit.AlternativeBrains = thisUnit.AlternativeBrains.AppendToArray(BrainList.HalfFiendMinotaur_Standard_Brain.ToReference<BlueprintBrainReference>());
                }

            }




            Demons.MinotaurGhost_Boss.AddComponent<AddStatBonus>(c => {
                c.Value = -4;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });
            Demons.MinotaurGhost_Boss.AddComponent<AddStatBonus>(c => {
                c.Value = -4;
                c.Descriptor = Kingmaker.Enums.ModifierDescriptor.UntypedStackable;
                c.Stat = Kingmaker.EntitySystem.Stats.StatType.AC;
            });

            
            HEContext.Logger.LogHeader("Updated Babau Abilities");

        }

        private static void BabauBuffs() {
            if (HEContext.Prebuffs.DemonBuffs.IsDisabled("MinotaurBuffs")) { return; }
            foreach (BlueprintUnit thisUnit in Demons.DemonMeleeMinotaurList) {

            }
            HEContext.Logger.LogHeader("Updated BabauBuffs");
        }

    }
}
