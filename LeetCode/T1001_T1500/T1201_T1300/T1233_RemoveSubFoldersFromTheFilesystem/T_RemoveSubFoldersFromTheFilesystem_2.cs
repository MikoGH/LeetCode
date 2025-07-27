namespace LeetCode.T1001_T1500.T1201_T1300.T1233_RemoveSubFoldersFromTheFilesystem;

public class T_RemoveSubFoldersFromTheFilesystem_2
{
    private const int mod = (int)1e9 + 7;
    private const int p = 37;

    public IList<string> RemoveSubfolders(string[] folder)
    {
        Array.Sort(folder);

        var result = new List<string>();
        long lastHash = 0;

        foreach (var item in folder)
        {
            var flag = false;
            long hash = 0;
            for (int i = 0; i < item.Length; i++)
            {
                hash = AddSmbToHash(hash, item[i]);

                if ((i == item.Length - 1 || item[i + 1] == '/') && lastHash == hash)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
                continue;

            lastHash = hash;
            result.Add(item);
        }

        return result;
    }

    private long AddSmbToHash(long hash, char smb)
    {
        return (hash * p + (smb - 'a' + 1)) % mod;
    }
}
