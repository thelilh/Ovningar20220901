namespace Ovningar20220901.IceCream;

public abstract class IceCreams
{
    private int _cost;

    public int Cost
    {
        get { return _cost; }
        set { _cost = value; }
    }


    public virtual string Buy()
    {
        return $"Det kostar {Cost}kr att köpa denna glass";
    }
}