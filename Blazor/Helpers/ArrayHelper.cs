namespace DSS.Helpers
{
    public class ArrayHelper
    {
        public static string ElementsToString(byte[] arr)
        {
            System.Console.WriteLine("MATTEO 2");
            string res = "";
            for (int i = 0; i < arr.Length; i++)
            {
                res += arr[i] + " ";
            }
            return res;
        }

        public static string ElementsToString(string[] arr)
        {
            string res = "";
            foreach (string x in arr)
            {
                res += "'" + x + "' ";
            }
            return res;
        }

        public static string ElementsToString(int[] arr)
        {
            string res = "";
            foreach (int x in arr)
            {
                res += x + " ";
            }
            return res;
        }

        public static double Avg(double[] arr)
        {
            double r = 0;
            foreach (double x in arr)
                r += x;
            return r/arr.Length;
        }

    
        public static double Min(double[] arr)
        {
            double res = arr[0];
            foreach(double x in arr)
            {
                if (x < res)
                    res = x;
            }
            return res;
        }

        public static double Max(double[] arr)
        {
            double res = arr[0];
            foreach (double x in arr)
            {
                if (x > res)
                    res = x;
            }
            return res;
        }
     
        public static double Sum(double[] arr)
        {
            double Sum = 0;
            foreach (double x in arr)
            {
                    Sum += x;
            }
            return Sum;
        }
      
        public static double Product(double[] arr)
        {
            double Prod = 1;
            for(int i=0; i< arr.Length; i++)
            {
                    Prod *= arr[i];
            }
            return Prod;
        }
    }
}
