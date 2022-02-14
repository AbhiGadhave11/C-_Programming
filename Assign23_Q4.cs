/*4. Write a program which accept string from user and 
display only digits from that string.

Input : “marve89llous121”

Output : 89121

Input : “Demo”

Output :
*/

using System;

class MyArray
{
	public void ConvertSmall(String str)
	{
		char []Arr = str.ToCharArray();

		Console.Write("Digits in String are : ");

		for(int i=0;i<Arr.Length;i++)
		{
			if(Arr[i]>='0' && Arr[i]<='9')
			{
				Console.Write(Arr[i]);
			}
			
			
			
		}
		Console.WriteLine();
	}
}

namespace Assign23_Q4
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = Console.ReadLine();

			MyArray mobj = new MyArray();
			mobj.ConvertSmall(str);
		}
	}
}
