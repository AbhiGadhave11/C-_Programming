/*5. Write a program which accept area in square 
     feet and convert it into square meter.
     (1 square feet = 0.0929 Square meter)
     Input : 5
     Output : 0.464515
     Input : 7
     Output : 0.650321
*/

using System;

namespace Assigncs7_Q5
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			float fArea  = 0.0f,mArea=0.0f;
			Console.WriteLine("Enter the area in Square feet");
			fArea = Convert.ToSingle(Console.ReadLine());
            
            mArea =(float)(fArea*0.0929);
            Console.WriteLine("Area in Square meter is "+mArea);
		}
	}
}
