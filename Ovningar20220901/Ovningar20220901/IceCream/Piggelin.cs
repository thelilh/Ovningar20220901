namespace Ovningar20220901.IceCream;

public class Piggelin : IceCreams
{
    public override string Buy()
    {
        return $"Det kostar {Cost} att köpa en piggelin";
    }

    public string BuyTen()
    {
        return $"Det kostar {Cost * 10} att köpa tio piggelin";
    }
}