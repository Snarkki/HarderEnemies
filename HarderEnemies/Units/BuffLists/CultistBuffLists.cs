using System;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.FactLogic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;


namespace HarderEnemies.Units.BuffLists {
    internal class CultistBuffLists {

        public static BlueprintUnitFactReference[] CultistCasterAbilities = {
            Abilities.Grease.ToReference<BlueprintUnitFactReference>(),
            Abilities.StinkingCloud.ToReference<BlueprintUnitFactReference>(),
            Abilities.CreatePit.ToReference<BlueprintUnitFactReference>(),
            Abilities.AnimateDead.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] CultistCasterBuffs = {
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
        };

       /// <summary>
       /// Clerics
       /// </summary>



        public static BlueprintUnitFactReference[] CultistClericAbilities = {
            Abilities.HoldPerson.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] CultistClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ResistFireBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
        };


        public static BlueprintUnitFactReference[] CultistEliteClericAbilities = {
            Abilities.RighteousMagic.ToReference<BlueprintUnitFactReference>(),
            Abilities.HoldPersonMass.ToReference<BlueprintUnitFactReference>(),
            Abilities.Heal.ToReference<BlueprintUnitFactReference>(),
            Abilities.UnholyBlight.ToReference<BlueprintUnitFactReference>(),
            Abilities.FlameStrike.ToReference<BlueprintUnitFactReference>(),
            Abilities.Prayer.ToReference<BlueprintUnitFactReference>(),
            Abilities.CureModerateWoundsMass.ToReference<BlueprintUnitFactReference>(),
        };
        public static BlueprintUnitFactReference[] CultistEliteClericBuffs = {
            Buffs.ShielfOfFaithBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BarkskinBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.UnholyAuraBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.DivinePowerBuff.ToReference<BlueprintUnitFactReference>(),
        };

    }
}


