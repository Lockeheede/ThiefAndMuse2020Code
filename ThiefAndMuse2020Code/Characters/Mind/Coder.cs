namespace ThiefAndMuses2020Code.Characters.Mind
{
    using System;
    using ThiefAndMuses2020Code.Apparel.Medium;
    using ThiefAndMuses2020Code.Weapons.Cyber;

    public class Coder
    {
        private string name;
        private int level;
        private int healthPoints;
        private int chiPoints;
        private string faction;

        private int strength;
        private int perception;
        private int endurance;
        private int charisma;
        private int intelligence;
        private int agility;
        private int luck;

        private LeatherVest apparel;
        private CPU weapon;

        private int damage;
        private int defense;
        private int speed;
        private int magick;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length < 2)
                {
                    System.Console.WriteLine("The name cannot have less than two characters! Default set to Dumb...");
                    name = "Dumb";
                }
                else
                {
                    name = value;
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (level >= 1 && level <= 100)
                {
                    level = value;
                }
                else
                {
                    System.Console.WriteLine("Inappropriate level value. Default set to 1");
                    level = 1;
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (healthPoints <= 0)
                {
                    System.Console.WriteLine("Health Points cannot be 0 or less! Default set to 100.");
                    healthPoints = 100;
                }
                else
                {
                    healthPoints = value;
                }
            }
        }
        public int ChiPoints
        {
            get
            {
                return chiPoints;
            }
            set
            {
                if (chiPoints < 0)
                {
                    System.Console.WriteLine("Chi Points cannot be negative. Default set to 0");
                    chiPoints = 0;
                }
                else
                {
                    chiPoints = value;
                }
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (faction != "Reggie" || faction != "Coder" || faction != "Sage" || faction != "unRealistic" || faction != "Rebel")
                {
                    System.Console.WriteLine("There are only 5 factions. Default set to Reggie!");
                    faction = "Reggie";
                }
                else
                {
                    faction = value;
                }
            }
        }
        public int Strength
        {
            get
            {
                return strength;
            }
            set
            {
                if (strength < 1)
                {
                    System.Console.WriteLine("Strength must be at least 1. Default set to 1.");
                    strength = 1;
                }
                else
                {
                    strength = value;
                }
            }
        }
        public int Perception
        {
            get
            {
                return perception;
            }
            set
            {
                if (perception < 1)
                {
                    System.Console.WriteLine("Perception must be at least 1. Default set to 1.");
                    perception = 1;
                }
                else
                {
                    perception = value;
                }
            }
        }
        public int Endurance
        {
            get
            {
                return endurance;
            }
            set
            {
                if (endurance < 1)
                {
                    System.Console.WriteLine("Endurance must be at least 1. Default set to 1.");
                    endurance = 1;
                }
                else
                {
                    endurance = value;
                }
            }
        }
        public int Charisma
        {
            get
            {
                return charisma;
            }
            set
            {
                if (charisma < 1)
                {
                    System.Console.WriteLine("Charisma must be at least 1. Default set to 1.");
                    charisma = 1;
                }
                else
                {
                    charisma = value;
                }
            }
        }
        public int Intelligence
        {
            get
            {
                return intelligence;
            }
            set
            {
                if (intelligence < 1)
                {
                    System.Console.WriteLine("Intelligence must be at least 1. Default set to 1.");
                    intelligence = 1;
                }
                else
                {
                    intelligence = value;
                }
            }
        }
        public int Agility
        {
            get
            {
                return agility;
            }
            set
            {
                if (agility < 1)
                {
                    System.Console.WriteLine("Agility must be at least 1. Default set to 1.");
                    agility = 1;
                }
                else
                {
                    agility = value;
                }
            }
        }
        public int Luck
        {
            get
            {
                return luck;
            }
            set
            {
                if (luck < 1)
                {
                    System.Console.WriteLine("Luck must be at least 1. Default set to 1.");
                    luck = 1;
                }
                else
                {
                    luck = value;
                }
            }
        }

        public LeatherVest Apparel { get => apparel; set => apparel = value; }
        public CPU Weapon { get => weapon; set => weapon = value; }
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (damage < 1)
                {
                    System.Console.WriteLine("Damage must be at least 1. Default set to 1.");
                    damage = 1;
                }
                else
                {
                    damage = value;
                }
            }
        }
        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                if (defense < 1)
                {
                    System.Console.WriteLine("Defense must be at least 1. Default set to 1.");
                    defense = 1;
                }
                else
                {
                    defense = value;
                }
            }
        }
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (speed < 1)
                {
                    System.Console.WriteLine("Speed must be at least 1. Default set to 1.");
                    speed = 1;
                }
                else
                {
                    speed = value;
                }
            }
        }
        public int Magick
        {
            get
            {
                return magick;
            }
            set
            {
                if (magick < 0)
                {
                    System.Console.WriteLine("Magick must be at least 0. Default set to 0.");
                    magick = 0;
                }
                else
                {
                    magick = value;
                }
            }
        }

       

        public Coder(string name, int level, int healthPoints, int chiPoints, string faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck, LeatherVest apparel, CPU weapon,
          int damage, int defense, int speed, int magick)
        {
            Level = level;
            Name = name;
            HealthPoints = (level * healthPoints) + (level * endurance);
            ChiPoints = (level * chiPoints) + (level * intelligence);
            Faction = faction;

            Strength = level * strength;
            Perception = level * perception;
            Endurance = level * endurance;
            Charisma = level * charisma;
            Intelligence = level * intelligence;
            Agility = level * agility;
            Luck = level * luck;

            Apparel = apparel;
            Weapon = weapon;

            Damage = (level * damage) + (level * strength);
            Defense = (level * defense) + (level * endurance);
            Speed = (level * speed) + (level * agility);
            Magick = (level * intelligence) + (level * perception);
        }


        public void Hack()
        {
            throw new NotImplementedException();

        }
        public void Program()
        {
            throw new NotImplementedException();

        }
        public void Virus()
        {
            throw new NotImplementedException();

        }
    }

}