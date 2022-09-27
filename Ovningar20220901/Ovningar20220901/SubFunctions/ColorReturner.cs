namespace Ovningar20220901.SubFunctions;

public class ColorReturner
{
    private double _blue = 50.0f;

    private double _red = 50.0f;

    public double Red
    {
        get
        {
            return _red;
        }
        set
        {
            _red = value;
            _blue = MakeHundred(_red);
        }
    }


    public double Blue
    {
        get { return _blue; }
        set
        {
            _blue = value;
            _red = MakeHundred(_blue);
        }
    }

    private static double MakeHundred(double a)
    {
        double b;
        if (a - 100.0 < 0)
        {
            b = 100.0 - a;
        }
        else
        {
            b = a - 100.0;
        }

        return b;
    }

    public override string ToString()
    {
        return $"blue = {_blue}, red = {_red}, total = {_blue + _red}";
    }
}