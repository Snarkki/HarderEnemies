using Kingmaker.AI.Blueprints;
using Kingmaker.AI.Blueprints.Considerations;
using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using Kingmaker.RuleSystem;
using Kingmaker.UnitLogic.Abilities.Blueprints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;

namespace HarderEnemies.AI_Mechanics.Actions {
    public class AiConsiderations {

        public static void CreateNew() {
            CreateNoBuff();
        }

        private static void CreateNoBuff() {

            var NoMindBlankConsideration = AiConsiderationList.NoBuffInvisibilityGreater.CreateCopy(HEContext, "NoMindBlankConsideration", bp => {
                bp.m_Buffs = new BlueprintBuffReference[] { Abilities.MindBlank.ToReference<BlueprintBuffReference>() };
            });
        }
    }
}
