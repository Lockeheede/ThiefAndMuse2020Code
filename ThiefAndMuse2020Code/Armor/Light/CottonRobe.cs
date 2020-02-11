using System;
using ThiefAndMuse2020Code.Armor.Light;

namespace ThiefAndMuses2020Code.Armor.Light
{
    public class CottonRobe : Light_Armor
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
                    this.armorName = "Cotton Robe";
                    Console.WriteLine($"Invalid value! Weapon name default to: " + this.armorName);
                }
                else
                {
                    this.armorName = value;
                }
            }
        }
        public CottonRobe(string armorName, int armorRating, int magickRating, int weaponDefense, int magickDefense)
        {
            this.ArmorName = armorName;
            this.ArmorRating = armorRating;           
            this.MagickRating = magickRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDefense = magickRating * magickDefense;
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

