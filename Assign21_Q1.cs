/*1. Accept character from user. If character is small 
display its corresponding capital character, and if 
it small then display its corresponding capital. 
In other cases display as it is.
*/

using System;

class Marvellous
{
	public char ConvertAlter(char ch)
	{
		if(ch>='a' && ch<='z')
		{
			ch = char.ToUpper(ch);
		}
		return ch;
	}
}

namespace Assign21_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the Character");
			char ch = '\0';

			ch = Convert.ToChar(Console.ReadLine());

			Marvellous mobj = new Marvellous();
			char newch = mobj.ConvertAlter(ch);

			Console.WriteLine("Updated Letter is : "+newch);

		}
	}
}
