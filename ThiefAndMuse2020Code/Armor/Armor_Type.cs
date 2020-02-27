using System;

namespace ThiefAndMuse2020Code.Armor
{
    public abstract class Armor_Type
    {
        private string armorName;
        private int armorRating;
        private int weaponDefense;

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
                    this.armorName = "Armor";
                    Console.WriteLine($"Invalid value! Weapon name default to: " + this.armorName);
                }
                else
                {
                    this.armorName = value;
                }
            }
        }
        public int ArmorRating
        {
            get
            {
                return this.armorRating;
            }
            set
            {
                {
                    if (value < 0)
                    {
                        Console.WriteLine("Inappropriate value! Armor Rating cannot be less than 0. Default set to 0.");
                        this.armorRating = 0;
                    }
                    else
                    {
                        this.armorRating = value;
                    }
                }
            }
        }
        public int WeaponDefense
        {
            get
            {
                return this.weaponDefense;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Weapon Defense cannot be less than 0. Default set to 0.");
                    this.weaponDefense = 0;
                }
                else
                {
                    this.weaponDefense = value;
                }
            }
        }

        public Armor_Type(string armorName)
        {
            this.ArmorName = armorName;
        }

    }
}
