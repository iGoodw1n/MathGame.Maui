namespace MathGame.Maui;

public partial class GamePage : ContentPage
{
    public string GameType { get; }
    int firstNumber = 0;
    int secondNumber = 0;

    public GamePage(string gameType)
	{
		InitializeComponent();
        GameType = gameType;
        BindingContext = this;
    }

    private void CreateNewQuestion()
    {
        var gameOperand = GameType switch
        {
            "Addition" => "+",
            "Subtraction" => "-",
            "Multiplication" => "*",
            "Division" => "/",
            _ => ""
        };

        var random = new Random();

        firstNumber = GameType != "Division" ? random.Next(1, 9) : random.Next(1, 99);
        secondNumber = GameType != "Division" ? random.Next(1, 9) : random.Next(1, 99);
    }
}