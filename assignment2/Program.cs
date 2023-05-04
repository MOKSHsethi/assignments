
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Channels;
//using System.Threading.Tasks;


//internal class Assign
//{
//   static void Main(string[] args)
//    {
//        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
//        int sum = 0;
//        float avg = 0;
//        sum = arr.Sum();
//        avg= sum / arr.Length;

//        Console.WriteLine("sum is"+ sum);
//        Console.WriteLine("avrge is"+ avg);
//    }

//}

//internal class Assign
//{
//    static void Main(string[] args)
//    {
//        int[,] arr = new int[,]{ { 1, 2, 3 },{ 4, 5, 6} ,{ 7, 8, 9} };
//        int sum = 0;
//        float avg = 0;
//        for(int i = 0; i < 3; i++)
//        {
//            for (int j = 0; j < 3; j++)
//            {
//                sum += arr[i, j];
//            }
//        }


//        Console.WriteLine("sum is" + sum);

//    }

//}






//internal class Assign
//{
//    static void Main(string[] args)
//    {
//        int[] arr = new int[] { 1, 2, 3 ,  4, 5, 6 , 7, 8, 9  };
//        //int sum = 0;
//        //float avg = 0;
//        int max =arr.Max();


//        Console.WriteLine("max is" + max);

//    }

//}



//internal class Assign
//{
//    static void Main(string[] args)
//    {
//        int[,] arr = new int[,] {{ 1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9 } };

//        //float avg = 0;
//        for(int i = 0; i < 3; i++)
//        {
//            int sum = 0;
//            for(int j = 0; j < 3; j++)
//            {
//                sum += arr[j,i];
//            }

//            Console.WriteLine("sum of coloumn" +i+ "is" + sum);
//        }




//    }

//}


internal class Assign
{
    static void Main(string[] args)
    {
        int[,] arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //float avg = 0;
        for (int i = 0; i < 3; i++)
        {
            int sum = 0;
            for (int j = 0; j < 3; j++)
            {
                sum += arr[i, j];
            }

            Console.WriteLine("sum of row" + i + "is" + sum);
        }




    }
}
