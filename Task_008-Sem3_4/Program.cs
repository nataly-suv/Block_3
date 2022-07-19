// Выдает таблицу квадратов от 1 до N

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

string lineN = String.Empty;
string lineN2 = String.Empty;

for (int count = 1; count <= num; count++)
{
    lineN = lineN + $"{count} ";
    lineN2 = lineN2 + $"{count * count} ";
}

Console.WriteLine(lineN);
Console.WriteLine(lineN2);



// List<int> listGen(int number)
// {
//     List<int> numbers = new List<int>();
//     for (int i = 1; i <= number; i++)
//     {
//         numbers.Add(i);
//     }
//     return numbers;
// }

// Console.WriteLine("Введите число");
// string? inputLine = Console.ReadLine();

// if (inputLine != null)
// {
//     int inputNumber = int.Parse(inputLine);
//     List<int> nums = listGen(inputNumber);
//     foreach (var i in nums)
//     {
//         Console.Write(i);
//         Console.Write(" ");
//     }
//     Console.WriteLine();
//     foreach (var i in nums)
//     {
//         Console.Write(Math.Pow(i, 2));
//         Console.Write(" ");
//     }
// }