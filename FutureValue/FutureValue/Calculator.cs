using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FutureValue
{
	public class Calculator
	{

		public decimal MonthlyInvestment;

		public decimal YearlyInterestRate;

		public int Years;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="monthlyInvestment"></param>
		/// <param name="monthlyInterestRate"></param>
		/// <param name="months"></param>
		/// <returns></returns>
		public decimal CalculateFutureValue()
		{
			decimal monthlyInterestRate = this.YearlyInterestRate / 1200m;
			int months = this.Years * 12;
			decimal futureValue = 0m;
			for(int i = 0; i < months; i++)
			{
				futureValue = (futureValue + this.MonthlyInvestment) * (1 + monthlyInterestRate);
			}
			return futureValue;
		}
	}
}
