using System;
using System.Collections.Generic;
using System.Text;

namespace Les_6._1
{
    public class BankAcc
    {
        private readonly decimal Amount;
        private readonly string Type;

        public BankAcc() { }
        public BankAcc(decimal amount, string type)
        {
            Amount = amount;
            Type = type;
        }

        public decimal A_mount
        {
            get { return Amount; }
        }

        public string T_ype
        {
            get { return Type; }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            BankAcc m = obj as BankAcc;
            if (m as BankAcc == null)
                return false;
            return m.Amount == this.Amount && m.Type == this.Type;
        }
        public bool Equals(BankAcc obj)
        {
            if (obj == null)
                return false;
            return obj.Amount == this.Amount && obj.Type == this.Type;
        }

        public static bool operator ==(BankAcc a, BankAcc b)
        {
                return (a.Type == b.Type); //   ??? System.NullReferenceException: "Object reference not set to an instance of an object."
        }
        public static bool operator !=(BankAcc a, BankAcc b)
        {
            return (a.Type != b.Type);
        }

        public override int GetHashCode()
        {
            int unitCode;
            if (Type == "RUR")
                unitCode = 1;
            else unitCode = 2;
            return (int)Amount + unitCode;
        }

        public override string ToString()
        {
            return "Acc: " + Type + " Money: " + Amount;
        }
    }
}
