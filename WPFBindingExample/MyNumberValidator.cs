using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFBindingExample
{
	/// <summary>
	/// This class must be public
	/// </summary>
	public class MyNumberValidator : ValidationRule
	{
		/// <summary>
		/// Validation function
		/// </summary>
		/// <param name="value"></param>
		/// <param name="cultureInfo"></param>
		/// <returns></returns>
		public override ValidationResult Validate(object value, CultureInfo cultureInfo)
		{
			try
			{
				int number;
				int.TryParse(value as string, out number);
				// Dumb control 50 < number < 100
				if (number < 100 && number > 50)
				{
					return new ValidationResult(true, null);
				}

				return new ValidationResult(false, "The number must be between 50 and 100");
			}
			catch (Exception)
			{
				return new ValidationResult(false, "The value must be a number");
			}

		}
	}
}
