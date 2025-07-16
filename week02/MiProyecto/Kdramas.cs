public class Kdramas
{
    private string _name;

    private int _score;

    public Kdramas()
    {
        _name = "Do you like Brahms?";
        _score = 10;
    }

    public Kdramas(string name, int score)
    {
        _name = name;
        _score = score;
    }
    public string GetKdramaInfo()
    {
        return $"Name: {_name}, Score: {_score}";
    }
}
