/*2. Accept N numbers from user and return the 
smallest number.
Input : N : 6

Elements :85 66 3 66 93 88

Output : 3
*/

using System;

 class MyArray
 {
 	public int Minimum(int [] Arr)
 	{
 		int iSmall = Arr[0];
 		for(int i=0;i<Arr.Length;i++)
 		{
 			if(iSmall > Arr[i])
 			{
 				iSmall = Arr[i];
 			}
 		}
 		return iSmall;
 	}
 }

 namespace Assign19_Q2
 {
 	class Program
 	{
 		public static void Main(String [] Arg)
 		{
 			int size = 0;
 			Console.WriteLine("Enter the Size of an Array");
 			size = Convert.ToInt32(Console.ReadLine());
 			int []Arr = new int[size];
 			Console.WriteLine("Enter the Elements");
 			for(int i=0;i<size;i++)
 			{
 				Arr[i] = Convert.ToInt32(Console.ReadLine());
 			}

 			MyArray mobj = new MyArray();
 			int iRet = mobj.Minimum(Arr);
 			Console.WriteLine("Minimum Element in the Array is : "+iRet);
 		}
 	}
 }