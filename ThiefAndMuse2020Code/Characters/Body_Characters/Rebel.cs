

namespace ThiefAndMuses2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Apparel.Medium;
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

        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Rebellion Coat", 5, 10, 10);
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
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public Rebel(string name, int level, int healthPoints, int skillPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
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
      
        public Rebel(string name, int level, Factions faction)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            this.SkillPoints = (level * DEFAULT_SKILL_POINTS);
            this.Faction = faction;

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

        public void Attack()
        {
            throw new NotImplementedException();

        }
        public void BoostInjection()
        {
            throw new NotImplementedException();

        }
        public void Kamakaze()
        {
            throw new NotImplementedException();

        }
    }
}