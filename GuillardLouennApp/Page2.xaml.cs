using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuillardLouennApp;

public partial class Page2 : ContentPage
{
    private readonly APICollecteur _api;
    
    public Page2()
    {
        InitializeComponent();
        _api = new APICollecteur();
        LoadData();
    }
    
    private async void LoadData()
    {
        var donnees = await _api.GetAsync(null);
        var donneesModifier = donnees.Trim('[',']');
        var items = donneesModifier.Split(new[] { '{' }, StringSplitOptions.RemoveEmptyEntries);
        listView.ItemsSource = items;
    }

    private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            DisplayAlert("Item selectionner", e.SelectedItem.ToString(), "OK");
        }
    }
}