using System;
using ThiefAndMuse2020Code.Armor.Heavy;

namespace ThiefAndMuses2020Code.Armor.Heavy
{
    public class HeavyJacket : Heavy_Armor
    {
       public HeavyJacket(string armorName, int armorRating, int weaponDefense, int magickRating, int magickDefense)
            :base(armorName)
        {
            this.ArmorName = armorName;
            this.ArmorRating = armorRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickRating = magickRating;
            this.MagickDefense = magickRating * magickDefense;
        }

        public void Constitution()
        {
            throw new NotImplementedException();

        }
    }
}