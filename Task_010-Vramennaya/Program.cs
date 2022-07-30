// Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

// Метод считывания координаты и возвращает массив с ней (точка x=34; y=-30)
int[,] ReadPoint()
{
    string inputLine = Console.ReadLine();

    string coordXLine = inputLine.Substring(0, inputLine.IndexOf(";"));
    // взяли подстроку от 0 до ; - x=34
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=") + 1);
    //взяли подстроку от = до окнца - 34

    string coordYLine = inputLine.Substring(inputLine.IndexOf(";") + 1);
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=") + 1);

    int coordX = int.Parse(coordXLine);
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1, 2]; // создали двумерный массив arrayOut
    arrayOut[0, 0] = coordX; // положили в массив координату Х
    arrayOut[0, 1] = coordY; // положили в массив координату У

    return arrayOut;
}

// метод вывода номера четверти 
void Answer(int[,] arrayPoint)
{
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("I четверть");
    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] > 0)
        Console.WriteLine("II четверть");
    if (arrayPoint[0, 0] < 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("III четверть");
    if (arrayPoint[0, 0] > 0 && arrayPoint[0, 1] < 0)
        Console.WriteLine("IV четверть");
}

int[,] arrayPoint = ReadPoint();
Answer(arrayPoint);


