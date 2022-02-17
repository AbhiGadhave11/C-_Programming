/*1.Write a program which accept string from user 
and copy the contents of that string into another 
string. (Implement strcpy() function)
Input : “Marvellous Multi OS”

Output : “Marvellous Multi OS” in another string
*/

using System;

class Myclass
{
	public String StrCpyX(String str)
	{
		char []Arr = str.ToCharArray();
		String newStr ="";

		foreach (char ch in Arr)
		{
			newStr = newStr + ch;
		}
		return newStr; 
	}
}

namespace Assign25_Q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Myclass mobj = new Myclass();
			String newStr = mobj.StrCpyX(str);
			Console.WriteLine("Updated String : "+newStr);
		}
	}
}
