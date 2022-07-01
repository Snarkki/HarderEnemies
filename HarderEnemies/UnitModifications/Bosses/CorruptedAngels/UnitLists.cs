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

namespace HarderEnemies.UnitModifications.Bosses.CorruptedAngels {
    internal class UnitLists {

        public static BlueprintUnit CorruptedHerald_Phase1 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b796a45e2a56beb458c553e507f193ae");
        public static BlueprintUnit CorruptedHerald_Phase1_CR25 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("68f497a2006185c4ea8f6d11eba0ce63");
        public static BlueprintUnit CorruptedHerald_Phase2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("38a1ababf66a5ba4694d282c592952c4");
        public static BlueprintUnit CorruptedHerald_Phase2_CR25 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e17a94be7b3a1924c806e91e85b0d4e2");
        public static BlueprintUnit CR24_Memitim_SupportToHerald = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("6c88c7421c064ba4aa60db286026d4b0");

        public static List<BlueprintUnit> CorruptHeraldsList = new List<BlueprintUnit>() {
            CorruptedHerald_Phase1,
            CorruptedHerald_Phase1_CR25,
            CorruptedHerald_Phase2,
            CorruptedHerald_Phase2_CR25,
            CR24_Memitim_SupportToHerald
        };
    }
}

