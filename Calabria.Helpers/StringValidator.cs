using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using FluentAssertions;
using Xunit;

namespace Calabria.Helpers
{
	/*
	public class StringValidator
	{
		

[Theory]
	[InlineData("0", 0)]
	[InlineData("1", 1)]
	[InlineData("123", 123)]
	[InlineData("-123", -123)]
	public void ValidStringWithNoDefaultValue_ReturnsExpectedResult(string input, int expectedResult)
	{
		var result = input.AsOrDefault<int>();

		result.Should().Be(expectedResult);
	}

	[Theory]
	[InlineData("0", 999, 0)]
	[InlineData("1", 999, 1)]
	[InlineData("123", 999, 123)]
	[InlineData("-123", -999, -123)]
	public void ValidStringWithDefaultValue_ReturnsExpectedResult(string input, int defaultValue, int expectedResult)
	{
		var result = input.AsOrDefault(defaultValue);

		result.Should().Be(expectedResult);
	}

	[Theory]
	[InlineData("")]
	[InlineData(" ")]
	[InlineData("abc")]
	public void InvalidStringWithNoDefaultValue_ReturnsIntegerDefault(string input)
	{
		var result = input.AsOrDefault<int>();

		result.Should().Be(default(int));
	}

	[Theory]
	[InlineData("", 0)]
	[InlineData(" ", 1)]
	[InlineData("abc", 234)]
	public void InvalidStringWithDefaultValue_ReturnsDefaultValue(string input, int defaultValue)
	{
		var result = input.AsOrDefault(defaultValue);

		result.Should().Be(defaultValue);
	}
}
	*/
}
