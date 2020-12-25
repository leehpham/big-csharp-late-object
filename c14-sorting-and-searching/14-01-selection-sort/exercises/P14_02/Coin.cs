public class Coin
{
    private int value;

    public Coin(int value)
    {
        this.value = value;
    }

    public int GetValue()
    {
        return this.value;
    }

    public override string ToString()
    {
        return this.value.ToString();
    }
}