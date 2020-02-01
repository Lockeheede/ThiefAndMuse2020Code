using System;

namespace ThiefAndMuses2020Code.Apparel.Light
{
    public class PartyDress
    {
        private string armorName;
        private int armorRating;
        private int magickRating;
        private int weaponDefense;
        private int magickDefense;


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
                    this.armorName = "Party Dress";
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

        public PartyDress(string armorName, int armorRating, int magickRating, int weaponDefense, int magickDefense)
        {
            this.ArmorName = armorName;
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