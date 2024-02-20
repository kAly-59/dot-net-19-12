using DemosMAUI.Models;

namespace DemosMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            TodoListView.ItemsSource = new List<TodoItem>
            {
                new TodoItem() {Name = "item1", Done = false},
                new TodoItem() {Name = "item2", Done = true},
                new TodoItem() {Name = "item3", Done = false},
                new TodoItem() {Name = "item4", Done = false},
                new TodoItem() {Name = "item5", Done = true},
            };
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                count++;

                if (count == 1)
                    CounterBtn.Text = $"Clicked {count} time";
                else
                    CounterBtn.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
            else
                LblText.Text = "valeur de l'Entry = " + EtTest.Text;
        }
    }

}
