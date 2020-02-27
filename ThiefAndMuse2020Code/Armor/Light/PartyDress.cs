using System;
using ThiefAndMuse2020Code.Armor.Light;

namespace ThiefAndMuses2020Code.Armor.Light
{
    public class PartyDress : Light_Armor
    { 
        public PartyDress(string armorName, int armorRating, int weaponDefense)
            :base(armorName)
        {
            this.ArmorRating = armorRating;
            this.WeaponDefense = armorRating * weaponDefense;
        }
        public void Vanish()
        {
            throw new NotImplementedException();
        }
        public void Floater()
        {
            throw new NotImplementedException();
        }
    }

}