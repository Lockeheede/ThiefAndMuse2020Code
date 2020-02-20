

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
        private const int DEFAULT_HEALTH_POINTS = 200;
        private const int DEFAULT_SKILL_POINTS = 20;
        private const Factions DEFAULT_FACTION = Factions.Physical;

        private const int DEFAULT_STRENGTH = 7;
        private const int DEFAULT_PERCEPTION = 3;
        private const int DEFAULT_ENDURANCE = 7;
        private const int DEFAULT_CHARISMA = 2;
        private const int DEFAULT_INTELLIGENCE = 2;
        private const int DEFAULT_AGILITY = 4;
        private const int DEFAULT_LUCK = 4;

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
                     
        public BodyGuard(string name, int level, int healthPoints, int skillPoints, Factions faction, int strength,
            int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            : base (name, level, skillPoints)
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

            this.Armor = armor;
            this.Weapon = weapon;

            this.Damage = (level * strength * this.Weapon.WeaponDamage);
            this.Defense = (level * endurance * this.Armor.ArmorRating);
            this.Speed = (level * agility * this.Weapon.WeaponSpeed);
        }

       

        private readonly HeavyJacket DEFAULT_ARMOR = new HeavyJacket("Flak Jacket", 5, 10, 0, 0);
        private readonly Gun DEFAULT_WEAPON = new Gun("Hand Cannon", 5, 1, 7, 3, 10);
        public BodyGuard()
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

        public override void Attack()
        {
            this.HeavyAttack();
        }
        public override void SpecialAttack()
        {
            this.StunAttack();
        }
        public override void Defend()
        {
            this.ShockArmor();
        }
    }
}

