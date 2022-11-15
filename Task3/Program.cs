// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Просим ввести данные матрицы А
Message("Введите кол-во строк 1-ой матрицы: ");
int countLine = Inputer();
Message("Введите кол-во столбцов 1-ой матрицы: ");
int countColums = Inputer();

//Создаём матрицу А и показываем её пользователю 
int[,] matrixA = CreatMatrix(countLine, countColums);
ShowMatrix(matrixA);
Console.WriteLine();

//Просим ввести данные матрицы B
Message("Введите кол-во строк 2-ой матрицы: ");
countLine = Inputer();
Message("Введите кол-во столбцов 2-ой матрицы: ");
countColums = Inputer();

//Создаём матрицу А и показываем её пользователю
int[,] matrixB = CreatMatrix(countLine, countColums);

//Если кол-во столбцов матрицы А совпадает с кол-вом стобцов матрицы B, то умножаем эти матрицы
if (matrixA.GetLength(1) == matrixB.GetLength(0))
{   
    ShowMatrix(matrixB);
    Console.WriteLine();

    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    matrixC = MultiplicationMatrix(matrixA, matrixB, matrixC);
    Console.WriteLine();
    ShowMatrix(matrixC);
}

// Иначе сообщаем что данные введены не правильно
else{Message("Матрицы не умножить! Кол-во столбцов 1-ой матрицы должно совпадать с ко-вом строк 2-ой матрицы");}

// Выводит сообщения
void Message(string message)
{
    Console.WriteLine(message);
}

//Вводим данные для матриц (цифрами матрица заполняется автоматически)
int Inputer()
{
    int num = 0;
    return num = Convert.ToInt32(Console.ReadLine());
}

// Создает матрицу
int[,] CreatMatrix(int l, int c)
{
    int lines = l;
    int columns = c;
    int[,] mat = new int[l, c];
    FillingInTheMatrix(mat);
    return mat;
}

//Заполняет матрицу цифрами
int[,] FillingInTheMatrix(int[,] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(0, 5);
        }
    }
    return arr;
}

//Показывавет матрицу пользователю
void ShowMatrix(int[,] mat)
{
    for (int i = 0; i < mat.GetLength(0); i++)
    {
        for (int j = 0; j < mat.GetLength(1); j++)
        {
            Console.Write($"{mat[i, j]}|");
        }
        Console.WriteLine();
    }
}

//Процес сумножения матриц
int[,] MultiplicationMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            matrixC[i, j] = FindMultElement(matrixA, matrixB, i, j);
        }
    }
    return matrixC;
}

//Нахожит произведение елементов матрицы А и B для матрицы С 
int FindMultElement(int[,] a, int[,] b, int x, int y)
{
    int mult = 0;

    for (int j = 0; j < a.GetLength(1); j++)
    {
        mult += a[x, j] * b[j, y];
    }
    return mult;
}
