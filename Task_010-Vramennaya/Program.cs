// Прграмма, по номеру четверти выдает диапозон координат 
void answer(int x)
{
    if (x == 1) Console.WriteLine("x > 0, y > 0");
    if (x == 2) Console.WriteLine("x < 0, y > 0");
    if (x == 3) Console.WriteLine("x < 0, y < 0");
    if (x == 4) Console.WriteLine("x > 0, y < 0");
}

Console.WriteLine("Введите номер четверти");
string? inNum = Console.ReadLine();
if (inNum != null)
{
    int num = int.Parse(inNum);
    answer(num);
}
