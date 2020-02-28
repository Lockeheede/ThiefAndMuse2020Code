namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
    using System;
    using ThiefAndMuse2020Code;
    using ThiefAndMuse2020Code.Characters.Spirit_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Light;
    using ThiefAndMuse2020Code.Weapons.Renaissance;
    public class Sage : Spirit
    {
        private CottonRobe armor;
        private Staff weapon;

        private readonly CottonRobe DEFAULT_ARMOR = new CottonRobe("Silky Shirt", 1, 1);
        private readonly Staff DEFAULT_WEAPON = new Staff("Crystal Staff", 1, 10);

        public CottonRobe Armor
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
        public Staff Weapon
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

        public Sage()
        {
            base.Level = Consts.Sage.LEVEL;
            base.Name = Consts.Sage.NAME;
            base.HealthPoints = (Consts.Sage.LEVEL * Consts.Sage.HEALTH_POINTS);
            base.EnergyPoints = (Consts.Sage.LEVEL * Consts.Sage.ENERGY_POINTS);
            base.Faction = Consts.Sage.FACTION;

            this.BodyArmor = DEFAULT_ARMOR;
            this.WeaponType = DEFAULT_WEAPON;

            base.Damage = (Consts.Sage.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (Consts.Sage.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }
        public Sage(string name, int level, int healthPoints, int energyPoints, Factions faction)
            : base(name, level, energyPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints);
            base.EnergyPoints = (level * energyPoints);
            base.Faction = faction;

            base.BodyArmor = armor;
            base.WeaponType = weapon;

            base.Damage = (level * this.WeaponType.WeaponDamage);
            base.Defense = (level * this.BodyArmor.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }
    
        //Semi-Custom Class
        public Sage(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.Sage.HEALTH_POINTS);
            base.EnergyPoints = (level * Consts.Sage.ENERGY_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level * this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ChiBlock()
        {
            return base.BodyArmor.WeaponDefense + Defense;
        }
        public int ChiBooster()
        {
            return base.WeaponType.WeaponDamage + Damage;

        }
        public int ChiShot()
        {
            return base.WeaponType.WeaponDamage + Damage;
        }

        public override int Attack()
        {
            return this.ChiShot();
        }
        public override int SpecialAttack()
        {
            return this.ChiBlock();
        }
        public override int Defend()
        {
            return this.ChiBooster();
        }
    }
}

