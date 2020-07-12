// Name: Georgina Chew
// Admin No: 180954W

using System;
using System.Collections.Generic;
namespace PokeSim
{
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PokeSim!");
            // uncomment the following for testing
            
            var pikachu = new Pikachu("Pikachu");
            var eevee = new Eevee("Eevee");

            pikachu.Thunderbolt(eevee);
            pikachu.Thunderbolt(eevee);

            List<Pokemon> pokemons = new List<Pokemon>();
            pokemons.Add(pikachu);
            pokemons.Add(eevee);

            foreach (var pokemon in pokemons) {
                Console.WriteLine($"Name:{pokemon.Name},HP:{pokemon.Hp},Exp:{pokemon.Exp}");
                pokemon.Evolve();
            }

            List<Normal> normals = new List<Normal>();
            normals.Add(pikachu);
            normals.Add(eevee);
            foreach (var normal in normals) {
                normal.Runaway();
            }
            
        }
    }
}
