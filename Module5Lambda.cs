using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda {
	class Program {
		static void Main(string[] args) {

			var myNumbers = new List<int> { 0, 0, 2, 3, 4, 4, 5, 9, 11, 14, 14, 18 };

			 // var numbersOver9 = myNumbers.Where(number => number > 9);

			 // foreach (var number in numbersOver9) {
			 // Console.WriteLine(number);
			var OddNumbers = myNumbers.Where(number => number % 2 == 1);

			foreach (var number in OddNumbers) {
			Console.WriteLine(number);
			}

		}
	}
}
