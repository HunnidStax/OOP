using System;

namespace Les2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc(123000);
            acc.Type = AccType.Current;
            Console.WriteLine(acc);
            Console.WriteLine(acc.TakeFounds(100000));
            Console.WriteLine(acc);
            Console.WriteLine(acc.TakeFounds(200000));
            Console.WriteLine(acc);
            Console.WriteLine(acc.AddFounds(500000));
            Console.WriteLine(acc);
            Console.WriteLine("-------------------------------------");
            BankAcc acc1 = new BankAcc(AccType.NRI);
            Console.WriteLine(acc1);
            Console.WriteLine(acc1.AddFounds(5000000));
            Console.WriteLine(acc1);
            Console.WriteLine("-------------------------------------");
            BankAcc bank = new BankAcc(120_000, AccType.Savings);
            Console.WriteLine(bank);
            Console.WriteLine(bank.Wallet);
            Console.WriteLine(bank.Type);
            bank.Type = AccType.Current;
            Console.WriteLine(bank.Type);
            bank.Wallet = 30_000;
            Console.WriteLine(bank.Wallet);
        }
    }
}