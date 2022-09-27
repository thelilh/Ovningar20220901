namespace Ovningar20220901.SubFunctions;

public class StepCounter
{
    private int _counter;

    public void Step()
    {
        _counter++;
    }

    public void Reset()
    {
        _counter = 0;
        Console.WriteLine("Stegräknaren är nu nollställd.");
    }

    public override string ToString()
    {
        return $"Du har gått {_counter} steg";
    }
}