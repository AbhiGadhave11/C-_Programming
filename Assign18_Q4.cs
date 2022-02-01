/*4. Accept N numbers from user and accept Range, 
Display all elements from that range
Input : N : 6
Start: 60
End : 90
Elements :85 66 3 76 93 88

Output : 66 76 88
Input : N : 6
Start: 30
End : 50
Elements :85 66 3 76 93 88
*/

using System;

class MyArray
{
	public void Display(int[] Arr,int no1,int no2)
	{
		int i = 0;
		Console.WriteLine("Elements are : ");
		for( i=0;i<Arr.Length;i++)
		{
			if(Arr[i]>=no1 && Arr[i]<=no2)
			Console.WriteLine(Arr[i]);
		}
		
	}
}

namespace Assign17_Q3
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int[] Arr;
			int size = 0,no1=0,no2=0;
			Console.WriteLine("Enter the size of an array");
			size = Convert.ToInt32(Console.ReadLine());
			
			Console.WriteLine("Enter Starting Point");
			no1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter Ending Point");
			no2 = Convert.ToInt32(Console.ReadLine());


			Arr = new int[size];
			Console.WriteLine("Enter the Elements");
			for(int i=0;i<size;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			
			MyArray mobj = new MyArray();
			 mobj.Display(Arr,no1,no2);
			
			
		}
	}
}