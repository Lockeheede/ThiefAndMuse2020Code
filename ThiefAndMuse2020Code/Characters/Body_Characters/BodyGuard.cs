

namespace ThiefAndMuses2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Armor.Heavy;
    using ThiefAndMuses2020Code.Weapons.Modern;
    public class BodyGuard : Body
    {
        private const int DEFAULT_LEVEL = 10;
        private const string DEFAULT_NAME = "Bodyguard";
        private const int DEFAULT_HEALTH_POINTS = 100;
        private const int DEFAULT_SKILL_POINTS = 20;
        private const Factions DEFAULT_FACTION = Factions.Physical;

        private const int DEFAULT_STRENGTH = 7;
        private const int DEFAULT_PERCEPTION = 3;
        private const int DEFAULT_ENDURANCE = 7;
        private const int DEFAULT_CHARISMA = 2;
        private const int DEFAULT_INTELLIGENCE = 2;
        private const int DEFAULT_AGILITY = 4;
        private const int DEFAULT_LUCK = 4;

        private readonly HeavyJacket DEFAULT_ARMOR = new HeavyJacket("Flak Jacket", 5, 10, 0, 0);
        private readonly Gun DEFAULT_WEAPON = new Gun("Hand Cannon", 5, 1, 7, 3, 10);

        private HeavyJacket armor;
        private Gun weapon;
            
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
        public Gun Weapon
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

        //Custom Class
        public BodyGuard(string name, int level, int healthPoints, int skillPoints, Factions faction, int strength,
            int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            : base (name, level, skillPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints);
            base.SkillPoints = (level * skillPoints);
            base.Faction = faction;
            
            base.Strength = level * strength;
            base.Perception = level * perception;
            base.Endurance = level * endurance;
            base.Charisma = level * charisma;
            base.Intelligence = level * intelligence;
            base.Agility = level * agility;
            base.Luck = level * luck;
            
            base.BodyArmor = armor;
            base.WeaponType = weapon;
            
            base.Damage = (level * strength * base.WeaponType.WeaponDamage);
            base.Defense = (level * endurance * base.BodyArmor.ArmorRating);
            base.Speed = (level * agility * base.WeaponType.WeaponSpeed);
        }

       

       //Default Class
        public BodyGuard()
        {
            {
                base.Level = DEFAULT_LUCK;
                base.Name = DEFAULT_NAME;
                base.HealthPoints = (DEFAULT_LEVEL * DEFAULT_HEALTH_POINTS);
                base.SkillPoints = (DEFAULT_LEVEL * DEFAULT_SKILL_POINTS);
                base.Faction = DEFAULT_FACTION;

                base.Strength = DEFAULT_LEVEL * DEFAULT_STRENGTH;
                base.Perception = DEFAULT_LEVEL * DEFAULT_PERCEPTION;
                base.Endurance = DEFAULT_LEVEL * DEFAULT_ENDURANCE;
                base.Charisma = DEFAULT_LEVEL * DEFAULT_CHARISMA;
                base.Intelligence = DEFAULT_LEVEL * DEFAULT_INTELLIGENCE;
                base.Agility = DEFAULT_LEVEL * DEFAULT_AGILITY;
                base.Luck = DEFAULT_LEVEL * DEFAULT_LUCK;

                base.BodyArmor = DEFAULT_ARMOR;
                base.WeaponType = DEFAULT_WEAPON;

                base.Damage = (DEFAULT_LEVEL * DEFAULT_STRENGTH * this.DEFAULT_WEAPON.WeaponDamage);
                base.Defense = (DEFAULT_LEVEL * DEFAULT_ENDURANCE * this.DEFAULT_ARMOR.ArmorRating);
                base.Speed = (DEFAULT_LEVEL * DEFAULT_AGILITY * this.DEFAULT_WEAPON.WeaponSpeed);
            }
        }

        //Semi-Custom Class
        public BodyGuard(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            base.SkillPoints = (level * DEFAULT_SKILL_POINTS);
            base.Faction = faction;

            base.Strength = level * DEFAULT_STRENGTH;
            base.Perception = level * DEFAULT_PERCEPTION;
            base.Endurance = level * DEFAULT_ENDURANCE;
            base.Charisma = level * DEFAULT_CHARISMA;
            base.Intelligence = level * DEFAULT_INTELLIGENCE;
            base.Agility = level * DEFAULT_AGILITY;
            base.Luck = level * DEFAULT_LUCK;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (base.Strength + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (base.Endurance + this.DEFAULT_ARMOR.ArmorRating);
            base.Speed = (level * DEFAULT_AGILITY * this.DEFAULT_WEAPON.WeaponSpeed);
        }
        public int HeavyAttack()
        {
            return base.WeaponType.WeaponDamage;
        }
        public int StunAttack()
        {
            return base.WeaponType.WeaponDamage;

        }

        public int HarderArmor()
        {
            return base.BodyArmor.WeaponDefense;
        }

        public override int Attack()
        {
            return this.HeavyAttack();
        }
        public override int SpecialAttack()
        {
            return this.StunAttack();
        }
        public override int Defend()
        {
            return this.HarderArmor();
        }
    }
}

