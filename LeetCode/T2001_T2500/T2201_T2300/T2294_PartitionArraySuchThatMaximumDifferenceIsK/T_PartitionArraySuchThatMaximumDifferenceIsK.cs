namespace LeetCode.T2001_T2500.T2201_T2300.T2294_PartitionArraySuchThatMaximumDifferenceIsK;

public class T_PartitionArraySuchThatMaximumDifferenceIsK
{
    public int PartitionArray(int[] nums, int k)
    {
        var counts = new int[nums.Max() + 1];

        for (int i = 0; i < nums.Length; i++)
        {
            counts[nums[i]]++;
        }

        var number = 0;
        while (counts[number] == 0)
            number++;

        var subsequences = 1;
        var min = number;
        counts[number]--;

        while (number < counts.Length)
        {
            if (counts[number] == 0)
            {
                number++;
                continue;
            }

            if (number - min > k)
            {
                subsequences++;
                min = number;
            }

            counts[number]--;
        }

        return subsequences;
    }
}
