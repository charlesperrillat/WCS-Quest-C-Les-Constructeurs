using System;
namespace _1_POO_Les_constructeurs
{
	public class Building
	{
		private int _numberOfFloors;
		private double _height;

		public Building(int numberOfFloors) : this(numberOfFloors, numberOfFloors * 3)
		{ }

		public Building(double height) : this((int) (height / 3), height)
		{ }

        public Building(int numberOfFloors, double height)
		{
			_numberOfFloors = numberOfFloors;
			_height = height;
        }

		public double GetFloorMaxSize()
		{
			return _height / _numberOfFloors;
		}

		public int GetFloorCount()
		{
			return _numberOfFloors;
		}

		public double GetSize()
		{
			return _height;
		}
    }
}

