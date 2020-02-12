
using System;

namespace ThiefAndMuses2020Code.Weapons.Modern
{

    public class Padlocke
    { 
        private string weaponName;
        private int weaponRating;
        private int magickRating;
        private int weaponDamage;
        private int magickDamage;
        private int weaponSpeed;

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
                    this.weaponName = "The Padlocke";
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
        public int MagickRating
        {
            get
            {
                return this.magickRating;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Magick Rating cannot be less than 0. Default set to 0.");
                    this.magickRating = 0;
                }
                else
                {
                    this.magickRating = value;
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
        public int MagickDamage
        {
            get
            {
                return this.magickDamage;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Magick Damage cannot be less than 0. Default set to 0.");
                    this.magickDamage = 0;
                }
                else
                {
                    this.magickDamage = value;
                }
            }
        }
        public int WeaponSpeed
        {
            get
            {
                return this.weaponSpeed;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Weapon Speed cannot be less than 0. Default set to 0.");
                    this.weaponSpeed = 0;
                }
                else
                {
                    this.weaponSpeed = value;
                }
            }
        }

        public Padlocke(string weaponName, int weaponRating, int magickRating, int weaponDamage, int magickDamage, int weaponSpeed)
        {
            this.WeaponName = weaponName;
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.MagickDamage = magickRating * magickDamage;
            this.WeaponSpeed = weaponRating * weaponSpeed;
        }
        public void Sensor()
        {
            throw new NotImplementedException();
        }
        public void Mapper()
        {
            throw new NotImplementedException();
        }
        public void Hacker()
        {
            throw new NotImplementedException();
        }
    }
}

