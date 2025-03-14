using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.ComponentModel;
using TheBartendingApp.Models;


namespace TheBartendingApp.ViewModels
{
    class SearchDrinkNameViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<Models.Drink> _adrinklist;
        public ObservableCollection<Models.Drink> Adrinklist 
        {
            get { return _adrinklist; }
            set { _adrinklist = value;
                OnPropertyChanged(nameof(Adrinklist));
            } 
        }
        
        public SearchDrinkNameViewModel(string drinkName) 
        {
            Adrinklist = new ObservableCollection<Models.Drink>();
            LoadDrinkAsync(drinkName);
        }
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public async void LoadDrinkAsync(string name)
        {
            Adrinklist = await GetDrinkAsync(name);
            
        }
        public static async Task<ObservableCollection<Models.Drink>> GetDrinkAsync(string name)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com");
            client.DefaultRequestHeaders.Add("X-Api-Key", "bE4SxZRRZ2IS1OTklxFIdA==obdNFc96bki3VbcG");
            ObservableCollection<Models.Drink> drinkList = null;
            
            HttpResponseMessage response = await client.GetAsync("/v1/cocktail?name=" + name);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                drinkList = JsonSerializer.Deserialize<ObservableCollection<Models.Drink>>(responseString);
            }
            return drinkList;
        }
    }
}
