// 4 основных метода

// 1-ая группа методов. ничего не принимает, ничего не возвращает
void Method1()  // ключевое слово void
{
    Console.WriteLine("Автор....");
}
Method1();   // вызвали метод

// 2-ая группа методов. ничего не возвращают, но принимают агрументы 
void Method21(string msg)
{
    Console.WriteLine(msg);
}
Method21(msg: "Текст сообщения");  // вызвали метод и дали аргумант
// можно делать аргументы именованные, т.е. явно указать какому аргумету, какое знаечние присваиваем (mag:)


void Method22(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method22("Мир, ты прекрасен!", 4);   // то же самое - Method22(msg: "Мир, ты прекрасен!", count: 4);

// 3-ья группа методов. что-то возвращают, но ничего не принимают
int Method3 ()
{
    return DateTime.Now.Year;
}
int year = Method3();  // вызываем метод
Console.WriteLine (year);

// 4-ая группа методов. что-то принимают и что-то возвращают
string Method4 (int count, string x)
{
    int i = 0;
    string result = "";  //  string result = String.Empty; - так лучше, код более читаемый 
    while (i < count)
    {
        result = result + x; 
        i++;
    }
    return result;
}
string res = Method4 (10, "Ура");
Console.WriteLine (res);

