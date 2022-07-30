// Програ принимает 2 точки и находит расстояние между ними

// глобальные переменные
int x1;
int y1;
int x2;
int y2;
double s;

// метод. считывает координаты точек
void ReadData()
{
    Console.WriteLine("Введите X1");
    x1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите Y1");
    y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите X2");
    x2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите Y2");
    y2 = int.Parse(Console.ReadLine());
}

// метод. Вычмсление расстояние между х и у
void Answer()
{
    s = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
}


ReadData();
Answer();
Console.WriteLine(s);
