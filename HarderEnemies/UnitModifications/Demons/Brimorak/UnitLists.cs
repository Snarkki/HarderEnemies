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

namespace HarderEnemies.UnitModifications.Demons.Brimorak {
    internal class UnitLists {

        public static BlueprintUnit BrimorakDrezen = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3f98c4a13cbee8840baf57c8d1e2017f");
        public static BlueprintUnit BrimorakWithScimitar = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("dc3a0a825cd4ee74f8ed20e39f3df7e9");
        public static BlueprintUnit CR5_BrimorakStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("61e89e329440c0e46a4125d4667720ee");
        public static BlueprintUnit CR5_BrimorakStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("855a8001a1e53e644a175629f24f373f");
        public static BlueprintUnit CR7_BrimorakAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("547bfb1f1db2cbe41bbc0a98b580947e");
        public static BlueprintUnit CR7_BrimorakAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("96662dac1c7945edbc2a9a04cfdad265");
        public static BlueprintUnit EmberQ2_BrimorakAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0f5699866ca71c84ab9146bcce32cb08");


        public static List<BlueprintUnit> DemonBrimorakList = new List<BlueprintUnit>() {
            BrimorakWithScimitar,
            CR5_BrimorakStandard,
            CR5_BrimorakStandard_RE,
            CR7_BrimorakAdvanced,
            CR7_BrimorakAdvanced_RE,
            EmberQ2_BrimorakAdvanced,
        };
    }
}
