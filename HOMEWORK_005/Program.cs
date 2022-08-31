// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
//что это невозможно (в случае, если матрица не квадратная).
void FillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 100);
        }
    }
}
void PrintMatrix(int[,] matr)
{
   for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    } 
}
void RowtocolumnMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0)-1; i++)
    {
        for(int j=i+1; j<matr.GetLength(1); j++)
        {
            int temp = matr[i,j];
            matr[i,j] = matr[j,i];
            matr[j,i] = temp;
        }
    }
}
Console.WriteLine("Введите количество строк m массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов n массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
FillMatrix(matrix);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
Console.WriteLine();
if(m==n)
{
 RowtocolumnMatrix(matrix);
 PrintMatrix(matrix);
}
else
{
Console.WriteLine("Заданную матрицу невозможн преобразовать, т.к. она не квадратная");
}