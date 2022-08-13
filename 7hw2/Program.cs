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

void ElementCheckArray(double[,] arr, int row, int column)
{
    if((row <= arr.GetLength(0))&&column <=arr.GetLength(1))
        Console.WriteLine($"{arr[row-1,column-1]}");
    else    
        Console.WriteLine("Task is not correct");
}

double[,] arr1 = Fill2xArray1(3,2,1,5);
Print2xArray(arr1);
ElementCheckArray(arr1, 2,3);
