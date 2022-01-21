//1.Program to divide two numbers

using System;

class Marvellous
{
	public float Dividex(int iNo1,int iNo2)
	{
		float fAns = 0.0f;
		fAns = (float)iNo1 / iNo2;
		return fAns;
	}
}
namespace Assigncs1
{
	class Program
	{

		public static void Main(String[] Arg)
		{
			int iValue1=0,iValue2=0;
			float fRet = 0.0f;

			Console.WriteLine("Enter First Number");
            iValue1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            iValue2 = Convert.ToInt32(Console.ReadLine());

            Marvellous mobj = new Marvellous();
            fRet= mobj.Dividex(iValue1,iValue2);

            Console.WriteLine("Result is : "+fRet);
		}
	}
}