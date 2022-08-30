//В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
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
int[] FindPosition(int[,] matr, int numb)
{
    for(int i=0;i<matr.GetLength(0);i++)
        for(int j=0;j<matr.GetLength(1);j++)
            if(matr[i,j]==numb)
                return new int[]{i,j};
    return new int[] {-1,-1};
}

Console.WriteLine("Введите количество строк m массива: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов n массива: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] matrix = new int[m,n];
FillMatrix(matrix);
Console.WriteLine("Ваш массив: ");
PrintMatrix(matrix);
Console.WriteLine("Введите число для проверки наличия его в массиве: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int[] position = FindPosition(matrix,number);
Console.WriteLine(position[0]< 0 || position[1]< 0 
    ? "К сожалению, данного числа нет в массиве." 
    : $"Позиция заданного Вами числа: ({position[0]},{position[1]})");

                                                                                  



