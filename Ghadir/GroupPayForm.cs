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
    public partial class GroupPayForm : Form
    {
        public GroupPayForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        List<string> codeFund = new List<string>();
        bool click = false;
        int PricePerShare;
        int mouseX, mouseY;
        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void GroupPayForm_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select * from tbl_fund";
            adapter.SelectCommand = com;
            adapter.Fill(dataTable);
            com.CommandText = "select PricePerShare from tbl_setting";
            con.Open();
            PricePerShare = int.Parse(com.ExecuteScalar().ToString());
            con.Close();

            for (int i = 0; i < dataTable.Rows.Count ; i++)
            {
                cboMemberName.Items.Add(dataTable.Rows[i][1] + " " + dataTable.Rows[i][2] + "    " + dataTable.Rows[i][0]);
                codeFund.Add(dataTable.Rows[i][0].ToString());
            }     
            if (cboMemberName.Items.Count != 0 )
            {
                cboMemberName.SelectedIndex = 0;
            }
        }

        private void cboMemberName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCode.Text = cboMemberName.Text.Substring(cboMemberName.Text.IndexOf("    ") + 4, cboMemberName.Text.Length - (cboMemberName.Text.IndexOf("    ") + 4));
        }
        private void btnSearch_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCode.TextLength == 4)
            {
                cboMemberName.SelectedIndex = codeFund.IndexOf(txtCode.Text);
            }
        }

        private void btnAddToList_MouseClick(object sender, MouseEventArgs e)
        {
            if (cboMemberName.Text != "")
            {
                if (listMembers.Items.IndexOf(cboMemberName.Text) < 0)
                {
                    listMembers.Items.Add(cboMemberName.Text);
                }
            }
        }
        private void btnPay_MouseClick(object sender, MouseEventArgs e)
        {
            if (listMembers.Items.Count == 0)
            {
                MessageBox.Show(".لطفا افراد مورد نظر را وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("آیا از این پرداخت اطمینان دارید؟", "!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    for (int i = 0; i < listMembers.Items.Count; i++)
                    {
                        string code = (listMembers.Items[i].ToString().Substring(listMembers.Items[i].ToString().IndexOf("    ") + 4, listMembers.Items[i].ToString().Length - (listMembers.Items[i].ToString().IndexOf("    ") + 4)));
                        int previous = 0;
                        //----------------------
                        string[] datePrevious = dataTable.Rows[codeFund.IndexOf(code)][6].ToString().Split('/');
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
                                    previous = (previous + int.Parse(dataTable.Rows[codeFund.IndexOf(code)][7].ToString()));
                                }
                                else
                                {
                                    previous = (((int.Parse(date[1])) - (int.Parse(datePrevious[1]))) - 1);
                                    previous = (previous + int.Parse(dataTable.Rows[codeFund.IndexOf(code)][7].ToString()));
                                }
                            }
                        }
                        //برای سال بعد
                        if (int.Parse(date[0]) > int.Parse(datePrevious[0]))
                        {
                            if ((int.Parse(date[2]) > int.Parse(datePrevious[2])))
                            {
                                previous = (int.Parse(date[1]) + (12 - int.Parse(datePrevious[1])));
                                previous = (previous + int.Parse(dataTable.Rows[codeFund.IndexOf(code)][7].ToString()));

                            }
                            else
                            {
                                previous = ((12 - int.Parse(datePrevious[1])) + (int.Parse(date[1]) - 1));
                                previous = (previous + int.Parse(dataTable.Rows[codeFund.IndexOf(code)][7].ToString()));

                            }
                        }
                        //----------------------
                        long numberOfShare = long.Parse(dataTable.Rows[codeFund.IndexOf(code)][3].ToString());
                        long payMonthly = PricePerShare * numberOfShare;
                        long totalFund = payMonthly + long.Parse(dataTable.Rows[codeFund.IndexOf(code)][4].ToString());
                        previous--;
                        if (previous < 0)
                        {
                            previous = 0;
                        }
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@PayMonthly", payMonthly);
                        com.Parameters.AddWithValue("@TotalFund", totalFund);
                        com.Parameters.AddWithValue("@DateLastPay", ClassCurrentDate.currentDate);
                        com.Parameters.AddWithValue("@Previous", previous);
                        com.CommandText = "update tbl_fund set TotalFund = @TotalFund , PayMonthly = @PayMonthly , DateLastPay = @DateLastPay , Previous = @Previous where Code=" + code;
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show(".اطلاعات با موفقیت وارد شدند", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
    }
}
