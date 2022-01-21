//3. Program to print 5 to 1 numbers on screen.

using System;

class Marvellous
{
	public void Pattern()
	{
        int i=0;
        for(i=5;i>=1;i--)
        {
        	Console.WriteLine(i);
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