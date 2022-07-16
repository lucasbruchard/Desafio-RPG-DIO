using desafio_rpg;

namespace desafio_rpg.src.Entities
{
    public abstract class Pokemon
    {
        public Pokemon (string name,
                        int HP,
                        string Hability1,
                        string Hability2,
                        int Attack1Damage,
                        int Attack2Damage)
        {
            this.name = name;
            this.HP = HP;
            this.Hability1 = Hability1;
            this.Hability2 = Hability2;
            this.Attack1Damage = Attack1Damage;
            this.Attack2Damage = Attack2Damage;
        }
        public string name;
        public int HP;
        public string Hability1;
        public string Hability2;
         public int Attack1Damage;
        public int Attack2Damage;

        // public override string ToString(){
        //     return this.HP + " " + this.Attack1 + " " + this.Attack2;

       public virtual string Attack1(){
        return this.name + " " + "aplicou um" + " " + this.Hability1 + 
        "ee causou" + " " + this.Attack1Damage + " " + " de dano";
       }
       public virtual string Attack2(){
        return this.name + " " + "aplicou um" + " " + this.Hability2 + 
        "e causou" + " " + this.Attack2Damage + " " + "de dano";

    }
    }
}