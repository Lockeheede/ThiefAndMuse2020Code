
namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
using System;
    public abstract class Spirit : Character
    {
        private int chiPoints;
        public int ChiPoints
        {
            get
            {
                return this.chiPoints;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Chi Points cannot be negative. Default set to 0");
                    this.chiPoints = 0;
                }
                else
                {
                    this.chiPoints = value;
                }
            }
        }
        public Spirit(string name, int level, int chiPoints)
        : base(name, level)
        {
            this.Name = name;
            this.Level = level;
            this.ChiPoints = chiPoints;
        }
    }
}
