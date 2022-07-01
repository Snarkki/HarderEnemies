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

namespace HarderEnemies.UnitModifications.Demons.Gibrileth {
    internal class UnitLists {

        public static BlueprintUnit AlushinyrraGibrilethCommoner = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("04ba556f6794ae9429d2fd130b980e12");
        public static BlueprintUnit CR10_GibrilethStandard_RE_low = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("42ea5a2411494370a7a07d0b93971936");
        public static BlueprintUnit CR11_GibrilethStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fc9479d70112ac14a8ebcd0fb9b208c1");
        public static BlueprintUnit CR11_GibrilethStandardArueshalae = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b7ed4ffba5709fc45b6422931027c47e");
        public static BlueprintUnit CR11_GibrilethStandard_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4697deaa625d0fc418305dd340d305c3");
        public static BlueprintUnit CR12_GibrilethAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b44609dbcf205ba4ca5057726a2176c6");
        public static BlueprintUnit CR13_GibrilethElite_RE_low = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("37ca7d0e3f84473fb7b829426b487102");
        public static BlueprintUnit CR14_GibrilethElite = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0d618058a02c6e843b094a3727d6edd7");
        public static BlueprintUnit CR14_GibrilethElite_RE_high = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("31f9dc85057057b409b0d80651db2f61");
        public static BlueprintUnit CR17M_MythicGibrilethElite = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("981b08bddac11ca41b3698d3f6059629");
        public static BlueprintUnit SarzaksisSlaverTrader_Gibrileth = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("95c84a60d369b2b43abc0fe13f076d8a");
        public static BlueprintUnit TTD_GibrilethPatron = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e8535371dab989f4f9e68afedf4d3a97");



        public static List<BlueprintUnit> DemonGibrilethList = new List<BlueprintUnit>() {
            CR10_GibrilethStandard_RE_low,
            CR11_GibrilethStandard,
            CR11_GibrilethStandardArueshalae,
            CR11_GibrilethStandard_RE_high,
            CR12_GibrilethAdvanced,
            CR13_GibrilethElite_RE_low,
            CR14_GibrilethElite,
            CR14_GibrilethElite_RE_high,
            CR17M_MythicGibrilethElite,
        };

    }
}
