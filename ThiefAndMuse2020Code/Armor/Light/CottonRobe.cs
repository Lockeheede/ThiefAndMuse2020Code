using System;
using ThiefAndMuse2020Code.Armor.Light;

namespace ThiefAndMuses2020Code.Armor.Light
{
    public class CottonRobe : Light_Armor
    {
        public CottonRobe(string armorName, int armorRating, int weaponDefense)
            :base(armorName)
        {
            this.ArmorRating = armorRating;           
            this.WeaponDefense = weaponDefense;
        }
        public void ChiBoost()
        {
            throw new NotImplementedException();
        }

        public void Softness()
        {
            throw new NotImplementedException();
        }
    }
}

