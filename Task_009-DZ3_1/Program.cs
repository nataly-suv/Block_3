// Проверка, яв-ся ли число 5-ти занчным палиндромом 
//-------------------------------------------------

// метод. поиск разряда числа 
int PoiskRazryad(int x)
{
    int y = (int)Math.Log10(Math.Abs(x)) + 1;
    return y;
}

// метод составления массива черырехзначных палиндромов
int[] SpisokPalindrom()
{
    int[] SpisokPalindrom = new int[90];
    for (int i = 1; i < 10; i++)
    {
        for (int j = 0; j < 10; j++)
        {
            SpisokPalindrom[i] = i * 1000 + j * 100 + j * 10 + i;
            Console.Write($"{SpisokPalindrom[i]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return SpisokPalindrom;
}

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int razryad = PoiskRazryad(num);  // нашла разряд введенного числа 
Console.WriteLine($"Разряд введенного числа {razryad}");

int num4 = (num / 1000) * 100 + num % 100; // Введенное число без средней цифры
Console.WriteLine($"Введенное число без средней цифры {num4}");

if (razryad == 5)
{
    int proverka = 0; // ввела, чтобы узнать было ли совпадение
    int[] spisok = SpisokPalindrom();  // выводит нормальный, полный массив  палиндромов 
    for (int i = 0; i < spisok.Length; i++)
    {
        Console.Write($"{spisok[i]} ");   
        // т.к. прога не работала, для проверки вывела массив который выводится
        // через цикл for. Ерунду какую-то выводит. Не могу разобраться почему. 
        // ведь при инициализации метода SpisokPalindrom выводится нормальный массив

        if (spisok[i] == num4)
        {
            Console.WriteLine($"веденное число {num} является палиндромом");
            proverka = spisok[i];
            break;
        }
    }
    Console.WriteLine();
    if (proverka == 0) Console.WriteLine($"веденное число {num} не является палиндромом");
}
else Console.WriteLine("Введенное число не является пятизначным. Запустите программу заново");


// // пробовала так найти нужный элемент, тоже не работает 
// int[] spisok = SpisokPalindrom();
// if (razryad == 5)
// {
//     int index = Array.IndexOf(spisok, num4);
//     Console.WriteLine(index);
// }


