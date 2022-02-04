/*5. Write a program which accept string from user 
and display it in reverse order.

Input : “MarvellouS”

Output : “SuollevraM”
*/

using System;

class MyArray
{
	public void Reverse(String str)
	{
		char []Arr = str.ToCharArray();
		
		for(int i=Arr.Length-1;i>=0;i--)
		{
			Console.Write(Arr[i]);
			
		}
		Console.WriteLine();
		
	}
}

namespace Assign22_Q5
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = null;

			str = Console.ReadLine();

			MyArray mobj = new MyArray();

			mobj.Reverse(str);
			
			
		}
	}
}
