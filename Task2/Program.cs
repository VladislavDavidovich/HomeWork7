// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = Fillmatrix(m, n, 10, -10);
Printmatrix(matr);

void Printmatrix(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
    
        }
        Console.WriteLine();
    }
}    

int[,] Fillmatrix(int rousCount, int columnsCount, int leftRange, int rightRange)
{
    
    int[,] matrix = new int [leftRange , rightRange];
    Random rand = new Random();

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
      return matrix;  
}

Console.WriteLine("Введите координаты позиции ");
int p = Convert.ToInt32(Console.ReadLine());

int[] position = positionMatrix(p);

if(position[0] <= m && position[1] <= n && position[0] >= 0 && position[1] >= 0) 
{
  int result = array[position[0]-1, position[1]-1];
  Console.Write($"Значение элемента: {result}");
}
else Console.Write("такого элемента нет.");