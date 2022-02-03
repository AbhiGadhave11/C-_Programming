/*5. Accept division of student from user and depends on the division display exam timing. There are 4 
divisions in school as A,B,C,D. Exam of division A at 7 AM, B at 8.30 AM, C at 9.20 AM and D at 10.30 AM.
(Application should be case insensitive)
Input : C
Output : Your exam at 9.20 AM
Input : d
Output : Your exam at 10.30 AM
*/

using System;

class MyArray
{
	public void ChkAlphabet(char ch)
	{
		if(ch=='a' || ch<='A')
		{
			Console.WriteLine("Your Exam is at : 7 AM");
		}
		else if(ch == 'b' || ch == 'B')
		{
			Console.WriteLine("Your Exam is at : 8:30 AM");
		}
		else if(ch == 'c' || ch == 'C')
		{
			Console.WriteLine("Your Exam is at : 9:20 AM");
		}
		else if(ch == 'd' || ch == 'D')
		{
			Console.WriteLine("Your Exam is at : 10:30 AM");
		}
		else
		{
			Console.WriteLine("Invalid Input");
		}
	}
}

namespace Assign20_Q1
{
	class Program
	{
		public static void Main(String []Arg)
		{
			Console.WriteLine("Enter the Division");
			char ch = '\0';
			ch = Convert.ToChar(Console.ReadLine());

      MyArray mobj = new MyArray();

			mobj.ChkAlphabet(ch);
			
		}
	}
}
