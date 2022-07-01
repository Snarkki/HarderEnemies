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

namespace HarderEnemies.UnitModifications.Bosses.Balors {
    internal class UnitLists {


        public static BlueprintUnit BalorLeader = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1ffa2585c4adde64ea653ba9ba29951a");
        public static BlueprintUnit Berengar_Balor = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("80318a4117554ddeac0a8c1bceacec45");
        public static BlueprintUnit CR20_BalorStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("eb0b4e6a01f6b30449f40cd03feb3c77");
        public static BlueprintUnit CR20_BalorStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a103fa2f05419664a93fe017467e2684");
        public static BlueprintUnit CR21_BalorAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d20e0c1c96cf5134496dc7d77ee24dac");
        public static BlueprintUnit CR21_BalorAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cf71b2fe0c9957f4ca080face95b38d4");
        public static BlueprintUnit CR26_BalorMythicBloodrager = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("138deed3343f207488cb85edc9e0c145");
        public static BlueprintUnit CR26_BalorMythicBloodrager_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("85eba255013867c41a3990c8ef691ab4");
        public static BlueprintUnit CR28M_BalorMythicFighter = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("9cbdad39cf0e7614da9453c7bed90210");
        public static BlueprintUnit CR28M_BalorMythicFighter_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4756ac51127e42f4796e30265b219f06");
        public static BlueprintUnit CR30_BalorMythicBloodrager_DLC1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c33d66055f934b66b60e3a4d61757baa");
        public static BlueprintUnit Khorramzadeh = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c114bf22097668b459767f0b20c995cc");
        public static BlueprintUnit Khorramzadeh_Aeon = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b1cb82e0dde84112a9792fe25e64087d");
        public static BlueprintUnit Khorramzadeh_Undead = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1aa49ee02b8643f1a9479a3dde54cdee");
        public static BlueprintUnit Darrazand = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("819a27486581bb64cbcc4b8437ecd228");
        public static BlueprintUnit Alushynirra_BalorNocticulaGuard = BlueprintTools.GetBlueprint<BlueprintUnit>("1ab1ac8ceb6648f9b72090b0c36e9000");

        public static List<BlueprintUnit> BalorList = new List<BlueprintUnit>() {
            Alushynirra_BalorNocticulaGuard,
            BalorLeader,
            Berengar_Balor,
            CR20_BalorStandard,
            CR20_BalorStandard_RE,
            CR21_BalorAdvanced,
            CR21_BalorAdvanced_RE,
            CR26_BalorMythicBloodrager,
            CR26_BalorMythicBloodrager_RE,
            CR28M_BalorMythicFighter,
            CR28M_BalorMythicFighter_RE,
            Darrazand,
            Khorramzadeh,
            Khorramzadeh_Aeon,
            Khorramzadeh_Undead,
        };
    }
}
