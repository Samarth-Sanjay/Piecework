using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exception = System.Exception;

namespace Piecework
{
    public partial class PayForm : Form
    {
        List<WorkersSalary> totalSalaries = new List<WorkersSalary>();
        public PayForm()
        {
            InitializeComponent();
        }
        private void PayForm_Load(object sender, EventArgs e)
        {
            buttonSummary.Enabled = false;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (totalSalaries.Any())
            {
                totalSalaries.RemoveAt(totalSalaries.Count - 1);
            }

            if (!totalSalaries.Any())
            {
                buttonSummary.Enabled = false;
            }

            textBoxNumberOfPieces.Text = "";
            textBoxWorkersName.Text = "";
            labelvalue.Text = "$ 0.00";
        }

        public double getPayRate(int piecesCompleted)
        {
            var payRate = 0.00;
            if (piecesCompleted >= 1 && piecesCompleted <= 199)
            {
                payRate = 0.50;
            }
            else if (piecesCompleted >= 200 && piecesCompleted <= 399)
            {
                payRate = 0.55;
            }
            else if (piecesCompleted >= 400 && piecesCompleted <= 599)
            {
                payRate = 0.60;
            }
            else if (piecesCompleted >= 600 )
            {
                payRate = 0.65;
            }

            return payRate;

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            
            if (validate())
            {
                var numberOfPieces = Convert.ToInt32(textBoxNumberOfPieces.Text.Trim());
                var workersName = textBoxWorkersName.Text.Trim();
                var salary = calculateSalary(numberOfPieces);
                totalSalaries.Add(new WorkersSalary()
                {
                    name = workersName,
                    piecesCompleted = numberOfPieces,
                    salary = salary
                });
                labelvalue.Text = "$ " + salary.ToString("0.00");
                buttonSummary.Enabled = true;
            }
            
        }

        public double calculateSalary(int numberOfpieces)
        {
            return numberOfpieces * getPayRate(numberOfpieces);
        }
        public bool validate()
        {
            var numberOfPieces = textBoxNumberOfPieces.Text.Trim();
            var workersName = textBoxWorkersName.Text.Trim();
            
            try
            {
                //if (!decimal.TryParse(workersName, out test))
                //{
                //  MessageBox.Show("Please enter valid workers name");

                //}
                //else {
                var checkWorkersName = workersName.All(char.IsLetter);
                if (string.IsNullOrEmpty(workersName))
                    {
                        throw new ArgumentException("Please add worker's name");
                    }
                else if (!checkWorkersName )
                {
                    throw new ArgumentException("Please add a valid workers name");
                    
                }
                

                try
                {
                    

                    if (string.IsNullOrEmpty(numberOfPieces))
                    {
                        throw new ArgumentException("Please add the number of pieces");
                    }

                    try
                    {
                        var checknumberOfPieces = Convert.ToInt32(numberOfPieces);
                        if (checknumberOfPieces <= 0)
                        {
                            throw new ArgumentException("Please enter a valid number of pieces");
                        }
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
                    Console.WriteLine(e);
                    throw;
                }
                    
               // }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Invalid Data");
                return false;
            }

            return true;
        }

        private void buttonclearAll_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to clear all", "Confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                totalSalaries = new List<WorkersSalary>();
                buttonSummary.Enabled = false;
                textBoxNumberOfPieces.Text = "";
                textBoxWorkersName.Text = "";
                labelvalue.Text = "$ 0.00";
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
            
        }

        //private summaryForm summaryForm = null;
        private void buttonSummary_Click(object sender, EventArgs e)
        {
           
            

                (new summaryForm(totalSalaries)).Show();

         

            //summaryForm summaryForm = new summaryForm();
            //this.Hide();
        }

        

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonPayform_Click(object sender, EventArgs e)
        {
            (new PayForm_class()).Show();
        }

        private void textBoxWorkersName_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class WorkersSalary
    {
        //public int workerId { get; set; }
        public double salary { get; set; }
        public int piecesCompleted { get; set; }
        public string name { get; set; }

    }
    
}
