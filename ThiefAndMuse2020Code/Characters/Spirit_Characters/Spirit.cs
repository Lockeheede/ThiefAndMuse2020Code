﻿
namespace ThiefAndMuse2020Code.Characters.Spirit_Characters
{
using System;
    public class Spirit : Character
    {
        private int chiPoints;
        public int ChiPoints
        {
            get
            {
                return this.chiPoints;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Chi Points cannot be negative. Default set to 0");
                    this.chiPoints = 0;
                }
                else
                {
                    this.chiPoints = value;
                }
            }
        }

    }
}
