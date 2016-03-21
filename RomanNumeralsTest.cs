using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RomanNumerals
{
	[TestFixture]
	public class RomanNumeralsTest
	{
		[TestCase(1, "I")]
		[TestCase(2, "II")]
		[TestCase(3, "III")]
		[TestCase(4, "IV")]
		[TestCase(5, "V")]
		[TestCase(6, "VI")]
		[TestCase(7, "VII")]
		[TestCase(8, "VIII")]
		[TestCase(9, "IX")]
		[TestCase(10, "X")]
		[TestCase(12, "XII")]
		[TestCase(14, "XIV")]
		[TestCase(18, "XVIII")]
		[TestCase(50, "L")]
		[TestCase(57, "LVII")]
		[TestCase(73, "LXXIII")]
		[TestCase(87, "LXXXVII")]
		public void GivenArabicCheckRoman(int actual, string expected)
		{
			Assert.AreEqual(expected, RomanNumerals.Convert(actual));
		}
	}
}
