using ClassLibrary1;
using consuming;
using Microsoft.VisualBasic;
using System.Text;

internal class Program
{

  

    public static void Main(string[] args)
    {
        NumericFunction func = new NumericFunction();
       Console.WriteLine( func.Add(1, 2, 3, 4, 5, 6));

        Console.WriteLine(func.IsPrime(11));
        Console.WriteLine(func.AllEven(2,40));
        Console.WriteLine(func.AllOdd(3, 33));
        Console.WriteLine(func.AllPrime(4, 60));
        Console.WriteLine(func.reverse(235));
        Console.WriteLine(func.isPalindrome(333));
        Console.WriteLine(func.countchar("My name is moksh"));
        Console.WriteLine(func.reversesen("My name is moksh"));
    }
}

