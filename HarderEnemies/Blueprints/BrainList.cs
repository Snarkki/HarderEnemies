using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kingmaker.AI.Blueprints;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using Kingmaker.UnitLogic.Abilities.Components;
using Kingmaker.UnitLogic.FactLogic;
using TabletopTweaks.Core.Utilities;
using static HarderEnemies.Main;

namespace HarderEnemies.Blueprints {
    public class BrainList {
        public static BlueprintBrain MinaghoBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("be29a8a505f3c2644b34341a970b1573");
        public static BlueprintBrain Alushinyrra_MinaghoBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("a4f9e2c494e6432cb9926a88ea84e984");
        public static BlueprintBrain Minagho_DrezenCitadel_BossBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("c1683cfd6c914f02bbf091701264e7ac");
        public static BlueprintBrain JerribethBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("f8ff8935f7859494fb18e056657d30ff");
        public static BlueprintBrain DarrazandBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("83cdabf6651755c4c936b5388f91b1af");
        public static BlueprintBrain CultistEvokerBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("3b260ee15e170b546992c683a6614a8c");
        public static BlueprintBrain CultistConjurerBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("7b03871cb6fb91f4fac27828903ddf17");

        public static BlueprintBrain ColoxusBrainStandard = BlueprintTools.GetBlueprint<BlueprintBrain>("822a0e3b77372ac46bb848f0b7339776");
        public static BlueprintBrain Coloxus_Brain_Confusion = BlueprintTools.GetBlueprint<BlueprintBrain>("2e5d8cbf6b078da47a042621555e0bb5");
        public static BlueprintBrain CR21Coloxus_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("42f2be7546674463a39bfebb311dd0c1");
        public static BlueprintBrain Coloxus_Brain_SongOfDiscord = BlueprintTools.GetBlueprint<BlueprintBrain>("374c04d41cd9a704f8a54cff19521562");
        public static BlueprintBrain ColoxusToughCaster_Brain_OverhwelmingPresence = BlueprintTools.GetBlueprint<BlueprintBrain>("52a64f64a0f2a534a9284c7d6bdfa398");
        public static BlueprintBrain GibrilethStandardBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("9761cff3240c3a24196f6c2bbffb1c60");
        public static BlueprintBrain GlabrezuBrainStandard = BlueprintTools.GetBlueprint<BlueprintBrain>("93486b9c4e2f14a46897d65aca967985");
        public static BlueprintBrain Mutasafen_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("5d5d64b872a06ff4495b5630de528f17");
        public static BlueprintBrain Alushinyrra_Minagho_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("a4f9e2c494e6432cb9926a88ea84e984");

        public static BlueprintBrain Nocticula_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("b37b0e3ae7ee4f38b29930aaa816c972");
        public static BlueprintBrain Areelu_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("a712b94402ff4b0ba40af14482b7250d");
        public static BlueprintBrain Deskari_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("e8df029c531638d448dbe8a548454c41");
        public static BlueprintBrain EchoOfDeskari_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("9e71574658a6f234193838bcd07f49d7");
        public static BlueprintBrain MidnightFane_DeskariPriestess_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("0a7fab9bcdef89e4ab50824c4aff882d");
        public static BlueprintBrain Areshkagal_BrainFirst = BlueprintTools.GetBlueprint<BlueprintBrain>("c1da4b6948f84bc3b6e87bf3d80be6df");
        public static BlueprintBrain BalorBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("8d252e57135076842b1425d5b3e082d3");
        public static BlueprintBrain BalorMythic6_BloodragerBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("222ac5dab8a22cd4d98253df4c786bf4");
        public static BlueprintBrain BalorMythic_FighterBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("4525d12246e49894cb02b9f3668a571a");
        public static BlueprintBrain BalorNocticulaGuard_Brain_Caster = BlueprintTools.GetBlueprint<BlueprintBrain>("a623eefae37d4772bdd0c38ecbf17013");
        public static BlueprintBrain BalorNocticulaGuard_Brain_Melee = BlueprintTools.GetBlueprint<BlueprintBrain>("01f3ed64c9434d508111a08b7f7335f9");
        public static BlueprintBrain Khor_BalorBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("440b0c54268c4bfdb7e0447f241d7f5c");


        public static BlueprintBrain DumbBrain = BlueprintTools.GetBlueprint<BlueprintBrain>("5abc8884c6f15204c8604cb01a2efbab");
        public static BlueprintBrain HalfFiendMinotaur_Standard_Brain = BlueprintTools.GetBlueprint<BlueprintBrain>("c6ba6fd4eca00a140b3a723c418c3343");
    }
}
