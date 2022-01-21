using System;

namespace Add
{
	class Marvellous
	{
		public static void Main(string[] Arg)
		{
		    int iValue1 = 0,iValue2=0;
		    
		    Console.WriteLine("Enter First Number");
		    iValue1 = Convert.ToInt32(Console.ReadLine());

		    Console.WriteLine("Enter Second Number");
		    iValue2 = Convert.ToInt32(Console.ReadLine());

		    int iAns = 0;
		    iAns = iValue1 + iValue2;

		    Console.WriteLine("Addition is :"+iAns);	
		}
		


	}
}