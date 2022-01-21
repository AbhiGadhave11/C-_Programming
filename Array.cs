using System;
using System.Linq;
using System.Collections;

namespace Arrayx
{
	class Marvellous
	{
		public static void Main(String[] Arg)
		{
			
			int iSize = 0;
			Console.WriteLine("Enter The Size");
			iSize = Convert.ToInt32(Console.ReadLine());
			int[] Arr;

			Arr = new int[iSize];
			

			int i=0;
			Console.WriteLine("Write Elements");
			for(i=0;i<Arr.Length;i++) 
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}
           
            Console.WriteLine("Elements are : ");
			for(i=0;i<Arr.Length;i++)
			{
               Console.WriteLine(Arr[i]);
			}

			Console.WriteLine("Sorting Elements are :");

			Array.Sort(Arr);

			for(i=0;i<Arr.Length;i++)
			{
				Console.WriteLine(Arr[i]);
			}

			Console.WriteLine("Maximum : "+Arr.Max());
			Console.WriteLine("Minimum : "+Arr.Min());
			Console.WriteLine("Sum : "+Arr.Sum());

		}
	}
}