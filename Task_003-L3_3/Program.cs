// Пробела заменить |, букву к на К

string text = "– Я думаю, – сказал князь, улыбаясь, – что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне  чаю?";

// есть строка string s = "abcd"
//             индексы     0123
// к элементу строки можно обратиться s[2]  - это буква с

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine (newText);
Console.WriteLine ();

string newText2 = Replace (newText, 'к', 'К');
Console.WriteLine (newText2);