using System;
using ThiefAndMuse2020Code.Armor.Light;

namespace ThiefAndMuses2020Code.Armor.Light
{
    public class PartyDress : Light_Armor
    { 
        public PartyDress(string armorName, int armorRating, int weaponDefense, int magickRating, int magickDefense)
            :base(armorName)
        {
            this.ArmorRating = armorRating;
            this.MagickRating = magickRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDefense = magickRating * magickDefense;
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