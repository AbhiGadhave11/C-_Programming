using System;

class Marvellous
{
	public void Display()
	{
		Console.WriteLine("Inside Display Function");
	}
}

namespace Function
{
    class Program
	{
		public static void fun()
		{
			Console.WriteLine("Inside fun");
		}
		public static void Main(String[] Arg)
		{
			fun();
			Marvellous mobj = new Marvellous();
			mobj.Display();
		}
	}
}