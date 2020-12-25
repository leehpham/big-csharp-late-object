public class SelectionSorter
{
    public static void Sort(Coin[] coinArr)
    {
        for (int i = 0; i < coinArr.Length - 1; i++)
        {
            int minPos = MinimumPosition(coinArr, i);
            ArrayUtil.Swap(coinArr, minPos, i);
        }
    }

    private static int MinimumPosition(Coin[] arr, int from)
    {
        int minPos = from;
        for (int i = from; i < arr.Length; i++)
        {
            if (arr[i].GetValue() < arr[minPos].GetValue())
            {
                minPos = i;
            }
        }
        return minPos;
    }
}