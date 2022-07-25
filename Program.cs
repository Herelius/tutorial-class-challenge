using System;

namespace Constructors
{
    public static class Program
    {
        public static void Main()
        {
            Building firstBuilding = new Building(60);
            Building secondBuilding = new Building(45, 5);
            Building[] buildings = { firstBuilding, secondBuilding };

            foreach (Building building in buildings)
            {
                Console.WriteLine("Floor height = " + building.GetFloorMaxheight() + " m");
                Console.WriteLine("Number of floors = " + building.GetFloorCount() + " floors");
                Console.WriteLine("height of the building = " + building.Getheight() + " m");
                Console.WriteLine("");
            }
        }
    }
    public class Building
    {
        private double _height;
        private int _floors;
        public Building(double height, int floors)
        {
            _height = height;
            _floors = floors;
        }
        public Building(int floors)
        {
            _floors = floors;
            _height = _floors * 3.0;
        }
        public double GetFloorMaxheight()
        {
            return _height / _floors;
        }
        public int GetFloorCount()
        {
            return Convert.ToInt32(_height / _floors);
        }
        public double Getheight()
        {
            return _height;
        }
    }
}