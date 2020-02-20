
namespace ThiefAndMuse2020Code.Characters.Body_Characters
{
using System;
    public abstract class Body : Character
    {
        private int skillPoints;

        public int SkillPoints
        {
            get
            {
                return this.skillPoints;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Skill Points cannot be negative. Default set to 0");
                    this.skillPoints = 0;
                }
                else
                {
                    this.skillPoints = value;
                }
            }
        }

        public Body()
        {

        }
        public Body(string name, int level, int skillPoints)
        {
            this.Name = name;
            this.Level = level;
            this.SkillPoints = skillPoints;
        }
    }
}
