// Дан текст. Нужно в тексте заменить все пробелы на черточки, маленькие буквы "к"
// заменить на большие "К", а большие "С" на маленькие "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
           + "ежели бы вас послали вместо нашего милого Винценгероде"
           + "вы бы взяли приступом согласие прусского короля."
           + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
// s[3] выдаст r

string Replace (string text, char oldValue, char newValue)
{
    string result = string.Empty; // Инициализация пустой строки
    int lenght = text.Length; //получаем длину нашей строки
    for (int i = 0; i < lenght; i ++) // т.е. мы идем по каждому символу в нашей строке
    {
        if (text[i] == oldValue) result = result + $"{newValue}"; // если текущий символ совпал с тем, кот нужно заменить
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|' );
Console.WriteLine(newText);
Console.WriteLine();

string newText2 = Replace(newText, 'к', 'К');
Console.WriteLine(newText2);
Console.WriteLine();

string newText3 = Replace(newText2, 'С', 'с');
Console.WriteLine(newText3);
