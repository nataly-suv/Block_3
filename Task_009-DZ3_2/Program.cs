// Поиск расстояние между точками в 3Д пространстве

// A (3, 6, 8); B (2, 1, -7) -> 15,84 

//  метод считывания координат
int[,] Point()
{
    Console.WriteLine("Введите координаты точек");
    string inData = Console.ReadLine();

    inData = inData.Replace(" ", "");  // удалила пробелы
    inData = inData.Replace(",", "|");  // заменила ','  - итоговая строка A(3|6|8);B(2|1|-7)

    // Выделяем координаты точки А
    string coordXa = inData.Substring(0, inData.IndexOf("|"));  // берем строку [от 0 до |) - A(3
    coordXa = coordXa.Substring(coordXa.IndexOf("(") + 1); // берем строку от ( до конца
    int indexDel = inData.IndexOf("|"); // нахожу индекс в строке с символом '|'
    inData = inData.Remove(0, indexDel + 1); // удаляю часть строки [от 0 до |]

    string coordYa = inData.Substring(0, inData.IndexOf("|"));  // берем строку [от 0 до |) - 6|
    inData = inData.Remove(0, inData.IndexOf("|") + 1); // удаляю часть строки [от 0 до ,] 

    string coordZa = inData.Substring(0, inData.IndexOf(")"));  // берем строку [от 0 до ')' )
    inData = inData.Remove(0, inData.IndexOf(")") + 1); // удаляю часть строки [от 0 до ) ]

    // Выделяем координаты точки В
    string coordXb = inData.Substring(0, inData.IndexOf("|"));  // берем строку [от 0 до ,)
    coordXb = coordXb.Substring(coordXb.IndexOf("(") + 1); // берем строку от ( до конца
    inData = inData.Remove(0, inData.IndexOf("|") + 1); // удаляю часть строки [от 0 до ,]

    string coordYb = inData.Substring(0, inData.IndexOf("|"));  // берем строку [от 0 до |)
    inData = inData.Remove(0, inData.IndexOf("|") + 1); // удаляю часть строки [от 0 до |]

    string coordZb = inData.Substring(0, inData.IndexOf(")"));  // берем строку [от 0 до ')' )


    int xA = int.Parse(coordXa);
    int yA = int.Parse(coordYa);
    int zA = int.Parse(coordZa);
    int xB = int.Parse(coordXb);
    int yB = int.Parse(coordYb);
    int zB = int.Parse(coordZb);

    int[,] array = new int[2, 3];
    array[0, 0] = xA;
    array[0, 1] = yA;
    array[0, 2] = zA;
    array[1, 0] = xB;
    array[1, 1] = yB;
    array[1, 2] = zB;

    return array;
}

// метод расчета расстояния
void Answer(int[,] massiv)
{
    double x2 = Math.Pow((massiv[0, 0] - massiv[1, 0]), 2);
    double y2 = Math.Pow((massiv[0, 1] - massiv[1, 1]), 2);
    double z2 = Math.Pow((massiv[0, 2] - massiv[1, 2]), 2);
    double length = Math.Sqrt(x2 + y2 + z2);
    Console.WriteLine($"расстояние между точками равно {length}");
}


int [,] massiv = Point();
Answer(massiv);


