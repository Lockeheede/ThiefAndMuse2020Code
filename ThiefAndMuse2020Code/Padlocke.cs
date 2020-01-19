public class Padlocke
{
    private int armorRating;
    private int weaponRating;
    private int magickRating;
    private int weaponDamage;
    private int weaponDefense;
    private int magickDamage;
    private int magickDefense;
    private int weaponSpeed;


    public int ArmorRating { get; set; }
    public int WeaponRating { get; set; }
    public int MagickRating { get; set; }
    public int WeaponDamage { get; set; }
    public int WeaponDefense { get; set; }
    public int MagickDamage { get; set; }
    public int MagickDefense { get; set; }
    public int WeaponSpeed { get; set; }

    public Padlocke(int armorRating, int weaponRating, int magickRating, int weaponDamage, int weaponDefense, int magickDamage, int magickDefense, int weaponSpeed)
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
    public void Sensor()
    {

    }
    public void Mapper()
    {

    }
    public void Hacker()
    {

    }
}

