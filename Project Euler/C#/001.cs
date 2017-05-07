using System;
using System.Linq;

public class Program
{
	static void Main(string[] args)
	{
	  Console.WriteLine(Enumerable.Range(0,1000).Where(x => x%3 || x%5).Sum());// 233168
	}
}
