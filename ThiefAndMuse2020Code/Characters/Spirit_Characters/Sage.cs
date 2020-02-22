namespace ThiefAndMuses2020Code.Characters.Spirit_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Spirit_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuses2020Code.Armor.Light;
    using ThiefAndMuses2020Code.Weapons.Renaissance;
    public class Sage : Spirit
    {
        private const int DEFAULT_LEVEL = 5;
        private const string DEFAULT_NAME = "Sage";
        private const int DEFAULT_HEALTH_POINTS = 250;
        private const int DEFAULT_ENERGY_POINTS = 10;
        private const Factions DEFAULT_FACTION = Factions.Spiritual;

        private const int DEFAULT_STRENGTH = 2;
        private const int DEFAULT_PERCEPTION = 6;
        private const int DEFAULT_ENDURANCE = 3;
        private const int DEFAULT_CHARISMA = 6;
        private const int DEFAULT_INTELLIGENCE = 6;
        private const int DEFAULT_AGILITY = 4;
        private const int DEFAULT_LUCK = 5;

        private CottonRobe armor;
        private Staff weapon;

        private readonly CottonRobe DEFAULT_ARMOR = new CottonRobe("Silky Shirt", 1, 5, 7, 10);
        private readonly Staff DEFAULT_WEAPON = new Staff("Oak Staff", 1, 2, 5, 4, 2, 6, 6, 3);

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

        public Sage(string name, int level, int healthPoints, int energyPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            : base(name, level, energyPoints)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * healthPoints) + (level * endurance);
            base.EnergyPoints = (level * energyPoints) + (level * intelligence);
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

            base.Damage = (level * strength * this.WeaponType.WeaponDamage);
            base.Defense = (level * endurance * this.BodyArmor.ArmorRating);
            base.Speed = (level * agility * this.WeaponType.WeaponSpeed);
            base.Magick = (level * intelligence) + (level * perception);
        }



        public Sage()
        {
            base.Level = DEFAULT_LUCK;
            base.Name = DEFAULT_NAME;
            base.HealthPoints = (DEFAULT_LEVEL * DEFAULT_HEALTH_POINTS);
            base.EnergyPoints = (DEFAULT_LEVEL * DEFAULT_ENERGY_POINTS);
            base.Faction = DEFAULT_FACTION;

            base.Strength = DEFAULT_LEVEL * DEFAULT_STRENGTH;
            base.Perception = DEFAULT_LEVEL * DEFAULT_PERCEPTION;
            base.Endurance = DEFAULT_LEVEL * DEFAULT_ENDURANCE;
            base.Charisma = DEFAULT_LEVEL * DEFAULT_CHARISMA;
            base.Intelligence = DEFAULT_LEVEL * DEFAULT_INTELLIGENCE;
            base.Agility = DEFAULT_LEVEL * DEFAULT_AGILITY;
            base.Luck = DEFAULT_LEVEL * DEFAULT_LUCK;

            this.BodyArmor = DEFAULT_ARMOR;
            this.WeaponType = DEFAULT_WEAPON;

            base.Damage = (DEFAULT_LEVEL * DEFAULT_STRENGTH * this.DEFAULT_WEAPON.MagickDamage);
            base.Defense = (DEFAULT_LEVEL * DEFAULT_ENDURANCE * this.DEFAULT_ARMOR.ArmorRating);
            base.Speed = (DEFAULT_LEVEL * DEFAULT_AGILITY * this.DEFAULT_WEAPON.WeaponSpeed);
        }

        public Sage(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * DEFAULT_HEALTH_POINTS);
            base.EnergyPoints = (level * DEFAULT_ENERGY_POINTS);
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

            base.Damage = (base.Intelligence + this.DEFAULT_WEAPON.MagickDamage);
            base.Defense = (base.Endurance + this.DEFAULT_ARMOR.ArmorRating);
            base.Speed = (level * DEFAULT_AGILITY * this.DEFAULT_WEAPON.WeaponSpeed);
        }

        public int ChiBlock()
        {
            return base.BodyArmor.WeaponDefense;
        }
        public int ChiBooster()
        {
            return base.WeaponType.WeaponDamage;

        }

        public int ChiShot()
        {
            return base.WeaponType.MagickDamage;
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

