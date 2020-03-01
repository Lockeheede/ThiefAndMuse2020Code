namespace ThiefAndMuse2020Code.Characters.Mind_Characters
{
    using System;
    using ThiefAndMuse2020Code.Armor.Medium;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Weapons.Modern;

    public class Coder : Mind
    {
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Hack-It Jacket", 5, 10);
        private readonly CPU DEFAULT_WEAPON = new CPU("Intent I-9", 5, 10);

        private LeatherVest armor;
        private CPU weapon;

        public LeatherVest Armor { get => this.armor; set => this.armor = value; }
        public CPU Weapon { get => this.weapon; set => this.weapon = value; }

        //Default Class
        public Coder()
        {
            base.Level = Consts.Coder.LEVEL;
            base.Name = Consts.Coder.NAME;
            base.HealthPoints = (Consts.Coder.LEVEL * Consts.Coder.HEALTH_POINTS);
            base.BrainPoints = (Consts.Coder.LEVEL * Consts.Coder.BRAIN_POINTS);
            base.Faction = Consts.Coder.FACTION;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (Consts.Coder.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (Consts.Coder.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }

        //Custom Class
        public Coder(string name, int level, int healthPoints, int brainPoints, Factions faction)
            : base(name, level, brainPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints);
            base.BrainPoints = (level * brainPoints);
            base.Faction = faction;

            base.BodyArmor = armor;
            base.WeaponType = weapon;

            base.Damage = (level * base.WeaponType.WeaponDamage);
            base.Defense = (level * base.BodyArmor.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }

        //Semi-Custom Class
        public Coder(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.Coder.HEALTH_POINTS);
            base.BrainPoints = (level * Consts.Coder.BRAIN_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level + this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Hack()
        {
            return base.WeaponType.WeaponDamage + 3;
        }
        public int Program()
        {
            return base.BodyArmor.WeaponDefense + 3;
        }
        public int Virus()
        {
            return base.WeaponType.WeaponRating + base.WeaponType.WeaponDamage;
        }
        public override int Attack()
        {
            return this.Hack();
        }
        public override int SpecialAttack()
        {
            return this.Virus();
        }
        public override int Defend()
        {
            return this.Program();
        }
    }
}