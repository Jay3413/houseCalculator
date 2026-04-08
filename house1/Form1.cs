using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace house1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbDownPaymentMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update unit label depending on mode
            if (cmbDownPaymentMode.SelectedIndex == 0)
            {
                lblDownPaymentUnit.Text = "(%)";
                txtDownPayment.Text = "20";
            }
            else
            {
                lblDownPaymentUnit.Text = "(金額)";
                txtDownPayment.Text = "2000000";
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse inputs with basic validation
            if (!double.TryParse(txtTotalPrice.Text, out double totalPrice))
            {
                MessageBox.Show("請輸入有效的房屋總價。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double downPaymentAmount = 0.0;
            if (cmbDownPaymentMode.SelectedIndex == 0)
            {
                // percent
                if (!double.TryParse(txtDownPayment.Text, out double downPct))
                {
                    MessageBox.Show("請輸入有效的自備款百分比。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                downPaymentAmount = totalPrice * (downPct / 100.0);
            }
            else
            {
                if (!double.TryParse(txtDownPayment.Text, out downPaymentAmount))
                {
                    MessageBox.Show("請輸入有效的自備款金額。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!double.TryParse(txtInterestRate.Text, out double annualRatePct))
            {
                MessageBox.Show("請輸入有效的年利率。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int loanYears = (int)numLoanTerm.Value;
            int graceYears = (int)numGracePeriod.Value;
            int graceMonths = graceYears * 12;

            double principal = totalPrice - downPaymentAmount;
            if (principal <= 0)
            {
                MessageBox.Show("自備款已覆蓋全部價格，無需貸款。", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double monthlyRate = (annualRatePct / 100.0) / 12.0;
            int totalMonths = loanYears * 12;

            var sb = new StringBuilder();

            // Only display the requested formatted results
            sb.AppendLine($"貸款總金額: {principal:N2}");


            // Amortized monthly payment after grace period (or from start if no grace)
            int amortMonths = totalMonths - (graceYears * 12);
            if (amortMonths <= 0)
            {
                sb.AppendLine("寬限期等於或超過貸款年限，無本金攤還。請調整參數。");
                txtResult.Text = sb.ToString();
                return;
            }

            double monthlyPayment = 0.0;
            if (monthlyRate == 0)
            {
                monthlyPayment = principal / amortMonths;
            }
            else
            {
                double r = monthlyRate;
                double numerator = principal * r * Math.Pow(1 + r, amortMonths);
                double denominator = Math.Pow(1 + r, amortMonths) - 1;
                monthlyPayment = numerator / denominator;
            }
            sb.AppendLine($"每月應繳金額(本+息): {monthlyPayment:N2}");

            // 首期利息與首期本金 (for first amortized payment)
            double firstInterest = 0.0;
            double firstPrincipal = 0.0;
            if (monthlyRate == 0)
            {
                firstInterest = 0.0;
                firstPrincipal = principal / amortMonths;
            }
            else
            {
                firstInterest = principal * monthlyRate;
                firstPrincipal = monthlyPayment - firstInterest;
            }

            // 若有寬限期，計算寬限期間的利息支出（僅利息）
            double interestDuringGrace = 0.0;
            if (graceMonths > 0)
            {
                interestDuringGrace = principal * monthlyRate * graceMonths;
            }

            // 總利息 = 寬限期利息 + 攤還期內之利息
            double interestDuringAmort = (monthlyPayment * amortMonths) - principal;
            double totalInterest = interestDuringGrace + interestDuringAmort;
            double totalRepayment = principal + totalInterest; // total paid to bank over loan life

            sb.AppendLine($"首期利息: {firstInterest:N2}");
            sb.AppendLine($"首期本金: {firstPrincipal:N2}");
            sb.AppendLine($"總利息支出: {totalInterest:N2}");
            sb.AppendLine($"總還款金額: {totalRepayment:N2}");

            txtResult.Text = sb.ToString();
        }
    }
}
