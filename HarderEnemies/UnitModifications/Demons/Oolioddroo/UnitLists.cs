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

namespace HarderEnemies.UnitModifications.Demons.Oolioddroo {
    internal class UnitLists {

        public static BlueprintUnit CR13_OolioddrooStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ffb2176dbd27838438a9e0879f145c79");
        public static BlueprintUnit CR13_OolioddrooStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("19c86e772a861f046a07a767d56f23c9");
        public static BlueprintUnit CR14_OolioddrooAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7e22e32226ef6cf469bf00a047a96c80");
        public static BlueprintUnit CR14_OolioddrooAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("56099a5811f9c2641b6bd4d276af4924");
        public static BlueprintUnit CR14_OolioddrooAdvanced_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("612f3f59100a42a28b8a96b3a9b22b49");
        public static BlueprintUnit CR17_OolioddrooToughCaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6d63a752d525ed9458e2b0415ef86462");
        public static BlueprintUnit CR19_OolioddrooInquisitor = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b9948fdfe5c3423384bf2b0d18401b06");
        public static BlueprintUnit CR20M_OolioddrooAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("918bc83bcf889d6409cff3d5990fb55a");
        public static BlueprintUnit CR20M_OolioddrooAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fb8c8aa55ee49af4ab4856c7e80785d4");
        public static BlueprintUnit CR20M_OolioddrooAdvanced_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("ebc727bf513a4459acfe9b8a8bc15942");
        public static BlueprintUnit Jerribeth = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("417ce3dcf3a9707488f2b9b2a790814b");
        public static BlueprintUnit Jerribeth_Wintersun = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fc8d7d07d716bee4499c9d17f6c43196");


        public static List<BlueprintUnit> OolioddrooList = new List<BlueprintUnit>() {
            CR13_OolioddrooStandard,
            CR13_OolioddrooStandard_RE,
            CR14_OolioddrooAdvanced,
            CR14_OolioddrooAdvanced_RE,
            CR14_OolioddrooAdvanced_RE_high,
            CR17_OolioddrooToughCaster,
            CR19_OolioddrooInquisitor,
            CR20M_OolioddrooAdvanced,
            CR20M_OolioddrooAdvanced_RE,
            CR20M_OolioddrooAdvanced_RE_high,
        };
    }
}
