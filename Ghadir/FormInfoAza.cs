using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ghadir
{
    public partial class FormInfoAza : Form
    {
        string code;
        public FormInfoAza(string code)
        {
            InitializeComponent();
            this.code = code;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        DataTable dataTable = new DataTable();
        SqlDataAdapter adpater = new SqlDataAdapter();
        int mouseX, mouseY;
        int payInstallment = 0, payKarmozd, numberOfInstallment;
        bool click = false;
        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void FormInfoAza_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void FormInfoAza_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void FormInfoAza_Load(object sender, EventArgs e)
        {
            try
            {
                com.Connection = con;
                com.CommandText = "select * from tbl_members where Code = '" + code + "'";
                adpater.SelectCommand = com;
                adpater.Fill(dataTable);
                lblCode.Text = dataTable.Rows[0][0].ToString();
                lblFname.Text = dataTable.Rows[0][1].ToString();
                lblLname.Text = dataTable.Rows[0][2].ToString();
                lblFatherName.Text = dataTable.Rows[0][3].ToString();
                lblDateBorn.Text = dataTable.Rows[0][4].ToString();
                lblAccountNumber.Text = dataTable.Rows[0][5].ToString();
                lblNationalCode.Text = dataTable.Rows[0][6].ToString();
                lblPhoneNumber.Text = dataTable.Rows[0][7].ToString();
                lblNumberShare.Text = dataTable.Rows[0][8].ToString();
                lblPrimitiveFund.Text = dataTable.Rows[0][9].ToString();
                dataTable.Clear();
                dataTable.Columns.Clear();
                com.CommandText = "select TotalFund , PayMonthly , DateLastPay , Previous from tbl_fund where Code=" + code;
                adpater.SelectCommand = com;
                adpater.Fill(dataTable);
                string test = dataTable.Rows[0][3].ToString();
                int previous = 0;
                //------------------
                string[] datePrevious = dataTable.Rows[0][2].ToString().Split('/');
                string[] date = ClassCurrentDate.currentDate.Split('/');
                //برای محاسبه عقب مانده
                if (int.Parse(date[0]) == int.Parse(datePrevious[0]))
                {
                    //شرط بالا برای سال جاری 
                    if (int.Parse(date[1]) > int.Parse(datePrevious[1]))
                    {
                        if (int.Parse(date[2]) > int.Parse(datePrevious[2]))
                        {
                            previous = ((int.Parse(date[1])) - (int.Parse(datePrevious[1])));
                            //previous = (previous + (int.Parse(dataTable.Rows[0][3].ToString())));
                        }
                        else
                        {
                            previous = (((int.Parse(date[1])) - (int.Parse(datePrevious[1]))) - 1);
                            //previous = (previous + (int.Parse(dataTable.Rows[0][3].ToString())));
                        }
                    }
                }
                //برای سال بعد
                if (int.Parse(date[0]) > int.Parse(datePrevious[0]))
                {
                    if ((int.Parse(date[2]) > int.Parse(datePrevious[2])))
                    {
                        previous = (int.Parse(date[1]) + (((int.Parse(date[0]) - int.Parse(datePrevious[0])) * 12) - int.Parse(datePrevious[1])));
                        // previous = (previous + (int.Parse(dataTable.Rows[0][3].ToString())));

                    }
                    else
                    {
                        previous = ((((int.Parse(date[0]) - int.Parse(datePrevious[0])) * 12) - int.Parse(datePrevious[1])) + (int.Parse(date[1]) - 1));
                        //  previous = (previous + (int.Parse(dataTable.Rows[0][3].ToString())));

                    }
                }
                //------------------
                lblTotalFund.Text = dataTable.Rows[0][0].ToString();
                lblPayMonthly.Text = dataTable.Rows[0][1].ToString();
                lblLastDatePay.Text = dataTable.Rows[0][2].ToString();
                lblLastMonthly.Text = (int.Parse(dataTable.Rows[0][3].ToString()) + (previous)).ToString();
                com.CommandText = "select count(JoinNumberRecieverLoan) from tbl_loan where JoinNumberRecieverLoan = " + code;
                con.Open();
                lblTotalLoan.Text = com.ExecuteScalar().ToString();
                com.CommandText = "select Loan from tbl_loan where JoinNumberRecieverLoan = " + code;
                dataTable.Clear();
                dataTable.Columns.Clear();
                adpater.SelectCommand = com;
                adpater.Fill(dataTable);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string data = dataTable.Rows[i][0].ToString();
                    com.CommandText = "select NumberNonPayInstallment from tbl_installment where Loan = " + dataTable.Rows[i][0].ToString();
                    numberOfInstallment = int.Parse(com.ExecuteScalar().ToString());
                    com.CommandText = "select PayKarmozd from tbl_installment where Loan = " + dataTable.Rows[i][0].ToString();
                    payKarmozd = int.Parse(com.ExecuteScalar().ToString());
                    if (payKarmozd == 1 && numberOfInstallment == 0)
                    {
                        payInstallment++;
                    }
                }
                lblPayLoan.Text = payInstallment.ToString();
                lblNonPayLoan.Text = ((int.Parse(lblTotalLoan.Text)) - (int.Parse(lblPayLoan.Text))).ToString();
                // lblTotalLoan.Text = com.ExecuteScalar().ToString();
                // com.CommandText  = "select count(JoinNumberRecieverLoan)  "
                con.Close();
            }
            //Fname,Lname,FatherName,DateBorn,AccountNumber,NationalCode PhoneNumber,ShareNumber,PrimitiveFund
            catch (IndexOutOfRangeException)
            {
                this.Close();
                MessageBox.Show(".لطفا روی دکمه تازه سازی کلیک کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormInfoAza_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
