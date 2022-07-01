using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Buffs.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;

namespace HarderEnemies.Blueprints {
    public class CharacterClass {

        public static BlueprintCharacterClass WitchClass = BlueprintTools.GetBlueprint<BlueprintCharacterClass>("1b9873f1e7bfe5449bc84d03e9c8e3cc");
        public static BlueprintCharacterClass OutsiderClass = BlueprintTools.GetBlueprint<BlueprintCharacterClass>("92ab5f2fe00631b44810deffcc1a97fd");
        public static BlueprintCharacterClass ClericClass = BlueprintTools.GetBlueprint<BlueprintCharacterClass>("67819271767a9dd4fbfd4ae700befea0");
        public static BlueprintCharacterClass WizardClass = BlueprintTools.GetBlueprint<BlueprintCharacterClass>("ba34257984f4c41408ce1dc2004e342e");
    }
}
