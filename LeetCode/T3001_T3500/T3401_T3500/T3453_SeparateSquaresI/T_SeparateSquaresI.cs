namespace LeetCode.T3001_T3500.T3401_T3500.T3453_SeparateSquaresI;

public class T_SeparateSquaresI
{
    public double SeparateSquares(int[][] squares)
    {
        double l = 0, r = 10e9, s;
        double e = 0.000001;
        while (r - l > e)
        {
            s = (l + r) / 2;
            var belowIsMore = CountSquares(squares, (decimal)s);
            if (belowIsMore)
                r = s;
            else
                l = s;
        }

        return l;
    }

    private bool CountSquares(int[][] squares, decimal s)
    {
        decimal above = 0, below = 0;
        for (int i = 0; i < squares.Length; i++)
        {
            if (squares[i][1] > s)
                above += squares[i][2] * squares[i][2];
            else if (squares[i][1] + squares[i][2] < s)
                below += squares[i][2] * squares[i][2];
            else
            {
                above += squares[i][2] * ((decimal)squares[i][1] + squares[i][2] - s);
                below += squares[i][2] * (s - squares[i][1]);
            }
        }

        return below >= above;
    }
}
