using System;
using System.Windows.Forms;

namespace FutureValue
{
	public class Validator
	{
		public const string Title = "Entry Error";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool IsPresent(TextBox textBox, string name)
		{
			if(textBox.Text != "")
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " is a required field.", "Entry Error");
				return false;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool IsDecimal(TextBox textBox, string name)
		{
			try
			{
				Convert.ToDecimal(textBox.Text);
				return true;
			}
			catch(FormatException)
			{
				MessageBox.Show(name + " must be a decimal value.", "Entry Error");
				return false;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		/// <param name="name"></param>
		/// <returns></returns>
		public static bool IsInt32(TextBox textBox, string name)
		{
			try
			{
				Convert.ToInt32(textBox.Text);
				return true;
			}
			catch(FormatException)
			{
				MessageBox.Show(name + " must be an integer.", "Entry Error");
				return false;
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textBox"></param>
		/// <param name="name"></param>
		/// <param name="min"></param>
		/// <param name="max"></param>
		/// <returns></returns>
		public static bool IsWithinRange(TextBox textBox, string name, decimal min, decimal max)
		{
			decimal number = Convert.ToDecimal(textBox.Text);
			if(number >= min && number <= max)
			{
				return true;
			}
			else
			{
				MessageBox.Show(name + " must be within " + min + " and " + max + ".", "Entry Error");
				return false;
			}
		}
	}
}
