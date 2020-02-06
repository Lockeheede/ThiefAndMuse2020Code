

namespace ThiefAndMuses2020Code.Characters.Body
{
    using System;
    using ThiefAndMuses2020Code.Apparel.Heavy;
    using ThiefAndMuses2020Code.Weapons.Modern;
    public class BodyGuard
    {
        private const int DEFAULT_LEVEL = 10;
        private const string DEFAULT_NAME = "Bodyguard";
        private const int DEFAULT_HEALTH_POINTS = 200;
        private const int DEFAULT_CHI_POINTS = 0;
        private const string DEFAULT_FACTION = "Reggie";

        private const int DEFAULT_STRENGTH = 7;
        private const int DEFAULT_PERCEPTION = 3;
        private const int DEFAULT_ENDURANCE = 7;
        private const int DEFAULT_CHARISMA = 2;
        private const int DEFAULT_INTELLIGENCE = 2;
        private const int DEFAULT_AGILITY = 4;
        private const int DEFAULT_LUCK = 4;

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

        private HeavyJacket armor;
        private TwentyShot weapon;

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
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {

                if (value == "Reggie" || value == "Coder" || value == "Sage" || value == "unRealistic" || value == "Rebel")
                {
                    this.faction = value;
                }
                else
                {
                    Console.WriteLine("There are only 5 factions. Default set to Reggie!");
                    this.faction = "Reggie";
                }
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
        public HeavyJacket Armor
        {
            get
            {
                return this.armor;
            }
            set
            {
                this.armor = value;
            }
        }
        public TwentyShot Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
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




        public BodyGuard(string name, int level, int healthPoints, int chiPoints, string faction, int strength,
            int perception, int endurance, int charisma, int intelligence, int agility, int luck, HeavyJacket armor, TwentyShot weapon,
            int damage, int defense, int speed, int magick)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * healthPoints) + (level * endurance);
            this.ChiPoints = (level * chiPoints) + (level * intelligence);
            this.Faction = faction;

            this.Strength = level * strength;
            this.Perception = level * perception;
            this.Endurance = level * endurance;
            this.Charisma = level * charisma;
            this.Intelligence = level * intelligence;
            this.Agility = level * agility;
            this.Luck = level * luck;

            this.Armor = armor;
            this.Weapon = weapon;

            this.Damage = (level * damage) + (level * strength);
            this.Defense = (level * defense) + (level * endurance);
            this.Speed = (level * speed) + (level * agility);
            this.Magick = (level * intelligence) + (level * perception);
        }

       

        private readonly HeavyJacket DEFAULT_ARMOR = new HeavyJacket("Flak Jacket", 5, 10, 0);
        private readonly TwentyShot DEFAULT_WEAPON = new TwentyShot("Hand Cannon", 5, 1, 7, 3, 10);
        public BodyGuard(string name, int level, string faction)
        {
            this.Level = DEFAULT_LEVEL;
            this.Name = DEFAULT_NAME;
            this.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            this.ChiPoints = (level * DEFAULT_CHI_POINTS);
            this.Faction = DEFAULT_FACTION;

            this.Strength = level * DEFAULT_STRENGTH;
            this.Perception = level * DEFAULT_PERCEPTION;
            this.Endurance = level * DEFAULT_ENDURANCE;
            this.Charisma = level * DEFAULT_CHARISMA;
            this.Intelligence = level * DEFAULT_INTELLIGENCE;
            this.Agility = level * DEFAULT_AGILITY;
            this.Luck = level * DEFAULT_LUCK;

            this.Armor = DEFAULT_ARMOR;
            this.Weapon = DEFAULT_WEAPON;

            this.Damage = (level * DEFAULT_STRENGTH * this.Weapon.WeaponDamage);
            this.Defense = (level * DEFAULT_ENDURANCE * this.Armor.ArmorRating);
            this.Speed = (level * DEFAULT_AGILITY * this.Weapon.WeaponSpeed);
            this.Magick = (level * DEFAULT_INTELLIGENCE) + (level * DEFAULT_PERCEPTION);
        }

        public void HeavyAttack()
        {
            throw new NotImplementedException();

        }
        public void StunAttack()
        {
            throw new NotImplementedException();

        }

        public void ShockArmor()
        {
            throw new NotImplementedException();

        }
    }
}

