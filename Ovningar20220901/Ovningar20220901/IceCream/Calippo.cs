namespace Ovningar20220901.IceCream;

public class Calippo : IceCreams
{
    public override string Buy()
    {
        return $"Det kostar {Cost} att köpa en calippo";
    }

    public string BuyFive()
    {
        return $"Det kostar {Cost * 5} att köpa fem calippo";
    }

}