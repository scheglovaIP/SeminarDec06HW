/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */


int minElement = ReadInt("Введите минимальное число диапазона: ");
int maxElement = ReadInt("Введите максимальное число диапазона: ");
int[] numbers = new int[maxElement - minElement + 1];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = minElement + i;
}

for (int i = 0; i < numbers.Length; i++)
{
    int j = new Random().Next(0, numbers.Length);
    int temp = numbers[i];
    numbers[i] = numbers[j];
    numbers[j] = temp;
}

int page = ReadInt("Введите количество страниц матрицы: ");
int rows = ReadInt("Введите количество строк матрицы: ");
int columns = ReadInt("Введите количество столбцов матрицы: ");
int[,,] unic = new int[page, rows, columns];
if (maxElement - minElement + 1 <= unic.Length)
{
    Console.WriteLine($"Матрицу, с указанными параметрами, невозможно заполнить уникальными числами от {minElement} до {maxElement}");
    return;
}
int count = 0;
for (int i = 0; i < unic.GetLength(0); i++)
{
    for (int j = 0; j < unic.GetLength(1); j++)
    {
        for (int k = 0; k < unic.GetLength(2); k++)
        {
            unic[i, j, k] = numbers[count];
            count++;
        }
    }
}
for (int i = 0; i < unic.GetLength(0); i++)
{
    for (int j = 0; j < unic.GetLength(1); j++)
    {
        for (int k = 0; k < unic.GetLength(2); k++)
        {
            Console.Write($"{unic[i, j, k]}({i},{j},{k}) ");
        }
        Console.WriteLine();

    }
}



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

