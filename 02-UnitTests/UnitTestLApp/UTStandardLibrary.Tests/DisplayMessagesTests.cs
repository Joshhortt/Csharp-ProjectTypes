using System;
using System.Collections.Generic;
using System.Text;
using UnitTestStandardLibrary;
using Xunit;

// # 3 Acts to a good Unit Test: Arrange; Act; Asert. #
// We use: expected value and Actual value keywords.
// A 'unit test' tests one unit of work only.
// Unit tests only test public methods.
// You should not test the dependencies.

namespace UTStandardLibrary.Tests
{
	public class DisplayMessagesTests  // this is the DisplayMessagesTests
	{
		[Fact]
		public void GreetingShouldReturnGoToBedMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Go to bed Josh";   // 'expected' keyword

			// Act
			string actual = messages.Greeting("Josh", 2);  // 'actual' keyword

			// Assert (this should have happened)
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void GreetingShouldReturnGoodMorningMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good morning Josh";   // 'expected' keyword

			// Act
			string actual = messages.Greeting("Josh", 7);  // 'actual' keyword

			// Assert (this should have happened)
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void GreetingShouldReturnGoodAfternoonMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good afternoon Josh";   // 'expected' keyword

			// Act
			string actual = messages.Greeting("Josh", 14);  // 'actual' keyword

			// Assert (this should have happened)
			Assert.Equal(expected, actual);
		}

		[Fact]
		public void GreetingShouldReturnGoodEveningMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good evening Josh";   // 'expected' keyword

			// Act
			string actual = messages.Greeting("Josh", 19);  // 'actual' keyword

			// Assert (this should have happened)
			Assert.Equal(expected, actual);
		}

		[Theory]
		[InlineData("Josh", 0, "Go to bed Josh")]
		[InlineData("Josh", 1, "Go to bed Josh")]
		[InlineData("Josh", 2, "Go to bed Josh")]
		[InlineData("Josh", 3, "Go to bed Josh")]
		[InlineData("Josh", 4, "Go to bed Josh")]
		[InlineData("Josh", 5, "Go to bed Josh")]
		[InlineData("Josh", 6, "Go to bed Josh")]
		[InlineData("Josh", 7, "Good morning Josh")]
		[InlineData("Josh", 8, "Good morning Josh")]
		[InlineData("Josh", 9, "Good morning Josh")]
		[InlineData("Josh", 10, "Good morning Josh")]
		[InlineData("Josh", 11, "Good morning Josh")]
		[InlineData("Josh", 12, "Good afternoon Josh")]
		[InlineData("Josh", 13, "Good afternoon Josh")]
		[InlineData("Josh", 14, "Good afternoon Josh")]
		[InlineData("Josh", 15, "Good afternoon Josh")]
		[InlineData("Josh", 16, "Good afternoon Josh")]
		[InlineData("Josh", 17, "Good afternoon Josh")]
		[InlineData("Josh", 18, "Good evening Josh")]
		[InlineData("Josh", 19, "Good evening Josh")]
		[InlineData("Josh", 20, "Good evening Josh")]
		[InlineData("Josh", 21, "Good evening Josh")]
		[InlineData("Josh", 22, "Good evening Josh")]
		[InlineData("Josh", 23, "Good evening Josh")]
		
		public void GreetingShouldReturnExpectedValue(
			string firstName,
			int hourOfTheDay,
			string expected)
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();

			// Act
			string actual = messages.Greeting(firstName, hourOfTheDay);  // 'actual' keyword

			// Assert (this should have happened)
			Assert.Equal(expected, actual);
		}
	}
}
