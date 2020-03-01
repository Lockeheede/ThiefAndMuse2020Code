namespace ThiefAndMuse2020Code.Characters.Body_Characters
{
    using System;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Medium;
    using ThiefAndMuse2020Code.Weapons.Renaissance;
    public class Thief : Body
    {
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Night Jacket", 1, 5);
        private readonly Dagger DEFAULT_WEAPON = new Dagger("Iron Dagger", 1, 2);

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

        //Default Class
        public Thief()
        {
            base.Level = Consts.Thief.LEVEL;
            base.Name = Consts.Thief.NAME;
            base.HealthPoints = (Consts.Thief.LEVEL * Consts.Thief.HEALTH_POINTS);
            base.SkillPoints = (Consts.Thief.LEVEL * Consts.Thief.SKILL_POINTS);
            base.Faction = Consts.Thief.FACTION;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (Consts.Thief.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (Consts.Thief.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }

        //Custom Class
        public Thief(string name, int level, int healthPoints, int skillPoints, Factions faction)
            : base(name, level, skillPoints)
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
        public Thief(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.Thief.HEALTH_POINTS);
            base.SkillPoints = (level * Consts.Thief.SKILL_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level + this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Steal()
        {
            return base.WeaponType.WeaponDamage + Damage + 2;
        }
        public int Sneak()
        {
            return base.WeaponType.WeaponDamage + Damage;
        }
        public int Dodge()
        {
            return base.BodyArmor.WeaponDefense + Defense + 2;

        }

        public override int Attack()
        {
            return this.Sneak();
        }
        public override int SpecialAttack()
        {
            return this.Steal();
        }
        public override int Defend()
        {
            return this.Dodge();
        }
    }
}
