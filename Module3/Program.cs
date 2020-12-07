using System;

public class Program
{
	public static void Main()
	{
		//string MyName = "Jane";
		//byte MyAge = 27;
		//bool MyPet = true;
		//double MyShoe = 37.5;

		//Console.WriteLine("My name is" + MyName);
		//Console.WriteLine("My age is" + MyAge);
		//Console.WriteLine("Do I have a pet? -" + MyPet);
		//Console.WriteLine("My shoe size is " + MyShoe);

		Console.Write("Введите имя: ");
		var name = Console.ReadLine();
		Console.Write("Введите возраст: ");
		var age = Convert.ToInt32(Console.ReadLine());
		Console.Write("Введите дату рождения: ");
		var birthday = Console.ReadLine();
		Console.WriteLine("Ваш день рождения {0}", birthday);
	}
}