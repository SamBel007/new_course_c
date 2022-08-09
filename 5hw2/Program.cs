int[] RandomArray()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's min");
    int min = int.Parse(Console.ReadLine());
    Console.WriteLine("Input elemet's max");
    int max = int.Parse(Console.ReadLine());
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(min, max+1);
        Console.Write($"{array[i]} ");
    }
    return(array);
}

void ArrayElementOnPosSumCounter(int[] array1)
{
    Console.WriteLine("Input element's counting %2 pos value (0 for first, third, etc elements; 1 for second, fourth, etc elements");
    int pos = int.Parse(Console.ReadLine());
    int Sum=0;
    for(int i=pos; i < array1.Length; i+=2)
    {
        Sum+=array1[i];
    }
    Console.WriteLine($"Sum of these elements is {Sum}");
}

ArrayElementOnPosSumCounter(RandomArray());
