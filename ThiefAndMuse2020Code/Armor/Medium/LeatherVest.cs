using System;
using ThiefAndMuse2020Code.Armor.Medium;

namespace ThiefAndMuses2020Code.Armor.Medium
{
    public class LeatherVest : Medium_Armor
    {
        public LeatherVest(string armorName, int armorRating, int weaponDefense)
            :base(armorName)
        {
            this.ArmorRating = armorRating;
            this.WeaponDefense = armorRating * weaponDefense;
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
