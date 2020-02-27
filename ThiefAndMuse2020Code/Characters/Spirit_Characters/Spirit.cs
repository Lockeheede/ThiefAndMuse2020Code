
namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
using System;

    public abstract class Spirit : Character
    {
        private int energyPoints;
        public int EnergyPoints
        {
            get
            {
                return this.energyPoints;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Energy Points cannot be negative. Default set to 0");
                    this.energyPoints = 0;
                }
                else
                {
                    this.energyPoints = value;
                }
            }
        }
        public Spirit()
        {

        }

        public Spirit(string name, int level)
            :base(name, level)
        {
            base.Name = name;
            base.Level = level;
        }
        public Spirit(string name, int level, int energyPoints)
        {
            this.Name = name;
            this.Level = level;
            this.EnergyPoints = energyPoints;
        }
    }
}
