using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;


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
        private static string path = @"C:\Users\Luis Laptop\source\repos\Pokedex.Backend\Pokedex.Backend\Data\tmp\";
        //public List<Sprite> Sprites { get; set; }
        public Sprites Sprites { get; set; }
        /*public class Sprite
        {
            
           

        }*/
      /*   public void DownloadSpite(string url)
        {
            using (WebClient client = new WebClient())
            {
                
                client.DownloadFileAsync(new Uri(url), $@"{path}{url}");
            }
        }
        public FileStream DisplaySpite(string url)
        {
            

            if (!File.Exists(path + url))
            {
                DownloadSpite(url);
            }
            return  File.Open(path + url, FileMode.Open);
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
