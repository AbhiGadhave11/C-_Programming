/*2. Write a program which accept width & height of 
  rectangle from user and calculate its area.
  (Area = Width * Height)
  Input : 5.3 9.78
  Output : 51.834
 */

using System;

namespace Assigncs7_Q4
{
	class Program
	{
		public static float Area(float Width,float Height)
		{
			float fAns = 0.0f;
			fAns = (float)Width * Height;
			return fAns;
		}
		public static void Main(String[] Arg)
		{
			float iValue1=0.0f,iValue2=0.0f,fRet=0.0f;
			Console.WriteLine("Enter The Widht");
			iValue1 = Convert.ToSingle(Console.ReadLine());

			Console.WriteLine("Enter the Height");
			iValue2 = Convert.ToSingle(Console.ReadLine());

			fRet = Area(iValue1,iValue2);
			Console.WriteLine("Area of rectangle is : "+fRet);
		}
	}
}