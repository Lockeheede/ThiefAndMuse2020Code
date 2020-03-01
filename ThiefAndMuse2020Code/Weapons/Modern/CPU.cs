using System;

namespace ThiefAndMuse2020Code.Weapons.Modern
{
    public class CPU : NewAge
    {
        public CPU(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;           
            this.WeaponDamage = weaponDamage;
        }
        public void Program()
        {
            throw new NotImplementedException();
        }

        public void Hack()
        {
            throw new NotImplementedException();
        }
    }
}