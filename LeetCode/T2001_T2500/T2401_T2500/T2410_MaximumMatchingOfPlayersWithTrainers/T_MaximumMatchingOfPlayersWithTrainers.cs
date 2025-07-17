namespace LeetCode.T2001_T2500.T2401_T2500.T2410_MaximumMatchingOfPlayersWithTrainers;

public class T_MaximumMatchingOfPlayersWithTrainers
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);

        var count = 0;

        var playerIndex = 0;
        var trainerIndex = 0;
        while (playerIndex < players.Length && trainerIndex < trainers.Length)
        {
            if (players[playerIndex] <= trainers[trainerIndex])
            {
                count++;
                playerIndex++;
            }

            trainerIndex++;
        }

        return count;
    }
}
