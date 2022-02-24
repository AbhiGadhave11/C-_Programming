/*3. Write a program which accept string from user and 
copy that characters of that string into another string 
by converting all small characters into capital case.

Input : “Marvellous Python 2”

Output : “MARVELLOUS PYTHON 2”
*/

using System;

class Myclass
{
	public String Uppercase(String str)
	{
		String newStr = str.ToUpper();
		return newStr;
	}
}

namespace Assign26_Q3
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");
			String str = Console.ReadLine();

			Myclass mobj = new Myclass();
			String newStr = mobj.Uppercase(str);
			Console.WriteLine("Reverse String : "+newStr);
		}
	}
}
