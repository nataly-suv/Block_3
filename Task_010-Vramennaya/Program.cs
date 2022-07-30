// Выдает таблицу квадратов от 1 до N

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()); 
// или int num = int.Parse(Console.ReadLine());

string lineN = String.Empty;
string lineN2 = String.Empty; 

for (int count = 1; count <= num; count++)
{
    lineN = lineN + $"{count} ";
    lineN2 = lineN2 + $"{count * count} ";
}

Console.WriteLine(lineN);
Console.WriteLine(lineN2);

 