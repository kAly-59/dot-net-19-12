﻿namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        //Changement de Page 
        private async void OnPlayGameClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MagicNumberPage());
        }

        private async void PlayQuizBtn(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuizPage());
        }
    }
}
