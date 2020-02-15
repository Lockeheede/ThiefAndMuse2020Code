using System;
using ThiefAndMuse2020Code.Weapons.Modern;

namespace ThiefAndMuses2020Code.Weapons.Modern
{
    public class Gun : NewAge
    {

        public Gun(string weaponName, int weaponRating, int magickRating, int weaponDamage, int magickDamage, int weaponSpeed)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.MagickDamage = magickRating * magickDamage;
            this.WeaponSpeed = weaponRating * weaponSpeed;
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