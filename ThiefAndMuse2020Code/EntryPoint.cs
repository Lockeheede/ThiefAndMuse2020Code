//Important note: See the classes.sln in order to see the notes made for this project. 
//More than likely you should know how things work anyway, but if you ever get lost, 
//that is the project to look for (Class.sln)


using System;
using ThiefAndMuse2020Code.Characters.Mind_Characters;
using ThiefAndMuse2020Code.Characters.Spirit_Characters;
using ThiefAndMuse2020Code.Characters;
using System.Collections.Generic;
using ThiefAndMuse2020Code.Characters.Body_Characters;
using ThiefAndMuse2020Code.Enumerations;
using ThiefAndMuse2020Code;

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

        Body currentBodyCharacter;
        Spirit currentSpiritCharacter;

        List<Character> characters = new List<Character>()
        {
            new BodyGuard("Rufus", 2, Factions.Physical),
            new Sage("Sonya", 10, Factions.Spiritual),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            new BodyGuard(),
            
            /*new BodyGuard("Rufus", 7, Factions.Physical),
            new BodyGuard("FJ", 7, Factions.Physical),
            new BodyGuard("John", 7, Factions.Physical),
            new Sage("Sonya", 7, Factions.Spiritual),
            new Sage("Ryan", 7, Factions.Spiritual),
            new Sage("Jaime", 7, Factions.Spiritual)*/
        };

        List<Body> bodyCharacters = new List<Body>();
        //List<Mind> mindCharacters = new List<Mind>();
        List<Spirit> spiritCharacters = new List<Spirit>();

        foreach (var character in characters)
        {
            if(character is Body)
            {
                bodyCharacters.Add((Body)character);
            }
            /*else if(character is Mind)
            {
                mindCharacters.Add((Mind)character);
            }*/
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
            currentBodyCharacter = bodyCharacters[rng.Next(0, bodyCharacters.Count)];
            currentSpiritCharacter = spiritCharacters[rng.Next(0, spiritCharacters.Count)];
            // 3. body attacks spirit
             
            currentSpiritCharacter.TakeDamage(currentBodyCharacter.Attack(), 
                currentBodyCharacter.Name);
            //Eventually use a currentCharacter.GetType().ToString(); for the Tools
            /* 3.1 Check to see if the character is dead
             */
             if(!currentSpiritCharacter.IsAlive)
            {
                currentBodyCharacter.WonBattle();
                spiritCharacters.Remove(currentSpiritCharacter);

                if (spiritCharacters.Count == 0)
                {
                    Tools.ColorfulWriteLine("\nBody over Spirit...Body team wins!", ConsoleColor.Red);
                    break;
                }
                else
                {
                    currentSpiritCharacter = spiritCharacters[rng.Next(0, spiritCharacters.Count)];
                }
            }
            /* 3.2 If dead, remove the character and replace with another random one
            * 
            * 4. spirit attacks body
            */
            currentBodyCharacter.TakeDamage(currentSpiritCharacter.Attack(),
                currentSpiritCharacter.Name);
            //Eventually use the ColorfulCW Tools
            /*4.1 Check to see if the character is dead
            * 4.2 If dead, remove the character and replace with another random one
            */
            if (!currentBodyCharacter.IsAlive)
            {
                currentSpiritCharacter.WonBattle();
                bodyCharacters.Remove(currentBodyCharacter);

                if (bodyCharacters.Count == 0)
                {
                    Tools.ColorfulWriteLine("\nSpirit over Body...Spirit team wins!", ConsoleColor.Yellow);
                    break;
                }
                else
                {
                    currentBodyCharacter = bodyCharacters[rng.Next(0, bodyCharacters.Count)];
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

//TODO: Simplify the statistics. Maybe use healthpoints, damage and defense and get rid of the other things...
//Can make more advanced once I get all the numbers right. 

