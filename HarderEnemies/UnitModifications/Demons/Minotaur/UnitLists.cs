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

namespace HarderEnemies.UnitModifications.Demons.Minotaur {
    internal class UnitLists {

        public static BlueprintUnit Colyphyr_MinotaurSlave = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d7e288cf73c66f041b6cf3dea3f7841d");
        public static BlueprintUnit CR10_FiendishMinotaur_Guard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("962427b9ddb354947ac92655dc637e0c");
        public static BlueprintUnit CR10_FiendishMinotaur_TwoAxes = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("a5df5f979efcd3b4f997842354abdf1f");
        public static BlueprintUnit CR10_HalfFiendFuriousMinotaur = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("49686b68c7e4694469191be48c3cccf2");
        public static BlueprintUnit CR10_HalfFiendFuriousMinotaur_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cafbbbac615c66248940d6698002956a");
        public static BlueprintUnit CR14_FiendishMinotaurAxeThrower = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("22713834d257ae145b8ebde1ebd85d3f");
        public static BlueprintUnit CR14_FiendishMinotaurAxeThrower_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0a31d380b3f471d4bbc086702ffc9779");
        public static BlueprintUnit CR14_FiendishMinotaur_DLC2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b5abbeaa0c5e4f5ab98eff55e1c74acb");
        public static BlueprintUnit CR14_FiendishMinotaur_TwoAxes = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c9f241472353a5b4ea38bc06d3fdf15d");
        public static BlueprintUnit CR14_HalfFiendFighterMinotaurDLC2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("f6f563f8c4b14d028d133ec28be98c6a");
        public static BlueprintUnit CR14_HalfFiendGuardianMinotaur = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b5c8b4561321a1b408146ed4cd230964");
        public static BlueprintUnit CR14_HalfFiendGuardianMinotaur_DLC2 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("2c930adfa1f049309872d20bb182ed6c");
        public static BlueprintUnit CR14_HalfFiendGuardianMinotaur_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0354f7cf2a57123438864088b94d89b5");
        public static BlueprintUnit CR14_MinotaurCleric = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("8d774849273538d4faa07c5f8d63c4c9");
        public static BlueprintUnit CR16_LabyrinthMinotaurStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b9785e113e729ff4fa5395c6dd9e3e4c");
        public static BlueprintUnit CR17_LabyrinthMinotaurAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("06a56a6dd9291ae4baca18b75f8d4f57");
        public static BlueprintUnit CR19_HalfFiendGuardianMinotaurEnhanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d37ad6e1ffbc95a4ebab944de7212f61");
        public static BlueprintUnit CR19_HalfFiendGuardianMinotaurEnhanced_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("60a35995607d493c85a8118dd9da993b");
        public static BlueprintUnit CR19_MinotaurCasterDispeller = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("0c05ae0e64dd0014e95c011197cd727a");
        public static BlueprintUnit CR20_LabyrinthMinotaurEnhanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c169c31cd7b9609438d1662f516649f3");
        public static BlueprintUnit CR20_MinotaurCasterBlaster = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("58de6b95783c4fe4fb2b90c039d899ce");
        public static BlueprintUnit CR20_MinotaurCasterBlaster_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("60fef47744694099bd15f235d2d36129");
        public static BlueprintUnit CR26_Minotaur_IngerMaggor = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("3042ec6d7d6d4308a26f74209771660c");
        public static BlueprintUnit CR4_Minotaur = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("eeb29b8b182f23e4a9a34c5520ae8571");
        public static BlueprintUnit CR5_FiendishMinotaurStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d2b03b8699c02854c925f99c3a9ba77a");
        public static BlueprintUnit CR5_FiendishMinotaurStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("7706e17ad3323d54c91697eeb1d91305");
        public static BlueprintUnit CR6_FiendishMinotaur_TwoAxes = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("cfb498cbb2b2cf442870dfb93ffbd2d4");
        public static BlueprintUnit CR6_HalfFiendMinotaurStandard = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("bba85568933de834286bc5d44281e97b");
        public static BlueprintUnit CR6_HalfFiendMinotaurStandard_RE = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("46d7e9fa8b58c914cb71b9be2ea8d1e0");
        public static BlueprintUnit Deradnu = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("b9793d3ebbae5c44b854134b437e929b");
        public static BlueprintUnit IvoryLabyrinthMinotaur18 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("55ae2f52c16d8f54b9da7d8cea8621af");
        public static BlueprintUnit IvoryLabyrinthMinotaur_SpecialBaphomet25 = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("31894935e6b3ed242a513336f092216b");
        public static BlueprintUnit MidnightFane_LabyrinthMinotaurAdvanced = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("d10d6cb6881b51542801cca573f4a07d");
        public static BlueprintUnit MinotaurGhost_Boss = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("1b5fc80bcedff624b805b950a2244165");
        public static BlueprintUnit MinotaurGhost_BossNoExp = ResourcesLibrary.TryGetBlueprint<BlueprintUnit>("c0dc27a43b555014286d89493e12bc14");


        public static List<BlueprintUnit> DemonMeleeMinotaurList = new List<BlueprintUnit>() {
            CR6_HalfFiendMinotaurStandard,
            CR6_HalfFiendMinotaurStandard_RE,
            CR5_FiendishMinotaurStandard,
            CR5_FiendishMinotaurStandard_RE,
            Colyphyr_MinotaurSlave, //cr14
            CR10_FiendishMinotaur_Guard,
            CR14_HalfFiendGuardianMinotaur,
            CR14_HalfFiendGuardianMinotaur_RE,
            CR16_LabyrinthMinotaurStandard,
            CR19_HalfFiendGuardianMinotaurEnhanced,
            CR19_HalfFiendGuardianMinotaurEnhanced_RE,
            IvoryLabyrinthMinotaur18,
        };

        public static List<BlueprintUnit> RushingMinotaursList = new List<BlueprintUnit>() {
            IvoryLabyrinthMinotaur_SpecialBaphomet25,
            MidnightFane_LabyrinthMinotaurAdvanced,
            CR10_HalfFiendFuriousMinotaur,
            CR10_HalfFiendFuriousMinotaur_RE,
            CR17_LabyrinthMinotaurAdvanced,
            CR20_LabyrinthMinotaurEnhanced,
        };
    }
}
