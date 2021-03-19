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
		public void AddShouldReturnExpectedValue(double a, double b, double expected)
		{
			// Arrange
			Calculations calc  = new Calculations();


			// Act
			double actual = calc.Add(a, b);


			// Assert
			Assert.Equal(expected, actual);
		}
	}
}
