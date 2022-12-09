/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */

int rows = ReadInt("Введите количество строк матрицы: ");
int columns = ReadInt("Введите количество столбцов матрицы: ");
int[,] spiral = new int[rows, columns];

int i = 0;
int j = 0;
int rowBegin = 0;
int columnBegin = 0;
int rowFinal = 0;
int columnFinal = 0;
int k = 1;


while (k <= spiral.Length)
{
    spiral[i, j] = k;
    if (i == rowBegin && j < columns - columnFinal - 1)
        j++;
    else if (j == columns - columnFinal - 1 && i < rows - rowFinal - 1)
        i++;
    else if (i == rows - rowFinal - 1 && j > columnBegin)
        j--;
    else i--;
    k++;
    if (i == rowBegin + 1 && j == columnBegin && columnBegin != columns - columnFinal - 1)
    {
        rowBegin++;
        columnBegin++;
        rowFinal++;
        columnFinal++;
    }

}
WriteMatrix(spiral);

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j] + "   ");
            }
            else
            {
                Console.Write(array[i, j] + "   ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
