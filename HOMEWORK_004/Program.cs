// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
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
void SortlineMatrix(int[,] matr)
{
 for(int i=0; i<matr.GetLength(0); i++) // Цикл для сортировки в каждой строке i.
 {
    for(int j=0; j<matr.GetLength(1); j++)
    {
       int maxPosition = j;
       for(int k=j+1; k<matr.GetLength(1); k++) // Поиск максимума из оставшихся элементов строки i, начиная со следующей от j.
       {
        if(matr[i,k] > matr[i,maxPosition]) maxPosition = k;           
       }
       int temp = matr[i,j];
       matr[i,j] =  matr[i,maxPosition]; // Перенос максимума влево в пределах одной строки i.
       matr[i,maxPosition] = temp;
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
SortlineMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Ваш упорядоченный массив: ");
PrintMatrix(matrix);
