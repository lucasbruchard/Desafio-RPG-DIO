namespace desafio_rpg.src.Entities
{
    public class ElectricPokemon : Pokemon
    {
        public ElectricPokemon (string name,
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
 public string AttackElectricAgainstWater1(){
    return this.name + " " + "aplicou um" + " " + this.Hability1 
    + " " + "e causou" + " " + this.Attack1Damage * 2 + " " + " de dano";
 }  

 public string AttackElectricAgainstWater2(){
    return this.name + " " + "aplicou um" + " " + this.Hability1 
    + " " + "e causou" + " " + this.Attack2Damage * 2 + " " + " de dano";
    }
    }
}