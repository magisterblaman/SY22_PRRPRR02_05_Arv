using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_05_Arv {
	internal class Vehicle {
		public int horsePower;
		public int numberOfTyres;
		public string color;

		public Vehicle(int inputHorsePower, 
			int inputTyres, 
			string inputColor) {

			horsePower = inputHorsePower;
			numberOfTyres = inputTyres;
			color = inputColor;
		}

		public void PrintInfo() {
			Console.WriteLine("Vehicle info ========");
			Console.WriteLine("Horsepower: " + horsePower);
			Console.WriteLine("# Tyres: " + numberOfTyres);
			Console.WriteLine("Color: " + color);
		}
	}
}
