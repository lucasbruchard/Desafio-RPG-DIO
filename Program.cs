using desafio_rpg.src.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        ElectricPokemon pikachuEX = new ElectricPokemon (
            "Pikachu EX", 130, "Thunder Schock", "Mega Thunderbolt", 30, 160);
        WaterPokemon BlastoiseV = new WaterPokemon ("Blastoise V", 220, "Water Gun", "Torrential Cannon", 30, 200);
           
              
        Console.Write("Começa a batalha entre" + " " + pikachuEX.name + " " + "e" + " " + BlastoiseV.name);
        Console.WriteLine(" ");

       Console.WriteLine (pikachuEX.AttackElectricAgainstWater1());
      
              
    }

        
}
