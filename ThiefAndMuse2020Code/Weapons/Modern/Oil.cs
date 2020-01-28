using System;

namespace ThiefAndMuses2020Code.Weapons.Modern
{
    public class Oil
    {
        private int armorRating;
        private int weaponRating;
        private int magickRating;
        private int weaponDamage;
        private int weaponDefense;
        private int magickDamage;
        private int magickDefense;
        private int weaponSpeed;



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
        public int MagickDefense
        {
            get
            {
                return this.magickDefense;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Inappropriate value! Magick Defense cannot be less than 0. Default set to 0.");
                    this.magickDefense = 0;
                }
                else
                {
                    this.magickDefense = value;
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

        public Oil(int armorRating, int weaponRating, int magickRating, int weaponDamage, int weaponDefense, int magickDamage, int magickDefense, int weaponSpeed)
        {
            this.ArmorRating = armorRating;
            this.WeaponRating = weaponRating;
            this.MagickRating = magickRating;
            this.WeaponDamage = weaponRating * weaponDamage;
            this.WeaponDefense = armorRating * weaponDefense;
            this.MagickDamage = magickRating * magickDamage;
            this.MagickDefense = magickRating * magickDefense;
            this.WeaponSpeed = weaponRating * weaponSpeed;
        }
        public void StatBooster()
        {
            throw new NotImplementedException();
        }
        public void ChiBooster()
        {
            throw new NotImplementedException();
        }
        public void TemporaryBooster()
        {
            throw new NotImplementedException();
        }
    }
}
