using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Pokedex.Backend.Models;
using Pokedex.Backend.Repo;


namespace Pokedex.Backend.Data
{
    public class PokeData : IPokeRepository
    {
        private static string apiUrl = @"https://pokeapi.co/api/v2/pokemon/";
        static HttpClient client;

         public PokeData()
        {
            Console.WriteLine("Conncting to pokeapi...");
            client = new HttpClient();
        }
        public Task<List<Pokemon>> GetAll()
        {
            throw new NotImplementedException();
        }

      

        public async Task<Pokemon> GetPokemon(string name)
        {
            Pokemon pokemon = null;
            var response = await client.GetAsync(apiUrl + name);
            if (response.IsSuccessStatusCode)
            {
                
                pokemon = await response.Content.ReadAsAsync<Pokemon>();
                Console.WriteLine("Requested the api...");
            }
            return pokemon;
        }
    }
}
