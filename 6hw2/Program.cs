double[] CrossPoint(double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];
    array[0]=(b2-b1)/(k2-k1);
    array[1]=(k1*b2-k2*b1)/(k2-k1);
    Console.Write($"{array[0]} ");
    Console.Write($"{array[1]}");
    return(array);
}
CrossPoint(2,4,6,-10);