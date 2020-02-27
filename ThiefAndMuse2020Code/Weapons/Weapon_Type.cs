using System;

namespace ThiefAndMuse2020Code.Weapons
{
    public abstract class Weapon_Type
    {
        private string weaponName;
        private int weaponRating;
        private int weaponDamage;

        public string WeaponName
        {
            get
            {
                return this.weaponName;
            }
            set
            {
                if (value.Length < 2)
                {
                    this.weaponName = "CPU";
                    Console.WriteLine($"Invalid value! Weapon name default to: " + this.weaponName);
                }
                else
                {
                    this.weaponName = value;
                }
            }
        }
        public int WeaponRating
        {
            get
            {
                return this.weaponRating;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Weapon Rating cannot be less than 0. Default set to 0.");
                    this.weaponRating = 0;
                }
                else
                {
                    this.weaponRating = value;
                }
            }
        }
        public int WeaponDamage
        {
            get
            {
                return this.weaponDamage;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Weapon Damage cannot be less than 0. Default set to 0.");
                    this.weaponDamage = 0;
                }
                else
                {
                    this.weaponDamage = value;
                }
            }
        }

        public Weapon_Type(string weaponName)
        {
            this.WeaponName = weaponName;
        }
    }
}
