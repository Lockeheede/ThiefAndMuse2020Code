using System;

namespace ThiefAndMuse2020Code.Weapons.Renaissance
{
    public class Dagger : DarkAge
    {
        public Dagger(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void BackStab()
        {
            throw new NotImplementedException();
        }
    }
}