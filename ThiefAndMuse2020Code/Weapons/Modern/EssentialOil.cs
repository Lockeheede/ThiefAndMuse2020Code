using System;

namespace ThiefAndMuse2020Code.Weapons.Modern
{
    public class EssentialOil : NewAge
    {
        public EssentialOil(string weaponName, int weaponRating, int weaponDamage)
        : base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void StatBooster()
        {
            throw new NotImplementedException();
        }
        public void ChiBooster()
        {
            throw new NotImplementedException();
        }
        public void TemporaryBooster()
        {
            throw new NotImplementedException();
        }
    }
}
