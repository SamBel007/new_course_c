void Print2xArray(double[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($" {arr[i, j], 20} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double[,] Fill2xArray1(int row, int column, int min, int max)
{
    double[,] arr = new double[row,column];

    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            arr[i,j]=new Random().NextDouble()+ new Random().Next(min, max);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

double[,] arr1 = Fill2xArray1(3,4,2,3);
Print2xArray(arr1);
