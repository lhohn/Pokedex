using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Pokedex.Backend.Models;

namespace Pokedex.Backend.Repo
{
      public interface IPokeRepository
    {
          

        Task<Pokemon> GetPokemon(string name);
        Task<List<Pokemon>> GetAll();

    }
}
