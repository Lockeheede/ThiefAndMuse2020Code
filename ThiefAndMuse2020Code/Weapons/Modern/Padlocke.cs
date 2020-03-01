using System;

namespace ThiefAndMuse2020Code.Weapons.Modern
{

    public class Padlocke : NewAge
    {

        public Padlocke(string weaponName, int weaponRating, int weaponDamage)
            : base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponRating * weaponDamage;
        }
        public void Sensor()
        {
            throw new NotImplementedException();
        }
        public void Mapper()
        {
            throw new NotImplementedException();
        }
        public void Reader()
        {
            throw new NotImplementedException();
        }
    }
}

*/