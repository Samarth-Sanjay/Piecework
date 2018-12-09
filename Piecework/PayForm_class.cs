using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clearwater;
using TampaBay;

namespace Piecework
{
    public partial class PayForm_class : Form
    {
        private List<PieceworkPay> totalSalary = new List<PieceworkPay>();

        public PayForm_class()
        {
            InitializeComponent();
        }

        private void PayForm_class_Load(object sender, EventArgs e)
        {
        }

        private void buttonclearAll_Click(object sender, EventArgs e)
        {
            var dialogResult =
                MessageBox.Show("Are you sure you want to clear all", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                totalSalary = new List<PieceworkPay>();
                buttonSummary.Enabled = false;
                textBoxNumberOfPieces.Text = "";
                textBoxWorkersName.Text = "";
                labelvalue.Text = "$ 0.00";
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (totalSalary.Any()) totalSalary.RemoveAt(totalSalary.Count - 1);

            if (!totalSalary.Any()) buttonSummary.Enabled = false;
            textBoxNumberOfPieces.Text = "";
            textBoxWorkersName.Text = "";
            labelvalue.Text = "$ 0.00";
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                var numberOfPieces = Convert.ToInt32(textBoxNumberOfPieces.Text.Trim());
                var workersName = textBoxWorkersName.Text.Trim();
                //var salary = calculateSalary(numberOfPieces);
                //var pieceWorkPay = checkBoxSeniorPay.Checked
                //    ? new SeniorPay(){
                //        Name = workersName,
                //        Pieces = numberOfPieces
                //    } 
                //    : new PieceworkPay()
                //    {
                //        Name = workersName,
                //        Pieces = numberOfPieces

                //    };


                if (checkBoxSeniorPay.Checked)
                {
                    var seniorPay = new SeniorPay
                    {
                        Name = workersName,
                        Pieces = numberOfPieces
                    };
                    totalSalary.Add(seniorPay);
                    labelvalue.Text = "$ " + seniorPay.CalculatePay().ToString("0.00");
                }
                else
                {
                    var pieceWorkPay = new PieceworkPay
                    {
                        Name = workersName,
                        Pieces = numberOfPieces
                    };
                    totalSalary.Add(pieceWorkPay);
                    labelvalue.Text = "$ " + pieceWorkPay.CalculatePay().ToString("0.00");
                }


                buttonSummary.Enabled = true;
            }
        }

        public bool validate()
        {
            var numberOfPieces = textBoxNumberOfPieces.Text.Trim();
            var workersName = textBoxWorkersName.Text.Trim();

            try
            {
                if (string.IsNullOrEmpty(workersName))
                    throw new ArgumentException("Please add worker's name");
                if (string.IsNullOrEmpty(numberOfPieces))
                    throw new ArgumentException("Please add the number of pieces");

                try
                {
                    var checknumberOfPieces = Convert.ToInt32(numberOfPieces);
                    if (checknumberOfPieces <= 0) throw new ArgumentException("Please enter a valid number of pieces");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Please enter a valid number of pieces", "Invalid Data");
                    textBoxNumberOfPieces.Focus();
                    textBoxNumberOfPieces.SelectAll();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Invalid Data");
                return false;
            }

            return true;
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            new summaryForm(totalSalary).Show();
        }
    }
}