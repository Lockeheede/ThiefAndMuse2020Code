using System;

namespace ThiefAndMuses2020Code.Weapons.Technology
{
    public class CPU
    {
        private int weaponRating;
        private int magickRating;
        private int weaponDamage;
        private int magickDamage;
        private int weaponSpeed;


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
        public CPU(int weaponRating, int magickRating, int weaponDamage, int magickDamage, int weaponSpeed)
        {
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.MagickDamage = magickRating * magickDamage;
            this.WeaponSpeed = weaponRating * weaponSpeed;
        }
        public void Program()
        {
            throw new NotImplementedException();
        }

        public void Hack()
        {
            throw new NotImplementedException();
        }
    }

}