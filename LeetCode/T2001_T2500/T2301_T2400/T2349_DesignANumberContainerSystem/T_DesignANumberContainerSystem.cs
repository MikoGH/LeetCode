namespace LeetCode.T2001_T2500.T2301_T2400.T2349_DesignANumberContainerSystem;

public class T_DesignANumberContainerSystem
{
    Dictionary<int, SortedSet<int>> indexesByNumbers = new();
    Dictionary<int, int> numbersByIndexes = new();

    public T_DesignANumberContainerSystem()
    {
    }

    public void Change(int index, int number)
    {
        if (numbersByIndexes.ContainsKey(index))
        {
            indexesByNumbers[numbersByIndexes[index]].Remove(index);
            if (indexesByNumbers[numbersByIndexes[index]].Count == 0)
                indexesByNumbers.Remove(numbersByIndexes[index]);

            numbersByIndexes[index] = number;
        }
        else
        {
            numbersByIndexes.Add(index, number);
        }

        if (!indexesByNumbers.ContainsKey(number))
        {
            indexesByNumbers.Add(number, new SortedSet<int>());
        }
        indexesByNumbers[number].Add(index);
    }

    public int Find(int number)
    {
        if (!indexesByNumbers.ContainsKey(number))
            return -1;

        return indexesByNumbers[number].First();
    }
}
