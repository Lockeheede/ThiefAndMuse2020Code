using System;
using ThiefAndMuse2020Code.Armor.Heavy;

namespace ThiefAndMuses2020Code.Armor.Heavy
{
    public class HeavyJacket : Heavy_Armor
    {
        private string armorName;
        public string ArmorName
        {
            get
            {
                return this.armorName;
            }
            set
            {
                if (value.Length < 2)
                {
                    this.armorName = "Heavy Jacket";
                    Console.WriteLine($"Invalid value! Weapon name default to: " + this.armorName);
                }
                else
                {
                    this.armorName = value;
                }
            }
        }
        public HeavyJacket(string armorName, int armorRating, int weaponDefense, int magickDefense)
        {
            this.ArmorName = armorName;
            this.ArmorRating = armorRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDefense = magickDefense;
        }

        public void Constitution()
        {
            throw new NotImplementedException();

        }
    }
}