using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;

namespace HarderEnemies {
    public class Golems {

        public static BlueprintUnit CR11_GolemStone = BlueprintTools.GetBlueprint<BlueprintUnit>("dfd21dba15fe7dd4f95961ff27d91836");
        public static BlueprintUnit CR13_GolemIron = BlueprintTools.GetBlueprint<BlueprintUnit>("64589573eba29d541b5240c7485e1aec");
        public static BlueprintUnit CR14_GolemBrass = BlueprintTools.GetBlueprint<BlueprintUnit>("9c782d25f29ad9140ac4cd4ffbaf48dc");
        public static BlueprintUnit CR15_GolemAutumn = BlueprintTools.GetBlueprint<BlueprintUnit>("ce7a339ed253a2a449eb455096b207c1");
        public static BlueprintUnit CR15_GolemGold = BlueprintTools.GetBlueprint<BlueprintUnit>("9b65460d19d5f11458b6d15bd27dc85c");
        public static BlueprintUnit CR15_GolemSummer = BlueprintTools.GetBlueprint<BlueprintUnit>("4616c995e1c9c7649a952af0a63ca505");
        public static BlueprintUnit CR17_GolemAutumnAdvancedGiant = BlueprintTools.GetBlueprint<BlueprintUnit>("6d5f1a4815447bf41a633289dec2ebfc");
        public static BlueprintUnit CR17_GolemSummerAdvancedGiant = BlueprintTools.GetBlueprint<BlueprintUnit>("1724bbee4c8c0cf4fb403ec09a2e15b6");
        public static BlueprintUnit CR19_GolemAdamantine = BlueprintTools.GetBlueprint<BlueprintUnit>("0f31ef3f80dc69a4894542074ac38f19");
        public static BlueprintUnit CR20_AreshkagalGolemGold = BlueprintTools.GetBlueprint<BlueprintUnit>("ef45aef663289ed48b9aadf8448d6ff0");
        public static BlueprintUnit CR20_GolemGold = BlueprintTools.GetBlueprint<BlueprintUnit>("338ad824744a4d38880c9d6a4ce0c24b");
        public static BlueprintUnit CR20_GolemGold_DLC1 = BlueprintTools.GetBlueprint<BlueprintUnit>("f869ca1ce3b44f4c96400b3677c4e96a");
        public static BlueprintUnit CR22_AreshkagalGolemPlatinum = BlueprintTools.GetBlueprint<BlueprintUnit>("2664ec32e2b949d89f9ad20bb8643dbf");
        public static BlueprintUnit CR23_GolemAdamantine = BlueprintTools.GetBlueprint<BlueprintUnit>("afb75a3f377db55458f6298c0bc30704");
        public static BlueprintUnit CR23_GolemAdamantine_DLC1 = BlueprintTools.GetBlueprint<BlueprintUnit>("ebed5455b79e4977b8700fdb009315fa");
        public static BlueprintUnit CR24_Areshkagal_GolemMithralMiniBoss = BlueprintTools.GetBlueprint<BlueprintUnit>("42cdfa00fddc6f445a9ce4d20a621b42");
        public static BlueprintUnit CR6_GolemWood = BlueprintTools.GetBlueprint<BlueprintUnit>("b02f074f82b26df4ba67d5cb369afdd1");
        public static BlueprintUnit GolemAdamantineDestructable = BlueprintTools.GetBlueprint<BlueprintUnit>("3f11d3c1f5b9994498feb367ab71a0db");

        public static List<BlueprintUnit> GolemList = new List<BlueprintUnit>() {
            CR11_GolemStone,
            CR13_GolemIron,
            CR14_GolemBrass,
            CR15_GolemAutumn,
            CR15_GolemGold,
            CR15_GolemSummer,
            CR17_GolemAutumnAdvancedGiant,
            CR17_GolemSummerAdvancedGiant,
            CR19_GolemAdamantine,
            CR20_AreshkagalGolemGold,
            CR20_GolemGold,
            CR20_GolemGold_DLC1,
            CR22_AreshkagalGolemPlatinum,
            CR23_GolemAdamantine,
            CR23_GolemAdamantine_DLC1,
            CR24_Areshkagal_GolemMithralMiniBoss,
            CR6_GolemWood,
            GolemAdamantineDestructable,
        };
    }
}
