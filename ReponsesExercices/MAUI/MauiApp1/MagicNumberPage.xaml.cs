using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MagicNumberPage : ContentPage
    {
        public MagicNumberPage()
        {
            InitializeComponent();
        }

        private async void VerifClick(object sender, EventArgs e)
        {
            await DisplayAlert("V�rification", "Bouton de v�rification cliqu� !", "OK");
        }

    }
}
