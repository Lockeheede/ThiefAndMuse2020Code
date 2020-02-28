using System;
using ThiefAndMuse2020Code.Weapons.Renaissance;

namespace ThiefAndMuse2020Code.Weapons.Renaissance
{
    public class Staff : DarkAge
    {
        public Staff(string weaponName, int weaponRating, int weaponDamage)
            :base(weaponName)
        {
            this.WeaponRating = weaponRating;
            this.WeaponDamage = weaponDamage;
        }
        public void HealTeam()
        {
            throw new NotImplementedException();
        }
        public void SpellAttackEnemyTeam()
        {
            throw new NotImplementedException();
        }
    }
}
