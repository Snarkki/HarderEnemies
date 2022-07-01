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

namespace HarderEnemies.UnitModifications.Demons.Abrikandilu {
    internal class UnitLists {

        public static BlueprintUnit CR3_AbrikandiluStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("35758d873d826214a8c95c526a401c90");
        public static BlueprintUnit CR3_AbrikandiluStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("22c8ceda478c46518300c58779ea6f0f");
        public static BlueprintUnit CR4_AbrikandiluAdvanced1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9aafb70c018c8d342940d49384d5603e");
        public static BlueprintUnit CR4_AbrikandiluAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2da0043c56aff674bb6520d857c1ef9f");
        public static BlueprintUnit CR4_AbrikandiluAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cff78f289c7346f38848b74277adad72");
        public static BlueprintUnit KenabresMansion_Abrikandilu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6de3651e1f866ad42b0b13676ab5639b");


        public static List<BlueprintUnit> DemonAbrikandiluList = new List<BlueprintUnit>() {
            CR3_AbrikandiluStandard,
            CR3_AbrikandiluStandard_RE,
            CR4_AbrikandiluAdvanced1,
            CR4_AbrikandiluAdvanced,
            CR4_AbrikandiluAdvanced_RE,
            KenabresMansion_Abrikandilu,
        };
    }
}
