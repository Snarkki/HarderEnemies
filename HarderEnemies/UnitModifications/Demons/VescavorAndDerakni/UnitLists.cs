﻿using Kingmaker.AI.Blueprints;
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

namespace HarderEnemies.UnitModifications.VescavorAndDerakni {
    internal class UnitLists {

        public static BlueprintUnit CR14_VescavorQueenBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("3d59b2d00f92a244ea887bd74f96dd85");
        public static BlueprintUnit CR19_VescavorGuard = BlueprintTools.GetBlueprint<BlueprintUnit>("0413e0164ae24d9d9d78348a186ce375");
        public static BlueprintUnit CR8_VescavorGuardStandard = BlueprintTools.GetBlueprint<BlueprintUnit>("17a0d2b9a532ff641bc122778fa80e05");
        //public static BlueprintUnit DaeranAlienSwarm = BlueprintTools.GetBlueprint<BlueprintUnit>("0264a9119a0737447a226cdd4ba1f79b");
        //public static BlueprintUnit LocustVescavorQueen = BlueprintTools.GetBlueprint<BlueprintUnit>("e3cbfef493c4a3f4fa2abb660ba6aad6");
        //public static BlueprintUnit RavenousVescavorSwarm = BlueprintTools.GetBlueprint<BlueprintUnit>("d1add298a78c9744c89c9b4f87df5316");

        public static BlueprintUnit AreeluLab_Derakni = BlueprintTools.GetBlueprint<BlueprintUnit>("9a07422abebed6e44be52b88abbdfa7a");
        public static BlueprintUnit CR10_DerakniStandard = BlueprintTools.GetBlueprint<BlueprintUnit>("1f8c87fde2d7be342b90a58d0180884b");
        public static BlueprintUnit CR10_DerakniStandard_RE_high = BlueprintTools.GetBlueprint<BlueprintUnit>("edd5319f92515d74ea02873b77230a30");
        public static BlueprintUnit CR12_DerakniAdvanced_RE_low = BlueprintTools.GetBlueprint<BlueprintUnit>("a4730df1e4da4fd389b8295de151051b");
        public static BlueprintUnit CR13_DerakniAdvanced = BlueprintTools.GetBlueprint<BlueprintUnit>("43233c4df8cbbde4c8168ad7d70dc639");
        public static BlueprintUnit CR13_DerakniAdvanced_RE_high = BlueprintTools.GetBlueprint<BlueprintUnit>("0bdd872da4d44bb390f2c31b7a41cb23");
        public static BlueprintUnit CR22_MythicDerakniFighter = BlueprintTools.GetBlueprint<BlueprintUnit>("bd78f369ef376ad478061cd73555efc2");
        public static BlueprintUnit CR9_DerakniStandard_RE_low = BlueprintTools.GetBlueprint<BlueprintUnit>("9299782d53344be78c58eaf371878d83");
        public static BlueprintUnit WintersunDerakniAdvanced = BlueprintTools.GetBlueprint<BlueprintUnit>("5ece6c29406ee1247864f8586a2e292b");

        public static List<BlueprintUnit> VescavorList = new List<BlueprintUnit>() {
            CR14_VescavorQueenBoss,
            CR19_VescavorGuard,
            CR8_VescavorGuardStandard
        };

        public static List<BlueprintUnit> DerakniList = new List<BlueprintUnit>() {
            AreeluLab_Derakni,
            CR10_DerakniStandard,
            CR10_DerakniStandard_RE_high,
            CR12_DerakniAdvanced_RE_low,
            CR13_DerakniAdvanced,
            CR13_DerakniAdvanced_RE_high,
            CR9_DerakniStandard_RE_low,
            WintersunDerakniAdvanced,
            CR22_MythicDerakniFighter
        };
    }
}
