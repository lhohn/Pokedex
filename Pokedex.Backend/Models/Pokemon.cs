using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using LitJson;

namespace Pokedex.Backend.Models
{
    public class Pokemon
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BaseExperience { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<PokemonAbility> Abilities { get; set; }
        //public List<Sprite> Sprites { get; set; }
        public Sprites Sprites { get; set; }
        /*public class Sprite
        {
            
           

        }*/

       
        public void Display()
        {
            Console.WriteLine($"Your Pokemon is:{Name} ");
        }
    }
    public struct Sprites
    {
       [JsonPropertyName("back_default")]
        public string Back_Default { get; set; }
        [JsonPropertyName("back_female")]
        public string Back_Female { get; set; }
        [JsonPropertyName("back_shiny")]
        public string Back_Shiny { get; set; }
        [JsonPropertyName("back_shiny_female")]
        public string Back_Shiny_Female { get; set; }
        [JsonPropertyName("front_default")]
        public string Front_Default { get; set; }
        [JsonPropertyName("front_shiny")]
        public string Front_Shiny { get; set; }
    }
}
