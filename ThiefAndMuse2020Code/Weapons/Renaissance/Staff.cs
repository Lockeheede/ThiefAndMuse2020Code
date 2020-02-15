using System;
using ThiefAndMuse2020Code.Weapons.Renaissance;

namespace ThiefAndMuses2020Code.Weapons.Renaissance
{
    public class Staff : DarkAge
    {
        public Staff(string weaponName, int armorRating, int weaponRating, int magickRating, int weaponDamage, int weaponDefense, int magickDamage, int magickDefense, int weaponSpeed)
            :base(weaponName)
        {
            this.ArmorRating = armorRating;
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDamage = magickRating * magickDamage;
            this.MagickDefense = magickRating * magickDefense;
            this.WeaponSpeed = weaponRating * weaponSpeed;
        }
        public void HealTeam()
        {
            throw new NotImplementedException();
        }
        public void SpellAttackEnemyTeam()
        {
            throw new NotImplementedException();
        }
    }
}
