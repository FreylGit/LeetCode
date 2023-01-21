/*
Дана строка s, найдите длину самой длинной 
подстрока
без повторяющихся символов.*/

/*
 Пример 1:
    Ввод: s = "abcabcbb"
    Вывод: 3
    Объяснение: Ответ "abc", длина 3.
*/

Console.WriteLine(LengthOfLongestSubstring("aab"));

static int LengthOfLongestSubstring(string s)
{
    int maxLength = 0;
    if(s.Length == 1)
    {
        return 1;
    }
    int start = 1;
    for (int i = start; i < s.Length; i++)
    {
        int currentLength = 1;
        for (int j = i - 1; j >= 0; j--)
        {
            if (!s[i].Equals(s[j]))
            {
                currentLength++;
            }
            else
            {
                start = j + 1;
                if(currentLength > maxLength)
                {
                    maxLength = currentLength;
                }
                break;
            }
           
        }
        if (i + 1 == s.Length)
        {
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }
        }
    }
    return maxLength;
}