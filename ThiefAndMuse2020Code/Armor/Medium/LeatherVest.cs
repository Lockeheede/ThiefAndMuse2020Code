using System;
using ThiefAndMuse2020Code.Armor.Medium;

namespace ThiefAndMuses2020Code.Armor.Medium
{
    public class LeatherVest : Medium_Armor
    {
        public LeatherVest(string armorName, int armorRating, int weaponDefense, int magickRating, int magickDefense)
            :base(armorName)
        {
            this.ArmorRating = armorRating;
            this.MagickRating = magickRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDefense = magickRating * magickDefense;
        }
        public void Quickness()
        {
            throw new NotImplementedException();
        }

        public void Blend()
        {
            throw new NotImplementedException();
        }

    }
}
