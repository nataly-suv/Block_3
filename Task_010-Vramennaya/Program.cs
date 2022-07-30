// Выдает таблицу кубов от 1 до N 


// метод вывода линии
string Liniya(int x, string tire)
{
    string line = String.Empty;
    for (int i = 0; i < x; i++)
    {
        line = line + tire;
    }
    //Console.WriteLine(line);
    return line;
}

Console.WriteLine("Введите число");
int inNum = int.Parse(Console.ReadLine());

string num = "|";
string num3 = "|";

for (int i = 1; i <= inNum; i++)
{
    num = num + $" {i} |";
    num3 = num3 + $" {Math.Pow(i, 3)} |";
    if (num3.Length > num.Length)
    {
        string inst = new String(' ', (num3.Length-num.Length));
        num = num.Insert((num.Length-1), inst);
    }
}

Console.WriteLine(Liniya(num3.Length, "—"));
Console.WriteLine(num);
Console.WriteLine(Liniya(num3.Length, "—"));
Console.WriteLine(num3);
Console.WriteLine(Liniya(num3.Length, "—"));

