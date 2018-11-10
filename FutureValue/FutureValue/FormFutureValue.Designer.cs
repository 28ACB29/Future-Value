namespace FutureValue
{
	partial class FormFutureValue
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonCalculate = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.labelFutureValue = new System.Windows.Forms.Label();
			this.labelNumberOfYears = new System.Windows.Forms.Label();
			this.textBoxYearlyInterestRate = new System.Windows.Forms.TextBox();
			this.labelYearlyInterestRate = new System.Windows.Forms.Label();
			this.textBoxMonthlyInvestment = new System.Windows.Forms.TextBox();
			this.labelMonthlyInvestment = new System.Windows.Forms.Label();
			this.comboBoxNumberOfYears = new System.Windows.Forms.ComboBox();
			this.listBoxFutureValue = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// buttonCalculate
			// 
			this.buttonCalculate.Location = new System.Drawing.Point(15, 185);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new System.Drawing.Size(75, 23);
			this.buttonCalculate.TabIndex = 18;
			this.buttonCalculate.Text = "&Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = true;
			this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(140, 185);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(75, 23);
			this.buttonExit.TabIndex = 19;
			this.buttonExit.Text = "E&xit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// labelFutureValue
			// 
			this.labelFutureValue.AutoSize = true;
			this.labelFutureValue.Location = new System.Drawing.Point(12, 81);
			this.labelFutureValue.Name = "labelFutureValue";
			this.labelFutureValue.Size = new System.Drawing.Size(70, 13);
			this.labelFutureValue.TabIndex = 16;
			this.labelFutureValue.Text = "Future Value:";
			this.labelFutureValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelNumberOfYears
			// 
			this.labelNumberOfYears.AutoSize = true;
			this.labelNumberOfYears.Location = new System.Drawing.Point(12, 57);
			this.labelNumberOfYears.Name = "labelNumberOfYears";
			this.labelNumberOfYears.Size = new System.Drawing.Size(91, 13);
			this.labelNumberOfYears.TabIndex = 14;
			this.labelNumberOfYears.Text = "Number Of Years:";
			this.labelNumberOfYears.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxYearlyInterestRate
			// 
			this.textBoxYearlyInterestRate.Location = new System.Drawing.Point(140, 33);
			this.textBoxYearlyInterestRate.Name = "textBoxYearlyInterestRate";
			this.textBoxYearlyInterestRate.Size = new System.Drawing.Size(100, 20);
			this.textBoxYearlyInterestRate.TabIndex = 13;
			this.textBoxYearlyInterestRate.TextChanged += new System.EventHandler(this.clearFutureValue);
			this.textBoxYearlyInterestRate.DoubleClick += new System.EventHandler(this.textBoxYearlyInterestRate_DoubleClick);
			// 
			// labelYearlyInterestRate
			// 
			this.labelYearlyInterestRate.AutoSize = true;
			this.labelYearlyInterestRate.Location = new System.Drawing.Point(12, 33);
			this.labelYearlyInterestRate.Name = "labelYearlyInterestRate";
			this.labelYearlyInterestRate.Size = new System.Drawing.Size(103, 13);
			this.labelYearlyInterestRate.TabIndex = 12;
			this.labelYearlyInterestRate.Text = "Yearly Interest Rate:";
			this.labelYearlyInterestRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxMonthlyInvestment
			// 
			this.textBoxMonthlyInvestment.Location = new System.Drawing.Point(140, 9);
			this.textBoxMonthlyInvestment.Name = "textBoxMonthlyInvestment";
			this.textBoxMonthlyInvestment.Size = new System.Drawing.Size(100, 20);
			this.textBoxMonthlyInvestment.TabIndex = 11;
			this.textBoxMonthlyInvestment.TextChanged += new System.EventHandler(this.clearFutureValue);
			// 
			// labelMonthlyInvestment
			// 
			this.labelMonthlyInvestment.AutoSize = true;
			this.labelMonthlyInvestment.Location = new System.Drawing.Point(12, 9);
			this.labelMonthlyInvestment.Name = "labelMonthlyInvestment";
			this.labelMonthlyInvestment.Size = new System.Drawing.Size(102, 13);
			this.labelMonthlyInvestment.TabIndex = 10;
			this.labelMonthlyInvestment.Text = "Monthly Investment:";
			this.labelMonthlyInvestment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// comboBoxNumberOfYears
			// 
			this.comboBoxNumberOfYears.FormattingEnabled = true;
			this.comboBoxNumberOfYears.Location = new System.Drawing.Point(140, 57);
			this.comboBoxNumberOfYears.Name = "comboBoxNumberOfYears";
			this.comboBoxNumberOfYears.Size = new System.Drawing.Size(121, 21);
			this.comboBoxNumberOfYears.TabIndex = 22;
			// 
			// listBoxFutureValue
			// 
			this.listBoxFutureValue.FormattingEnabled = true;
			this.listBoxFutureValue.Location = new System.Drawing.Point(140, 84);
			this.listBoxFutureValue.Name = "listBoxFutureValue";
			this.listBoxFutureValue.Size = new System.Drawing.Size(100, 95);
			this.listBoxFutureValue.TabIndex = 23;
			// 
			// FormFutureValue
			// 
			this.AcceptButton = this.buttonCalculate;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(243, 242);
			this.Controls.Add(this.listBoxFutureValue);
			this.Controls.Add(this.comboBoxNumberOfYears);
			this.Controls.Add(this.buttonCalculate);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.labelFutureValue);
			this.Controls.Add(this.labelNumberOfYears);
			this.Controls.Add(this.textBoxYearlyInterestRate);
			this.Controls.Add(this.labelYearlyInterestRate);
			this.Controls.Add(this.textBoxMonthlyInvestment);
			this.Controls.Add(this.labelMonthlyInvestment);
			this.Name = "FormFutureValue";
			this.Text = "Future Value";
			this.DoubleClick += new System.EventHandler(this.FormFutureValue_DoubleClick);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonCalculate;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Label labelFutureValue;
		private System.Windows.Forms.Label labelNumberOfYears;
		private System.Windows.Forms.TextBox textBoxYearlyInterestRate;
		private System.Windows.Forms.Label labelYearlyInterestRate;
		private System.Windows.Forms.TextBox textBoxMonthlyInvestment;
		private System.Windows.Forms.Label labelMonthlyInvestment;
		private System.Windows.Forms.ComboBox comboBoxNumberOfYears;
		private System.Windows.Forms.ListBox listBoxFutureValue;
	}
}

