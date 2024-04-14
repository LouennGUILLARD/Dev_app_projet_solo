using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuillardLouennApp;

public partial class pageGif : ContentPage
{
    public pageGif()
    {
        InitializeComponent();
    }

    public async void Button_back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
    
    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await Task.Delay(100);
        imgLoader.IsAnimationPlaying = true;
    }
    
}