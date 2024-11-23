namespace LeetCode.T1501_T2000.T1861_RotatingTheBox;

public class T_RotatingTheBox
{
    public char[][] RotateTheBox(char[][] box)
    {
        char[][] result = new char[box[0].Length][];

        for (int i = 0; i < box[0].Length; i++)
            result[i] = new char[box.Length];

        for (int i = box.Length - 1; i >= 0; i--)
        {
            var pos = box[i].Length - 1;
            for (int j = box[i].Length - 1; j >= 0; j--)
            {
                switch (box[i][j])
                {
                    case '.':
                        result[j][box.Length - 1 - i] = '.';
                        break;
                    case '*':
                        result[j][box.Length - 1 - i] = '*';
                        pos = j - 1;
                        break;
                    default:
                        result[j][box.Length - 1 - i] = '.';
                        result[pos][box.Length - 1 - i] = '#';
                        pos--;
                        break;
                }
            }
        }

        return result;
    }
}
