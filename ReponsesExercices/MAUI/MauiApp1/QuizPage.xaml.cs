namespace MauiApp1;

public partial class QuizPage : ContentPage
{	
	public QuizPage()
	{
		InitializeComponent();
	}

    private List<string> questions = new List<string>
        {
            "Quelle est le président Français actuel?",
            "Quelle est le président Français actuel?",
            "Quelle est le président Français actuel?",
            "Quelle est le président Français actuel?",
            "Quelle est le président Français actuel?",
        };

    private List<string[]> options = new List<string[]>
        {
            new string[] { "Macron", "Sarkozy", "Hollande", "Chirac" },
            new string[] { "Macron", "Sarkozy", "Hollande", "Chirac" },
            new string[] { "Macron", "Sarkozy", "Hollande", "Chirac" },
            new string[] { "Macron", "Sarkozy", "Hollande", "Chirac" },
            new string[] { "Macron", "Sarkozy", "Hollande", "Chirac" },
        };

}