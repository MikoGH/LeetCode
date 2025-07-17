namespace LeetCode.T3001_T3500.T3101_T3200.T3136_ValidWord;

public class T_ValidWord
{
    private readonly HashSet<char> Vowels = new() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

    public bool IsValid(string word)
    {
        if (word.Length < 3)
            return false;

        var containsVowel = false;
        var containsConsonant = false;

        foreach (var smb in word)
        {
            if (smb >= 'a' && smb <= 'z' || smb >= 'A' && smb <= 'Z')
            {
                if (Vowels.Contains(smb))
                    containsVowel = true;
                else
                    containsConsonant = true;
            }
            else if (!(smb >= '0' && smb <= '9'))
            {
                return false;
            }
        }

        return containsVowel && containsConsonant;
    }
}
