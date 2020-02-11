
namespace ThiefAndMuse2020Code.Characters.Body_Characters
{
using System;
    public class Body : Character
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

    }
}
