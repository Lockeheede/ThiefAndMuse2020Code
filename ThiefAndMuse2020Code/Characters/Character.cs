using System;
using ThiefAndMuse2020Code.Enumerations;

namespace ThiefAndMuse2020Code.Characters
{
    public class Character
    {
        private string name;
        private int level;
        private int healthPoints;
        private Factions faction;

        private int strength;
        private int perception;
        private int endurance;
        private int charisma;
        private int intelligence;
        private int agility;
        private int luck;

        private int damage;
        private int defense;
        private int speed;
        private int magick;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < 2)
                {
                    Console.WriteLine("The name cannot have less than two characters! Default set to Dumb...");
                    this.name = "Dumb";
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    this.level = value;
                }
                else
                {
                    Console.WriteLine("Inappropriate level value. Default set to 1");
                    this.level = 1;
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Health Points cannot be 0 or less! Default set to 100.");
                    this.healthPoints = 100;
                }
                else
                {
                    this.healthPoints = value;
                }
            }
        }
        public Factions Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                this.faction = value;
            }
        }
        public int Strength
        {
            get
            {
                return this.strength;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Strength must be at least 1. Default set to 1.");
                    this.strength = 1;
                }
                else
                {
                    this.strength = value;
                }
            }
        }
        public int Perception
        {
            get
            {
                return this.perception;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Perception must be at least 1. Default set to 1.");
                    this.perception = 1;
                }
                else
                {
                    this.perception = value;
                }
            }
        }
        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Endurance must be at least 1. Default set to 1.");
                    this.endurance = 1;
                }
                else
                {
                    this.endurance = value;
                }
            }
        }
        public int Charisma
        {
            get
            {
                return this.charisma;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Charisma must be at least 1. Default set to 1.");
                    this.charisma = 1;
                }
                else
                {
                    this.charisma = value;
                }
            }
        }
        public int Intelligence
        {
            get
            {
                return this.intelligence;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Intelligence must be at least 1. Default set to 1.");
                    this.intelligence = 1;
                }
                else
                {
                    this.intelligence = value;
                }
            }
        }
        public int Agility
        {
            get
            {
                return this.agility;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Agility must be at least 1. Default set to 1.");
                    this.agility = 1;
                }
                else
                {
                    this.agility = value;
                }
            }
        }
        public int Luck
        {
            get
            {
                return this.luck;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Luck must be at least 1. Default set to 1.");
                    this.luck = 1;
                }
                else
                {
                    this.luck = value;
                }
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Damage must be at least 1. Default set to 1.");
                    this.damage = 1;
                }
                else
                {
                    this.damage = value;
                }
            }
        }
        public int Defense
        {
            get
            {
                return this.defense;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Defense must be at least 1. Default set to 1.");
                    this.defense = 1;
                }
                else
                {
                    this.defense = value;
                }
            }
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("Speed must be at least 1. Default set to 1.");
                    this.speed = 1;
                }
                else
                {
                    this.speed = value;
                }
            }
        }
        public int Magick
        {
            get
            {
                return this.magick;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Magick must be at least 0. Default set to 0.");
                    this.magick = 0;
                }
                else
                {
                    this.magick = value;
                }
            }
        }
    }
}
