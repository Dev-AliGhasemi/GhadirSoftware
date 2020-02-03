using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Bunifu.Framework.UI;

namespace Ghadir
{
    public partial class SectionSarmaye : UserControl
    {
        public SectionSarmaye()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlCommand comForTableInstallment = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        BunifuFlatButton btnSet;
        List<long> code = new List<long>();
        long PricePerShare;
        int i;
        private void btnPayGrouply_Click(object sender, EventArgs e)
        {
            GroupPayForm groupPayFrom = new GroupPayForm();
            groupPayFrom.ShowDialog();
        }

        private void SectionSarmaye_Load(object sender, EventArgs e)
        {
            string[] date = ClassCurrentDate.currentDate.Split('/');
            txtYear.Text = date[0];
            txtMonth.Text = date[1];
            txtDay.Text = date[2];
            com.Connection = con;
            com.CommandText = "select * from tbl_fund";
            Adapter.SelectCommand = com;
            Adapter.Fill(dataTable);
            con.Open();
            com.CommandText = "select Code from tbl_fund";
            dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                code.Add(long.Parse(dataReader[0].ToString()));
            }
            dataReader.Close();
            com.CommandText = "select Fname+' '+Lname from tbl_fund";
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Activecolor = Color.FromArgb(70, 79, 134);
                btn.BackColor = Color.FromArgb(70, 79, 134);
                btn.BorderRadius = 5;
                btn.Normalcolor = Color.FromArgb(70, 79, 134);
                btn.OnHovercolor = Color.FromArgb(108, 119, 179);
                btn.OnHoverTextColor = Color.White;
                btn.TextFont = new Font("B Roya", 10.5f, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Width = 162;
                btn.Height = 45;
                btn.Iconcolor = Color.Transparent;
                btn.Iconimage = null;
                btn.Text = dataReader[0].ToString() + " " + code[i];
                flowUsers.Controls.Add(btn);
                btn.Click += btn_Click;
                i++;
            }
            con.Close();
        }
        private void btn_Click(object sender , EventArgs e)
        {
            try
            {
                btnSet = (BunifuFlatButton)sender;
                flowUsers.Enabled = false;
                com.CommandText = "select PricePerShare from tbl_setting";
                con.Open();
                PricePerShare = int.Parse(com.ExecuteScalar().ToString());
                con.Close();
                for (i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (dataTable.Rows[i][0].ToString() == btnSet.Text.Substring(btnSet.Text.IndexOf(" ") + 1, btnSet.Text.Length - (btnSet.Text.IndexOf(" ") + 1)))
                    {
                        break;
                    }
                }
                txtCode.Text = dataTable.Rows[i][0].ToString();
                txtName.Text = dataTable.Rows[i][1].ToString() + " " + dataTable.Rows[i][2].ToString();
                txtNumberSahm.Text = dataTable.Rows[i][3].ToString();
                txtTotalSarmaye.Text = dataTable.Rows[i][4].ToString();
                txtPayMonthly.Text = (long.Parse(dataTable.Rows[i][3].ToString()) * PricePerShare).ToString();
                txtLastDatePay.Text = dataTable.Rows[i][6].ToString();
                string date120 = dataTable.Rows[i][7].ToString();
                txtPrevious.Text = dataTable.Rows[i][7].ToString();
                string[] date = ClassCurrentDate.currentDate.Split('/');
                txtYear.Text = date[0];
                txtMonth.Text = date[1];
                txtDay.Text = date[2];
                string[] datePrevious = txtLastDatePay.Text.Split('/');
                //برای محاسبه عقب مانده
                if (int.Parse(date[0]) == int.Parse(datePrevious[0]))
                {
                    //شرط بالا برای سال جاری 
                if (int.Parse(date[1]) > int.Parse(datePrevious[1]))
                 {
                    if (int.Parse(date[2]) > int.Parse(datePrevious[2]))
                    {
                        txtPrevious.Text = ((int.Parse(date[1])) - (int.Parse(datePrevious[1]))).ToString();
                        txtPrevious.Text = (int.Parse(txtPrevious.Text) + int.Parse(dataTable.Rows[i][7].ToString())).ToString();
                    }
                    else
                    {
                        txtPrevious.Text = (((int.Parse(date[1])) - (int.Parse(datePrevious[1])))-1).ToString();
                        txtPrevious.Text = (int.Parse(txtPrevious.Text) + int.Parse(dataTable.Rows[i][7].ToString())).ToString();
                        }
                    }
                }
                //برای سال بعد
                if (int.Parse(date[0]) > int.Parse(datePrevious[0]))
                {
                    if ((int.Parse(date[2]) > int.Parse(datePrevious[2])))
                    {
                        txtPrevious.Text = (int.Parse(date[1]) + (((int.Parse(date[0])-int.Parse(datePrevious[0]))*12) - int.Parse(datePrevious[1]))).ToString();
                        txtPrevious.Text = (int.Parse(txtPrevious.Text) + int.Parse(dataTable.Rows[i][7].ToString())).ToString();
                    }
                    else
                    {
                        txtPrevious.Text = ((((int.Parse(date[0]) - int.Parse(datePrevious[0])) * 12) - int.Parse(datePrevious[1])) + (int.Parse(date[1])-1)).ToString();
                        txtPrevious.Text = (int.Parse(txtPrevious.Text) + int.Parse(dataTable.Rows[i][7].ToString())).ToString();

                    }
                }
                if (int.Parse(txtPrevious.Text)<0)
                {
                    txtPrevious.Text = "0";
                }
                flowUsers.Enabled = true;
                btnPayMonthly.Enabled = true;
            }
            catch
            {
                MessageBox.Show(".خطا در آوردن اطلاعات لطفا دکمه تازه سازی را بزنیدیا یکبار برنامه رو راه اندازی مجدد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            if (txtDay.TextLength == 2)
            {
                txtMonth.Focus();
            }
        }
        private void txtMonth_TextChanged(object sender, EventArgs e)
        {
            if (txtMonth.TextLength == 2)
            {
                txtYear.Focus();
            }
        }

        private void btnPayMonthly_Click(object sender, EventArgs e)
        {
            if (txtYear.TextLength == 0 || txtMonth.TextLength == 0 || txtDay.TextLength == 0)
            {
                MessageBox.Show(".بعضی از فیلد ها پر نشده است", "!!هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtYear.TextLength != 4)
            {
                MessageBox.Show(".لطفا فیلد های تاریخ را درست وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("آیا از این پرداخت اطمینان دارید؟", "!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    txtTotalSarmaye.Text = (long.Parse(txtPayMonthly.Text) + long.Parse(txtTotalSarmaye.Text)).ToString();
                    txtLastDatePay.Text = txtYear.Text + "/" + txtMonth.Text + "/" + txtDay.Text;
                    txtPrevious.Text = (int.Parse(txtPrevious.Text) - 1).ToString();
                    if (int.Parse(txtPrevious.Text) < 0)
                    {
                        txtPrevious.Text = "0";
                    }
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@PayMonthly", txtPayMonthly.Text);
                    com.Parameters.AddWithValue("@TotalFund", txtTotalSarmaye.Text);
                    com.Parameters.AddWithValue("@DateLastPay", txtLastDatePay.Text);
                    com.Parameters.AddWithValue("@Previous", txtPrevious.Text);
                    com.CommandText = "update tbl_fund set TotalFund = @TotalFund , PayMonthly = @PayMonthly , DateLastPay = @DateLastPay , Previous = @Previous where Code=" + code[i];
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    com.CommandText = "select * from tbl_fund";
                    Adapter.SelectCommand = com;
                    dataTable.Clear();
                    Adapter.Fill(dataTable);
                    MessageBox.Show(".اطلاعات با موفقیت وارد شدند", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            flowUsers.Enabled = false;
            flowUsers.Controls.Clear();
            dataTable.Clear();
            code.Clear();
            com.CommandText = "select PricePerShare from tbl_setting";
            con.Open();
            PricePerShare = int.Parse(com.ExecuteScalar().ToString());
            com.CommandText = "select * from tbl_fund";
            Adapter.SelectCommand = com;
            Adapter.Fill(dataTable);
            com.CommandText = "select Code from tbl_fund";
            dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                code.Add(long.Parse(dataReader[0].ToString()));
            }
            dataReader.Close();
            com.CommandText = "select Fname+' '+Lname from tbl_fund";
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                BunifuFlatButton btn = new BunifuFlatButton();
                btn.Activecolor = Color.FromArgb(70, 79, 134);
                btn.BackColor = Color.FromArgb(70, 79, 134);
                btn.BorderRadius = 5;
                btn.Normalcolor = Color.FromArgb(70, 79, 134);
                btn.OnHovercolor = Color.FromArgb(108, 119, 179);
                btn.OnHoverTextColor = Color.White;
                btn.TextFont = new Font("B Roya", 10.5f, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Width = 162;
                btn.Height = 45;
                btn.Iconcolor = Color.Transparent;
                btn.Iconimage = null;
                btn.Text = dataReader[0].ToString() + " " + code[i];
                flowUsers.Controls.Add(btn);
                btn.Click += btn_Click;
                i++;
            }
            con.Close();
            txtName.Clear();
            txtTotalSarmaye.Clear();
            txtNumberSahm.Clear();
            txtPayMonthly.Clear();
            txtLastDatePay.Clear();
            txtPrevious.Clear();
            txtCode.Clear();
            btnPayMonthly.Enabled = false;
            btnRefresh.Enabled = true;
            flowUsers.Enabled = true;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
                if (rdoName.Checked)
                {
                    foreach (BunifuFlatButton targetButton in flowUsers.Controls)
                    {
                        if (targetButton.Text.IndexOf(txtSearch.Text) >= 0)
                        {
                            flowUsers.ScrollControlIntoView(targetButton);
                        }
                    }
                }
            else
            {
                foreach (BunifuFlatButton targetButton in flowUsers.Controls)
                {
                    if (targetButton.Text.IndexOf(txtSearch.Text) >= 0)
                    {
                        flowUsers.ScrollControlIntoView(targetButton);
                    }
                }
            }
        }
        private void picSetting_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelSearch.Visible)
            {
                panelSearch.Visible = false;
            }
            else
            {
                animatorPanelSearchFund.ShowSync(panelSearch);
                panelSearch.Visible = true;
            }           
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoName.Checked == true)
            {
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Right && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Space)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
                {
                    e.Handled = true;
                }
            }
        }
        private void rdoName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
