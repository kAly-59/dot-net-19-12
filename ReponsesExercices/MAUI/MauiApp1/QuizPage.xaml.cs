namespace MauiApp1;

public partial class QuizPage : ContentPage
{	
	public QuizPage()
	{
		InitializeComponent();
	}

    private List<string> questions = new List<string>
        {
            "Quelle est le pr�sident Fran�ais actuel?",
            "Quelle est le pr�sident Fran�ais actuel?",
            "Quelle est le pr�sident Fran�ais actuel?",
            "Quelle est le pr�sident Fran�ais actuel?",
            "Quelle est le pr�sident Fran�ais actuel?",
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