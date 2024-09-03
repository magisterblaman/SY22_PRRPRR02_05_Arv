using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_05_Arv {
	internal class Program {
		static void Main(string[] args) {

			Vehicle vehicle = new Vehicle(250, 3, "pink");

			vehicle.PrintInfo();

			Car car = new Car(200, "orange", 2, 2);

			car.PrintInfo();

		}
	}
}
