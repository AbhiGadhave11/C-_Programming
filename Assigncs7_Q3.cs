/*4. Write a program which accept temperature in 
   Fahrenheit and convert it into celsius. 
(1 celsius = (Fahrenheit -32) * (5/9))
Input : 10
Output : -12.2222 (10 - 32) * (5/9)
Input : 34
Output : 1.11111 (34 - 32) * (5/9)
*/

using System;

namespace Assigncs7_Q3
{
	class Program
	{
		public static float tempc(int iNo)
		{
			float fAns = 0.0f;
			fAns =(float)(iNo-32) * 5 / 9;
			return fAns; 
		}
		public static void Main(String[] Arg)
		{
			int iValue = 0;
			float fRet = 0.0f;
			Console.WriteLine("Enter temperature in Fahrenheit");
			iValue = Convert.ToInt32(Console.ReadLine());
			fRet = tempc(iValue);
			Console.WriteLine("temperature in celcius is : "+fRet);
		}
	}
}