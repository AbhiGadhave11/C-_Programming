/*1.Write a program which accept number from user 
and display its digits in reverse order.
Input : 2395
Output : 
5
9
3
2
Input : 1018
Output : 
8
1
0
1
Input : -1018
Output :
8
1
0
1
Input : 9000
Output : 
0
0
0
9
*/

using System;

class Marvellous
{
	public  void  Display(int iNo)
	{
	   int iDigit = 0;
	   if(iNo<0)
	   {
	   	iNo = -iNo;
	   }
	   while(iNo>0)
	   {
	   	iDigit = iNo % 10;
	   	Console.WriteLine(iDigit);
	   	iNo = iNo / 10;
       }		
	}
}

namespace Assigncs4_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
		   int iValue = 0;
		   
           
		   Console.WriteLine("Enter First Number");
		   iValue = Convert.ToInt32(Console.ReadLine());

           Marvellous mobj = new Marvellous();
		   mobj.Display(iValue);

		    //Console.WriteLine("Result is : "+iRet);
		}
	}
}