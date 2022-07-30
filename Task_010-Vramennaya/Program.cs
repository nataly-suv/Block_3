// Проверка, яв-ся ли число 5-ти занчным палиндромом 
//-------------------------------------------------

// метод. поиск разряда числа 
int PoiskRazryad(int x)
{
    int y = (int)Math.Log10(Math.Abs(x)) + 1;
    return y;
}

Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());

int razryad = PoiskRazryad(num);  // нашла разряд введенного числа 
Console.WriteLine($"Разряд введенного числа {razryad}");

if (razryad == 5)
{
    if ((num/10000) == (num%10) && (num/1000%10) == (num/10%10))
    {
        Console.WriteLine ($"Введенное число {num} является полиндромом");
    }
    else Console.WriteLine ($"Введенное число {num} не является полиндромом");
}
else Console.WriteLine ("Вы ввели не 5-ти значное число. Перезапустите прграмму");