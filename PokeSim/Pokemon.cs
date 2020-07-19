// Name: Georgina Chew
// Admin No: 180954W

using System;

namespace PokeSim {
    // TODO for Part 1
     class Pokemon
    {
        private string name;
        private int hp;
        private double exp;

        public Pokemon(string name)
        {
            this.name = name;
            this.hp = 100;
            this.exp = 0;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Hp
        {
            get { return this.hp; }
            set { this.hp = value; }
        }
        public double Exp
        {
            get { return this.exp; }
            set { this.exp = value; }
        }
        public virtual void Evolve()
        {
            Console.WriteLine("");
        }
    }
    interface Normal {
        public void Runaway();
    }
    interface Electric {
        public void Thunderbolt(Pokemon target);
    }
    class Pikachu : Pokemon, Normal, Electric
    {
        public Pikachu(string name) : base(name) {}
        public void Runaway() {
            Console.Write($"{this.Name} is running away!\n");
        }
        public void Thunderbolt(Pokemon target) {
            Console.Write("Pikaaachuuu\n");
            target.Hp = target.Hp - 10;
            if (target.Hp < 0) {
                target.Hp = 0;
            }
            this.Exp = this.Exp + 10;
        }
        public override void Evolve()
        {
            if (this.Exp >= 20) {
                Console.Write($"{this.Name} has evolved into Raichu!\n");
            } else {
                Console.Write($"{this.Name} is trying to evolve into Raichu.\n");
            }
        }
    }
    class Eevee : Pokemon, Normal
    {
        public Eevee(string name) : base(name) {}
        public void Runaway() {
            Console.Write($"{this.Name} tries to exit the battle.\n");
        }
        public override void Evolve() 
        {
            // var evolved_form = new List<string> {"Vaporeon", "Leafeon", "Espeon", "Umbreon", "Sylveon", " Flareon", "Jolteon"};
            string [] forms = {"Vaporeon", "Leafeon", "Espeon", "Umbreon", "Sylveon", "Flareon", "Jolteon"};
            Random random = new Random();
            int r = random.Next(0, 7);
            string evolved_form = forms[r];

            Console.Write($"{this.Name} is evolving into {evolved_form}!\n");
        }
    }
}