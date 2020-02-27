using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThiefAndMuse2020Code.Enumerations;

namespace ThiefAndMuse2020Code
{
    public static class Consts
    {
        public static class BodyGuard
        {
            public const int LEVEL = 1;//Maximum LEVEL is 100
            public const string NAME = "Bodyguard";
            public const int HEALTH_POINTS = 70;//Maximum HEALTH is 100
            public const int SKILL_POINTS = 20;//Maximum SKILL is 100
            public const Factions FACTION = Factions.Physical;
            public const int DAMAGE = 7;//Maximum DAMAGE and DEFENSE is 10
            public const int DEFENSE = 10;
        }

        public static class Sage
        {
            public const int LEVEL = 1;
            public const string NAME = "Sage";
            public const int HEALTH_POINTS = 70;
            public const int ENERGY_POINTS = 10;
            public const Factions FACTION = Factions.Spiritual;
            public const int DAMAGE = 10;
            public const int DEFENSE = 7;
        }
    }
    
}
