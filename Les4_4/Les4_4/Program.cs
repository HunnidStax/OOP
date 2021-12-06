using System;

namespace Les4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            House house1 = new House(3, 5, 4);
            Console.WriteLine(house1.ToString());
            Console.WriteLine(house1.GetRoomsCountInHouse());
            House house2 = new House(5, 9, 1);
            Console.WriteLine(house2.ToString());
            Console.WriteLine(house2.GetRoomsCountInPorch());
            Console.ReadKey();
        }
    }
}
