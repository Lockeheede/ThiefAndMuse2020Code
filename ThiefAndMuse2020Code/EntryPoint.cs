//Important note: See the classes.sln in order to see the notes made for this project. 
//More than likely you should know how things work anyway, but if you ever get lost, 
//that is the project to look for (Class.sln)
using System;
using ThiefAndMuses2020Code.Characters.Body_Characters;
using ThiefAndMuse2020Code.Characters.Mind_Characters;
using ThiefAndMuse2020Code.Characters.Spirit_Characters;
using ThiefAndMuse2020Code.Characters;
using ThiefAndMuses2020Code.Characters.Mind_Characters;
using ThiefAndMuses2020Code.Characters.Spirit_Characters;
using System.Collections.Generic;
using ThiefAndMuse2020Code.Characters.Body_Characters;

class EntryPoint
    {
    static void Main()
    {

        //Classes to make
        //Characters - Thief, Muse, Coder, BodyGuard, Sage, Rebel
        //Apparel - HeavyJacket, LeatherVest, PartyDress, CottonRobe
        //Weapons - TwentyShot, Dagger, Sword, Club, Staff, SpellBook, Padlocke, CPU, Oil
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
        ///Faction must be a Physical, Mental, or Spiritual
        ///
        ///Note for later: Simplify the code required for armor and weapons

        //To calcuate action stats, I will need to make some stats for the weapons and apparel
        //The action stats are damage, speed, magick and defense. Effected by normal stats, items and character level
        bool gameOver = false;

        Random rng = new Random();

        int currentBodyCharacter = 0;
        int currentMindCharacter = 0;
        int currentSpiritCharacter = 0;

        List<Character> characters = new List<Character>()
        {
            new BodyGuard(),
            new Rebel(),
            new Thief(),
            new Coder(),
            new Sage(),
            new Muse()
        };

        List<Body> bodyCharacters = new List<Body>();
        List<Mind> mindCharacters = new List<Mind>();
        List<Spirit> spiritCharacters = new List<Spirit>();

        foreach (var character in characters)
        {
            if(character is Body)
            {
                bodyCharacters.Add((Body)character);
            }
            else if(character is Mind)
            {
                mindCharacters.Add((Mind)character);
            }
            else if(character is Spirit)
            {
                spiritCharacters.Add((Spirit)character);
            }
        }

        while(!gameOver)
        {
            /*Psuedo Game Logic
             * 1. Select a random bodyCharacter
             * 2. Select a random spiritCharacter
             */
            currentBodyCharacter = rng.Next(0, bodyCharacters.Count);
            currentSpiritCharacter = rng.Next(0, spiritCharacters.Count);
            // 3. body attacks spirit
             
            spiritCharacters[currentSpiritCharacter].TakeDamage(bodyCharacters[currentBodyCharacter].Attack(), bodyCharacters[currentBodyCharacter].Name);
            /* 3.1 Check to see if the character is dead
             */
             if(!spiritCharacters[currentSpiritCharacter].IsAlive)
            {
                spiritCharacters.Remove(spiritCharacters[currentSpiritCharacter]);

                if (spiritCharacters.Count == 0)
                {
                    Console.WriteLine("Body over Spirit...Body team wins!");
                    break;
                }
                else
                {
                    currentSpiritCharacter = rng.Next(0, spiritCharacters.Count);
                }
            }
            /* 3.2 If dead, remove the character and replace with another random one
            * 
            * 4. spirit attacks body
            */
            bodyCharacters[currentBodyCharacter].TakeDamage(spiritCharacters[currentSpiritCharacter].Attack(), spiritCharacters[currentSpiritCharacter].Name);
            /*4.1 Check to see if the character is dead
            * 4.2 If dead, remove the character and replace with another random one
            */
            if (!bodyCharacters[currentBodyCharacter].IsAlive)
            {
                bodyCharacters.Remove(bodyCharacters[currentBodyCharacter]);

                if (bodyCharacters.Count == 0)
                {
                    Console.WriteLine("Spirit over Body...Spirit team wins!");
                    break;
                }
                else
                {
                    currentBodyCharacter = rng.Next(0, bodyCharacters.Count);
                }
            }

            /* 
            * 5. Using this logic
            * bodyCharacters[0].TakeDamage(spiritCharacters[0].Attack());
            * You can determine which character is attacking (spiritCharacters[0]) and which character
            * Is taking damage bodyCharacters[0]. The TakeDamage and Attack methods are coming from the base
            * Character class
            * 
            * 5. If there are no characters alive from either team, gameOver = true.
            * 
            * 6. (Bonus) Try to have the mindCharacter interact with a random character from either team. 
            */
        }
    }
    }

