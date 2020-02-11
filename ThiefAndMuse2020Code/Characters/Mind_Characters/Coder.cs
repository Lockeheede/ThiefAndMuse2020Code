﻿namespace ThiefAndMuses2020Code.Characters.Mind_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Mind_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Apparel.Medium;
    using ThiefAndMuses2020Code.Weapons.Technology;

    public class Coder : Mind
    {
        private const int DEFAULT_LEVEL = 5;
        private const string DEFAULT_NAME = "Coder";
        private const int DEFAULT_HEALTH_POINTS = 25;
        private const int DEFAULT_BRAIN_POINTS = 300;
        private const Factions DEFAULT_FACTION = Factions.Mental;

        private const int DEFAULT_STRENGTH = 1;
        private const int DEFAULT_PERCEPTION = 7;
        private const int DEFAULT_ENDURANCE = 1;
        private const int DEFAULT_CHARISMA = 3;
        private const int DEFAULT_INTELLIGENCE = 7;
        private const int DEFAULT_AGILITY = 1;
        private const int DEFAULT_LUCK = 7;

        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Hack-It Jacket", 3, 8, 10);
        private readonly CPU DEFAULT_WEAPON = new CPU("Intent I-9", 5, 3, 10, 5, 10);

        private LeatherVest armor;
        private CPU weapon;

        public LeatherVest Armor { get => this.armor; set => this.armor = value; }
        public CPU Weapon { get => this.weapon; set => this.weapon = value; }



        public Coder(string name, int level, int healthPoints, int brainPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
        {
            Level = level;
            Name = name;
            HealthPoints = (level * healthPoints);
            BrainPoints = (level * brainPoints);
            Faction = faction;

            Strength = level * strength;
            Perception = level * perception;
            Endurance = level * endurance;
            Charisma = level * charisma;
            Intelligence = level * intelligence;
            Agility = level * agility;
            Luck = level * luck;

            Armor = armor;
            Weapon = weapon;

            this.Damage = (level * strength * this.Weapon.WeaponDamage);
            this.Defense = (level * endurance * this.Armor.ArmorRating);
            this.Speed = (level * agility * this.Weapon.WeaponSpeed);
            Magick = (level * intelligence) + (level * perception);
        }
        public Coder(string name, int level, Factions faction)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            this.BrainPoints = (level * DEFAULT_BRAIN_POINTS);
            this.Faction = faction;

            this.Strength = level * DEFAULT_STRENGTH;
            this.Perception =   level * DEFAULT_PERCEPTION;
            this.Endurance =    level * DEFAULT_ENDURANCE;
            this.Charisma =     level * DEFAULT_CHARISMA;
            this.Intelligence = level * DEFAULT_INTELLIGENCE;
            this.Agility =      level * DEFAULT_AGILITY;
            this.Luck =         level * DEFAULT_LUCK;

            this.Armor = DEFAULT_ARMOR;
            this.Weapon = DEFAULT_WEAPON;

            this.Damage = (level * DEFAULT_STRENGTH * this.Weapon.WeaponDamage);
            this.Defense = (level * DEFAULT_ENDURANCE * this.Armor.ArmorRating);
            this.Speed = (level * DEFAULT_AGILITY * this.Weapon.WeaponSpeed);
            this.Magick = (level * DEFAULT_INTELLIGENCE) + (level * DEFAULT_PERCEPTION);
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