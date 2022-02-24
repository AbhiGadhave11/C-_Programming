/*4. Write a program which accept string from user and 
copy that characters of that string into another string 
by converting all capital characters into small case.

Input : “Marvellous Python 2”

Output : “marvellous python 2”
*/

using System;

class Myclass
{
	public String Lowercase(String str)
	{
		String newStr = str.ToLower();
		return newStr;
	}
}

namespace Assign26_Q4
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Myclass mobj = new Myclass();
			String newStr = mobj.Lowercase(str);
			Console.WriteLine("Reverse String : "+newStr);
		}
	}
}
