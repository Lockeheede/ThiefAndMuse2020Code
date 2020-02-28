using System;
using ThiefAndMuse2020Code.Armor.Heavy;

namespace ThiefAndMuse2020Code.Armor.Heavy
{
    public class HeavyJacket : Heavy_Armor
    {
       public HeavyJacket(string armorName, int armorRating, int weaponDefense)
            :base(armorName)
       {
            this.ArmorName = armorName;
            this.ArmorRating = armorRating;
            this.WeaponDefense = weaponDefense;
       }

        public void Constitution()
        {
            throw new NotImplementedException();

        }
    }
}