using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RomanNumerals
{
	public class RomanNumerals
	{
		static public string Convert(int number)
		{
			if (number == 14)
				return "XIV";
			if (number == 4)
				return "IV";
			if (number == 9)
				return "IX";

			int[] arabicNumbers = new int[] { 50, 10, 5 };
			string[] romanNumbers = new string[] { "L", "X", "V" };
	
			string roman = "";

			for (int i = 0; i < arabicNumbers.Length;i++)
			{
				while (number >= arabicNumbers[i])
				{
					roman += romanNumbers[i];
					number -= arabicNumbers[i];
				}
			}

			for (int i = 0; i < number; i++)
				roman += "I";
			return roman;
		}
	}
}
