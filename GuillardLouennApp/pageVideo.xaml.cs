using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuillardLouennApp;

public partial class pageVideo : ContentPage
{
    public pageVideo()
    {
        InitializeComponent();
    }
    
    public async void Button_back(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}