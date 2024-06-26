﻿namespace GuillardLouennApp
{
    public partial class MainPage : ContentPage
    {

        private readonly APICollecteur _api;
        
        public MainPage()
        {
            InitializeComponent();
            _api = new APICollecteur();
        }

        private void GoToGifPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pageGif());
        }
        
        private void GoToVideoPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pageVideo());
        }
    }

}
