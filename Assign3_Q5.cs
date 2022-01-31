/*5. Accept on character from user and check 
whether that character is vowel (a,e,i,o,u) or not.
Input : E Output : TRUE
Input : d Output : FALSE
*/

using System;

class Marvellous
{
	public bool Display(char ch)
	{
		if(ch=='a'||ch=='e'||ch=='i'||ch=='o'||ch=='u'||ch=='A'||ch=='E'||ch=='I'||ch=='O'||ch=='U')
		{
			return true;
		}
		else
		{
			return false;
		}
		
	}
}

namespace Assigncs3_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   char cValue ;
           bool bRet = false;
		   
		   Console.WriteLine("Enter the character");
		   cValue = Console.ReadLine()[0];

           Marvellous mobj = new Marvellous();
		   bRet = mobj.Display(cValue);

		   if(bRet==true)
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
