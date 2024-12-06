// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
	static void Main(string[] args)
	{
		// Task 1: Declaring and initializing a variables and print their values
		string name = "John Doe";
		int age = 25;
		bool isAdmin = true;

		Console.WriteLine("Task 1 solution:");
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Age: " + age);
		Console.WriteLine("Is Admin: " + isAdmin);
		Console.WriteLine();

		// Task 2: If the number is even or odd
		Console.WriteLine("Task 2:");
		Console.Write("Enter an integer: ");
		int userInput = int.Parse(Console.ReadLine());
		if (userInput % 2 == 0)
		{
			Console.WriteLine("Even");
		}
		else
		{
			Console.WriteLine("Odd");
		}
		Console.WriteLine();

		// Task 3: Printing numbers 1 to 10 using a for loop
		
		for (int i = 1; i <= 10; i++)
		{
			Console.WriteLine(i);
		}
		Console.WriteLine();

		// Task 4: Work with an integer array
		int[] numbers = { 2, 4, 6, 8, 10 };
		int sum = 0;

		//Console.WriteLine("Task 4:");
		Console.WriteLine("Array elements:");
		foreach (int num in numbers)
		{
			Console.WriteLine(num);
			sum += num;
		}
		Console.WriteLine("Sum of all elements: " + sum);
		Console.WriteLine();

		// Task 5: Method to print a greeting
		//Console.WriteLine("Task 5:");
		Greet("Alice");

		for(int i = 1;i <= 10; i++)
		{
			Console.WriteLine($"{i}");
		}
		
	}

	// Method for Task 5
	static void Greet(string name)
	{
		Console.WriteLine($"Hello, {name}!");
		
	}
}
