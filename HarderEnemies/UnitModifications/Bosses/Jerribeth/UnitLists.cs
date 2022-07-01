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

namespace HarderEnemies.UnitModifications.Bosses.Jerribeth {
    internal class UnitLists {

        public static BlueprintUnit Jerribeth = BlueprintTools.GetBlueprint<BlueprintUnit>("417ce3dcf3a9707488f2b9b2a790814b");
        public static BlueprintUnit Jerribeth_Wintersun = BlueprintTools.GetBlueprint<BlueprintUnit>("fc8d7d07d716bee4499c9d17f6c43196");
        public static BlueprintUnit Jerribeth_Sanctum = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("bb9fe2c12d6941a43bfd5d5090ac97b9");

        public static List<BlueprintUnit> JerribethList = new List<BlueprintUnit>() {
            Jerribeth,
            Jerribeth_Wintersun,
            Jerribeth_Sanctum
        };
    }
}
