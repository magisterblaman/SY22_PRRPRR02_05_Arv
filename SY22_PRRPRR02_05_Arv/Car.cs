using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_05_Arv {
	internal class Car : Vehicle {
		public int numberOfDoors;
		public int pulleyCapacity;

		public Car(int inputHorsePower, 
			string inputColor,
			int inputDoors,
			int inputPulleyCap) : base(inputHorsePower, 4, inputColor) {

			numberOfDoors = inputDoors;
			pulleyCapacity = inputPulleyCap;
		}

		public new void PrintInfo() {
			Console.WriteLine("Car info ========");
			Console.WriteLine("Horsepower: " + horsePower);
			Console.WriteLine("# Tyres: " + numberOfTyres);
			Console.WriteLine("Color: " + color);
			Console.WriteLine("# Doors: " + numberOfDoors);
			Console.WriteLine("Pulley cap: " + pulleyCapacity);
		}
	}
}
