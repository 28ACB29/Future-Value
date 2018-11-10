using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FutureValue
{
	public partial class FormFutureValue : Form
	{
		private const string CURRENCY_FORMAT_STRING = "c";

		private const string PERCENT_FORMAT_STRING = "p1";

		private const int futureValuesRowSize = 10;

		private const int futureValuesColumnSize = 4;

		private Calculator calculator;

		private List<string[]> futureValues;

		public FormFutureValue()
		{
			this.InitializeComponent();
			for(int i = 1; i <= 40; i++)
			{
				this.comboBoxNumberOfYears.Items.Add(i);
			}
			this.comboBoxNumberOfYears.SelectedItem = 1;

			this.calculator = new Calculator();

			this.futureValues = new List<string[]>(FormFutureValue.futureValuesRowSize);
			this.futureValues.Add(new string[]
			{
				"Inv/Mo.",
				"Rate",
				"Years",
				"Future Values"
			});
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		public bool IsValidData()
		{
			return
				//Validate textBoxMonthlyInvestment
				Validator.IsPresent(this.textBoxMonthlyInvestment, this.textBoxMonthlyInvestment.Name) &&
				Validator.IsDecimal(this.textBoxMonthlyInvestment, this.textBoxMonthlyInvestment.Name) &&
				Validator.IsWithinRange(this.textBoxMonthlyInvestment, this.textBoxMonthlyInvestment.Name, 1, 1000) &&
				//Validate textBoxYearlyInterestRate
				Validator.IsPresent(this.textBoxYearlyInterestRate, this.textBoxYearlyInterestRate.Name) &&
				Validator.IsDecimal(this.textBoxYearlyInterestRate, this.textBoxYearlyInterestRate.Name) &&
				Validator.IsWithinRange(this.textBoxYearlyInterestRate, this.textBoxYearlyInterestRate.Name, 1, 20);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="input"></param>
		/// <returns></returns>
		private static string Strip(string input)
		{
			string output = input;
			foreach(char character in output)
			{
				if(character == '$' || character == '%' || character == ',' || character == ' ')
				{
					input = input.Remove(input.IndexOf(character), 1);
				}
			}
			return output;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void FormFutureValue_DoubleClick(object sender, EventArgs e)
		{
			this.textBoxMonthlyInvestment.Text = "";
			this.textBoxYearlyInterestRate.Text = "";
			this.listBoxFutureValue.Items.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void textBoxYearlyInterestRate_DoubleClick(object sender, EventArgs e)
		{
			this.textBoxYearlyInterestRate.Text = "12";
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void clearFutureValue(object sender, EventArgs e)
		{
			this.listBoxFutureValue.Items.Clear();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonCalculate_Click(object sender, System.EventArgs e)
		{
			try
			{
				if(this.IsValidData())
				{
					this.calculator.MonthlyInvestment = Convert.ToDecimal(FormFutureValue.Strip(this.textBoxMonthlyInvestment.Text));
					this.calculator.YearlyInterestRate = Convert.ToDecimal(FormFutureValue.Strip(this.textBoxYearlyInterestRate.Text));
					int years = Convert.ToInt32(this.comboBoxNumberOfYears.Text);

					decimal yearlyValue;
					this.listBoxFutureValue.Items.Clear();
					for(int i = 1; i < years; i++)
					{
						this.calculator.Years = i;
						yearlyValue = this.calculator.CalculateFutureValue();
						this.listBoxFutureValue.Items.Add(yearlyValue.ToString(FormFutureValue.CURRENCY_FORMAT_STRING));
					}
					this.calculator.Years = years;
					decimal futureValue = this.calculator.CalculateFutureValue();
					this.listBoxFutureValue.Items.Add(futureValue.ToString(FormFutureValue.CURRENCY_FORMAT_STRING));

					this.textBoxMonthlyInvestment.Focus();

					this.futureValues.Add(new string[]
					{
						this.calculator.MonthlyInvestment.ToString(FormFutureValue.CURRENCY_FORMAT_STRING),
						(this.calculator.YearlyInterestRate / 100m).ToString(FormFutureValue.PERCENT_FORMAT_STRING),
						years.ToString(),
						futureValue.ToString(FormFutureValue.CURRENCY_FORMAT_STRING)
					});
				}
			}
			catch(FormatException formatException)
			{
				MessageBox.Show("Invalid Format: " + formatException.Message);
			}
			catch(OverflowException overflowException)
			{
				MessageBox.Show("Overflow Ocurred: " + overflowException.Message);
			}
			catch(Exception exception)
			{
				MessageBox.Show("Exception message: " + exception.Message + "\nException type: " + exception.GetType().ToString() + "\nException stack trace:\n" + exception.StackTrace, "Exception Ocurred");
			}
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void buttonExit_Click(object sender, EventArgs e)
		{
			StringBuilder futureValuesOuput = new StringBuilder();
			for(int i = 0; i < this.futureValues.Count; i++)
			{
				futureValuesOuput
					.Append(this.futureValues[i][0]).Append("\t")
					.Append(this.futureValues[i][1]).Append("\t")
					.Append(this.futureValues[i][2]).Append("\t")
					.Append(this.futureValues[i][3]).Append(Environment.NewLine);
			}
			MessageBox.Show(futureValuesOuput.ToString(), "Future Value Calculations");

			base.Close();
		}
	}
}
