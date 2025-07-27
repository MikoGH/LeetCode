namespace LeetCode.T1001_T1500.T1201_T1300.T1233_RemoveSubFoldersFromTheFilesystem;

public class T_RemoveSubFoldersFromTheFilesystem
{
    private const int Mod = (int)1e9 + 7;
    private const int P = 37;

    public IList<string> RemoveSubfolders(string[] folder)
    {
        Array.Sort(folder, (a, b) => a.Length - b.Length);

        var result = new List<string>();
        var hashes = new HashSet<long>();

        foreach (var item in folder)
        {
            var flag = false;
            long hash = 0;
            for (int i = 0; i < item.Length; i++)
            {
                hash = AddSmbToHash(hash, item[i]);

                if ((i == item.Length - 1 || item[i + 1] == '/') && hashes.Contains(hash))
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                continue;

            hashes.Add(hash);
            result.Add(item);
        }

        return result;
    }

    private long AddSmbToHash(long hash, char smb)
    {
        return (hash * P + (smb - 'a' + 1)) % Mod;
    }
}
