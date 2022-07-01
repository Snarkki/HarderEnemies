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

namespace HarderEnemies.UnitModifications.Bosses.Minagho {
    internal class UnitLists {

        public static BlueprintUnit Minagho = BlueprintTools.GetBlueprint<BlueprintUnit>("495b15de02d7cc74f84b4342a829bfbc");
        public static BlueprintUnit Minagho_GreyGarrison = BlueprintTools.GetBlueprint<BlueprintUnit>("bbcd85f6c1762364ba48be9f72f115ae");
        public static BlueprintUnit Alushinyrra_Minagho = BlueprintTools.GetBlueprint<BlueprintUnit>("23e9e36701934fcbbf3e1472091d9321");
        public static BlueprintUnit Minagho_DrezenCitadel_Boss = BlueprintTools.GetBlueprint<BlueprintUnit>("b8d11ced33308874790188d910b71a2f");

        public static List<BlueprintUnit> MinaghoList = new List<BlueprintUnit>() {
            Alushinyrra_Minagho,
            Minagho,
            Minagho_DrezenCitadel_Boss
        };
    }
}
