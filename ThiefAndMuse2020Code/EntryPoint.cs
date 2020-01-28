//Important note: See the classes.sln in order to see the notes made for this project. 
//More than likely you should know how things work anyway, but if you ever get lost, 
//that is the project to look for (Class.sln)
using System;
using ThiefAndMuses2020Code.Characters.Body;

class EntryPoint
    {
        static void Main()
        {
        //Classes to make
        //Characters - Thief, Muse, Coder, BodyGuard, Sage, Rebel
        //Apparel - HeavyJacket, LeatherVest, PartyDress, CottonRobe
        //Weapons - TwentyShot, Dagger, Sword, Club, Staff, SpellBook
        //Items/Gear - Padlocke, CPU, Oil
        /*Normal Statistics
         * Name
         * Level
         * HealthPoints
         * ChiPoints
         * Faction
         * Strength
         * Perception
         * Endurance
         * Charisma
         * Intelligence
         * Agility
         * Luck
         * Apparel
         * Weapon
         * 
         * Item Statistics
         * ArmorRating
         * WeaponDamage 
         *
         * Action Statistics
         * Damage
         * Defense
         * Magick 
         * WeaponSpeed
        */

        //Make skills for each class. Create them as methods. Make 1 offensive, 1 defensive, and 1 support skill each
        //This includes the apparel, items and weapons as well
        //Example Thief can Attack, Dodge, Steal
        //Twenty Shot can Shoot, Cover, Reload
        //Not all items, weapons, etc need three skills.

        ///Note on validation of the classes
        ///Levels should be 1 to 100. WeaponDamage and ArmorRating cannot be 0 or negative
        ///Faction must be a Reggie, Coder, Rebel, Sage or unRealistic
        ///
        ///Note for later: Simplify the code required for armor and weapons

        //To calcuate action stats, I will need to make some stats for the weapons and apparel
        //The action stats are damage, speed, magick and defense. Effected by normal stats, items and character level
        Thief playerOne = new Thief("Lockes The Thief", 1, 50, 0, "Reggie", 3, 5, 2, 7, 5, 5, 6);
        Console.WriteLine(playerOne.Name);
        }
    }

