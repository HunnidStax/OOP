using System;
using System.Collections.Generic;
using System.Text;

public enum AccType
{
    Current,
    Savings,
    NRI
}

namespace Les2_1

{
    public class BankAcc
    {
        private static int _No = 1;
        public int no { get; }
        public int wallet { get; set; }
        public AccType Type { get; set; }

        public BankAcc()
        {
            no = _No++;
        }

        public BankAcc(int Wall, AccType type)
        {
            no = _No++;
            wallet = Wall;
            Type = type;
        }

        public void SetWallet(int Wall)
        {
            wallet = Wall;
        }
        public void SetAccType(AccType type)
        {
            Type = type;
        }

        public AccType GetAccType()
        {
            return Type;
        }

        public int GetNo()
        {
            return no;
        }

        public int GetWallet()
        {
            return wallet;
        }

        public override string ToString() => $"AccountNumber - {no}, Balans - {wallet}, Type - {Type}";
    }
}
