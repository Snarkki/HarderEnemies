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

namespace HarderEnemies.UnitModifications.Cultists.Casters {
    internal class BuffLists {

        public static BlueprintUnitFactReference[] CR4WizardBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            };
        public static BlueprintUnitFactReference[] CR6WizardBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            };

        public static BlueprintUnitFactReference[] CR8WizardBuffs = {
            Buffs.MageArmorBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.MageShieldBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.ProtectionFromArrowsBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.BlurBuff.ToReference<BlueprintUnitFactReference>(),
            Buffs.StoneskinBuff.ToReference<BlueprintUnitFactReference>(),
            };
    }
}
