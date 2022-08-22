void Print2xArray(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for(int i=0; i<row_size; i++)
    {
        for(int j=0; j<column_size; j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Fill2xArray(int row, int column, int min, int max)
{
    int[,] arr = new int[row,column];

    for(int i=0; i<row; i++)
    {
        for(int j=0; j<column; j++)
        {
            arr[i,j]=new Random().Next(min,max+1);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return(arr);
}

double[] Count2xArray(int[,] arr)
{
    double[] Sum1 = new double[arr.GetLength(0)];

    for(int i=0; i<arr.GetLength(0); i++)
    {
        double Sum=0;
        for(int j=0; j<arr.GetLength(1); j++)
        {
            Sum+=arr[i,j];
        }
        Sum1[i]=Sum/arr.GetLength(1);
        Console.Write($"{Sum1[i]} ");
    }
    Console.WriteLine();
    return(Sum1);
}



int[,] arr1 = Fill2xArray(3,4,-3,-2 );
Print2xArray(arr1);
Count2xArray(arr1);
