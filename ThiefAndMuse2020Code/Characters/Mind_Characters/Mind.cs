
namespace ThiefAndMuse2020Code.Characters.Mind_Characters
{
using System;
    public class Mind : Character
    {
        private int brainPoints;

        public int BrainPoints
        {
            get
            {
                return this.BrainPoints;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Brain Points cannot be negative. Default set to 0");
                    this.brainPoints = 0;
                }
                else
                {
                    this.brainPoints = value;
                }
            }
        }
        public Mind(string name, int level, int brainPoints)
        : base(name, level)
        {
            this.Name = name;
            this.Level = level;
            this.BrainPoints = brainPoints;
        }
    }
}
