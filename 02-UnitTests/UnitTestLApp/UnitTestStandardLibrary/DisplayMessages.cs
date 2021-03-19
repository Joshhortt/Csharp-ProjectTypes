// C # Project Types - Unit Tests
using System;
using System.Collections.Generic;
using System.Text;

// Test Driven Development: Red, Green, Refactor

namespace UnitTestStandardLibrary
{
	public class DisplayMessages  // this is the DisplayMessages class
	{
		public string Greeting(string firstName, int hourOfTheDay)
		{
			string output = "";

			if(hourOfTheDay < 7)
			{
				output = $"Go to bed { firstName }";
			}

			else if(hourOfTheDay < 12)
			{
				output = $"Good morning { firstName }";
			}

			else if(hourOfTheDay < 18)
			{
				output = $"Good afternoon { firstName }";
			}
			else
			{
				output = $"Good evening { firstName }";
			}
			return output;
		}
	}
}
