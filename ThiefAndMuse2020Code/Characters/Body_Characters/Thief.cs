namespace ThiefAndMuses2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Armor.Medium;
    using ThiefAndMuses2020Code.Weapons.Renaissance;
    public class Thief : Body
    {
        private const int DEFAULT_LEVEL = 5;
        private const string DEFAULT_NAME = "Thief";
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const int DEFAULT_SKILL_POINTS = 30;
        private const Factions DEFAULT_FACTION = Factions.Physical;

        private const int DEFAULT_STRENGTH = 2;
        private const int DEFAULT_PERCEPTION = 5;
        private const int DEFAULT_ENDURANCE = 6;
        private const int DEFAULT_CHARISMA = 5;
        private const int DEFAULT_INTELLIGENCE = 4;
        private const int DEFAULT_AGILITY = 7;
        private const int DEFAULT_LUCK = 7;

        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Night Jacket", 1, 5, 5);
        private readonly Dagger DEFAULT_WEAPON = new Dagger("Iron Dagger", 1, 0, 5, 0, 10);

        private LeatherVest armor;
        private Dagger weapon;

        public LeatherVest Armor
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
        public Dagger Weapon
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

        public Thief(string name, int level, int healthPoints, int skillPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * healthPoints);
            this.SkillPoints = (level * skillPoints);
            this.Faction = faction;

            this.Strength = level * strength;
            this.Perception = level * perception;
            this.Endurance = level * endurance;
            this.Charisma = level * charisma;
            this.Intelligence = level * intelligence;
            this.Agility = level * agility;
            this.Luck = level * luck;

            this.Armor = new LeatherVest("Night Jacket", 1, 5, 5);
            this.Weapon = new Dagger("Iron Dagger", 1, 0, 5, 0, 10);

            this.Damage = (level * strength * this.Weapon.WeaponDamage);
            this.Defense = (level * endurance * this.Armor.ArmorRating);
            this.Speed = (level * agility * this.Weapon.WeaponSpeed);
        }
       
        public Thief(string name, int level, Factions faction)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            this.SkillPoints = (level * DEFAULT_SKILL_POINTS);
            this.Faction = faction;

            this.Strength =   level * DEFAULT_STRENGTH;
            this.Perception = level * DEFAULT_PERCEPTION;
            this.Endurance =  level * DEFAULT_ENDURANCE;
            this.Charisma =   level * DEFAULT_CHARISMA;
            this.Intelligence = level * DEFAULT_INTELLIGENCE;
            this.Agility =    level * DEFAULT_AGILITY;
            this.Luck =       level * DEFAULT_LUCK;

            this.Armor =  DEFAULT_ARMOR;
            this.Weapon = DEFAULT_WEAPON;

            this.Damage = (level * DEFAULT_STRENGTH * this.Weapon.WeaponDamage);
            this.Defense = (level * DEFAULT_ENDURANCE * this.Armor.ArmorRating);
            this.Speed = (level * DEFAULT_AGILITY * this.Weapon.WeaponSpeed);
        }

        public void Steal()
        {
            throw new NotImplementedException();

        }
        public void Attack()
        {
            throw new NotImplementedException();

        }
        public void Dodge()
        {
            throw new NotImplementedException();

        }

    }
}

