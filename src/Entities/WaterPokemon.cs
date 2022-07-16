namespace desafio_rpg.src.Entities
{
    public class WaterPokemon : Pokemon
    {
      public WaterPokemon (string name,
                           int HP,
                           string Hability1,
                           string Hability2,
                           int Attack1Damage,
                           int Attack2Damage
                           ) : base (name, HP, Hability1, Hability2, Attack1Damage, Attack2Damage)
        {
            this.name = name;
            this.HP = HP;
            this.Hability1 = Hability1;
            this.Hability2 = Hability2; 
            this.Attack1Damage = Attack1Damage; 
            this.Attack2Damage = Attack2Damage;
            
        }

    
       
    }
}