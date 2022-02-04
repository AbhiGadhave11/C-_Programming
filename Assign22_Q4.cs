/*4. Write a program which accept string from user 
and check whether it contains vowels in it or not.

Input : “marvellous”

Output : TRUE

Input : “Demo”

Output : TRUE

Input : “xyz”

Output : FALSE
*/

using System;

class MyArray
{
	public bool ConvertCapital(String str)
	{
		char []Arr = str.ToCharArray();
		bool flag = false;

		foreach(char ch in Arr)
		{
			if(ch=='a' || ch<='e'|| ch<='i'|| ch<='o'|| ch<='u'|| ch<='A'|| ch<='E'|| ch<='I'|| ch<='O'|| ch<='U')
			{
				flag = true;
				break;
			}
		}
		return flag;
	}
}

namespace Assign22_Q4
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the String");

			String str = null;

			str = Console.ReadLine();

			MyArray mobj = new MyArray();

			bool bRet = mobj.ConvertCapital(str);
			
			if(bRet == true)
			{
				Console.WriteLine("Vowels are There");
			}			
			else
			{
				Console.WriteLine("Vowels are Not Present");
			}
		}
	}
}
