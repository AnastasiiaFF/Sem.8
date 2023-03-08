// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0 , 1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        //Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        //Console.WriteLine("|");
        Console.WriteLine();
    }
}

int[] MatrixToArray(int [,] matrix)
{
    int c = 0;
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[c] = matrix[i, j];
        }
    }
    return array;
}

void PrintArray(int[] array)
{

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} ");
        else Console.WriteLine($"{array[i]}]");

    }
}


void SumElemArray(int[] array)
{
    int count = 1;
    int currentNum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == currentNum) count ++;
        else 
        {
            Console.WriteLine($"число {currentNum} встречается {count} раз.");
            currentNum = array[i];
            count = 1;
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
int[] array = MatrixToArray(array2d);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Array.Sort(array);
SumElemArray(array);
