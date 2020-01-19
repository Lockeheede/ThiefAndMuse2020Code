public class Thief
{
    private string name;
    private int level;
    private int healthPoints;
    private int chiPoints;
    private string faction;

    private int strength;
    private int perception;
    private int endurance;
    private int charisma;
    private int intelligence;
    private int agility;
    private int luck;

    private LeatherVest apparel;
    private Dagger weapon;

    private int damage;
    private int defense;
    private int speed;
    private int magick;

    public string Name { get; set; }
    public int Level { get; set; }
    public int HealthPoints { get; set; }
    public int ChiPoints { get; set; }
    public string Faction { get; set; }
    public int Strength { get; set; }
    public int Perception { get; set; }
    public int Endurance { get; set; }
    public int Charisma { get; set; }
    public int Intelligence { get; set; }
    public int Agility { get; set; }
    public int Luck { get; set; }
    public LeatherVest Apparel { get; set; }
    public Dagger Weapon { get; set; }

    public int Damage { get; set; }
    public int Defense { get; set; }
    public int Speed { get; set; }
    public int Magick { get; set; }

    public Thief(string name, int level, int healthPoints, int chiPoints, string faction, int strength,
      int perception, int endurance, int charisma, int intelligence, int agility, int luck, LeatherVest apparel, Dagger weapon,
      int damage, int defense, int speed, int magick)
    {
        Level = level;
        Name = name;
        HealthPoints = (level * healthPoints) + (level * endurance);
        ChiPoints = (level * chiPoints) + (level * intelligence);
        Faction = faction;

        Strength = level * strength;
        Perception = level * perception;
        Endurance = level * endurance;
        Charisma = level * charisma;
        Intelligence = level * intelligence;
        Agility = level * agility;
        Luck = level * luck;

        Apparel = apparel;
        Weapon = weapon;

        Damage = (level * damage) + (level * strength);
        Defense = (level * defense) + (level * endurance);
        Speed = (level * speed) + (level * agility);
        Magick = (level * intelligence) + (level * perception);
    }

    public void Steal()
    {

    }
    public void Attack()
    {

    }
    public void Dodge()
    {

    }
        
}

