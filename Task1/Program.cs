// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int [,] array = CreatMatrix();
Console.WriteLine();

Messager("Матрица до упорядочивания: ");
ShowMatrix(array);
Console.WriteLine();

Messager("Матрица после упорядочивания: ");
array = ArrangeTheArray(array);
ShowMatrix(array);
Console.WriteLine();

int[,] CreatMatrix()
{   

    Messager("Введите кол-во строк (от 1 до 5): ");
    int lines = Convert.ToInt32(Console.ReadLine());
    
    Messager("Введите кол-во стобцов (от 1 до 5): ");
    int columns = Convert.ToInt32(Console.ReadLine());

    int[,] arr = new int[lines, columns];
    FillingInTheArray(arr);
    return arr;
}

void Messager(string message)
{
    Console.WriteLine(message);
}

void ShowMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}|");
        }
        Console.WriteLine();
    }
}

int [,] FillingInTheArray(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(-10, 11);
        }
    }
    return arr;
}

int[,] ArrangeTheArray(int[,]arr)
{
    int [] line = new int [arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < line.Length; j++)
        {

            line[j] = arr[i,j];

        }
        line = ArrangeRow(line);

        for (int x = 0; x < line.Length; x++)
        {
            arr[i,x] = line[x];
        }
    }
    return arr;
}

int[] ArrangeRow(int[] line)
{
    for (int i = 0; i < line.Length; i++)
    {
        for (int j = 0; j < line.Length; j++)
        {
            if(line[i] > line[j])
            {
                int temp = line[i];
                line[i] = line[j];
                line[j] = temp;
            }
        }
    }
    return line;
}