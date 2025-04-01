namespace LeetCode.T2001_T2500.T2101_T2200.T2140_SolvingQuestionsWithBrainpower;

public class T_SolvingQuestionsWithBrainpower
{
    public long MostPoints(int[][] questions)
    {
        var dp = new long[questions.Length + 1];
        for (int i = questions.Length - 1; i >= 0; i--)
        {
            dp[i] = dp[i + 1];
            var j = i + questions[i][1] + 1;
            if (j >= dp.Length)
            {
                if (questions[i][0] > dp[i])
                    dp[i] = questions[i][0];
            }
            else if(questions[i][0] + dp[j] > dp[i])
                dp[i] = questions[i][0] + dp[j];
        }

        return dp[0];
    }
}
