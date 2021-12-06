using System;

namespace Les4_4
{
    class House
    {
        public int porchCount;
        public int floorCount;
        private int roomsOnFloor;
        private static int numhouse = 0;

        public int Porchs
        {
            get { return porchCount; }
            set { porchCount = value; }
        }

        public int Floors
        {
            get { return floorCount; }
            set { floorCount = value; }
        }

        public int RoomsOnFloor
        {
            get { return roomsOnFloor; }
            set { roomsOnFloor = value; }
        }

        public static int NumHouse{ get; set; }
        public void SetNumHouse()
        {
            numhouse += 1;
        }
        public House()
        {
            SetNumHouse();
        }

        public House(int porchCount, int floorCount, int roomsOnFloor) : this()
        {
            this.porchCount = porchCount;
            this.floorCount = floorCount;
            this.roomsOnFloor = roomsOnFloor;
        }

        public int GetRoomsCountInPorch()
        {
            return roomsOnFloor * floorCount;
        }

        public int GetRoomsCountInHouse()
        {
            return GetRoomsCountInPorch() * porchCount;
        }


        public override string ToString()
        {
            return string.Format("Количество этажей: {0} \nКоличество подъездов: {1} \nНомер дома: {2}", Floors, Porchs, numhouse);
        }
    }
}
