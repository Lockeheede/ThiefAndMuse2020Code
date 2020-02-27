

namespace ThiefAndMuses2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code;
    using ThiefAndMuse2020Code.Characters.Body_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Armor.Heavy;
    using ThiefAndMuses2020Code.Weapons.Modern;
    public class BodyGuard : Body
    { 

        private readonly HeavyJacket DEFAULT_ARMOR = new HeavyJacket("Flak Jacket", 1, 5);
        private readonly Gun DEFAULT_WEAPON = new Gun("Hand Cannon", 1, 5);

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

        //Default Class
        public BodyGuard()
        {
            {
                base.Level = Consts.BodyGuard.LEVEL;
                base.Name = Consts.BodyGuard.NAME;
                base.HealthPoints = (Consts.BodyGuard.LEVEL * Consts.BodyGuard.HEALTH_POINTS);
                base.SkillPoints = (Consts.BodyGuard.LEVEL * Consts.BodyGuard.SKILL_POINTS);
                base.Faction = Consts.BodyGuard.FACTION;

                base.BodyArmor = DEFAULT_ARMOR;
                base.WeaponType = DEFAULT_WEAPON;

                base.Damage = (Consts.BodyGuard.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
                base.Defense = (Consts.BodyGuard.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

                base.IsAlive = true;
                base.Scores = 0;
            }
        }
        //Custom Class
        public BodyGuard(string name, int level, int healthPoints, int skillPoints, Factions faction)
            : base (name, level, skillPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints);
            base.SkillPoints = (level * skillPoints);
            base.Faction = faction;
                     
            base.BodyArmor = armor;
            base.WeaponType = weapon;
            
            base.Damage = (level * base.WeaponType.WeaponDamage);
            base.Defense = (level * base.BodyArmor.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }

       

       

        //Semi-Custom Class
        public BodyGuard(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.BodyGuard.HEALTH_POINTS);
            base.SkillPoints = (level * Consts.BodyGuard.SKILL_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level + this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }
        public int HeavyAttack()
        {
            return base.WeaponType.WeaponDamage + Damage;
        }
        public int StunAttack()
        {
            return base.WeaponType.WeaponDamage + Damage;

        }

        public int HarderArmor()
        {
            return base.BodyArmor.WeaponDefense + Defense;
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

