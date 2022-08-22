int[] CrAr()
{
    Console.WriteLine("Input number of elements");
    int num = int.Parse(Console.ReadLine());
    // Console.WriteLine("Input elemet's min");
    // int min = int.Parse(Console.ReadLine());
    // Console.WriteLine("Input elemet's max");
    // int max = int.Parse(Console.ReadLine());
    int min = 100;
    int max = 999;
    int[] array = new int[num];
    for(int i=0; i < num; i++)
    {
        array[i]=new Random().Next(min, max+1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return(array);
}
void ArrayElement(int[] array1)
{
    int rem=2;
    while(rem<0||rem>1)
    {
        Console.WriteLine("Input %2 element's value need to count (0 or 1)");
        rem = int.Parse(Console.ReadLine());
    }
    int a=0;
    int Sum=0;
    for(int i=0; i < array1.Length; i++)
    {
        
        if(array1[i]%2==rem)
        {
            a+=1;
            Sum+=array1[i];
        }         
    }
    if (a==0)
        Console.WriteLine("This values isn't found in array");
    else
        Console.WriteLine($"This values is found in array {a} times, Sum of these elements is {Sum}");
}
ArrayElement(CrAr());
