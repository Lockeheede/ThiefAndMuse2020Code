using System;
using ThiefAndMuse2020Code.Weapons.Modern;

namespace ThiefAndMuses2020Code.Weapons.Modern
{
    public class Gun : NewAge
    {
        public Gun(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void Shoot()
        {
            throw new NotImplementedException();
        }
        public void Reload()
        {
            throw new NotImplementedException();
        }
    }

}