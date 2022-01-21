//2. Program to print 5 times “Marvellous” on screen.

using System;

class Marvellous
{
	public void Pattern()
	{
        int i=0;
        for(i=1;i<=5;i++)
        {
        	Console.WriteLine("Marvellous");
        }
	}
}
namespace Assigncs1_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			Marvellous mobj = new Marvellous();
			mobj.Pattern();
		}
	}
}