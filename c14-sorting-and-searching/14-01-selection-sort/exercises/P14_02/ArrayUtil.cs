using System;

public class ArrayUtil
{
    private static Random rand = new Random();

    public static Coin[] CreateCoinArr(int length)
    {
        int[] coinValues = {CoinValues.Penny, 
            CoinValues.Nickel, 
            CoinValues.Dime, 
            CoinValues.Quarter};

        Coin[] coinArr = new Coin[length];
        for (int i = 0; i < coinArr.Length; i++)
        {
            coinArr[i] = new Coin(coinValues[rand.Next(coinValues.Length)]);
        }
        return coinArr;
    }

    public static string ToString(Coin[] arr)
    {
        string output = "";
        foreach (Coin c in arr)
        {
            output += c.ToString() + " ";
        }
        return output;
    }

    public static void Swap(Coin[] arr, int i, int j)
    {
        Coin temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
}