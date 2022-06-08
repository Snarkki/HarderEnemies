using Kingmaker.AI.Blueprints.Considerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;


namespace HarderEnemies.Blueprints {
    public  class AiConsiderationList {

        public static ComplexConsideration AttackTargetsPriority = BlueprintTools.GetBlueprint<ComplexConsideration>("7a2b25dcc09cd244db261ce0a70cca84");
        public static CommandCooldownConsideration SwiftActionCooldown = BlueprintTools.GetBlueprint<CommandCooldownConsideration>("c2b7d2f9a5cb8d04d9e1aa4bf3d3c598");
       
        public static RandomConsideration ChaoticBehavior = BlueprintTools.GetBlueprint<RandomConsideration>("aad346ba597e8aa45bb4b589d9f9d0ea");

        public static UnitsAroundConsideration ChooseMoreAoeTargets = BlueprintTools.GetBlueprint<UnitsAroundConsideration>("b2490b137b8b53a4e950c1d79d1c5c1d");
        public static UnitsAroundConsideration AvoidSelf = BlueprintTools.GetBlueprint<UnitsAroundConsideration>("c6f51b70d77ef9943ba4b1a5b5ff56f8");

        public static BuffConsideration NoBuffInvisibilityGreater = BlueprintTools.GetBlueprint<BuffConsideration>("2fc05579e43f56146a1cdaaa82e5119c");
        public static FactConsideration NoSwarmDiminiutuiveConsideration = BlueprintTools.GetBlueprint<FactConsideration>("e5c06effb59a452e982422eee15517a1");
        public static FactConsideration CasterConsideration = BlueprintTools.GetBlueprint<FactConsideration>("4309796864c63624ca5b7cce059cc4e2");

    }
}
