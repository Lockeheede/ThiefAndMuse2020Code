namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
    using System;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Light;
    using ThiefAndMuse2020Code.Weapons.Modern;
    public class Muse : Spirit
    {
        private readonly PartyDress DEFAULT_ARMOR = new PartyDress("Red Silk", 5, 5);
        private readonly EssentialOil DEFAULT_WEAPON = new EssentialOil("Lavender", 3, 10);

        private PartyDress armor;
        private EssentialOil weapon;

        public PartyDress Armor
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
        public EssentialOil Weapon
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

        public Muse()
        {
            base.Level = Consts.Muse.LEVEL;
            base.Name = Consts.Muse.NAME;
            base.HealthPoints = (Consts.Muse.LEVEL * Consts.Muse.HEALTH_POINTS);
            base.EnergyPoints = (Consts.Muse.LEVEL * Consts.Muse.ENERGY_POINTS);
            base.Faction = Consts.Muse.FACTION;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (Consts.Muse.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (Consts.Muse.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }
        //Custom Class
        public Muse(string name, int level, int healthPoints, int energyPoints, Factions faction)
            : base(name, level, energyPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints);
            base.EnergyPoints = (level * energyPoints);
            base.Faction = faction;

            base.BodyArmor = armor;
            base.WeaponType = weapon;

            base.Damage = (level * base.WeaponType.WeaponDamage);
            base.Defense = (level * base.BodyArmor.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }

        //Semi-Custom Class
        public Muse(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.Muse.HEALTH_POINTS);
            base.EnergyPoints = (level * Consts.Muse.ENERGY_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level + this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }

        public int ChiBlast()
        {
            return base.WeaponType.WeaponDamage + 5;
        }
        public int ChiShield()
        {
            return base.BodyArmor.ArmorRating + 5;
        }
        public int ConsumeOil()
        {
            return base.BodyArmor.ArmorRating + 10;
        }

        public override int Attack()
        {
            return this.ChiBlast();
        }
        public override int SpecialAttack()
        {
            return this.ConsumeOil();
        }
        public override int Defend()
        {
            return this.ChiShield();
        }
    }
}