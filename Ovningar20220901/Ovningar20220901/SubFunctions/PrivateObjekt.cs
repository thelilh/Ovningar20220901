namespace Ovningar20220901.SubFunctions;

public class PrivateObjekt
{
    public readonly int Number;

    private PrivateObjekt()
    {
        Number = new Random().Next(0, 100);
    }

    public static PrivateObjekt ReturnThis()
    {
        return new PrivateObjekt();
    }

    public override string ToString()
    {
        return $"Detta objekt har numret {Number}";
    }
}