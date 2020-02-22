/*

namespace ThiefAndMuses2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Armor.Medium;
    using ThiefAndMuses2020Code.Weapons.Renaissance;
    public class Rebel : Body
    {
        private const int DEFAULT_LEVEL = 3;
        private const string DEFAULT_NAME = "Rebel";
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_SKILL_POINTS = 10;
        private const Factions DEFAULT_FACTION = Factions.Physical;

        private const int DEFAULT_STRENGTH = 3;
        private const int DEFAULT_PERCEPTION = 3;
        private const int DEFAULT_ENDURANCE = 3;
        private const int DEFAULT_CHARISMA = 3;
        private const int DEFAULT_INTELLIGENCE = 3;
        private const int DEFAULT_AGILITY = 3;
        private const int DEFAULT_LUCK = 3;

        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Rebellion Coat", 5, 10, 5, 5);
        private readonly Sword DEFAULT_WEAPON = new Sword("Steel Sword", 5, 1, 7, 3, 10);

        private LeatherVest armor;
        private Sword weapon;
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
        public Sword Weapon
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

        public Rebel(string name, int level, int healthPoints, int skillPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            :base(name, level, skillPoints)
        {
            Level = level;
            Name = name;
            HealthPoints = (level * healthPoints);
            SkillPoints = (level * skillPoints);
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
        }
      
        public Rebel()
        {
            {
                this.Level = DEFAULT_LUCK;
                this.Name = DEFAULT_NAME;
                this.HealthPoints = (DEFAULT_LUCK * DEFAULT_HEALTH_POINTS);
                this.SkillPoints = (DEFAULT_LUCK * DEFAULT_SKILL_POINTS);
                this.Faction = DEFAULT_FACTION;

                this.Strength = DEFAULT_LEVEL * DEFAULT_STRENGTH;
                this.Perception = DEFAULT_LEVEL * DEFAULT_PERCEPTION;
                this.Endurance = DEFAULT_LEVEL * DEFAULT_ENDURANCE;
                this.Charisma = DEFAULT_LEVEL * DEFAULT_CHARISMA;
                this.Intelligence = DEFAULT_LEVEL * DEFAULT_INTELLIGENCE;
                this.Agility = DEFAULT_LEVEL * DEFAULT_AGILITY;
                this.Luck = DEFAULT_LEVEL * DEFAULT_LUCK;

                this.Armor = DEFAULT_ARMOR;
                this.Weapon = DEFAULT_WEAPON;

                this.Damage = (DEFAULT_LEVEL * DEFAULT_STRENGTH * this.Weapon.WeaponDamage);
                this.Defense = (DEFAULT_LEVEL * DEFAULT_ENDURANCE * this.Armor.ArmorRating);
                this.Speed = (DEFAULT_LEVEL * DEFAULT_AGILITY * this.Weapon.WeaponSpeed);
            }
        }

        public void Headbutt()
        {
            throw new NotImplementedException();

        }
        public void BoostInjection()
        {
            throw new NotImplementedException();

        }
        public void Kamikaze()
        {
            throw new NotImplementedException();

        }

        public override void Attack()
        {
            this.Headbutt();
        }
        public override void SpecialAttack()
        {
            this.Kamikaze();
        }
        public override void Defend()
        {
            this.BoostInjection();
        }
    }
}*/