double[] RandomArray()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's max");
    int max = int.Parse(Console.ReadLine());
    double[] array = new double[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().NextDouble()+ new Random().Next(min, max);
        Console.Write($"{array[i]} ");
    }
    return(array);
}

double[] CopyArray(double[] array1)
{
    double[] array2 = new double[array1.Length];
    for(int i=0;i<array1.Length;i++)
        array2[i]=array1[i];
    return(array2);    
}

CopyArray(RandomArray());
