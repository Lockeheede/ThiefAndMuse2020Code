namespace ThiefAndMuse2020Code.Characters.Body_Characters
{
    using ThiefAndMuse2020Code.Enumerations;
    using ThiefAndMuse2020Code.Armor.Medium;
    using ThiefAndMuse2020Code.Weapons.Renaissance;
    public class Rebel : Body
    {
        private readonly LeatherVest DEFAULT_ARMOR = new LeatherVest("Rebellion Coat", 1, 3);
        private readonly Sword DEFAULT_WEAPON = new Sword("Steel Sword", 3, 2);

        private LeatherVest armor;
        private Sword weapon;
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
        public Sword Weapon
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
        public Rebel()
        {
            base.Level = Consts.Rebel.LEVEL;
            base.Name = Consts.Rebel.NAME;
            base.HealthPoints = (Consts.Rebel.LEVEL * Consts.Rebel.HEALTH_POINTS);
            base.SkillPoints = (Consts.Rebel.LEVEL * Consts.Rebel.SKILL_POINTS);
            base.Faction = Consts.Rebel.FACTION;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (Consts.Rebel.LEVEL * this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (Consts.Rebel.LEVEL * this.DEFAULT_ARMOR.ArmorRating);

            base.IsAlive = true;
            base.Scores = 0;
        }
        
        //Custom Class
        public Rebel(string name, int level, int healthPoints, int skillPoints, Factions faction)
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
        public Rebel(string name, int level, Factions faction)
        {
            base.Level = level;
            base.Name = name;
            base.HealthPoints = (level * Consts.Rebel.HEALTH_POINTS);
            base.SkillPoints = (level * Consts.Rebel.SKILL_POINTS);
            base.Faction = faction;

            base.BodyArmor = DEFAULT_ARMOR;
            base.WeaponType = DEFAULT_WEAPON;

            base.Damage = (level + this.DEFAULT_WEAPON.WeaponDamage);
            base.Defense = (level + this.DEFAULT_ARMOR.WeaponDefense);

            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Headbutt()
        {
            return base.WeaponType.WeaponDamage + Damage;
        }
        public int BoostInjection()
        {
            return base.BodyArmor.WeaponDefense + Defense;
        }
        public int Kamikaze()
        {
            return base.WeaponType.WeaponDamage + Damage + 10;
        }

        public override int Attack()
        {
            return this.Headbutt();
        }
        public override int SpecialAttack()
        {
            return this.Kamikaze();
        }
        public override int Defend()
        {
            return this.BoostInjection();
        }
    }
}