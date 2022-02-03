/*4. Accept Character from user and check whether 
it is small case ornot (a-z).
Input : g
Output : TRUE
Input : D
Output : FALSE
*/


using System;

class MyArray
{
	public bool ChkAlphabet(char ch)
	{
		if(ch>='a' && ch<='z')
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}

namespace Assign20_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the Character");
			char ch = '\0';
			ch = Convert.ToChar(Console.ReadLine());


			MyArray mobj = new MyArray();

			bool bRet = mobj.ChkAlphabet(ch);
			if(bRet == true)
			{
				Console.WriteLine("TRUE");
			}
			else
			{
				Console.WriteLine("FALSE");
			}
		}
	}
}
