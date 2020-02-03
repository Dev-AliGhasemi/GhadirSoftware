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
    public partial class FormInfoVam : Form
    {
        string codeVam;
        public FormInfoVam(string codeVam)
        {
            InitializeComponent();
            this.codeVam = codeVam;
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        int YEAR, MONTH, DAY;
        bool ISMONTHESFAN = false , ISFIRSTHALF = false , CURRENTYEAR = false;
        bool click = false;
        int mouseX, mouseY;
        private void btnPayMoreInstallment_MouseClick(object sender, MouseEventArgs e)
        {
            long mablagh = long.Parse(lblAmount.Text) - long.Parse(lblNonPay.Text);
            lblNonPay.Text =Math.Abs(mablagh).ToString();
            lblPay.Text = (long.Parse(lblPay.Text) + long.Parse(lblAmount.Text)).ToString();
            lblInstallment.Text = (long.Parse(lblInstallment.Text) + 1).ToString();
            lblNonInstallment.Text = (long.Parse(lblNonInstallment.Text) - 1).ToString();
            if (lblNonInstallment.Text == "0")
            {
                btnPayMoreInstallment.Enabled = false;
            }
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@NumberPayInstallment", lblInstallment.Text);
            com.Parameters.AddWithValue("@NumberNonPayInstallment", lblNonInstallment.Text);
            com.Parameters.AddWithValue("@NumberPayAmount", lblPay.Text);
            com.Parameters.AddWithValue("@NumberNonPayAmount", lblNonPay.Text);
            com.CommandText = "update  tbl_installment set  NumberPayInstallment = @NumberPayInstallment  , NumberNonPayInstallment = @NumberNonPayInstallment , NumberPayAmount = @NumberPayAmount , NumberNonPayAmount = @NumberNonPayAmount  where Loan = " + codeVam;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        private void FormInfoVam_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void FormInfoVam_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
        private void FormInfoVam_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }

        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void FormInfoVam_Load(object sender, EventArgs e)
        {
            try
            {
                lblPayDateNow.Text = ClassCurrentDate.currentDate;
                com.Connection = con;
                com.CommandText = "select Loan,RecieverLoan,JoinNumberRecieverLoan,Guarantor,LoanType,Amount,DateStart,DateFinish,PercentKarmozd,DateBack  from tbl_loan where Loan =" + codeVam;
                Adapter.SelectCommand = com;
                Adapter.Fill(dataTable);
                lblNumberVam.Text = dataTable.Rows[0][0].ToString();
                lblNumberVam2.Text = dataTable.Rows[0][0].ToString();
                lblRecieverVam.Text = dataTable.Rows[0][1].ToString();
                lblCode.Text = dataTable.Rows[0][2].ToString();
                lblCode2.Text = dataTable.Rows[0][2].ToString();
                lblZamen.Text = dataTable.Rows[0][3].ToString();
                lblTypeVam.Text = dataTable.Rows[0][4].ToString();
                lblMablagh.Text = dataTable.Rows[0][5].ToString();
                lblStartDate.Text = dataTable.Rows[0][6].ToString();
                lblFinishDate.Text = dataTable.Rows[0][7].ToString();
                lblPercentKarmozd.Text = dataTable.Rows[0][8].ToString();
                lblDateBack.Text = dataTable.Rows[0][9].ToString();
                com.CommandText = "select  NumberOfInstallment , AmountPerInstallment , NumberPayInstallment , NumberNonPayInstallment , NumberPayAmount , NumberNonPayAmount , DateLastPay , DateNextPay , PayKarmozd from tbl_installment where Loan =" + codeVam;
                Adapter.SelectCommand = com;
                dataTable.Clear();
                dataTable.Columns.Clear();
                Adapter.Fill(dataTable);
                lblNumberInstallment.Text = dataTable.Rows[0][0].ToString();
                lblAmountPerInstallment.Text = dataTable.Rows[0][1].ToString();
                lblAmount.Text = dataTable.Rows[0][1].ToString();
                lblInstallment.Text = dataTable.Rows[0][2].ToString();
                lblNonInstallment.Text = dataTable.Rows[0][3].ToString();
                lblPay.Text = dataTable.Rows[0][4].ToString();
                lblNonPay.Text = dataTable.Rows[0][5].ToString();
                lblDateLastPay.Text = dataTable.Rows[0][6].ToString();
                lblDateNextPay.Text = dataTable.Rows[0][7].ToString();
                string isHaveKarmozd = dataTable.Rows[0][8].ToString();
                if (lblPercentKarmozd.Text != "0" && isHaveKarmozd == "0")
                {
                    btnPayKarmozd.Enabled = true;
                    lblAmountKarmozd.Text = ((long.Parse(lblMablagh.Text) * long.Parse(lblPercentKarmozd.Text)) / 100).ToString();
                }
                else
                {
                    lblAmountKarmozd.Text = "0";
                }

                if (lblNonPay.Text == "0")
                {
                    btnPayInstallment.Enabled = false;
                }
                if (lblDateLastPay.Text == lblFinishDate.Text)
                {
                    btnPayInstallment.Enabled = false;
                    lblDateNextPay.Text = "-";
                    if (int.Parse(lblNumberInstallment.Text) > int.Parse(lblDateBack.Text) && lblNonInstallment.Text != "0")
                    {
                        btnPayMoreInstallment.Enabled = true;
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {
                this.Close();
                MessageBox.Show(".لطفا روی دکمه تازه سازی کلیک کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPayKarmozd_MouseClick(object sender, MouseEventArgs e)
        {
            long mablagh =long.Parse(lblNonPay.Text) - long.Parse(lblAmountKarmozd.Text);
            lblNonPay.Text = mablagh.ToString();
            lblPay.Text  = (long.Parse(lblPay.Text) + long.Parse(lblAmountKarmozd.Text)).ToString();
            lblAmountKarmozd.Text = "0";
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@NumberPayAmount", lblPay.Text);
            com.Parameters.AddWithValue("@NumberNonPayAmount", lblNonPay.Text);
            com.CommandText = "update tbl_installment set  NumberPayAmount =@NumberPayAmount , NumberNonPayAmount = @NumberNonPayAmount , PayKarmozd = 1 where Loan = " + codeVam;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            btnPayKarmozd.Enabled = false;
        }

        private void btnPayInstallment_MouseClick(object sender, MouseEventArgs e)
        {
            if (lblNonPay.Text != "0")
            {
                long mablagh = long.Parse(lblNonPay.Text) - long.Parse(lblAmountPerInstallment.Text);
                //if (mablagh < 0)
                //{
                //    mablagh = 0;
                //}
                lblNonPay.Text = mablagh.ToString();
                lblPay.Text = (long.Parse(lblPay.Text)+long.Parse(lblAmountPerInstallment.Text)).ToString();
                lblInstallment.Text = (int.Parse(lblInstallment.Text) + 1).ToString();
                lblNonInstallment.Text = (int.Parse(lblNonInstallment.Text) - 1).ToString();
                lblDateLastPay.Text = lblDateNextPay.Text;

                string dateNext = lblDateNextPay.Text;

                YEAR = int.Parse(dateNext.Substring(0, dateNext.IndexOf("/")));
                MONTH = int.Parse(dateNext.Substring(dateNext.IndexOf("/") + 1, (dateNext.LastIndexOf("/") - dateNext.IndexOf("/")) - 1));
                DAY = int.Parse(dateNext.Substring(dateNext.LastIndexOf("/") + 1, (dateNext.Length) - (dateNext.LastIndexOf("/") + 1)));
                //برای اسفند ماه
                if ((MONTH + 1) == 12 && (DAY == 30))
                {
                    YEAR += 1;
                    DAY = 1;
                    MONTH = 1;
                    ISMONTHESFAN = true;
                }
                if ((MONTH + 1) > 12)
                {
                    YEAR += 1;
                    MONTH = 1;
                    ISMONTHESFAN = true;
                }
                //برای نیمه اول سال کنونی
                if (MONTH + 1 <= 6 && MONTH + 1 >= 1 && ISMONTHESFAN == false && ISFIRSTHALF == false)
                {
                    ISFIRSTHALF = true;
                    MONTH += 1;
                }
                //برای نیمه دوم سال کنونی
                if (MONTH + 1 > 6 && MONTH + 1 < 13 && ISFIRSTHALF == false && ISMONTHESFAN == false)
                {
                    if (DAY == 31)
                    {
                        DAY = 1;
                        MONTH += 2;
                    }
                    else
                    {
                        MONTH += 1;
                    }
                    CURRENTYEAR = true;
                }

                if (MONTH > 12 && ISMONTHESFAN == false && CURRENTYEAR == false)
                {
                    YEAR += 1;
                    //برای نیمه دوم سال بعد
                    if (DAY == 31 && MONTH + 1 > 6)
                    {
                        DAY = 1;
                        MONTH += 1;
                    }
                    else
                    {
                        //DAY = int.Parse(txtDay.Text);
                        MONTH += 1;
                    }
                }
                lblDateNextPay.Text = YEAR + "/" + MONTH + "/" + DAY;
                ISMONTHESFAN = false;
                CURRENTYEAR = false;
                ISFIRSTHALF = false;
                if (lblNonInstallment.Text == "0")
                {
                    btnPayInstallment.Enabled = false;
                    lblDateNextPay.Text = "-";
                    if (int.Parse(lblInstallment.Text)>int.Parse(lblDateBack.Text))
                    {
                        btnPayMoreInstallment.Enabled = true;
                    }
                }
                if (lblInstallment.Text == lblDateBack.Text)
                {
                    btnPayInstallment.Enabled = false;
                    lblDateNextPay.Text = "-";
                    if (int.Parse(lblNumberInstallment.Text)>int.Parse(lblDateBack.Text))
                    {
                        btnPayMoreInstallment.Enabled = true;
                    }
                }
            }
            com.Parameters.Clear();
            com.Parameters.AddWithValue("@NumberPayInstallment", lblInstallment.Text);
            com.Parameters.AddWithValue("@NumberNonPayInstallment", lblNonInstallment.Text);
            com.Parameters.AddWithValue("@NumberPayAmount", lblPay.Text);
            com.Parameters.AddWithValue("@NumberNonPayAmount", lblNonPay.Text);
            com.Parameters.AddWithValue("@DateLastPay", lblDateLastPay.Text);
            com.Parameters.AddWithValue("@DateNextPay",lblDateNextPay.Text);
            com.CommandText = "update  tbl_installment set  NumberPayInstallment = @NumberPayInstallment  , NumberNonPayInstallment = @NumberNonPayInstallment , NumberPayAmount = @NumberPayAmount , NumberNonPayAmount = @NumberNonPayAmount , DateLastPay = @DateLastPay , DateNextPay = @DateNextPay where Loan = "+codeVam;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
