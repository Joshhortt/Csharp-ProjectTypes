using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CalculationLibrary.Tests
{
	public class CalculationTests
	{
		//private object calc;

		[Theory]
		[InlineData(4, 2, 6)]
		[InlineData(0, 0, 0)]
		[InlineData(1200, -1200, 0)]
		[InlineData(40, -41, -1)]
		public void AddShouldReturnExpectedValue(double a, double b, double expected)
		{
			// Arrange
			Calculations calc  = new Calculations();

			// Act
			double actual = calc.Add(a, b);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(8, 2, 6)]
		[InlineData(0, 2, -2)]
		[InlineData(9, 10, -1)]
		[InlineData(99, 109, -10)]
		public void SubtractShouldReturnExpectedValue(double a, double b, double expected)
		{
			// Arrange
			Calculations calc = new Calculations();

			// Act
			double actual = calc.Subtract(a, b);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(4, 2, 8)]
		[InlineData(1, 2, 2)]
		[InlineData(40, 0, 0)]
		[InlineData(3, 7, 21)]
		public void MultiplyShouldReturnExpectedValue(double a, double b, double expected)
		{
			// Arrange
			Calculations calc = new Calculations();

			// Act
			double actual = calc.Multiply(a, b);

			// Assert
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData(4, 2, 2)]
		[InlineData(1, 4, 0.25)]
		[InlineData(6, 2, 3)]
		[InlineData(15, 0, 0)]  // Returns infinitve number. It s necessary implement output condition to return zero.
		public void DivideShouldReturnExpectedValue(double a, double b, double expected)
		{
			// Arrange
			Calculations calc = new Calculations();

			// Act
			double actual = calc.Divide(a, b);

			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
