using System;

namespace Les3._2
{
    class Program
    {
        public static string revers(string input)
        {
            var inputArray = input.ToCharArray();
            var end = inputArray.Length / 2;

            for (int i = 0; i < end; i++)
            {
                var temp = inputArray[i];
                inputArray[i] = inputArray[inputArray.Length - i - 1];
                inputArray[inputArray.Length - i - 1] = temp;
            }

            var result = new string(inputArray);

            return result;
        }
        static void Main(string[] args)
        {
            string a = "Hello World!";
            string b = "yyyyeeee";
            string c = "hahaha";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(revers(a));
            Console.WriteLine(revers(b));
            Console.WriteLine(revers(c));
        }
    }
}
