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
        private const int DEFAULT_HEALTH_POINTS = 25;
        private const int DEFAULT_CHI_POINTS = 10;
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

        public Sage(string name, int level, int healthPoints, int chiPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            : base(name, level, chiPoints)
        {
            this.Level = level;
            this.Name = name;
            this.HealthPoints = (level * healthPoints) + (level * endurance);
            this.ChiPoints = (level * chiPoints) + (level * intelligence);
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
            this.Magick = (level * intelligence) + (level * perception);
        }



        public Sage()
        {
            this.Level = DEFAULT_LUCK;
            this.Name = DEFAULT_NAME;
            this.HealthPoints = (DEFAULT_LUCK * DEFAULT_HEALTH_POINTS);
            this.ChiPoints = (DEFAULT_LUCK * DEFAULT_CHI_POINTS);
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
    


        public void ChiHeal()
        {
            throw new NotImplementedException();
        }
        public void ChiBooster()
        {
            throw new NotImplementedException();
        }

        public void ChiShot()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ChiShot();
        }
        public override void SpecialAttack()
        {
            this.ChiHeal();
        }
        public override void Defend()
        {
            this.ChiBooster();
        }
    }
}

