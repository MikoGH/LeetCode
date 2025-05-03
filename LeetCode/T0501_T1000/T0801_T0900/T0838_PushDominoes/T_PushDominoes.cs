using System.Diagnostics;

namespace LeetCode.T0501_T1000.T0801_T0900.T0838_PushDominoes;

public class T_PushDominoes
{
    public string PushDominoes(string dominoes)
    {
        var dominoesList = dominoes.ToCharArray();
        var dominoesSteps = new int[dominoes.Length];

        var queue = new Queue<(int Index, char Direction, int Step)>();

        for (int i = 0; i < dominoesList.Length; i++)
        {
            if (dominoesList[i] == '.')
                continue;
            queue.Enqueue(new(i, dominoesList[i], 0));
        }

        while (queue.Count > 0)
        {
            var elm = queue.Dequeue();
            if (dominoesList[elm.Index] == '.')
                continue;
            var nextIndex = elm.Direction == 'L' ? elm.Index - 1 : elm.Index + 1;
            var nextStep = elm.Step + 1;
            if (nextIndex < 0 || nextIndex >= dominoesList.Length)
                continue;
            if (dominoesList[nextIndex] != '.')
            {
                if (dominoesSteps[nextIndex] == nextStep)
                {
                    dominoesList[nextIndex] = '.';
                }
                continue;
            }
            dominoesSteps[nextIndex] = nextStep;
            dominoesList[nextIndex] = elm.Direction;
            queue.Enqueue(new(nextIndex, elm.Direction, nextStep));
        }

        return new string(dominoesList);
    }
}
