using Pokedex.Backend.Models;
using Pokedex.Backend.Repo;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex.Backend.Data
{
    public class RSPokeData : IPokeRepository
    {
        RestClient client;
        private static string apiUrl = @"https://pokeapi.co/api/v2/pokemon/";

        public RSPokeData()
        {
            client = new RestClient(apiUrl);
        }
        public Task<List<Pokemon>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            var request = new RestRequest(name);
            return await client.GetAsync<Pokemon>(request).ConfigureAwait(false);
        }
    }
}
