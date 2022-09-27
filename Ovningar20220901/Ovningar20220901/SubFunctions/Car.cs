using System.Diagnostics;

namespace Ovningar20220901.SubFunctions;

[Flags]
public enum Colours
{
    Röd,
    Vit,
    Blå,
    Grön,
    Svart
}
public class Car
{
    private string _make;
    private int _price;
    private Colours _colour;
    private int _length;
    private int _speed;
    private Stopwatch _time;
    private int _place;

    public int Distance { get; set; }

    public Colours Colour
    {
        get { return _colour; }
        set { _colour = value; }
    }


    public int Price
    {
        get
        {
            return _price;
        }
        set
        {
            if (_price > 0)
            {
                if (value <= _price / 2)
                {
                    HalfPrice();
                }
            }
            _price = value;
        }
    }


    public string Make
    {
        get { return _make; }
        set { _make = value; }
    }

    public Car()
    {
        Console.WriteLine($"Detta är en bil");
    }
    public Car(string make, int price, Colours colour)
    {
        var rand = new Random();
        Make = make;
        Price = price;
        Colour = colour;
        _length = rand.Next(3, 6);
        _speed = rand.Next(60, 241);
        Distance = 0;
    }

    public Car(string make, int price)
    {
        var rand = new Random();
        Make = make;
        Price = price;
        Colour = (Colours)rand.Next(0, 5);
        _length = rand.Next(3, 6);
        _speed = rand.Next(60, 241);
        Distance = 0;
    }

    public void HalfPrice()
    {
        Console.WriteLine($"Priset på {Make} med färgen {Colour} är nu hälften!");
    }

    public override string ToString()
    {
        return $"Bilen är en {_make}, kostar {_price}, är {_length}m, har färgen {_colour} och hastigheten {_speed} km/h";
    }

    public static List<Car> MakeCars(bool randomColours)
    {
        var tempCars = new List<Car>();
        var rand = new Random();
        var randColours = (Colours)rand.Next(0, 5);
        for (var i = 0; i < 10; i++)
        {
            if (randomColours)
            {
                randColours = (Colours)rand.Next(0, 5);
            }
            tempCars.Add(new Car("Volvo", 10000, randColours));
        }
        return tempCars;
    }

    public void DriveForOneHour()
    {
        Distance += _speed;
        if (Distance > 10000)
        {
            Distance = 10000;
        }
    }

    public void GetGraph()
    {
        double playerPos = 10000 - Distance;
        playerPos /= 500;
        var truePlayerPos = (int)Math.Round(playerPos, 0);
        Console.Write("|");
        for (var i = 20; i >= 0; i--)
        {
            if (i == truePlayerPos)
            {
                switch (Colour)
                {
                    case Colours.Blå:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Colours.Grön:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Colours.Röd:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Colours.Svart:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                    case Colours.Vit:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
                Console.Write("x");
                Console.ResetColor();
            }
            else
            {
                Console.Write("-");
            }
        }
        Console.Write($"| {_speed} km/h -");
        if (Distance == 10000)
        {
            if (_time.IsRunning)
            {
                _time.Stop();
            }
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            TimeSpan ts = _time.Elapsed;
            var elapsedTime = $"{ts.Minutes} minuter, {ts.Seconds} sekunder och {ts.Milliseconds / 10} milisekunder - {_place}";
            if (_place >= 4)
            {
                elapsedTime += "th place";
            }
            else
            {
                if (_place == 1)
                {
                    elapsedTime += "st place";
                }
                else if (_place == 2)
                {
                    elapsedTime += "nd place";
                }
                else if (_place == 3)
                {
                    elapsedTime += "rd place";
                }
            }
            Console.Write($" {Distance} km - tog {elapsedTime}\n");
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($" {Distance} km\n");
            Console.ResetColor();
        }
    }

    public static void SimulateTenCars()
    {
        var tempCars = MakeCars(randomColours: true);
        var place = 1;
        foreach (var x in tempCars)
        {
            x._time = new Stopwatch();
            x._time.Start();
        }
        while (true)
        {
            var amount = 0;
            foreach (var x in tempCars)
            {
                if (x.Distance < 10000)
                {
                    x.DriveForOneHour();
                    amount++;
                }
                if (x._time.IsRunning && x.Distance >= 10000)
                {
                    x._place = place;
                    place++;
                }
                x.GetGraph();
            }

            if (amount == 0)
            {
                break;
            }
            Thread.Sleep(1000);
            Console.Clear();
        }
    }
}