using System;

namespace Les_6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc a1 = new BankAcc(100, "RUR");
            BankAcc a2 = new BankAcc(100, "RUR");
            BankAcc a3 = new BankAcc(100, "USD");
            Console.WriteLine(a1.GetHashCode()); // 101
            Console.WriteLine(a2.GetHashCode()); // 101
            Console.WriteLine(a3.GetHashCode()); // 102
            Console.WriteLine(a3.ToString());
            Console.WriteLine(a1.Equals(a3));
        }
    }
}
