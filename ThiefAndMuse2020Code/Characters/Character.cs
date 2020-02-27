using System;
using System.Threading;
using ThiefAndMuse2020Code.Armor;
using ThiefAndMuse2020Code.Characters.Interfaces;
using ThiefAndMuse2020Code.Enumerations;
using ThiefAndMuse2020Code.Weapons;

namespace ThiefAndMuse2020Code.Characters
{
    public abstract class Character : IAttack, IDefend
    {
        private string name;
        private int level;
        private int healthPoints;
        private Factions faction;

        private Armor_Type bodyArmor;
        private Weapon_Type weaponType;

        private int damage;
        private int defense;
        
        private bool isAlive = true;
        private int scores;
        private int damageCalculator;

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
                if (value <= 0 || value >= 1000)
                {
                    Console.WriteLine("Inappropriate value! Default HP has been set to 100.");
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

        public Armor_Type BodyArmor { get => this.bodyArmor; set => this.bodyArmor = value; }
        public Weapon_Type WeaponType { get => this.weaponType; set => this.weaponType = value; }
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
            }
        }
        public int Scores
        {
            get
            {
                return this.scores;
            }
            set
            {
                this.scores = value;
            }
        }

        public int DamageCalculator { get => damageCalculator; set => damageCalculator = value; }

        public Character()
        {
           
        }

        public Character(string name, int level)
        {
            this.name = name;
            this.level = level;
        }

        public abstract int Attack();
   

        public abstract int SpecialAttack();


        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName)
        {
            healthPoints = healthPoints - damage + defense;

            if (healthPoints <= 0)
            {
                this.isAlive = false;
            }
        
            /*else if (defense >= damage)
            {
                Console.WriteLine($"{this.name} Took no damage from {attackerName}!");
                Thread.Sleep(3000);
            }*/

            if (!this.isAlive)
            {
                Console.WriteLine($"{ this.name} received {damage} damage from {attackerName} and is now dead!");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine($"{ this.name} received {damage} damage from {attackerName} and now has {healthPoints} HP!");
                Thread.Sleep(3000);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if(this.scores % 3 == 0)
            {
                this.level++;//Every three scores, the character levels up
            }
        }
    }
}
