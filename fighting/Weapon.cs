public class weapon
{
    public string name;

    public int dmg;

    Random generator = new Random();

    public int damageAmount()
    {
        return generator.Next(dmg-10, dmg+10);
    }
}
