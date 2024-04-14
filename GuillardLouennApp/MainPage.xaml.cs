namespace GuillardLouennApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
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
