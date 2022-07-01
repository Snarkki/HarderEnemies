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

namespace HarderEnemies.UnitModifications.EliteCasters {
    internal class UnitLists {

        // boss of blackwater
        public static BlueprintUnit CR18_MageWithAHundredFaces_Boss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b77c75af5cbea5a4db030f3e0331c693");
        public static BlueprintUnit CR18_MageWithAHundredFaces_Boss1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e1214079b6bd4474a273047d68263351");

        // lich in baphomet prison
        public static BlueprintUnit AlderpashLich25 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("72bc5adfe506b6f4ba419963b036a553");


        public static List<BlueprintUnit> SemiEliteCasterList = new List<BlueprintUnit>() {
                CR18_MageWithAHundredFaces_Boss,
                CR18_MageWithAHundredFaces_Boss1,
        };

        public static List<BlueprintUnit> AllEliteCastersList = new List<BlueprintUnit>() {
                AlderpashLich25
        };
    }
}
