namespace LeetCode.T0001_T0500.T0085_MaximalRectangle;

public class T_MaximalRectangle
{
    public int MaximalRectangle(char[][] matrix)
    {
        int n = matrix.Length, m = matrix[0].Length;
        var dp_height = new int[m];
        var max = 0;

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < m; j++)
            {
                dp_height[j] = matrix[i][j] == '1' ? dp_height[j] + 1 : 0;
            }

            var stack = new Stack<int>();
            //stack.Push(0);
            for (var j = 0; j < m; j++)
            {
                if (stack.Count == 0 && matrix[i][j] == '1')
                    stack.Push(j);

                if (j == m - 1 || matrix[i][j + 1] == '0')
                {
                    while (stack.Count > 0)
                    {
                        if (dp_height[j] * (j - stack.Peek() + 1) > max)
                            max = dp_height[j] * (j - stack.Peek() + 1);
                        stack.Pop();
                    }
                    continue;
                }

                if (matrix[i][j] == '0')
                    continue;

                while (stack.Count > 1 && dp_height[j] < dp_height[stack.ElementAt(stack.Count - 2)])
                {
                    stack.Pop();
                }

                //if (stack.Count == 0)
                //    stack.Push(j);

                if (dp_height[j] * (j - stack.Peek() + 1) > max)
                    max = dp_height[j] * (j - stack.Peek() + 1);

                if (dp_height[j] > dp_height[stack.Peek()])
                    stack.Push(j);
            }
        }

        return max;
    }
}
