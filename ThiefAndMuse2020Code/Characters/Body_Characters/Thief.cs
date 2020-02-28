/*
namespace ThiefAndMuse2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Medium;
    using ThiefAndMuse2020Code.Weapons.Renaissance;
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

        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Night Jacket", 1, 5, 1, 5);
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
            : base(name, level, skillPoints)
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

            this.Armor = new LeatherVest("Night Jacket", 1, 5, 1, 5);
            this.Weapon = new Dagger("Iron Dagger", 1, 0, 5, 0, 10);

            this.Damage = (level * strength * this.Weapon.WeaponDamage);
            this.Defense = (level * endurance * this.Armor.ArmorRating);
            this.Speed = (level * agility * this.Weapon.WeaponSpeed);
        }
       
        public Thief()
        {
            this.Level = DEFAULT_LUCK;
            this.Name = DEFAULT_NAME;
            this.HealthPoints = (DEFAULT_LUCK * DEFAULT_HEALTH_POINTS);
            this.SkillPoints = (DEFAULT_LUCK * DEFAULT_SKILL_POINTS);
            this.Faction = DEFAULT_FACTION;

            this.Strength =   DEFAULT_LEVEL * DEFAULT_STRENGTH;
            this.Perception = DEFAULT_LEVEL * DEFAULT_PERCEPTION;
            this.Endurance =  DEFAULT_LEVEL * DEFAULT_ENDURANCE;
            this.Charisma =   DEFAULT_LEVEL * DEFAULT_CHARISMA;
            this.Intelligence = DEFAULT_LEVEL * DEFAULT_INTELLIGENCE;
            this.Agility =    DEFAULT_LEVEL * DEFAULT_AGILITY;
            this.Luck =       DEFAULT_LEVEL * DEFAULT_LUCK;

            this.Armor =  DEFAULT_ARMOR;
            this.Weapon = DEFAULT_WEAPON;

            this.Damage = (DEFAULT_LEVEL * DEFAULT_STRENGTH * this.Weapon.WeaponDamage);
            this.Defense = (DEFAULT_LEVEL * DEFAULT_ENDURANCE * this.Armor.ArmorRating);
            this.Speed = (DEFAULT_LEVEL * DEFAULT_AGILITY * this.Weapon.WeaponSpeed);
        }

        public void Steal()
        {
            throw new NotImplementedException();

        }
        public void Sneak()
        {
            throw new NotImplementedException();

        }
        public void Dodge()
        {
            throw new NotImplementedException();

        }

        public override void Attack()
        {
            this.Sneak();
        }
        public override void SpecialAttack()
        {
            this.Steal();
        }
        public override void Defend()
        {
            this.Dodge();
        }
    }
}

*/