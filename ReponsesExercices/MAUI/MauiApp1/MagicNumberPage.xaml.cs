using Microsoft.Maui.Controls;

namespace MauiApp1
{
    public partial class MagicNumberPage : ContentPage
    {
        Random random = new Random();
        int nombreMagique;
        int userInput;

        public MagicNumberPage()
        {
            nombreMagique = random.Next(1, 21);
            InitializeComponent();
        }

        private async void VerifClick(object sender, EventArgs e)
        {
            if (userInput == nombreMagique)
            {
                await DisplayAlert("Résultat", "C'est gagné !", "OK");
            }
            else
            {
                await DisplayAlert("Résultat", "C'est perdu ! Le nombre magique était " + nombreMagique, "OK");
            }
        }
    }
}

