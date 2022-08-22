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

double ArrayMinMaxDelta(double[] array1)
{
    double Min = array1[0];
    double Max = array1[0];
    for(int i=1; i < array1.Length; i++)
    {
        if(array1[i]<Min)
            Min = array1[i];
        if(array1[i]>Max)
            Max = array1[i];    
    }
    Console.WriteLine();
    Console.WriteLine($"{Max-Min} ");
    return(Max-Min);
}

ArrayMinMaxDelta(RandomArray());
