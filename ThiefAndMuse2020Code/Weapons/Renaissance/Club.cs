using System;
using ThiefAndMuse2020Code.Weapons.Renaissance;

namespace ThiefAndMuses2020Code.Weapons.Renaissance
{
    public class Club : DarkAge
    {
        public Club(string weaponName, int weaponRating, int magickRating, int weaponDamage, int magickDamage, int weaponSpeed)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.MagickDamage = magickRating * magickDamage;
            this.WeaponSpeed = weaponRating * weaponSpeed;
        }

        public void Smash()
        {
            throw new NotImplementedException();
        }
    }
}
