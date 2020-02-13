namespace GUI_Payroll_Calculator
{
    partial class MainForm
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
            if (disposing && (components != null))
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
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.hoursWorkedGroupbox = new System.Windows.Forms.GroupBox();
            this.overtimeTextbox = new System.Windows.Forms.TextBox();
            this.overtimeLabel = new System.Windows.Forms.Label();
            this.totalHoursTextbox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.sundayTextbox = new System.Windows.Forms.TextBox();
            this.sundayLabel = new System.Windows.Forms.Label();
            this.saturdayTextbox = new System.Windows.Forms.TextBox();
            this.saturdayLabel = new System.Windows.Forms.Label();
            this.fridayTextbox = new System.Windows.Forms.TextBox();
            this.fridayLabel = new System.Windows.Forms.Label();
            this.thursdayTextbox = new System.Windows.Forms.TextBox();
            this.thurdayLabel = new System.Windows.Forms.Label();
            this.wednesdayTextbox = new System.Windows.Forms.TextBox();
            this.wednesdayLabel = new System.Windows.Forms.Label();
            this.tuesdayTextbox = new System.Windows.Forms.TextBox();
            this.tuesdayLabel = new System.Windows.Forms.Label();
            this.mondayTextbox = new System.Windows.Forms.TextBox();
            this.mondayLabel = new System.Windows.Forms.Label();
            this.hourlyRateTextbox = new System.Windows.Forms.TextBox();
            this.employeeNameTextbox = new System.Windows.Forms.TextBox();
            this.taxExemptCheckbox = new System.Windows.Forms.CheckBox();
            this.taxRateLabel = new System.Windows.Forms.Label();
            this.taxrateTextbox = new System.Windows.Forms.TextBox();
            this.otherDeductionsLabel = new System.Windows.Forms.Label();
            this.otherDeductionsTextbox = new System.Windows.Forms.TextBox();
            this.chequeDateLabel = new System.Windows.Forms.Label();
            this.chequeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.grossPayLabel = new System.Windows.Forms.Label();
            this.deductionsLabel = new System.Windows.Forms.Label();
            this.netpayLabel = new System.Windows.Forms.Label();
            this.grossPayTextbox = new System.Windows.Forms.TextBox();
            this.deductionsTextbox = new System.Windows.Forms.TextBox();
            this.netPayTextbox = new System.Windows.Forms.TextBox();
            this.calculateNetPayButton = new System.Windows.Forms.Button();
            this.savePaySlipButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.taxRatePercentLabel = new System.Windows.Forms.Label();
            this.hoursWorkedGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(25, 42);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(125, 20);
            this.employeeNameLabel.TabIndex = 0;
            this.employeeNameLabel.Text = "Employee Name";
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(57, 86);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(93, 20);
            this.hourlyRateLabel.TabIndex = 0;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // hoursWorkedGroupbox
            // 
            this.hoursWorkedGroupbox.Controls.Add(this.overtimeTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.overtimeLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.totalHoursTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.totalLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.sundayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.sundayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.saturdayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.saturdayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.fridayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.fridayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.thursdayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.thurdayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.wednesdayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.wednesdayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.tuesdayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.tuesdayLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.mondayTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.mondayLabel);
            this.hoursWorkedGroupbox.Location = new System.Drawing.Point(29, 126);
            this.hoursWorkedGroupbox.Name = "hoursWorkedGroupbox";
            this.hoursWorkedGroupbox.Size = new System.Drawing.Size(588, 416);
            this.hoursWorkedGroupbox.TabIndex = 3;
            this.hoursWorkedGroupbox.TabStop = false;
            this.hoursWorkedGroupbox.Text = "Hours Worked in Week";
            // 
            // overtimeTextbox
            // 
            this.overtimeTextbox.Location = new System.Drawing.Point(392, 368);
            this.overtimeTextbox.Name = "overtimeTextbox";
            this.overtimeTextbox.ReadOnly = true;
            this.overtimeTextbox.Size = new System.Drawing.Size(100, 26);
            this.overtimeTextbox.TabIndex = 3;
            this.overtimeTextbox.TabStop = false;
            // 
            // overtimeLabel
            // 
            this.overtimeLabel.AutoSize = true;
            this.overtimeLabel.Location = new System.Drawing.Point(293, 368);
            this.overtimeLabel.Name = "overtimeLabel";
            this.overtimeLabel.Size = new System.Drawing.Size(80, 20);
            this.overtimeLabel.TabIndex = 0;
            this.overtimeLabel.Text = "OverTime:";
            // 
            // totalHoursTextbox
            // 
            this.totalHoursTextbox.Location = new System.Drawing.Point(141, 368);
            this.totalHoursTextbox.Name = "totalHoursTextbox";
            this.totalHoursTextbox.ReadOnly = true;
            this.totalHoursTextbox.Size = new System.Drawing.Size(100, 26);
            this.totalHoursTextbox.TabIndex = 3;
            this.totalHoursTextbox.TabStop = false;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(70, 371);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 0;
            this.totalLabel.Text = "Total:";
            // 
            // sundayTextbox
            // 
            this.sundayTextbox.Location = new System.Drawing.Point(141, 306);
            this.sundayTextbox.Name = "sundayTextbox";
            this.sundayTextbox.Size = new System.Drawing.Size(80, 26);
            this.sundayTextbox.TabIndex = 9;
            this.sundayTextbox.Enter += new System.EventHandler(this.SundayTextbox_Enter);
            this.sundayTextbox.Leave += new System.EventHandler(this.SundayTextbox_Leave);
            // 
            // sundayLabel
            // 
            this.sundayLabel.AutoSize = true;
            this.sundayLabel.Location = new System.Drawing.Point(55, 306);
            this.sundayLabel.Name = "sundayLabel";
            this.sundayLabel.Size = new System.Drawing.Size(63, 20);
            this.sundayLabel.TabIndex = 0;
            this.sundayLabel.Text = "Sunday";
            // 
            // saturdayTextbox
            // 
            this.saturdayTextbox.Location = new System.Drawing.Point(141, 263);
            this.saturdayTextbox.Name = "saturdayTextbox";
            this.saturdayTextbox.Size = new System.Drawing.Size(80, 26);
            this.saturdayTextbox.TabIndex = 8;
            this.saturdayTextbox.Enter += new System.EventHandler(this.SaturdayTextbox_Enter);
            this.saturdayTextbox.Leave += new System.EventHandler(this.SaturdayTextbox_Leave);
            // 
            // saturdayLabel
            // 
            this.saturdayLabel.AutoSize = true;
            this.saturdayLabel.Location = new System.Drawing.Point(45, 263);
            this.saturdayLabel.Name = "saturdayLabel";
            this.saturdayLabel.Size = new System.Drawing.Size(73, 20);
            this.saturdayLabel.TabIndex = 0;
            this.saturdayLabel.Text = "Saturday";
            // 
            // fridayTextbox
            // 
            this.fridayTextbox.Location = new System.Drawing.Point(141, 219);
            this.fridayTextbox.Name = "fridayTextbox";
            this.fridayTextbox.Size = new System.Drawing.Size(80, 26);
            this.fridayTextbox.TabIndex = 7;
            this.fridayTextbox.Enter += new System.EventHandler(this.FridayTextbox_Enter);
            this.fridayTextbox.Leave += new System.EventHandler(this.FridayTextbox_Leave);
            // 
            // fridayLabel
            // 
            this.fridayLabel.AutoSize = true;
            this.fridayLabel.Location = new System.Drawing.Point(66, 219);
            this.fridayLabel.Name = "fridayLabel";
            this.fridayLabel.Size = new System.Drawing.Size(52, 20);
            this.fridayLabel.TabIndex = 0;
            this.fridayLabel.Text = "Friday";
            // 
            // thursdayTextbox
            // 
            this.thursdayTextbox.Location = new System.Drawing.Point(141, 177);
            this.thursdayTextbox.Name = "thursdayTextbox";
            this.thursdayTextbox.Size = new System.Drawing.Size(80, 26);
            this.thursdayTextbox.TabIndex = 6;
            this.thursdayTextbox.Enter += new System.EventHandler(this.ThursdayTextbox_Enter);
            this.thursdayTextbox.Leave += new System.EventHandler(this.ThursdayTextbox_Leave);
            // 
            // thurdayLabel
            // 
            this.thurdayLabel.AutoSize = true;
            this.thurdayLabel.Location = new System.Drawing.Point(44, 177);
            this.thurdayLabel.Name = "thurdayLabel";
            this.thurdayLabel.Size = new System.Drawing.Size(74, 20);
            this.thurdayLabel.TabIndex = 0;
            this.thurdayLabel.Text = "Thursday";
            // 
            // wednesdayTextbox
            // 
            this.wednesdayTextbox.Location = new System.Drawing.Point(141, 133);
            this.wednesdayTextbox.Name = "wednesdayTextbox";
            this.wednesdayTextbox.Size = new System.Drawing.Size(80, 26);
            this.wednesdayTextbox.TabIndex = 5;
            this.wednesdayTextbox.Enter += new System.EventHandler(this.WednesdayTextbox_Enter);
            this.wednesdayTextbox.Leave += new System.EventHandler(this.WednesdayTextbox_Leave);
            // 
            // wednesdayLabel
            // 
            this.wednesdayLabel.AutoSize = true;
            this.wednesdayLabel.Location = new System.Drawing.Point(27, 133);
            this.wednesdayLabel.Name = "wednesdayLabel";
            this.wednesdayLabel.Size = new System.Drawing.Size(93, 20);
            this.wednesdayLabel.TabIndex = 0;
            this.wednesdayLabel.Text = "Wednesday";
            // 
            // tuesdayTextbox
            // 
            this.tuesdayTextbox.Location = new System.Drawing.Point(141, 89);
            this.tuesdayTextbox.Name = "tuesdayTextbox";
            this.tuesdayTextbox.Size = new System.Drawing.Size(80, 26);
            this.tuesdayTextbox.TabIndex = 4;
            this.tuesdayTextbox.Enter += new System.EventHandler(this.TuesdayTextbox_Enter);
            this.tuesdayTextbox.Leave += new System.EventHandler(this.TuesdayTextbox_Leave);
            // 
            // tuesdayLabel
            // 
            this.tuesdayLabel.AutoSize = true;
            this.tuesdayLabel.Location = new System.Drawing.Point(44, 89);
            this.tuesdayLabel.Name = "tuesdayLabel";
            this.tuesdayLabel.Size = new System.Drawing.Size(69, 20);
            this.tuesdayLabel.TabIndex = 0;
            this.tuesdayLabel.Text = "Tuesday";
            // 
            // mondayTextbox
            // 
            this.mondayTextbox.Location = new System.Drawing.Point(141, 46);
            this.mondayTextbox.Name = "mondayTextbox";
            this.mondayTextbox.Size = new System.Drawing.Size(80, 26);
            this.mondayTextbox.TabIndex = 3;
            this.mondayTextbox.Enter += new System.EventHandler(this.MondayTextbox_Enter);
            this.mondayTextbox.Leave += new System.EventHandler(this.MondayTextbox_Leave);
            // 
            // mondayLabel
            // 
            this.mondayLabel.AutoSize = true;
            this.mondayLabel.Location = new System.Drawing.Point(48, 46);
            this.mondayLabel.Name = "mondayLabel";
            this.mondayLabel.Size = new System.Drawing.Size(65, 20);
            this.mondayLabel.TabIndex = 0;
            this.mondayLabel.Text = "Monday";
            // 
            // hourlyRateTextbox
            // 
            this.hourlyRateTextbox.Location = new System.Drawing.Point(175, 80);
            this.hourlyRateTextbox.Name = "hourlyRateTextbox";
            this.hourlyRateTextbox.Size = new System.Drawing.Size(102, 26);
            this.hourlyRateTextbox.TabIndex = 2;
            this.hourlyRateTextbox.Leave += new System.EventHandler(this.HourlyRateTextbox_Leave);
            // 
            // employeeNameTextbox
            // 
            this.employeeNameTextbox.Location = new System.Drawing.Point(175, 36);
            this.employeeNameTextbox.Name = "employeeNameTextbox";
            this.employeeNameTextbox.Size = new System.Drawing.Size(442, 26);
            this.employeeNameTextbox.TabIndex = 1;
            this.employeeNameTextbox.Leave += new System.EventHandler(this.EmployeeNameTextbox_Leave);
            // 
            // taxExemptCheckbox
            // 
            this.taxExemptCheckbox.AutoSize = true;
            this.taxExemptCheckbox.Location = new System.Drawing.Point(29, 568);
            this.taxExemptCheckbox.Name = "taxExemptCheckbox";
            this.taxExemptCheckbox.Size = new System.Drawing.Size(118, 24);
            this.taxExemptCheckbox.TabIndex = 10;
            this.taxExemptCheckbox.Text = "&Tax Exempt";
            this.taxExemptCheckbox.UseVisualStyleBackColor = true;
            this.taxExemptCheckbox.CheckedChanged += new System.EventHandler(this.TaxExemptCheckbox_CheckedChanged);
            this.taxExemptCheckbox.CheckStateChanged += new System.EventHandler(this.TaxExemptCheckbox_CheckStateChanged);
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.Location = new System.Drawing.Point(166, 568);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(77, 20);
            this.taxRateLabel.TabIndex = 0;
            this.taxRateLabel.Text = "Tax Rate:";
            // 
            // taxrateTextbox
            // 
            this.taxrateTextbox.Location = new System.Drawing.Point(250, 567);
            this.taxrateTextbox.Name = "taxrateTextbox";
            this.taxrateTextbox.Size = new System.Drawing.Size(74, 26);
            this.taxrateTextbox.TabIndex = 11;
            this.taxrateTextbox.Leave += new System.EventHandler(this.TaxrateTextbox_Leave);
            // 
            // otherDeductionsLabel
            // 
            this.otherDeductionsLabel.AutoSize = true;
            this.otherDeductionsLabel.Location = new System.Drawing.Point(25, 616);
            this.otherDeductionsLabel.Name = "otherDeductionsLabel";
            this.otherDeductionsLabel.Size = new System.Drawing.Size(138, 20);
            this.otherDeductionsLabel.TabIndex = 0;
            this.otherDeductionsLabel.Text = "Other Deductions:";
            // 
            // otherDeductionsTextbox
            // 
            this.otherDeductionsTextbox.Location = new System.Drawing.Point(170, 616);
            this.otherDeductionsTextbox.Name = "otherDeductionsTextbox";
            this.otherDeductionsTextbox.Size = new System.Drawing.Size(154, 26);
            this.otherDeductionsTextbox.TabIndex = 12;
            this.otherDeductionsTextbox.Leave += new System.EventHandler(this.OtherDeductionsTextbox_Leave);
            // 
            // chequeDateLabel
            // 
            this.chequeDateLabel.AutoSize = true;
            this.chequeDateLabel.Location = new System.Drawing.Point(42, 662);
            this.chequeDateLabel.Name = "chequeDateLabel";
            this.chequeDateLabel.Size = new System.Drawing.Size(108, 20);
            this.chequeDateLabel.TabIndex = 0;
            this.chequeDateLabel.Text = "Cheque Date:";
            // 
            // chequeDateTimePicker
            // 
            this.chequeDateTimePicker.Checked = false;
            this.chequeDateTimePicker.CustomFormat = " ";
            this.chequeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.chequeDateTimePicker.Location = new System.Drawing.Point(170, 662);
            this.chequeDateTimePicker.Name = "chequeDateTimePicker";
            this.chequeDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.chequeDateTimePicker.TabIndex = 13;
            this.chequeDateTimePicker.Value = new System.DateTime(2019, 12, 19, 15, 57, 1, 0);
            this.chequeDateTimePicker.ValueChanged += new System.EventHandler(this.ChequeDateTimePicker_ValueChanged);
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(64, 736);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(86, 20);
            this.grossPayLabel.TabIndex = 0;
            this.grossPayLabel.Text = "Gross Pay:";
            // 
            // deductionsLabel
            // 
            this.deductionsLabel.AutoSize = true;
            this.deductionsLabel.Location = new System.Drawing.Point(56, 790);
            this.deductionsLabel.Name = "deductionsLabel";
            this.deductionsLabel.Size = new System.Drawing.Size(94, 20);
            this.deductionsLabel.TabIndex = 0;
            this.deductionsLabel.Text = "Deductions:";
            // 
            // netpayLabel
            // 
            this.netpayLabel.AutoSize = true;
            this.netpayLabel.Location = new System.Drawing.Point(82, 846);
            this.netpayLabel.Name = "netpayLabel";
            this.netpayLabel.Size = new System.Drawing.Size(68, 20);
            this.netpayLabel.TabIndex = 0;
            this.netpayLabel.Text = "Net Pay:";
            // 
            // grossPayTextbox
            // 
            this.grossPayTextbox.Location = new System.Drawing.Point(175, 730);
            this.grossPayTextbox.Name = "grossPayTextbox";
            this.grossPayTextbox.ReadOnly = true;
            this.grossPayTextbox.Size = new System.Drawing.Size(163, 26);
            this.grossPayTextbox.TabIndex = 13;
            this.grossPayTextbox.TabStop = false;
            // 
            // deductionsTextbox
            // 
            this.deductionsTextbox.Location = new System.Drawing.Point(175, 784);
            this.deductionsTextbox.Name = "deductionsTextbox";
            this.deductionsTextbox.ReadOnly = true;
            this.deductionsTextbox.Size = new System.Drawing.Size(163, 26);
            this.deductionsTextbox.TabIndex = 13;
            this.deductionsTextbox.TabStop = false;
            // 
            // netPayTextbox
            // 
            this.netPayTextbox.Location = new System.Drawing.Point(175, 840);
            this.netPayTextbox.Name = "netPayTextbox";
            this.netPayTextbox.ReadOnly = true;
            this.netPayTextbox.Size = new System.Drawing.Size(163, 26);
            this.netPayTextbox.TabIndex = 13;
            this.netPayTextbox.TabStop = false;
            // 
            // calculateNetPayButton
            // 
            this.calculateNetPayButton.Enabled = false;
            this.calculateNetPayButton.Location = new System.Drawing.Point(364, 724);
            this.calculateNetPayButton.Name = "calculateNetPayButton";
            this.calculateNetPayButton.Size = new System.Drawing.Size(157, 39);
            this.calculateNetPayButton.TabIndex = 14;
            this.calculateNetPayButton.Text = "&Calculate Net Pay";
            this.calculateNetPayButton.UseVisualStyleBackColor = true;
            this.calculateNetPayButton.Click += new System.EventHandler(this.CalculateNetPayButton_Click);
            // 
            // savePaySlipButton
            // 
            this.savePaySlipButton.Enabled = false;
            this.savePaySlipButton.Location = new System.Drawing.Point(364, 799);
            this.savePaySlipButton.Name = "savePaySlipButton";
            this.savePaySlipButton.Size = new System.Drawing.Size(157, 39);
            this.savePaySlipButton.TabIndex = 16;
            this.savePaySlipButton.Text = "&Save Pay Slip";
            this.savePaySlipButton.UseVisualStyleBackColor = true;
            this.savePaySlipButton.Click += new System.EventHandler(this.SavePaySlipButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(364, 890);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(157, 39);
            this.quitButton.TabIndex = 17;
            this.quitButton.Text = "&Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // taxRatePercentLabel
            // 
            this.taxRatePercentLabel.AutoSize = true;
            this.taxRatePercentLabel.Location = new System.Drawing.Point(330, 572);
            this.taxRatePercentLabel.Name = "taxRatePercentLabel";
            this.taxRatePercentLabel.Size = new System.Drawing.Size(23, 20);
            this.taxRatePercentLabel.TabIndex = 0;
            this.taxRatePercentLabel.Text = "%";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 941);
            this.Controls.Add(this.taxRatePercentLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.savePaySlipButton);
            this.Controls.Add(this.calculateNetPayButton);
            this.Controls.Add(this.netPayTextbox);
            this.Controls.Add(this.deductionsTextbox);
            this.Controls.Add(this.grossPayTextbox);
            this.Controls.Add(this.netpayLabel);
            this.Controls.Add(this.deductionsLabel);
            this.Controls.Add(this.grossPayLabel);
            this.Controls.Add(this.chequeDateTimePicker);
            this.Controls.Add(this.chequeDateLabel);
            this.Controls.Add(this.otherDeductionsTextbox);
            this.Controls.Add(this.otherDeductionsLabel);
            this.Controls.Add(this.taxrateTextbox);
            this.Controls.Add(this.taxRateLabel);
            this.Controls.Add(this.taxExemptCheckbox);
            this.Controls.Add(this.hourlyRateTextbox);
            this.Controls.Add(this.employeeNameTextbox);
            this.Controls.Add(this.hoursWorkedGroupbox);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI Payroll Calculator";
            this.hoursWorkedGroupbox.ResumeLayout(false);
            this.hoursWorkedGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.GroupBox hoursWorkedGroupbox;
        private System.Windows.Forms.TextBox hourlyRateTextbox;
        private System.Windows.Forms.TextBox employeeNameTextbox;
        private System.Windows.Forms.TextBox overtimeTextbox;
        private System.Windows.Forms.Label overtimeLabel;
        private System.Windows.Forms.TextBox totalHoursTextbox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox taxExemptCheckbox;
        private System.Windows.Forms.Label taxRateLabel;
        private System.Windows.Forms.TextBox taxrateTextbox;
        private System.Windows.Forms.Label otherDeductionsLabel;
        private System.Windows.Forms.TextBox otherDeductionsTextbox;
        private System.Windows.Forms.Label chequeDateLabel;
        private System.Windows.Forms.DateTimePicker chequeDateTimePicker;
        private System.Windows.Forms.Label grossPayLabel;
        private System.Windows.Forms.Label deductionsLabel;
        private System.Windows.Forms.Label netpayLabel;
        private System.Windows.Forms.TextBox grossPayTextbox;
        private System.Windows.Forms.TextBox deductionsTextbox;
        private System.Windows.Forms.TextBox netPayTextbox;
        private System.Windows.Forms.Button calculateNetPayButton;
        private System.Windows.Forms.Button savePaySlipButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label taxRatePercentLabel;
        private System.Windows.Forms.Label sundayLabel;
        private System.Windows.Forms.Label saturdayLabel;
        private System.Windows.Forms.Label fridayLabel;
        private System.Windows.Forms.Label thurdayLabel;
        private System.Windows.Forms.Label wednesdayLabel;
        private System.Windows.Forms.Label tuesdayLabel;
        private System.Windows.Forms.Label mondayLabel;
        private System.Windows.Forms.TextBox sundayTextbox;
        private System.Windows.Forms.TextBox saturdayTextbox;
        private System.Windows.Forms.TextBox fridayTextbox;
        private System.Windows.Forms.TextBox thursdayTextbox;
        private System.Windows.Forms.TextBox wednesdayTextbox;
        private System.Windows.Forms.TextBox tuesdayTextbox;
        private System.Windows.Forms.TextBox mondayTextbox;
    }
}

