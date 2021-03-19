// C # Project Types - Mini-Project - Unit Tests - Test Driven Development Process
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculationLibrary
{
	public class Calculations
	{
		public static Calculations calc;

		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Subtract(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			return a * b;
		}

		public double Divide(double a, double b)
		{
			// return a / b;    -- If we divide 15/0  it returns a infinitive number instead of zero that we want.
			double output = 0;
			if(b != 0)
			{
				output = a / b;
			}
			return output;
		}
	}
}
