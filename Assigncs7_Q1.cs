/*1.Write a program which accept radius of circle 
from user and calculate its area.
Consider value of PI as 3.14.
(Area = PI * Radius * Radius)
Input : 5.3
Output : 88.2026
Input : 10.4
Output : 339.6224
*/

using System;

class Marvellous
{
	public float Area(float radius)
	{
        float fAns = 0.0f;
        float PI = 3.14f;
        fAns = PI * radius * radius;
        return fAns;
    }
}

namespace Assigncs7_Q1
{
	class Program
	{
		public static void Main(String[] Arg)
		{
			float iValue = 0.0f,iRet=0.0f;
			Console.WriteLine("Enter the radius");
			
		  //iValue = Single.Parse(Console.ReadLine());
          iValue = Convert.ToSingle(Console.ReadLine());
          //iValue = Single.Parse(Console.ReadLine()); 

			Marvellous mobj = new Marvellous();
			iRet = mobj.Area(iValue);
			Console.WriteLine("Area is : "+iRet);
		}
	}
}