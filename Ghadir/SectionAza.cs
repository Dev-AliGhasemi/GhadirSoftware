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

namespace Ghadir
{
    public partial class SectionAza : UserControl
    {
        public SectionAza()
        {
            InitializeComponent();
        }
        CreateForm frmCreate;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        SqlDataReader dataReader;
        bool minimize = false;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreate = new CreateForm(true,0);
            frmCreate.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmCreate = new CreateForm(false,int.Parse(dataGridAza.Rows[dataGridAza.CurrentCell.RowIndex].Cells[1].Value.ToString()));
            frmCreate.ShowDialog();
        }

        private void SectionAza_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            dataTable.Columns.Add("شناسه");
            dataTable.Columns.Add("Code");
            dataTable.Columns.Add("Fname");
            dataTable.Columns.Add("Lname");
            dataTable.Columns.Add("FatherName");
            dataTable.Columns.Add("تاریخ تولد");
            dataTable.Columns.Add("شماره حساب");
            dataTable.Columns.Add("کد ملی");
            dataTable.Columns.Add("Phone");
            dataTable.Columns.Add("تعداد سهم");
            dataTable.Columns.Add("سرمایه اولیه");
            com.CommandText = "select * from tbl_members";
            con.Open();
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                dataTable.Rows.Add();
                dataTable.Rows[i][0] = i + 1;
                dataTable.Rows[i][1] = dataReader[0];
                dataTable.Rows[i][2] = dataReader[1];
                dataTable.Rows[i][3] = dataReader[2];
                dataTable.Rows[i][4] = dataReader[3];
                dataTable.Rows[i][5] = dataReader[4];
                dataTable.Rows[i][6] = dataReader[5];
                dataTable.Rows[i][7] = dataReader[6];
                dataTable.Rows[i][8] = dataReader[7];
                dataTable.Rows[i][9] = dataReader[8];
                dataTable.Rows[i][10] = dataReader[9];
                i++;
            }
            dataReader.Close();
            dataGridAza.DataSource = dataTable;
            dataGridAza.Columns[1].HeaderText = "شماره عضویت";
            dataGridAza.Columns[2].HeaderText = "نام";
            dataGridAza.Columns[3].HeaderText = "نام خانوادگی";
            dataGridAza.Columns[4].HeaderText = "نام پدر";
            dataGridAza.Columns[8].HeaderText = "تلفن";
            //for disable sort of datagrid View
            foreach (DataGridViewColumn column in dataGridAza.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (dataGridAza.RowCount !=0)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                com.CommandText = "dbcc checkident (tbl_members , reseed , 1000)";
                com.ExecuteNonQuery();
                com.CommandText = "dbcc checkident (tbl_fund , reseed , 1000)";
                com.ExecuteNonQuery();
            }
            con.Close();
            if (dataGridAza.Rows.Count != 0)
            {
                dataGridAza.Rows[0].Selected = false;
                dataGridAza.Rows[dataGridAza.Rows.Count-1].Selected = true;
                btnRefresh_Click(null, null);
            }
        }

        private void dataGridAza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormInfoAza frm = new FormInfoAza(dataGridAza[1, dataGridAza.CurrentCell.RowIndex].Value.ToString());
                frm.ShowDialog();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(".لطفا دقیق انتخاب کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از پاک کردن این عضو اطمینان دارید؟","!!هشدار",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                com.CommandText = "delete from tbl_members where Code =" + dataGridAza[1, dataGridAza.CurrentCell.RowIndex].Value;
                con.Open();
                com.ExecuteNonQuery();
                com.CommandText   = "delete from tbl_fund where Code=" + dataGridAza[1, dataGridAza.CurrentCell.RowIndex].Value;
                com.ExecuteNonQuery();
                con.Close();
            }
         
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            dataTable.Clear();
            //dataTable.Columns.Clear();
            com.CommandText = "select * from tbl_members";
            con.Open();
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                dataTable.Rows.Add();
                dataTable.Rows[i][0] = i + 1;
                dataTable.Rows[i][1] = dataReader[0];
                dataTable.Rows[i][2] = dataReader[1];
                dataTable.Rows[i][3] = dataReader[2];
                dataTable.Rows[i][4] = dataReader[3];
                dataTable.Rows[i][5] = dataReader[4];
                dataTable.Rows[i][6] = dataReader[5];
                dataTable.Rows[i][7] = dataReader[6];
                dataTable.Rows[i][8] = dataReader[7];
                dataTable.Rows[i][9] = dataReader[8];
                dataTable.Rows[i][10] = dataReader[9];
                i++;
            }
            dataReader.Close();
            dataGridAza.DataSource = dataTable;
            dataGridAza.Columns[1].HeaderText = "شماره عضویت";
            dataGridAza.Columns[2].HeaderText = "نام";
            dataGridAza.Columns[3].HeaderText = "نام خانوادگی";
            dataGridAza.Columns[4].HeaderText = "نام پدر";
            dataGridAza.Columns[8].HeaderText = "تلفن";
            if (dataGridAza.RowCount != 0)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                com.CommandText = "dbcc checkident (tbl_members , reseed , 1000)";
                com.ExecuteNonQuery();
                com.CommandText = "dbcc checkident (tbl_fund , reseed , 1000)";
                com.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            con.Close();
            if (dataGridAza.Rows.Count != 0)
            {
                dataGridAza.Rows[0].Selected = false;
                dataGridAza.Rows[dataGridAza.Rows.Count - 1].Selected = true;
            }
            btnRefresh.Enabled = true;
        }

        private void SectionAza_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 1084 && minimize == false)
            {
                dataGridAza.Width = (this.Width-15);
                minimize = true;
            }
            else if (this.Width <= 1084 && minimize == true)
            {
                dataGridAza.Width = 1069;
                minimize = false;
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
                animatorPanelSearch.ShowSync(panelSearch);
                panelSearch.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (rdoFname.Checked)
            {
                dataTable.DefaultView.RowFilter = "Fname like '%" + txtSearch.Text.Trim() + "%'";
            }
            else  if (rdoLname.Checked)
            {
                dataTable.DefaultView.RowFilter = "Lname  like '*" + txtSearch.Text.Trim() + "*'";
            }
            else if (rdoFatherName.Checked)
            {
                dataTable.DefaultView.RowFilter = "FatherName like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoPhone.Checked)
            {
                dataTable.DefaultView.RowFilter = "Phone like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoCode.Checked)
            {
                dataTable.DefaultView.RowFilter = "Code like '%" + txtSearch.Text.Trim() + "%'";
            }

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoPhone.Checked == false && rdoCode.Checked ==false)
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

        private void rdoFname_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
