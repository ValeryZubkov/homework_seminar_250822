// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
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
Console.WriteLine("Введите количество строк m массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов n массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
FillMatrix(matrix);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
for(int j = 0; j<n; j++)
{
    double sum = 0;
    for(int i = 0; i<m; i++)
    {
     sum = sum + matrix[i,j];  
    } 
    double average = Math.Round(sum / m, 2);
    Console.WriteLine($"Среднее арифметическое {j+1}-го столбца равна: {average}");
}
