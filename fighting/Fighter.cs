public class Fighter
{
    public string name;


    public weapon weapon;

   public int hp = 100;

   public void attack(Fighter target)
   {
    int dmg = weapon.damageAmount();
    target.hp -=dmg;
   }
}