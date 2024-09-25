using System.Diagnostics;
using System.Numerics;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;

namespace Mortgage_calculator
{
    public partial class FormMain : Form
    {
        DataBase dataBase = new DataBase();


        bool isTrue = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
            dgv.Columns.Add("Стоимость жилья (руб.)", "Стоимость жилья (руб.)");
            dgv.Columns.Add("Ставка (%)", "Ставка (%)");
            dgv.Columns.Add("Срок (лет)", "Срок (лет)");
            dgv.Columns.Add("Первоначальный взнос (руб)", "Первоначальный взнос (руб)");
            dgv.Columns.Add("Вид ипотечных платежей (0 - анн., 1 - диф)", "Вид ипотечных платежей (0 - анн., 1 - диф)");
            dgv.Columns.Add("Ежемесячный платёж (руб.)", "Ежемесячный платёж (руб.)");
            dgv.Columns.Add("Погашение долга (руб.)", "Погашение долга (руб.)");
            dgv.Columns.Add("Процентная часть (руб.)", "Процентная часть (руб.)");
        }


        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string queryString = $"select * from calculate";

            dataBase.OpenConnection();

            SQLiteCommand command = new SQLiteCommand(queryString, dataBase.getConnection());

            SQLiteDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var fullPrice = reader.GetValue(0);
                    var Procent = reader.GetValue(1);
                    var Period = reader.GetValue(2);
                    var InitialPayment = reader.GetValue(3);
                    var TypeOfPayment = reader.GetValue(4);
                    var MonthlyPayment = reader.GetValue(5);
                    var DebtRepayment = reader.GetValue(6);
                    var PercentagePart = reader.GetValue(7);
                    var id = reader.GetValue(8);

                    dgv.Rows.Add(fullPrice, Procent, Period, InitialPayment, TypeOfPayment, MonthlyPayment, DebtRepayment, PercentagePart);
                }
            }
            reader.Close();
        }

        private void MainForm_load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dgv);
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
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void Float_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 46) //цифры, клавиша BackSpace и запятая а ASCII
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
                MessageBox.Show("Ошибка!");
                Close();
            }

            Double procent;
            err = Double.TryParse(ProcentInput.Text.ToString(), out procent);
            if (!err)
            {
                MessageBox.Show("Ошибка!");
                Close();
            }

            UInt32 period;
            err = UInt32.TryParse(PeriodInputBox.Text.ToString(), out period);
            if (!err)
            {
                MessageBox.Show("Ошибка!");
                Close();
            }

            UInt64 initialPayment = 0;
            if (isTrue)
            {
                err = UInt64.TryParse(InitialPaymentInput.Text.ToString(), out initialPayment);
                if (!err)
                {
                    MessageBox.Show("Ошибка!");
                    Close();
                }
            }

            if (initialPayment >= fullPrice)
            {
                MessageBox.Show("Ошибка! Первоначальный взнос не может быть равен или больше суммы ипотеки");
                Close();
            }

            fullPrice -= initialPayment; // вычитаем первоначальный взнос
            period *= 12; // в месяц

            Double monthlyRate = procent / 12.0 / 100.0;
            Double generalRate = Math.Pow((1 + monthlyRate), period);

            if (!radioButton1.Checked)
            {
                Double MonthlyPaymentOfDebt = Math.Round(fullPrice / (period * 1.0));
                Double AllProcent = Math.Round(fullPrice * monthlyRate);

                Result.Text = "Ежемесячный платёж составит: " + (MonthlyPaymentOfDebt + AllProcent) + "рублей";
                Result.Text += $"\nПогашение долга: {MonthlyPaymentOfDebt} рублей\nПроцентная часть: {AllProcent} рублей";
            }
            else
            {
                Double monthlyPayment = Math.Round(fullPrice * monthlyRate * generalRate / (generalRate - 1));
                Result.Text = "Ежемесячный платёж составит: " + monthlyPayment.ToString() + "рублей ";
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

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FileAboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}