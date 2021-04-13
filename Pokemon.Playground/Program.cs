using System;
using Pokedex.Backend.Models;
using Pokedex.Backend.Data;
using Pokedex.Backend.Repo;
namespace Pokedex.Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            PokeData pd = new PokeData();
            GetPoke(pd,"1").Display();
        }
        private static Pokemon GetPoke(IPokeRepository poke, string name)
        {
            return poke.GetPokemon(name).Result;
        }
    }
}
