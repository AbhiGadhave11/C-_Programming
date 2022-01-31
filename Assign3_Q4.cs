/*4.Accept one character from user and convert 
case of that character.
Input : a Output : A
Input : D Output : d
*/

using System;

class Marvellous
{
	public void Display(char ch)
	{
		if(ch>='A'&&ch<='Z')
		{
			
			Console.WriteLine(char.ToLower(ch));
		}
		if(ch>='a'&&ch<='z')
		{
			
			Console.WriteLine(char.ToUpper(ch));
		}
		
	}
}

namespace Assigncs3_Q4
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   char cValue ;
           
		   
		   Console.WriteLine("Enter the character");
		   cValue = Console.ReadLine()[0];

           Marvellous mobj = new Marvellous();
		   mobj.Display(cValue);

		}
	}
}
