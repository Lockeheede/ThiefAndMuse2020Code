using System;
using ThiefAndMuse2020Code.Characters;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiefAndMuse2020Code
{
    public static class Tools
    {
        public static void ColorfulWriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void TypeSpecificColorfulCW(string message, string type)
        {
            ConsoleColor color = ConsoleColor.White;

            switch (type)
            {
                case "ThiefAndMuse2020Code.Characters.Body_Characters.Bodyguard":
                    color = ConsoleColor.DarkBlue;
                    break;
                case "ThiefAndMuse2020Code.Characters.Body_Characters.Rebel":
                    color = ConsoleColor.DarkRed;
                    break;
                case "ThiefAndMuse2020Code.Characters.Body_Characters.Thief":
                    color = ConsoleColor.Gray;
                    break;
                case "ThiefAndMuse2020Code.Characters.Mind_Characters.Code":
                    color = ConsoleColor.DarkCyan;
                    break;
                case "ThiefAndMuse2020Code.Characters.Spirit_Characters.Sage":
                    color = ConsoleColor.Yellow;
                    break;
                case "ThiefAndMuse2020Code.Characters.Spirit_Characters.Muse":
                    color = ConsoleColor.Green;
                    break;
                default:
                    color = ConsoleColor.White;
                    break;

            }


        }


    }

}