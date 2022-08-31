namespace PetConsoleApp;

public class ConsoleMenu
{
    private string _title = String.Empty;
    private List<string> _choices = new();
    private List<string> _options = new();

    public ConsoleMenu(string title)
    {
        _title = title;
    }

    public void AddOption(string choice, string option)
    {
        _choices.Add(choice);
        _options.Add(option);
    }

    public void Show()
    {
        Console.WriteLine(_title);
        Console.WriteLine(new String('=', _title.Length));
        for(int i = 0; i < _options.Count; i++)
        {
            Console.WriteLine($"{_choices[i]}. {_options[i]}");
        }
    }

    public bool ValidateChoice(string choiceToValidate)
    {
        foreach(var choice in _choices)
        {
            if(choice.ToUpper() == choiceToValidate.ToUpper())
            {
                return true;
            }
        }
        return false;
    }
}
