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

namespace HarderEnemies.UnitModifications.Demons.DemondandStringy {


    internal class UnitLists {

        public static BlueprintUnit AlushinyrraDemodandCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0fabe8cf1bf5e394f90fe45b2736bceb");
        public static BlueprintUnit AlushinyrraDemodandCommonerStringy = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5e55690a01a31d84cbb9da03e623dfa6");
        public static BlueprintUnit CR15_DemodandStringyStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e926c6709e6b9134e9ebe0be2faa0195");
        public static BlueprintUnit CR15_DemodandStringyStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("5d407eff374b066418660bf8e10d3637");
        public static BlueprintUnit CR16_DemodandStringyAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d83665de2b5ee8546be9416919543c1f");
        public static BlueprintUnit CR16_DemodandStringyAdvanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3ab5715f9010a09408fbd307c7731c4c");
        public static BlueprintUnit DemodandStringyForSE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("05ab760ee34af4c44a82514cec76b59b");


        public static List<BlueprintUnit> DemodandStringyList = new List<BlueprintUnit>() {
            CR15_DemodandStringyStandard,
            CR15_DemodandStringyStandard_RE,
            CR16_DemodandStringyAdvanced,
            CR16_DemodandStringyAdvanced_RE,
        };
    }
}
