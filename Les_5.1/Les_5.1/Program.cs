using System;

namespace Les_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumber rationalNumber = new RationalNumber(1, 2);
            Console.WriteLine(rationalNumber.ToString());

            RationalNumber sum = rationalNumber + rationalNumber;
            Console.WriteLine(sum.ToString());

            Console.WriteLine(rationalNumber.Equals(rationalNumber));
        }
    }
}
