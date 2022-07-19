// Сортировка выбором
int[] array = { 1, 5, 7, 9, 1, 8, 7, 6 };

// метод печати массива
void PrintArray(int[] arr)
{
    int count = arr.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
PrintArray(array); // вызвали метод. напечатали массив

Console.WriteLine();

// метод сортировки
void Sort(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[minPos]) minPos = j;
        }
        int temporary = arr[i];
        arr[i] = arr[minPos];
        arr[minPos] = temporary;
    }
}
Sort(array);
PrintArray(array);