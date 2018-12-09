using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clearwater;
using TampaBay;

namespace Piecework
{
    public partial class summaryForm : Form
    {
        private string classType = string.Empty;
        List<WorkersSalary> TotalSalaries = new List<WorkersSalary>();
        List<PieceworkPay> TotalSalaries_payForm = new List<PieceworkPay>();

        public summaryForm(List<WorkersSalary> totalSalaries)
        {
            InitializeComponent();
            TotalSalaries = totalSalaries;
            classType = typeof(PayForm).ToString();
            
        }

        public summaryForm(List<PieceworkPay> totalSalaries)
        {
            InitializeComponent();
            TotalSalaries_payForm = totalSalaries;
            classType = typeof(PayForm_class).ToString();
        
        }
     

        private void summaryForm_Load(object sender, EventArgs e)
        {
            if (classType == typeof(PayForm).ToString())
            {
                labeltotalPieces.Text = TotalSalaries.Sum(x => x.piecesCompleted).ToString();
                labelTotalPay.Text = TotalSalaries.Sum(x => x.salary).ToString("0.00");
                labelAveragePay.Text = (TotalSalaries.Sum(x => x.salary) / TotalSalaries.Count).ToString("0.00");
            }
            else if (classType == typeof(PayForm_class).ToString())
            {
                labeltotalPieces.Text = TotalSalaries_payForm.Sum(x => x.Pieces).ToString();
                labelTotalPay.Text = TotalSalaries_payForm.Sum(x =>
                {
                    if (x.GetType() == typeof(SeniorPay))
                    {
                        return ((SeniorPay) x).CalculatePay();
                    }
                    return x.CalculatePay();
                }).ToString("0.00");
                labelAveragePay.Text = (TotalSalaries_payForm.Sum(x => {
                    if (x.GetType() == typeof(SeniorPay))
                    {
                        return ((SeniorPay)x).CalculatePay();
                    }
                    return x.CalculatePay();
                }) / TotalSalaries_payForm.Count).ToString("0.00");
            }
        }
    }
}
