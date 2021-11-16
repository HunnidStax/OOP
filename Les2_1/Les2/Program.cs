using System;

namespace Les2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAcc acc = new BankAcc();
            acc.SetWallet(400000);
            acc.SetAccType(AccType.NRI);
            Console.WriteLine(acc);
            BankAcc bank = new BankAcc(120_000, AccType.Savings);
            bank.GetWallet();
            bank.SetWallet(300000);
            Console.WriteLine(bank);
        }
    }
}
