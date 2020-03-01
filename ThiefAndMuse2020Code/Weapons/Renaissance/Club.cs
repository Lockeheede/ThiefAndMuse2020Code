using System;

namespace ThiefAndMuse2020Code.Weapons.Renaissance
{
    public class Club : DarkAge
    {
        public Club(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }

        public void Smash()
        {
            throw new NotImplementedException();
        }
    }
}
*/