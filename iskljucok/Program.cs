using System;
using System.IO;

interface IVrednosti
{

}

class TestiranjeIsklucoci:IVrednosti
{
    static double BezbednoDelenje(double x, double y)
    {
        if (y == 0)
            throw new System.DivideByZeroException();
        return x / y;
    }

    static void Main()
    {
        
        double a = 98, b = 5;
        double rez = 0;

        try
        {
            rez = BezbednoDelenje(a, b);
            Console.WriteLine("{0} podeleno so {1} = {2}", a, b, rez);
            Console.ReadLine();
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Delenje so 0 !");
            Console.ReadLine();
        }
    }
}