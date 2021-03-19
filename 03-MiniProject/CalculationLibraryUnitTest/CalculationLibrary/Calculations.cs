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
			return a / b;
		}
	}
}
