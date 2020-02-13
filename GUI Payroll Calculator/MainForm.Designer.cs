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
            this.totalTextbox = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
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
            this.viewPaySlipButton = new System.Windows.Forms.Button();
            this.savePaySlipButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.taxRatePercentLabel = new System.Windows.Forms.Label();
            this.hoursWorkedListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insertAfterButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.hourlyRateLabel.TabIndex = 1;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // hoursWorkedGroupbox
            // 
            this.hoursWorkedGroupbox.Controls.Add(this.textBox1);
            this.hoursWorkedGroupbox.Controls.Add(this.loadButton);
            this.hoursWorkedGroupbox.Controls.Add(this.deleteButton);
            this.hoursWorkedGroupbox.Controls.Add(this.insertAfterButton);
            this.hoursWorkedGroupbox.Controls.Add(this.updateButton);
            this.hoursWorkedGroupbox.Controls.Add(this.addButton);
            this.hoursWorkedGroupbox.Controls.Add(this.hoursWorkedListBox);
            this.hoursWorkedGroupbox.Controls.Add(this.overtimeTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.overtimeLabel);
            this.hoursWorkedGroupbox.Controls.Add(this.totalTextbox);
            this.hoursWorkedGroupbox.Controls.Add(this.totalLabel);
            this.hoursWorkedGroupbox.Location = new System.Drawing.Point(29, 126);
            this.hoursWorkedGroupbox.Name = "hoursWorkedGroupbox";
            this.hoursWorkedGroupbox.Size = new System.Drawing.Size(588, 416);
            this.hoursWorkedGroupbox.TabIndex = 2;
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
            // 
            // overtimeLabel
            // 
            this.overtimeLabel.AutoSize = true;
            this.overtimeLabel.Location = new System.Drawing.Point(293, 368);
            this.overtimeLabel.Name = "overtimeLabel";
            this.overtimeLabel.Size = new System.Drawing.Size(80, 20);
            this.overtimeLabel.TabIndex = 2;
            this.overtimeLabel.Text = "OverTime:";
            // 
            // totalTextbox
            // 
            this.totalTextbox.Location = new System.Drawing.Point(141, 368);
            this.totalTextbox.Name = "totalTextbox";
            this.totalTextbox.ReadOnly = true;
            this.totalTextbox.Size = new System.Drawing.Size(100, 26);
            this.totalTextbox.TabIndex = 3;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(70, 371);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(48, 20);
            this.totalLabel.TabIndex = 2;
            this.totalLabel.Text = "Total:";
            // 
            // hourlyRateTextbox
            // 
            this.hourlyRateTextbox.Location = new System.Drawing.Point(175, 80);
            this.hourlyRateTextbox.Name = "hourlyRateTextbox";
            this.hourlyRateTextbox.Size = new System.Drawing.Size(102, 26);
            this.hourlyRateTextbox.TabIndex = 3;
            this.hourlyRateTextbox.Leave += new System.EventHandler(this.HourlyRateTextbox_Leave);
            // 
            // employeeNameTextbox
            // 
            this.employeeNameTextbox.Location = new System.Drawing.Point(175, 36);
            this.employeeNameTextbox.Name = "employeeNameTextbox";
            this.employeeNameTextbox.Size = new System.Drawing.Size(442, 26);
            this.employeeNameTextbox.TabIndex = 3;
            this.employeeNameTextbox.Leave += new System.EventHandler(this.EmployeeNameTextbox_Leave);
            // 
            // taxExemptCheckbox
            // 
            this.taxExemptCheckbox.AutoSize = true;
            this.taxExemptCheckbox.Location = new System.Drawing.Point(29, 568);
            this.taxExemptCheckbox.Name = "taxExemptCheckbox";
            this.taxExemptCheckbox.Size = new System.Drawing.Size(118, 24);
            this.taxExemptCheckbox.TabIndex = 4;
            this.taxExemptCheckbox.Text = "Tax Exempt";
            this.taxExemptCheckbox.UseVisualStyleBackColor = true;
            this.taxExemptCheckbox.CheckedChanged += new System.EventHandler(this.TaxExemptCheckbox_CheckedChanged);
            // 
            // taxRateLabel
            // 
            this.taxRateLabel.AutoSize = true;
            this.taxRateLabel.Location = new System.Drawing.Point(166, 568);
            this.taxRateLabel.Name = "taxRateLabel";
            this.taxRateLabel.Size = new System.Drawing.Size(77, 20);
            this.taxRateLabel.TabIndex = 5;
            this.taxRateLabel.Text = "Tax Rate:";
            // 
            // taxrateTextbox
            // 
            this.taxrateTextbox.Location = new System.Drawing.Point(250, 567);
            this.taxrateTextbox.Name = "taxrateTextbox";
            this.taxrateTextbox.Size = new System.Drawing.Size(74, 26);
            this.taxrateTextbox.TabIndex = 6;
            this.taxrateTextbox.Leave += new System.EventHandler(this.TaxrateTextbox_Leave);
            // 
            // otherDeductionsLabel
            // 
            this.otherDeductionsLabel.AutoSize = true;
            this.otherDeductionsLabel.Location = new System.Drawing.Point(25, 616);
            this.otherDeductionsLabel.Name = "otherDeductionsLabel";
            this.otherDeductionsLabel.Size = new System.Drawing.Size(138, 20);
            this.otherDeductionsLabel.TabIndex = 7;
            this.otherDeductionsLabel.Text = "Other Deductions:";
            // 
            // otherDeductionsTextbox
            // 
            this.otherDeductionsTextbox.Location = new System.Drawing.Point(170, 616);
            this.otherDeductionsTextbox.Name = "otherDeductionsTextbox";
            this.otherDeductionsTextbox.Size = new System.Drawing.Size(154, 26);
            this.otherDeductionsTextbox.TabIndex = 8;
            this.otherDeductionsTextbox.TextChanged += new System.EventHandler(this.OtherDeductionsTextbox_TextChanged);
            // 
            // chequeDateLabel
            // 
            this.chequeDateLabel.AutoSize = true;
            this.chequeDateLabel.Location = new System.Drawing.Point(42, 662);
            this.chequeDateLabel.Name = "chequeDateLabel";
            this.chequeDateLabel.Size = new System.Drawing.Size(108, 20);
            this.chequeDateLabel.TabIndex = 9;
            this.chequeDateLabel.Text = "Cheque Date:";
            // 
            // chequeDateTimePicker
            // 
            this.chequeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.chequeDateTimePicker.Location = new System.Drawing.Point(170, 662);
            this.chequeDateTimePicker.Name = "chequeDateTimePicker";
            this.chequeDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.chequeDateTimePicker.TabIndex = 11;
            // 
            // grossPayLabel
            // 
            this.grossPayLabel.AutoSize = true;
            this.grossPayLabel.Location = new System.Drawing.Point(64, 736);
            this.grossPayLabel.Name = "grossPayLabel";
            this.grossPayLabel.Size = new System.Drawing.Size(86, 20);
            this.grossPayLabel.TabIndex = 12;
            this.grossPayLabel.Text = "Gross Pay:";
            // 
            // deductionsLabel
            // 
            this.deductionsLabel.AutoSize = true;
            this.deductionsLabel.Location = new System.Drawing.Point(56, 790);
            this.deductionsLabel.Name = "deductionsLabel";
            this.deductionsLabel.Size = new System.Drawing.Size(94, 20);
            this.deductionsLabel.TabIndex = 12;
            this.deductionsLabel.Text = "Deductions:";
            // 
            // netpayLabel
            // 
            this.netpayLabel.AutoSize = true;
            this.netpayLabel.Location = new System.Drawing.Point(82, 846);
            this.netpayLabel.Name = "netpayLabel";
            this.netpayLabel.Size = new System.Drawing.Size(68, 20);
            this.netpayLabel.TabIndex = 12;
            this.netpayLabel.Text = "Net Pay:";
            // 
            // grossPayTextbox
            // 
            this.grossPayTextbox.Location = new System.Drawing.Point(175, 730);
            this.grossPayTextbox.Name = "grossPayTextbox";
            this.grossPayTextbox.ReadOnly = true;
            this.grossPayTextbox.Size = new System.Drawing.Size(163, 26);
            this.grossPayTextbox.TabIndex = 13;
            // 
            // deductionsTextbox
            // 
            this.deductionsTextbox.Location = new System.Drawing.Point(175, 784);
            this.deductionsTextbox.Name = "deductionsTextbox";
            this.deductionsTextbox.ReadOnly = true;
            this.deductionsTextbox.Size = new System.Drawing.Size(163, 26);
            this.deductionsTextbox.TabIndex = 13;
            // 
            // netPayTextbox
            // 
            this.netPayTextbox.Location = new System.Drawing.Point(175, 840);
            this.netPayTextbox.Name = "netPayTextbox";
            this.netPayTextbox.ReadOnly = true;
            this.netPayTextbox.Size = new System.Drawing.Size(163, 26);
            this.netPayTextbox.TabIndex = 13;
            // 
            // calculateNetPayButton
            // 
            this.calculateNetPayButton.Location = new System.Drawing.Point(364, 724);
            this.calculateNetPayButton.Name = "calculateNetPayButton";
            this.calculateNetPayButton.Size = new System.Drawing.Size(157, 39);
            this.calculateNetPayButton.TabIndex = 14;
            this.calculateNetPayButton.Text = "Calculate Net Pay";
            this.calculateNetPayButton.UseVisualStyleBackColor = true;
            this.calculateNetPayButton.Click += new System.EventHandler(this.CalculateNetPayButton_Click);
            // 
            // viewPaySlipButton
            // 
            this.viewPaySlipButton.Location = new System.Drawing.Point(364, 778);
            this.viewPaySlipButton.Name = "viewPaySlipButton";
            this.viewPaySlipButton.Size = new System.Drawing.Size(157, 39);
            this.viewPaySlipButton.TabIndex = 14;
            this.viewPaySlipButton.Text = "View Pay Slip";
            this.viewPaySlipButton.UseVisualStyleBackColor = true;
            // 
            // savePaySlipButton
            // 
            this.savePaySlipButton.Location = new System.Drawing.Point(364, 834);
            this.savePaySlipButton.Name = "savePaySlipButton";
            this.savePaySlipButton.Size = new System.Drawing.Size(157, 39);
            this.savePaySlipButton.TabIndex = 14;
            this.savePaySlipButton.Text = "Save Pay Slip";
            this.savePaySlipButton.UseVisualStyleBackColor = true;
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(364, 890);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(157, 39);
            this.quitButton.TabIndex = 14;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // taxRatePercentLabel
            // 
            this.taxRatePercentLabel.AutoSize = true;
            this.taxRatePercentLabel.Location = new System.Drawing.Point(330, 572);
            this.taxRatePercentLabel.Name = "taxRatePercentLabel";
            this.taxRatePercentLabel.Size = new System.Drawing.Size(23, 20);
            this.taxRatePercentLabel.TabIndex = 15;
            this.taxRatePercentLabel.Text = "%";
            // 
            // hoursWorkedListBox
            // 
            this.hoursWorkedListBox.FormattingEnabled = true;
            this.hoursWorkedListBox.ItemHeight = 20;
            this.hoursWorkedListBox.Location = new System.Drawing.Point(17, 46);
            this.hoursWorkedListBox.Name = "hoursWorkedListBox";
            this.hoursWorkedListBox.Size = new System.Drawing.Size(168, 284);
            this.hoursWorkedListBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(392, 46);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(171, 40);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add Hours";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(392, 104);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(171, 40);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update Hours";
            this.updateButton.UseVisualStyleBackColor = true;
            // 
            // insertAfterButton
            // 
            this.insertAfterButton.Location = new System.Drawing.Point(392, 167);
            this.insertAfterButton.Name = "insertAfterButton";
            this.insertAfterButton.Size = new System.Drawing.Size(171, 40);
            this.insertAfterButton.TabIndex = 5;
            this.insertAfterButton.Text = "Insert After";
            this.insertAfterButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(392, 229);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(171, 40);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Delete Hours";
            this.deleteButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(392, 290);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(171, 40);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load Time Sheet";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 26);
            this.textBox1.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 941);
            this.Controls.Add(this.taxRatePercentLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.savePaySlipButton);
            this.Controls.Add(this.viewPaySlipButton);
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
        private System.Windows.Forms.TextBox totalTextbox;
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
        private System.Windows.Forms.Button viewPaySlipButton;
        private System.Windows.Forms.Button savePaySlipButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label taxRatePercentLabel;
        private System.Windows.Forms.ListBox hoursWorkedListBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button insertAfterButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

