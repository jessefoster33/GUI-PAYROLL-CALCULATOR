// Assignment 4: GUI Payroll Calculator
//
// Author: Jesse Foster
// Dec 19, 2019
//
// Purpose: Calculating an employee's net pay after deductions via a GUI, and allowing user to save payslips.
//
// Description: This application will request an employee's information including name, hours worked, deduction percentage, and hourly rate
// and then will calculate and display their gross pay, deductions taken, and net pay after deductions. This will also display data input by
// user including employee name, hours worked, and hourly rate. A payslip text file can be saved summarizing input and calculated data.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Personal Note: remember in the future that tab order index also includes group boxes, which is what messed up my initial order so badly until I set the number for it

namespace GUI_Payroll_Calculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string employeeName;                    //user's first and last name will be entered here
        const int MaxLength         = 50;       //used to limit number of characters in employeeName textfield to 50 or less               

        float   hourlyRate          = 0;        //hourly rate numeric value will be set by user, and will be used in calculating gross pay
        float   overTimeRate        = 0;        //overtime rate is assumed to be time and a half; this will be calculated by multiplying hourlyRate by 1.5


        float   convertedHourValue  = 0;        //variable that is used for a TryParse argument to verify whether a valid numeric value was entered 
        float   monHours            = 0;        //if hours > 8, overTime hours should equal monHours - 8 and then added to overtime (same with each day-related variable in this section)
        float   tuesHours           = 0;
        float   wedHours            = 0;
        float   thursHours          = 0;
        float   friHours            = 0;
        float   satHours            = 0;
        float   sunHours            = 0;
        float   totalHours          = 0;        //all valid values entered in weekday textboxes will be added together using this variable
        float   overTimeHours       = 0;        //overTimeHours will be calculated by subtracting 40 from total hours if totalHours > 40

        float   regularHoursPay     = 0;        //variable used to hold total value of regular hours multiplied by regular hourly rate
        float   overTimePay         = 0;        //variable used to hold total value of overtime hours multiplied by time and a half rate

        float   taxRate             = 0;        //user sets tax rate value here, and is used to calculate deductions and netPay value (if user is NOT tax-exempt)
        float   taxDeductions       = 0;        //taxes deducted from gross pay

        float   otherDeductions     = 0;        //user sets other deduction value here, and is subtracted from gross pay alongside tax deductions

        float   grossPay            = 0;        //total of all hours, including regular and overtime hourly pay
        float   deductions          = 0;        //determined by multiplying grossPay by taxRate value, and will be subtracted from grossPay to determine netPay
        float   netPay              = 0;        //value determined by grossPay minus all deductions


        private void EmployeeNameTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(employeeNameTextbox.Text, out _))                //verifies if value is a string. If it is a number, error message is displayed. Refactored to out_ from: float.TryParse(employeeNameTextbox.Text,out float isANumber), isANumber is unnecessary assignment here
            {

                MessageBox.Show("Value must be a string.");
                return;
            }

            if (employeeNameTextbox.Text == string.Empty)                       //deactivates payslip save buttons if user deletes employee name
            {
                
                savePaySlipButton.Enabled = false;

                MessageBox.Show("Please enter employee name if saving payslips.");
            }

            else
            {
                employeeName = $"{employeeNameTextbox.Text}";                   //displays string value in employeeNameTextbox if it is a valid string value
            }

            if (employeeName.Length > MaxLength)
            {
                employeeName = employeeName.Substring(0, MaxLength);            //manually truncates number of characters in employeeName if over 50 characters are entered
            }
        }

        private void HourlyRateTextbox_Leave(object sender, EventArgs e)
        {
            
            if (float.TryParse(hourlyRateTextbox.Text, out float hourlyRateValue))    //verifies hourlyRate is a numerical value
            {
                hourlyRate = hourlyRateValue;                                         //outputs converted value to hourlyRate value
            }

            if (hourlyRate <= 0)                                                      //prevents user from entering an invalid value; hourly rate of 0 not allowed
            {
                calculateNetPayButton.Enabled = false;                                //calculate net pay button cannot be used without an hourly rate
                MessageBox.Show("Hourly rate must be a numerical value above 0.");
                return;
            }

            if (taxRate <= 0 && taxExemptCheckbox.Checked == false)
            {
                calculateNetPayButton.Enabled = false;
            }

            hourlyRateTextbox.Text = hourlyRate.ToString("c2");         //converts displayed value of hourlyRate to currency
        }

        private void CalculateButtonActivate()                          //method that activates calculateNetPayButton only when at least 1 day has hours entered, hourly rate is entered, and if tax exempt OR tax rate entered
        {
            if (totalHours > 0 && hourlyRate > 0 && taxRate > 0 || totalHours > 0 && hourlyRate > 0 && taxExemptCheckbox.Checked == true)
            {
                calculateNetPayButton.Enabled = true;
            }
        }

        private void FindTotalHours()                                   //method that updates value of totalHours added to totalHoursTextbox and determines overtime hours and rate
        {
            totalHoursTextbox.Text = totalHours.ToString("f2");         //f2 converts value to a float displaying up to 2 decimal places

            if (totalHours > 40)
            {
                overTimeHours = totalHours - 40;                        //find overTimeHours by subtracting 40 from total hours if greater than 40
                overTimeRate = hourlyRate * 1.5f;                       //finds overTimeRate according to user input in hourlyRate set to time and a half
            }

            overtimeTextbox.Text = overTimeHours.ToString("f2");
        }

        private void DisplayHoursFloat()                                //method to convert hour values to float displaying 2 decimal places. Enables calculate button when at least 1 day has hours input
        {
            totalHoursTextbox.Text = totalHours.ToString("f2");
            overtimeTextbox.Text = overTimeHours.ToString("f2");

            if (totalHours <= 0)
            {
                calculateNetPayButton.Enabled = false;
                savePaySlipButton.Enabled = false;
               
                MessageBox.Show("Please input your hours for at least one day.");
            }

            CalculateButtonActivate();
        }

        private void CorrectOverTimeHours()                     //method to remove overtime hours if user changes hour input values to total less than 40 hours
        {
            if (totalHours <= 40)
            {
                overTimeHours -= overTimeHours;
            }
        }

        private void MondayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(mondayTextbox.Text, out convertedHourValue))         //determines if valid numeric value is entered
            {
                monHours    = convertedHourValue;
                totalHours  += monHours;                                            //refactored from totalHours = totalHours + monHours to a compoutnd assignment via intellisense recommendation; shortens number of lines
                FindTotalHours();
            }
            else if (mondayTextbox.Text is null)                                    //allows field to be left empty, assumes value is 0
            {
                monHours = 0;
            }
            if (monHours < 0 || monHours > 24)                                       //prevents negative values from being entered and values over 24 (why if instead of else if? Because else if is an either or situation, while if always runs when if argument is true 
            {
                totalHours  -= monHours;                                             //negates value less than 0 when entered and keeps it from affecting totalHours value; refactored to compound assignment from totalHours = totalHours - monHours
                monHours    -= monHours;                                             //negates value less than 0 when entered in relevent text field (monHours in this case)
                DailyHoursErrorMessage();
            }

            DisplayHoursFloat();                                                    //displays a float value even if left empty in both total and overtime hours
            mondayTextbox.Text = monHours.ToString("f2");                           //value in related textfield will display as a float value even if null, assuming value of 0
        }

        private void TuesdayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(tuesdayTextbox.Text, out convertedHourValue))
            {
                tuesHours   = convertedHourValue;
                totalHours  += tuesHours;
                FindTotalHours();
            }
            else if (tuesdayTextbox.Text is null)
            {
                tuesHours = 0;
            }
            if (tuesHours < 0 || tuesHours > 24)
            {
                totalHours -= tuesHours;                            
                tuesHours  -= tuesHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            tuesdayTextbox.Text = tuesHours.ToString("f2");
        }

        private void WednesdayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(wednesdayTextbox.Text, out convertedHourValue))
            {
                wedHours    = convertedHourValue;
                totalHours  += wedHours;
                FindTotalHours();
            }
            else if (wednesdayTextbox.Text is null)
            {
                wedHours = 0;
            }
            if (wedHours < 0 || wedHours > 24)
            {
                totalHours  -= wedHours;
                wedHours    -= wedHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            wednesdayTextbox.Text = wedHours.ToString("f2");
        }

        private void ThursdayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(thursdayTextbox.Text, out convertedHourValue))
            {
                thursHours = convertedHourValue;
                totalHours += thursHours;
                FindTotalHours();
            }
            else if (thursdayTextbox.Text is null)
            {
                thursHours = 0;
                
            }
            if (thursHours < 0 || thursHours > 24)
            {
                totalHours -= thursHours;
                thursHours -= thursHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            thursdayTextbox.Text = thursHours.ToString("f2");
        }

        private void FridayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(fridayTextbox.Text, out convertedHourValue))
            {
                friHours    = convertedHourValue;
                totalHours  += friHours;
                FindTotalHours();
            }
            else if (fridayTextbox.Text is null)
            {
                friHours = 0;
            }
            if (friHours < 0 || friHours > 24)
            {
                totalHours -= friHours;
                friHours -= friHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            fridayTextbox.Text = friHours.ToString("f2");
        }

        private void SaturdayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(saturdayTextbox.Text, out convertedHourValue))
            {
                satHours = convertedHourValue;
                totalHours += satHours;
                FindTotalHours();
            }
            else if (saturdayTextbox.Text is null)
            {
                satHours = 0;
            }
            if (satHours < 0 || satHours > 24)
            {
                totalHours -= satHours;
                satHours -= satHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            saturdayTextbox.Text = satHours.ToString("f2");
        }

        private void SundayTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(sundayTextbox.Text, out convertedHourValue))
            {
                sunHours    = convertedHourValue;
                totalHours  += sunHours;
                FindTotalHours();
            }
            else if (sundayTextbox.Text is null)
            {
                sunHours = 0;

            }
            if (sunHours < 0 || sunHours > 24)
            {
                totalHours -= sunHours;
                sunHours -= sunHours;
                DailyHoursErrorMessage();
            }
            DisplayHoursFloat();
            sundayTextbox.Text = sunHours.ToString("f2");                
        }

        private static void DailyHoursErrorMessage()                              //error message displays if values in daily hour fields are below 0 or above 24 hours
        {
            MessageBox.Show($"Hours entered must be between 0 and 24.");
        }

        private void TaxExemptCheckbox_CheckedChanged(object sender, EventArgs e)  //if checked, the tax rate fields disappear and are disabled
        {
             if (taxExemptCheckbox.Checked == true)
            {
                taxRateLabel.Visible = false;                                      //taxRateLabel is removed
                taxrateTextbox.Visible = false;                                    //taxrateTextBox field is removed
                taxRatePercentLabel.Visible = false;                               //percent label is removed
                taxRate = 0;                                                       //taxRate value is reset to 0
                taxrateTextbox.Clear();                                            //resets taxrateTextbox string value 
            }

            else
            {
                taxRateLabel.Visible = true;
                taxrateTextbox.Visible = true;
                taxRatePercentLabel.Visible = true;
            }
            CalculateButtonActivate();
        }

        private void TaxrateTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(taxrateTextbox.Text, out float taxRateValue))            //verifies taxRate value is a float number
            {
                taxRate = taxRateValue * 0.01f;                                         //pulls converted value to call as taxRateValue and sets value to a percentage rather than whole number

            }
            if (taxExemptCheckbox.Checked == false && taxRateValue <= 0)                //calculate net pay button is disabled if value of 0 or less is input when tax exempt checkbox is unchecked
            {
                calculateNetPayButton.Enabled = false;
                taxRate -= taxRate;                                                     //resets value if invalid
                MessageBox.Show("Tax rate must be greater than 0 if not tax exempt.");
            }

            if (hourlyRate <= 0 || totalHours <= 0)                                     //this extra conditional statement activates calculate button in conditions separate from CalculateButtonActivate method 
            {
                calculateNetPayButton.Enabled = true;
            }
            CalculateButtonActivate();
           // SavePayslipButtonActivate();

            taxrateTextbox.Text = taxRateValue.ToString("f2");                          //displays taxRateValue input (before multiplying by 0.01 for deduction calculation) as a float number showing 2 decimal places
        }

        private void SavePayslipButtonActivate()                                        //enables savePayslipButton only if calculate button is active, employee name has a string,
        {                                                                               //and chequeDateTimePicker has selection made and either tax exempt is checked or taxrate value is above 0

            if (calculateNetPayButton.Enabled == true && employeeName != null && taxRate > 0 && taxExemptCheckbox.Checked == false && chequeDateTimePicker.Value != null || calculateNetPayButton.Enabled == true && employeeName != null && taxExemptCheckbox.Checked == true && chequeDateTimePicker.Value != null)
            {

                savePaySlipButton.Enabled = true;
            }
            else
            {

                savePaySlipButton.Enabled = false;
            }
        }

        private void OtherDeductionsTextbox_Leave(object sender, EventArgs e)
        {
            if (float.TryParse(otherDeductionsTextbox.Text, out float otherDeductionValue))
            {
                otherDeductions = otherDeductionValue;
            }
            else if (otherDeductionsTextbox.Text is null)
            {
                otherDeductions = 0;
                otherDeductionsTextbox.Text = otherDeductions.ToString("c2");   //converts this value to currency and displays as $0.00 if null
            }
            else if (otherDeductions < 0)
            {
                MessageBox.Show($"Deductions value must not be less than 0.");  //prevents values less than 0  being entered
                return;
            }
            otherDeductionsTextbox.Text = otherDeductions.ToString("c2");       //converts this value to currency
            }

        private void CalculateNetPayButton_Click(object sender, EventArgs e)
        {
            regularHoursPay      = (totalHours - overTimeHours) * hourlyRate;       //calculates pay for regular hours (40 hours or less) at regular rate
            overTimePay          = overTimeHours * overTimeRate;                    //calculates overtime pay (above 40 hours) at time and a half rate
            grossPay             = regularHoursPay + overTimePay;                   //adds up total pay values between regular hours and overtime

            grossPayTextbox.Text = grossPay.ToString("c2");                         //converts grosspay value to currency, displays in gross pay read only gross pay textbox

            taxDeductions   = grossPay * taxRate;                                   //finds deductions to gross pay after tax calculated
            deductions      = taxDeductions + otherDeductions;                      //finds total deductions including additional deductions

            deductionsTextbox.Text = deductions.ToString("c2");                     //converts the deduction value to currency, displays in deductions read only textbox

            netPay = grossPay - deductions;                                         //finds total pay after taxes and deductions

            netPayTextbox.Text = netPay.ToString("c2");                             //converts netPay value to currency, displays in netpay read only textboxt
        }

        private void MondayTextbox_Enter(object sender, EventArgs e)                //resets value if user comes back to fix it and removes previous value from totalHours
        {
            if (monHours > 0)                                                       //this means if a previous value above 0 is entered, it will be reset for the new input value
            {
                totalHours -= monHours;
            }
            CorrectOverTimeHours();                                                 //resets overtime hours value to 0 if hourly total is less than 40 after user makes changes
        }

        private void TuesdayTextbox_Enter(object sender, EventArgs e)
        {
            if (tuesHours > 0)
            {
                totalHours -= tuesHours;
            }
            CorrectOverTimeHours();
        }

        private void WednesdayTextbox_Enter(object sender, EventArgs e)
        {
            if (wedHours > 0)
            {
                totalHours -= wedHours;
            }
            CorrectOverTimeHours();
        }

        private void ThursdayTextbox_Enter(object sender, EventArgs e)
        {
            if (thursHours > 0)
            {
                totalHours -= thursHours;
            }
            CorrectOverTimeHours();
        }

        private void FridayTextbox_Enter(object sender, EventArgs e)
        {
            if (friHours > 0)
            {
                totalHours -= friHours;
            }
            CorrectOverTimeHours();
        }

        private void SaturdayTextbox_Enter(object sender, EventArgs e)
        {
            if (satHours > 0)
            {
                totalHours -= satHours;
            }
            CorrectOverTimeHours();
        }

        private void SundayTextbox_Enter(object sender, EventArgs e)
        {
            if (sunHours > 0)
            {
                totalHours -= sunHours;
            }
            CorrectOverTimeHours();
        }

        private void ChequeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            chequeDateTimePicker.CustomFormat = "dd MMMM yyyy";                     //first, I chose custom format in datetimepicker properties, then in custom date entered a space to show a null value by default,
                                                                                    //then set the custom format by hand here. This format will view as day, full month name, full year (ex 18 December 2019)

            DateTimePicker dtp = sender as DateTimePicker;                          //used DateTimePicker as data type here, chosen via intelliSense recommnedation. Calls to DateTimePicker 
            DateTime selectedDate = dtp.Value;                                      //DateTime used as data type here. References the selected value of the dateTimePicker
            if (selectedDate.DayOfWeek != DayOfWeek.Monday)                         //does not allow user to choose any day of week but Monday
            {
                int offset = (int)DayOfWeek.Monday - (int)selectedDate.DayOfWeek;   //subtracts added days from nearest Monday date to force the selection to the Monday of that week
                DateTime monday = selectedDate + TimeSpan.FromDays(offset);         //adds from the number of the days between the selected date and the offset date
                dtp.Value = monday;                                                 //references Monday as the day to set when finding the day of the week above
            }

            SavePayslipButtonActivate();

            if (calculateNetPayButton.Enabled == false)
            {
                savePaySlipButton.Enabled = false;
            }
        }

        private void TaxExemptCheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            if (taxExemptCheckbox.Checked == false && taxRate == 0)      //deactives calculate button if user unchecks checkbox. Without this, the calculate button stays active with a null tax rate value
            {
                calculateNetPayButton.Enabled = false;
            }

            if (calculateNetPayButton.Enabled == false)
            {
                savePaySlipButton.Enabled = false;
            }

            //SavePayslipButtonActivate();
        }

        private void SavePaySlipButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            DialogResult result = sfd.ShowDialog();

            if (result != DialogResult.OK)
            {
                return;
            }

            try
            { 
            StreamWriter outputFile = new StreamWriter(sfd.FileName);

            outputFile.WriteLine($"Employee Name: {employeeName}");
            outputFile.WriteLine($"Date Issued: {chequeDateTimePicker.Value.ToString("MMM dd yy")}"); //.Value selects the actual value selected in chequeDateTimePicker, and .ToString("MMM dd, yy") sets custom format ex: Jan 12, 19;
            outputFile.WriteLine($"Total Hours Worked: {totalHours}");
            outputFile.WriteLine($"Regular Hours Worked: {totalHours - overTimeHours}");
            outputFile.WriteLine($"Overtime Hours Worked: {overTimeHours}");
            outputFile.WriteLine($"Hourly Rate: {hourlyRate}");
            outputFile.WriteLine($"Overtime Multiplier: 1.5");
            outputFile.WriteLine($"Gross Pay: {grossPay}");
            outputFile.WriteLine($"Deductions: {deductions}");
            outputFile.WriteLine($"Net Pay: {netPay}");

            outputFile.Close();         //closes file when application is done with save process
            }
            catch (Exception excp)
            {
                MessageBox.Show($"Output file {sfd.FileName} was not written. {excp.Message}");
                return;
            }
        }
    }
}
