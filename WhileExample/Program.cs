﻿
namespace WhileExample
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1 to 10
			int i = 1;
			do
			{
				System.Console.WriteLine(i + "");
				i++;
			}
			while (i <= 10);
			System.Console.WriteLine();

			// 0 to 9
			i = 0;
			do
			{
				System.Console.WriteLine(i + "");
				i++;
			}
			while (i < 10);
			System.Console.WriteLine();

			// 9 to 0
			i = 9;
			do
			{
				System.Console.WriteLine(i + "");
				i--;
			}
			while (i >= 0);

			System.Console.ReadKey();
		}
	}
}
