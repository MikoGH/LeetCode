namespace LeetCode.T0001_T0500.T0001_T0100.T0085_MaximalRectangle;

public class T_MaximalRectangle
{
    public int MaximalRectangle(char[][] matrix)
    {
        int n = matrix.Length, m = matrix[0].Length;
        var dp_height = new int[m];
        var max = 0;
        var height = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                dp_height[j] = matrix[i][j] == '1' ? dp_height[j] + 1 : 0;
            }

            var stack = new Stack<(int, int)>();
            for (var j = 0; j < m; j++)
            {
                if (stack.Count == 0 && matrix[i][j] == '1')
                    stack.Push((j, dp_height[j]));

                if (stack.Count > 0 && dp_height[j] > stack.Peek().Item2)
                    stack.Push((j, dp_height[j]));

                if (j == m - 1 || matrix[i][j + 1] == '0')
                {
                    height = dp_height[j];
                    while (stack.Count > 0)
                    {
                        height = Math.Min(Math.Min(dp_height[j], stack.Peek().Item2), height);
                        if (height * (j - stack.Peek().Item1 + 1) > max)
                            max = height * (j - stack.Peek().Item1 + 1);
                        stack.Pop();
                    }
                    continue;
                }

                if (matrix[i][j] == '0')
                    continue;

                if (dp_height[j] < stack.Peek().Item2)
                {
                    var elm = stack.Peek();
                    elm.Item2 = dp_height[j];
                    stack.Pop();
                    stack.Push(elm);
                }

                height = dp_height[j];
                while (stack.Count > 1 && j < m - 1 && dp_height[j + 1] <= stack.Peek().Item2)
                {
                    height = Math.Min(Math.Min(dp_height[j], stack.Peek().Item2), height);
                    if (height * (j - stack.Peek().Item1 + 1) > max)
                        max = height * (j - stack.Peek().Item1 + 1);
                    var tmp = stack.Peek();
                    stack.Pop();
                    if (dp_height[j + 1] > stack.Peek().Item2)
                    {
                        stack.Push(tmp);
                        break;
                    }
                }

                height = Math.Min(dp_height[j], stack.Peek().Item2);
                if (height * (j - stack.Peek().Item1 + 1) > max)
                    max = height * (j - stack.Peek().Item1 + 1);
            }
        }

        return max;
    }
}
