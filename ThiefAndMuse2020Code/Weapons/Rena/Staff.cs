using System;

namespace ThiefAndMuses2020Code.Weapons.Rena
{
    public class Staff
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
                return armorRating;
            }
            set
            {
                {
                    if (value < 0)
                    {
                        System.Console.WriteLine("Inappropriate value! Armor Rating cannot be less than 0. Default set to 0.");
                        armorRating = 0;
                    }
                    else
                    {
                        armorRating = value;
                    }
                }
            }
        }
        public int WeaponRating
        {
            get
            {
                return weaponRating;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Weapon Rating cannot be less than 0. Default set to 0.");
                    weaponRating = 0;
                }
                else
                {
                    weaponRating = value;
                }
            }
        }
        public int MagickRating
        {
            get
            {
                return magickRating;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Magick Rating cannot be less than 0. Default set to 0.");
                    magickRating = 0;
                }
                else
                {
                    magickRating = value;
                }
            }

        }
        public int WeaponDamage
        {
            get
            {
                return weaponDamage;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Weapon Damage cannot be less than 0. Default set to 0.");
                    weaponDamage = 0;
                }
                else
                {
                    weaponDamage = value;
                }
            }
        }
        public int WeaponDefense
        {
            get
            {
                return weaponDefense;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Weapon Defense cannot be less than 0. Default set to 0.");
                    weaponDefense = 0;
                }
                else
                {
                    weaponDefense = value;
                }
            }
        }
        public int MagickDamage
        {
            get
            {
                return magickDamage;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Magick Damage cannot be less than 0. Default set to 0.");
                    magickDamage = 0;
                }
                else
                {
                    magickDamage = value;
                }
            }
        }
        public int MagickDefense
        {
            get
            {
                return magickDefense;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Magick Defense cannot be less than 0. Default set to 0.");
                    magickDefense = 0;
                }
                else
                {
                    magickDefense = value;
                }
            }
        }
        public int WeaponSpeed
        {
            get
            {
                return weaponSpeed;
            }
            set
            {
                if (value < 0)
                {
                    System.Console.WriteLine("Inappropriate value! Weapon Speed cannot be less than 0. Default set to 0.");
                    weaponSpeed = 0;
                }
                else
                {
                    weaponSpeed = value;
                }
            }
        }


        public Staff(int armorRating, int weaponRating, int magickRating, int weaponDamage, int weaponDefense, int magickDamage, int magickDefense, int weaponSpeed)
        {
            ArmorRating = armorRating;
            WeaponRating = weaponRating;
            MagickRating = magickRating;
            WeaponDamage = weaponRating * weaponDamage;
            WeaponDefense = armorRating * weaponDefense;
            MagickDamage = magickRating * magickDamage;
            MagickDefense = magickRating * magickDefense;
            WeaponSpeed = weaponRating * weaponSpeed;
        }
        public void HealTeam()
        {
            throw new NotImplementedException();
        }
        public void SpellAttackEnemyTeam()
        {
            throw new NotImplementedException();
        }
    }
}
