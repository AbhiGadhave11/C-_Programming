/*2. Write a program which accept string from user and 
copy that characters of that string into another string 
by removing all white spaces.

Input : “Marvel lous Pyth on”
Output : “MarvellousPython”
*/

using System;

class Myclass
{
	public String Remove(String str)
	{
		char []Arr = str.ToCharArray();
		String newStr = "";
		for(int i=0;i<str.Length;i++)
		{
			if(Arr[i] == ' ')
				continue;
			newStr = newStr + Arr[i];
		} 
		return newStr;
	}
}

namespace Assign26_Q2
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Myclass mobj = new Myclass();
			String newStr = mobj.Remove(str);
			Console.WriteLine("Reverse String : "+newStr);
		}
	}
}
