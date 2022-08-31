// В прямоугольной матрице найти строку с наименьшей суммой элементов.
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
int MinPosition(int[] array)
{
int minIndex = 0;
int minSum = array[0];
for(int i=0; i<array.Length-1; i++)
{
   if(array[i+1] < minSum)
    {
    minSum = array[i+1];
    minIndex = i+1;
    }
}
return minIndex;
}
Console.WriteLine("Введите размер прямоугольной матрицы: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int n = m;
int[,] matrix = new int[m,n];
FillMatrix(matrix);
Console.WriteLine("Ваша матрица: ");
PrintMatrix(matrix);
Console.Write("Массив значений сумм по строкам матрицы: ");
int[] arrayLine = new int[m];
for(int i=0; i<m; i++)
{
    int sum = 0;
    for(int j=0; j<m; j++)
    {
     sum = sum + matrix[i,j];
    }
    arrayLine[i] = sum;
    Console.Write($" {arrayLine[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Строка с наименьшей суммой элементов - {MinPosition(arrayLine)+1}-я.");