namespace LeetCode.T3001_T3500.T3401_T3500.T3443_MaximumManhattanDistanceAfterKChanges;

public class T_MaximumManhattanDistanceAfterKChanges
{
    public int MaxDistance(string s, int k)
    {
        var north = 0;
        var south = 0;
        var west = 0;
        var east = 0;

        var result = 0;

        int maxSN;
        int maxWE;
        int minSN;
        int minWE;

        foreach (var smb in s)
        {
            switch (smb)
            {
                case 'N':
                    north++;
                    break;
                case 'S':
                    south++;
                    break;
                case 'W':
                    west++;
                    break;
                default:
                    east++;
                    break;
            }

            if (south > north)
            {
                maxSN = south;
                minSN = north;
            }
            else
            {
                maxSN = north;
                minSN = south;
            }

            if (east > west)
            {
                maxWE = east;
                minWE = west;
            }
            else
            {
                maxWE = west;
                minWE = east;
            }

            var dist = maxSN - minSN + maxWE - minWE;

            var maxDist = dist + Math.Min(k, minSN + minWE) * 2;

            if (maxDist > result)
                result = maxDist;
        }

        return result;
    }
}
