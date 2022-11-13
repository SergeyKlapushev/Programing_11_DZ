// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] matrix = CreatMatrix();
ShowMatrix(matrix);
int[] arraySums = FindSumsNumbersOnLine(matrix);
ShowArraySums(arraySums);
int NumberLineWhithMinSum = FindMin(arraySums);
ShowLineWhithMinSum(NumberLineWhithMinSum);

int[,] CreatMatrix()
{
    int lines = 3;
    int columns = 5;
    int[,] arr = new int[lines, columns];
    FillingInTheArray(arr);
    return arr;
}

int[,] FillingInTheArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 11);
        }
    }
    return arr;
}

void ShowMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}|");
        }
        Console.WriteLine();
    }
}

int[] FindSumsNumbersOnLine(int[,] mat)
{

    int[] line = new int[mat.GetLength(1)];
    int[] arraySum = new int[mat.GetLength(0)];
    int Sum = 0;

    for (int IndexLine = 0; IndexLine < mat.GetLength(0); IndexLine++)
    {
        line = FillingLine(mat, line, IndexLine);
        Sum = FindSumOfLine(line);
        arraySum[IndexLine] = Sum;
    }
    return arraySum;
}

int[] FillingLine(int[,] mat, int[] line, int index)
{
    for (int IndexColumn = 0; IndexColumn < mat.GetLength(1); IndexColumn++)
    {
        line[IndexColumn] = mat[index, IndexColumn];
    }
    return line;
}

int FindSumOfLine(int[] line)
{
    int sum = 0;

    for (int i = 0; i < line.Length; i++)
    {
        sum = sum + line[i];
    }
    return sum;
}

int FindMin(int[] arr)
{
    int NumberLineWhithMinSum = 1;
    int temp = arr[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (temp > arr[i])
        {
            temp = arr[i];
            NumberLineWhithMinSum = i + 1;
        }
    }
    return NumberLineWhithMinSum;
}

void ShowArraySums(int[] arraySums)
{
    for (int i = 0; i < arraySums.Length; i++)
    {
        Console.WriteLine($"{i + 1}-я строка - {arraySums[i]} ");
    }
}

void ShowLineWhithMinSum(int line)
{
    Console.WriteLine($"Строка с минимальной суммой чисел -> {line}");
}