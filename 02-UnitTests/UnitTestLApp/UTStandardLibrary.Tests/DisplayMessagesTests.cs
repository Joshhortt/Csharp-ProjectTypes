using System;
using System.Collections.Generic;
using System.Text;
using UnitTestStandardLibrary;
using Xunit;

// # 3 Acts to a good Unit Test: Arrange; Act; Asert. #
// We use: expected value and Actual value keywords
namespace UTStandardLibrary.Tests
{
	public class DisplayMessagesTests  // this is the DisplayMessagesTests
	{
		[Fact]
		public void GreetingShouldReturnGoodMorningMessage()
		{
			// Arrange
			DisplayMessages messages = new DisplayMessages();
			string expected = "Good morning Josh";   // 'expected' keyword

			// Act
			string actual = messages.Greeting("Josh", 2);  // 'actual' keyword

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
	}
}
