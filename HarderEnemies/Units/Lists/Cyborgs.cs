using Kingmaker.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;

namespace HarderEnemies.Units.Lists {
    internal class Cyborgs {

        // blackwater units

        public static BlueprintUnit CR13_CyborgGreaterKalavakusAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("e0eccf6669683124a80ddbc34d0c81f8");
        public static BlueprintUnit CR14_Cyborg_CrusaderRangedLevel12 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("70be6d04398af684ba4c355b8d1946ef");
        public static BlueprintUnit CR14_Cyborg_CrusaderTankLevel12 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("91ffaba796637df4594f4bb4167c0b65");
        public static BlueprintUnit CR15_CyborgSalamander_Add = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("65c08a0ea25b4d07a8961cb2d2c0e725");
        public static BlueprintUnit CR15_Cyborg_CrusaderCasterLevel13 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0f83ec1cf88439541ad14ed7c622ebde");
        public static BlueprintUnit CR15_Cyborg_CrusaderMeleeLevel13 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("af2e905fc0ed04a419923df1578c57fc");
        public static BlueprintUnit CR15_Cyborg_CrusaderRogueLevel13 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4ac079b8b4644a344809a3f49a319418");
        public static BlueprintUnit CR15_Cyborg_Incubus_Assasin = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("32b5ac85cad5f7b4596546f0e256c9cf");
        public static BlueprintUnit CR16_Cyborg_SuccubusSorc = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0272f1c847ca4e34a86e67ecdc5c3a92");
        public static BlueprintUnit CR17_CyborgSalamander_Boss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1d41c13cb3ac51648b689d3a86d35b92");
        public static BlueprintUnit CR7_CyborgCrusader_WorkshopBoss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("fef36508eb0842e4ba8b95eea191af69");
        public static BlueprintUnit CyborgChiefFemale_Boss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("4b7ba40dd891acf4bbb0582d65b6f506");


        public static List<BlueprintUnit> CyborgsList = new List<BlueprintUnit>() {
            CR13_CyborgGreaterKalavakusAdvanced,
            CR14_Cyborg_CrusaderRangedLevel12,
            CR14_Cyborg_CrusaderTankLevel12,
            CR15_CyborgSalamander_Add,
            CR15_Cyborg_CrusaderCasterLevel13,
            CR15_Cyborg_CrusaderMeleeLevel13,
            CR15_Cyborg_CrusaderRogueLevel13,
            CR15_Cyborg_Incubus_Assasin,
            CR16_Cyborg_SuccubusSorc,
            CR17_CyborgSalamander_Boss,
            CR7_CyborgCrusader_WorkshopBoss,
            CyborgChiefFemale_Boss,
        };

    }
}
