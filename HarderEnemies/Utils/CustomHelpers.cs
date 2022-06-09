using Kingmaker.Blueprints;
using Kingmaker.Blueprints.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabletopTweaks.Core.Utilities;
using HarderEnemies.Blueprints;
using static HarderEnemies.Main;
using Kingmaker.Designers.Mechanics.Facts;
using Kingmaker.ElementsSystem;
using Kingmaker.UnitLogic.Mechanics.Actions;
using Kingmaker.UnitLogic.FactLogic;

namespace HarderEnemies.Utils {
    public static class CustomHelpers {


        public static void AddFactListsToUnit(this BlueprintUnit unit, int casterlevel, BlueprintUnitFactReference[] buffList) {
            unit.AddComponent<AddFacts>(c => {
                c.CasterLevel = casterlevel;
                c.MinDifficulty = Kingmaker.Settings.GameDifficultyOption.Story;
                c.m_Facts = buffList;
            });
        }


    }
}
