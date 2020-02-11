using System;
using ThiefAndMuse2020Code.Armor.Medium;

namespace ThiefAndMuses2020Code.Armor.Medium
{
    public class LeatherVest : Medium_Armor
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
                    this.armorName = "Leather Vest";
                    Console.WriteLine($"Invalid value! Weapon name default to: " + this.armorName);
                }
                else
                {
                    this.armorName = value;
                }
            }
        }


        public LeatherVest(string armorName, int armorRating, int weaponDefense, int magickDefense)
        {
            this.ArmorName = armorName;
            this.ArmorRating = armorRating;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDefense = armorRating * magickDefense;
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
