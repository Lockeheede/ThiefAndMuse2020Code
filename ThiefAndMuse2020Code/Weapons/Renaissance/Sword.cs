using System;

namespace ThiefAndMuse2020Code.Weapons.Renaissance
{
    public class Sword : DarkAge
    {
        public Sword(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void VerticalSlash()
        {
            throw new NotImplementedException();
        }

        public void HorizontalSlash()
        {
            throw new NotImplementedException();
        }

        public void Lunge()
        {
            throw new NotImplementedException();
        }

        public void Parry()
        {
            throw new NotImplementedException();
        }
    }
}

