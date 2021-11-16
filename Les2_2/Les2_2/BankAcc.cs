using System;
using System.Collections.Generic;
using System.Text;

public enum AccType
{
    Unsigned,
    Current,
    Savings,
    NRI
}

namespace Les2_2
{
    public class BankAcc
    {
        static public int wallet = 0;
        static public AccType type = AccType.Unsigned;
        public int no { get; set; }
        Random _No = new Random();
        public int Wallet
        {
            get
            {
                return wallet;
            }
            set
            {
                    wallet = value;
            }
        }
        public AccType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        public void AccNo()
        {
            no = _No.Next(100, 1000);
        }

        public BankAcc()
        {
            AccNo();
        }

        public BankAcc(int Wall) : this()
        {
            wallet = Wall;
        }

        public BankAcc(AccType type) : this()
        {
            Type = type;
        }

        public BankAcc(int Wall, AccType type) : this()
        {
            wallet = Wall;
            Type = type;
        }

        public string TakeFounds(int val)
        {
            if (val > wallet)
            {
                return $"На счету недостаточно средств:{wallet}";
            }
            else
            {
                wallet = wallet - val;
                return $"Операция выполнена успешно, ваш счет: {wallet}";
            }
        }

        public string AddFounds(int val)
        {
            wallet += val;
            return $"Вам поступило: {val}. Ваш счет: {wallet}.";
        }

        public override string ToString() => $"AccountNumber - {no}, Balans - {wallet}, Type - {Type}";
    }
}