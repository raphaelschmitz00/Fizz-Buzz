using System;
using System.Text;


namespace FizzBuzz
{
	internal class Program
	{
		public static int Main(string[] args)
		{
			if (args.Length == 0)
			{
				DoAHundred();
				return 0;
			}
			
			int inputInt;
			if (!int.TryParse(args[0], out inputInt))
			{
				Console.WriteLine("Can't read number!");
				return 1;
			}
			
			string result = EnFizzBuzzNumber(inputInt);
			Console.WriteLine(result);
			return 0;
		}


		private static void DoAHundred()
		{
			for (int i = 1; i <= 100; i++)
			{
				string result = EnFizzBuzzNumber(i);
				Console.WriteLine(result);
			}
		}


		private static string EnFizzBuzzNumber(int input)
		{
			bool isFizz = input % 3 == 0;
			bool isBuzz = input % 5 == 0;

			bool isRegularNumber = !isFizz && !isBuzz;
			if (isRegularNumber) return input.ToString();

			StringBuilder stringBuilder = new StringBuilder();
			if (isFizz) stringBuilder.Append("Fizz");
			if (isBuzz) stringBuilder.Append("Buzz");
			return stringBuilder.ToString();
		}
	}
}