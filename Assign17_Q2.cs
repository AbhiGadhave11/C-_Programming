/*2. Accept N numbers from user and return difference 
between frequency of even number and odd numbers.
Input : N : 7

Elements :85 66 3 80 93 88 90

Output : 1 (4 -3)
*/

using System;

class MyArray
{
	public int Even(int[] Arr)
	{
	int iCnt1=0,iCnt2=0;
	for(int i=0;i<Arr.Length;i++)
	{
		if(Arr[i]%2==0)
		{
			iCnt1++;
		}

		else
		{
			iCnt2++;
		}
	}

	return iCnt1-iCnt2;
    }
}

namespace Assign17_Q2
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			int n=0;
			Console.WriteLine("Enter Number of Elements");
			n = Convert.ToInt32(Console.ReadLine());
			int[] Arr = new int[n];
			for(int i=0;i<Arr.Length;i++)
			{
				Arr[i] = Convert.ToInt32(Console.ReadLine());
			}

			 MyArray mobj = new MyArray();
			 int iRet = mobj.Even(Arr);
			Console.WriteLine("Difference between even and odd Elements is : "+iRet); 

		}
	}
}