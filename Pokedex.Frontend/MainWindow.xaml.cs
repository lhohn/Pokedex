using System;
using System.Collections.Generic;
using System.Windows;
using Pokedex.Backend.Models;
using Pokedex.Backend.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Controls;

namespace Pokedex.Frontend
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Pokemon> pm = new List<Pokemon>();

        public MainWindow()
        {
            InitializeComponent();


            ReadPokemon("1");
            
            PokeListLb.ItemsSource = pm;
            PokeNameLbl.Content = (Pokemon)PokeListLb.SelectedItem;
            

        }

        private async void ReadPokemon(string name)
        {
            RSPokeData pd = new RSPokeData();
            var v = await pd.GetPokemon(name);
            pm.Add(v);

        }
        private void ShowSelcted(object sender, SelectionChangedEventArgs args)
        {
            var item = ((sender as ListBox).SelectedItem as Pokemon);
            
            PokeNameLbl.Content = item.Name;
        }
        

        
    }
}
