using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;
namespace ConsoleApp12.Models;
public static class Extension
{
    public static int MatchCount(this string sentence, string word)
    {
        int num = 0;
        string[] strings = { };
        string data = string.Empty;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ' || sentence[i] == '.')
            {
                Array.Resize(ref strings, strings.Length + 1);
                strings[strings.Length - 1] = data;
                data = "";
            }
            else
            {
                data += sentence[i];
            }
        }
        foreach (var str in strings)
        {
            if (str == word)
            {
                num++;
            }
        }
        return num;
    }
}
