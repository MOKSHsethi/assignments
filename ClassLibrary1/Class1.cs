namespace ClassLibrary1
{
    public class NumericFunction
    {
        public int Add (params int[] num)
        {
            return num.Sum();
        }
        public int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        public int Multiply(int num1, int num2)
        {
            return num1*num2;
        }
        public int Divide(int num1, int num2)
        {
            return num1/num2;
        }
        public int MaxNum(params int[] num)
        {
            return num.Max();
        }
        public int MinNum(params int[] num)
        {
            return num.Min();

        }
        public bool IsEven( int num)
        {
            return num%2==0? true: false;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }

        public bool IsPrime(int num)

        {
            int count =  - 1;
            for(int i = 2; i <= Math.Sqrt(num); i++) { 
                if(num%i == 0) {
                    count = 0;

                }
                if (count == 0)
                {
                    return false;
                }
                
            }
            return true;
        }
    }
}