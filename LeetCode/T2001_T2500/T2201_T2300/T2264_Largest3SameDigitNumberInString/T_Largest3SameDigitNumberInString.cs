namespace LeetCode.T2001_T2500.T2201_T2300.T2264_Largest3SameDigitNumberInString;

public class T_Largest3SameDigitNumberInString
{
    public string LargestGoodInteger(string num)
    {
        var max3Number = "";
        var lastNumber = '-';
        var count = 0;

        foreach (var number in num)
        {
            if (number == lastNumber)
            {
                count++;
                if (count == 3)
                {
                    if (max3Number.Length == 0 || number > max3Number[0])
                    {
                        max3Number = number.ToString();
                    }
                }
                continue;
            }

            lastNumber = number;
            count = 1;
        }

        return string.Join("",[max3Number, max3Number, max3Number]);
    }
}
