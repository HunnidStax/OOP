using System;

namespace Les3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc(123000);
            acc.Type = AccType.Current;
            Console.WriteLine(acc);
            Console.WriteLine("-------------------------------------");
            BankAcc acc1 = new BankAcc(AccType.NRI);
            Console.WriteLine(acc1.AddFounds(5000000));
            Console.WriteLine(acc1);
            Console.WriteLine("-------------------------------------");
            acc.TranferFounds(acc1, 100);
            Console.WriteLine(acc);
            Console.WriteLine(acc1);
        }
    }
}
