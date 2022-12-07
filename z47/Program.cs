// Задача 47: Задайте двумерный массив размером m×n,
//  заполненный случайными вещественными числами, округлёнными до 
//  одного знака.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void Zadacha47()
{
    Random rand = new Random(-5);
    Console.WriteLine("Ввведите Количество столбцов");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ввведите Количество колонок");
    int n = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[m, n];
    FillArray(array, 10);
    FillNegativeNumber(array);
    PrintArray(array);
}


// Описание методов
void FillArray(double[,] massive, int max)
{
    Random rand = new Random();
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            massive[i, j] = rand.NextDouble() * 5;
            massive[i, j] = Math.Round(massive[i, j], 1, MidpointRounding.ToZero);
        }
    }

}


void PrintArray(double[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(massive[i, j] + "\t");
        }
         Console.WriteLine("\n");
    }
}

void FillNegativeNumber(double[,] massive)
{
    int rows = massive.GetLength(0);
    int columns = massive.GetLength(1);
    for (int i = 0; i < rows -1; i++)

       {
       
        for (int j = 0; j < columns; j++) massive[i+1,j] *=-1;
       }
}

Zadacha47();