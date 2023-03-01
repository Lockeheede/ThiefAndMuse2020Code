using System;

namespace ThiefAndMuse2020Code.Weapons.Renaissance
{

    public class SpellBook : DarkAge
    {
        public SpellBook(string weaponName, int weaponRating, int weaponDamage)
            : base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void LearnSpell()
        {
            throw new NotImplementedException();
        }
        public void UseSpell()
        {
            throw new NotImplementedException();
        }

        public void ThrowBook()
        {
            throw new NotImplementedException();
        }
    }

}