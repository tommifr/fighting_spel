Fighter fighter1 =new ();

fighter1.weapon =new();

fighter1.weapon.name = "scissors";

fighter1.weapon.dmg = 20;

Fighter fighter2 = new();

fighter2.weapon.name = "baseballbat";
fighter2.weapon.dmg= 17;


while(fighter1.hp > 0 && fighter2.hp > 0 ){
    Console.WriteLine($"Fighter one's hp is{fighter1.hp}, fighter two's hp is {fighter2.hp}");
    fighter1.attack(fighter2);

}