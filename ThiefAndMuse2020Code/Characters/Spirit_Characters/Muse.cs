/*
namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
    using System;
    using ThiefAndMuse2020Code.Characters.Spirit_Characters;
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Light;
    using ThiefAndMuse2020Code.Weapons.Modern;
    public class Muse : Spirit
    {
        private const int DEFAULT_LEVEL = 10;
        private const string DEFAULT_NAME = "Muse";
        private const int DEFAULT_HEALTH_POINTS = 50;
        private const int DEFAULT_CHI_POINTS = 50;
        private const Factions DEFAULT_FACTION = Factions.Spiritual;

        private const int DEFAULT_STRENGTH = 4;
        private const int DEFAULT_PERCEPTION = 7;
        private const int DEFAULT_ENDURANCE = 3;
        private const int DEFAULT_CHARISMA = 7;
        private const int DEFAULT_INTELLIGENCE = 7;
        private const int DEFAULT_AGILITY = 4;
        private const int DEFAULT_LUCK = 7;

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

        public Muse(string name, int level, int healthPoints, int chiPoints, Factions faction, int strength,
          int perception, int endurance, int charisma, int intelligence, int agility, int luck)
            :base(name, level, chiPoints)
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
        
        private readonly PartyDress DEFAULT_ARMOR = new PartyDress("Red Dress", 5, 5, 1, 10);
        private readonly EssentialOil DEFAULT_WEAPON = new EssentialOil("Frankincense", 5, 2, 5, 0, 10, 5, 10, 7);
        public Muse()
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

        public void ChiBlast()
        {
            throw new NotImplementedException();
        }
        public void ChiShield()
        {
            throw new NotImplementedException();
        }
        public void ConsumeOil()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            this.ChiBlast();
        }
        public override void SpecialAttack()
        {
            this.ConsumeOil();
        }
        public override void Defend()
        {
            this.ChiShield();
        }
    }
}

*/