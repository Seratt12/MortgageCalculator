using System.Diagnostics;
using System.Numerics;

namespace Mortgage_calculator
{
    public partial class FormMain : Form
    {
        bool isTrue = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Int_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // ����� � ������� BackSpace
            {
                e.Handled = true;
            }
        }

        private void Float_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46) //�����, ������� BackSpace � ������� � ASCII
            {
                e.Handled = true;
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            UInt64 fullPrice;
            var err = UInt64.TryParse(FullPriceInput.Text.ToString(), out fullPrice);
            if (!err)
            {
                MessageBox.Show("������!");
                Close();
            }

            Double procent;
            err = Double.TryParse(ProcentInput.Text.ToString(), out procent);
            if (!err)
            {
                MessageBox.Show("������!");
                Close();
            }

            UInt32 period;
            err = UInt32.TryParse(PeriodInputBox.Text.ToString(), out period);
            if (!err)
            {
                MessageBox.Show("������!");
                Close();
            }

            UInt64 initialPayment = 0;
            if (isTrue)
            {
                err = UInt64.TryParse(InitialPaymentInput.Text.ToString(), out initialPayment);
                if (!err)
                {
                    MessageBox.Show("������!");
                    Close();
                }
            }

            if (initialPayment >= fullPrice)
            {
                MessageBox.Show("������! �������������� ����� �� ����� ���� ����� ��� ������ ����� �������");
                Close();
            }

            fullPrice -= initialPayment; // �������� �������������� �����
            period *= 12; // � �����

            Double monthlyRate = procent / 12.0 / 100.0;
            Double generalRate = Math.Pow((1 + monthlyRate), period);

            if (!radioButton1.Checked)
            {
                Double MonthlyPaymentOfDebt = Math.Round(fullPrice / (period * 1.0));
                Double AllProcent = Math.Round(fullPrice * monthlyRate);

                Result.Text = "����������� ����� ��������: " + (MonthlyPaymentOfDebt + AllProcent) + "������";
                Result.Text += $"\n��������� �����: {MonthlyPaymentOfDebt} ������\n���������� �����: {AllProcent} ������";
            }
            else
            {
                Double monthlyPayment = Math.Round(fullPrice * monthlyRate * generalRate / (generalRate - 1));
                Result.Text = "����������� ����� ��������: " + monthlyPayment.ToString() + "������ ";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                isTrue = true;
                label4.Visible = true;
                InitialPaymentInput.Visible = true;
                label8.Visible = true;
            }
            else
            {
                isTrue = false;
                label4.Visible = false;
                InitialPaymentInput.Visible = false;
                label8.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}