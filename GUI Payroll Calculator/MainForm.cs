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

//remember to return to Windows Form App from console app

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

        private float[] dailyHoursDataSet;   //Instance variable that can be accessed later down

        string employeeName;
        float hourlyRate        = 0;    //consider using decimal instead of float for more accurate money value? And something like 0m?
        float overTimeRate      = 1.5f; //the f suffix means that this number is float value

        float monHours          = 0;    //if hours > 8, overTime hours should equal monHours - 8 and then added to overtime?
        float tuesHours         = 0;
        float wedHours          = 0;
        float thursHours        = 0;
        float friHours          = 0;
        float satHours          = 0;
        float sunHours          = 0;
        float totalHours        = 0;
        float overTimeHours     = 0; //any hours >40 in total hours should cause event of totalHours - 40 to get overTime?


        float monOvertime       = 0;  //monHours(findOvertimeHours); //solution for finding overtime hours for individual days?
        float tuesOvertime      = 0;
        float wedOvertime       = 0;
        float thursOvertime     = 0;
        float friOvertime       = 0;
        float satOvertime       = 0;
        float sunOvertime       = 0;

        float taxRate           = 0;

        float otherDeductions   = 0;

        float grossPay          = 0;
        float deductions        = 0;
        float netPay            = 0;

        public static void findTotalHours()
        {


            //if (y >= 0)
            //{
            //    totalHours = totalHours + y;
            //}
        }

        //public static void findOvertimeHours (float x) //method to determine overtime hours for each individual day?
        //{
        //    if (x > 8)
        //    {
        //       x = (x - 8);
        //    }
        //}



        private void CalculateNetPayButton_Click(object sender, EventArgs e)
        {
            grossPay = (totalHours - overTimeHours * hourlyRate) + (overTimeHours * hourlyRate * overTimeRate); 
        }

        private void MondayTextbox_Enter(object sender, EventArgs e)    //resets the numerical value so it doesn't keep adding to total when changed
        {
            //totalHours = totalHours - monHours;
            //overTimeHours = overTimeHours - monOvertime;
            ////monHours = 0;
            ////monOvertime = 0;
        }

        private void MondayTextbox_Leave(object sender, EventArgs e)
        {
            //if (float.TryParse(mondayTextbox.Text, out monHours))       //converts string value to float if valid number
            //{
            //    totalHours = totalHours + monHours;                     //hours for this day are added to total week hours upon leaving textbox
            //    totalTextbox.Text = totalHours.ToString();              //outputs converted numeric value to the total hours textbox as an added value

            //    if (monHours < 0)                                       //verifies valid numeric value that is not below 0
            //    {
            //        MessageBox.Show("Value must not be less than 0.");
            //        return;
            //    }

            //    //if (monHours >= 0 && monHours < 8)
            //    //{
            //    //    monOvertime = 0;
            //    //}

            //    if (monHours > 8)                                       //adds overtime hours separately to calculate at overtime rate
            //    {
            //        monOvertime = monOvertime + (monHours - 8);
            //        overTimeHours = overTimeHours + monOvertime;
            //        overtimeTextbox.Text = overTimeHours.ToString();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Non-numerical value entered.");
            //    return;
            //}

        }

        private void TuesdayTextbox_Enter(object sender, EventArgs e)
        {
            //totalHours = totalHours - tuesHours;
        }

        private void TuesdayTextbox_Leave(object sender, EventArgs e)
        {
            //if (float.TryParse(tuesdayTextbox.Text, out tuesHours))
            //{
            //    totalHours = totalHours + tuesHours;
            //    totalTextbox.Text = totalHours.ToString();

            //    if (tuesHours < 0)
            //    {
            //        MessageBox.Show("Value must not be less than 0.");
            //        return;
            //    }

            //    if (monHours > 8)
            //    {
            //        overTimeHours = overTimeHours + (tuesHours - 8);
            //        overtimeTextbox.Text = overTimeHours.ToString();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Non-numerical value entered.");
            //    return;
            //}
        }

        private void EmployeeNameTextbox_Leave(object sender, EventArgs e)
        {
            float isANumber;
            if (float.TryParse(employeeNameTextbox.Text, out isANumber))    //verifies if value is a string. If not, exception is made.
            {
                MessageBox.Show("Value must be a string.");
                return;
            }

            else
            { 
            employeeName = $"{employeeNameTextbox.Text}";
            }

            Console.WriteLine($"Employee Name:{employeeName}");   //checks if employeeName is being called correctly

        }

        private void HourlyRateTextbox_Leave(object sender, EventArgs e)
        {
            float hourlyRateValue;
            if (float.TryParse(hourlyRateTextbox.Text, out hourlyRateValue))    //verifies hourlyRate is a numerical value
            {
                hourlyRate = hourlyRateValue;                                   //outputs converted value to hourlyRate value
            }

            else
            {MessageBox.Show("Hourly rate must be a numerical value.");
                return;
            }

            Console.WriteLine($"Hourly Rate:{hourlyRate}");  //checks if hourlyRate is being called correctly
        }

        private void TaxExemptCheckbox_CheckedChanged(object sender, EventArgs e)  //if checked, the tax rate fields disappear and are disabled
        {
             if (taxExemptCheckbox.Checked == true)
            {
                taxRateLabel.Visible = false;
                taxrateTextbox.Visible = false;
                taxRatePercentLabel.Visible = false;
                taxRate = 0;
                taxrateTextbox.Clear();
            }

            else
            {
                taxRateLabel.Visible = true;
                taxrateTextbox.Visible = true;
                taxRatePercentLabel.Visible = true;
            }

            Console.WriteLine($"Tax Rate: {taxRate}");      //checks to see if tax rate is changed to 0 when checked
        }

        private void TaxrateTextbox_Leave(object sender, EventArgs e)
        {
            float taxRateValue;
            if (float.TryParse(taxrateTextbox.Text, out taxRateValue))  //verifies taxRate value is a float number
            {
                taxRate = taxRateValue;                                 //pulls converted value to call as taxRateValue
            }
            else
            {
                MessageBox.Show("Tax rate must be a numeric value.");
            }

            Console.WriteLine($"Tax Rate: {taxRate}");                                 //checks if taxRate value is pulled correctly
        }

        private void OtherDeductionsTextbox_TextChanged(object sender, EventArgs e)
        {
            float otherDeductionValue;
            if (float.TryParse(otherDeductionsTextbox.Text, out otherDeductionValue))
            {
                otherDeductions = otherDeductionValue;
            }
            else
            {
                MessageBox.Show("Other deductions must be a numeric value.");
            }

            Console.WriteLine($"Other Deductions: {otherDeductions}");
        }









        //Allow the entry of the employee's full name

        //Allow the entry of hourly wage

        //Allow entry of hours worked per day of the week (default set to 0)

        //Allow entry of whether they are tax exempt; if not, percentage rate applied to gross pay.

        //Allow entry of total of other deductions, which can be optionally left blank.

        //Allow entry of date of pay calculation. Must be on a Monday, with date shown as full month name, full year digits (ex November 22, 2019)
        //Date of pay calculation must be present for user to view or save to Payslips (part of optional additions)

        //Must have button that performs calculations of pay. Displayed values must include:
        //Gross Pay, total deductions, and net pay. Currency values must be properly formatted.

        //Tax exempt control: if tax exempt checkbox is checked, the tax rate text box must be removed from the screen. The % label included.

        //Before calculate button may run, make requirement for entering at least one day's hours, entered an hourly rate, and selected either tax exempt, or tax %

        //Employee name and cheque date do NOT need to be entered for pay calculation, but do for View Payslip as well as requirements above if View Payslip is implemented
    }
}
