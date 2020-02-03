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
using System.Globalization;
namespace Ghadir
{
    public partial class SectionVam : UserControl
    {
        public SectionVam()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlCommand comForTableInstallment = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        DataTable dataTableForAddDataInDataGridView = new DataTable();
        bool minmize = false;
        int firstDay, firstMonth, firstYear;
        int secondDay, secondMonth, secondYear;
        SqlDataReader dataReader;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            VamForm frmVam = new VamForm(true,0);
            frmVam.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            VamForm frmVam = new VamForm(false,int.Parse(dataGridVam[1,dataGridVam.CurrentCell.RowIndex].Value.ToString()));
            frmVam.ShowDialog();
        }

        private void SectionVam_Load(object sender, EventArgs e)
        {
            string[] dateFirst = ClassCurrentDate.currentDate.Split('/');
            string[] dateSecond;
            firstYear = int.Parse(dateFirst[0]);
            firstMonth = int.Parse(dateFirst[1]);
            firstDay = int.Parse(dateFirst[2]);
            com.Connection = con;
            comForTableInstallment.Connection = con;
            comForTableInstallment.CommandText = "select NumberNonPayInstallment , DateNextPay , PayKarmozd from tbl_installment";
            Adapter.SelectCommand = comForTableInstallment;
            Adapter.Fill(dataTable);
            com.CommandText = "select Loan,RecieverLoan,JoinNumberRecieverLoan,Guarantor,JoinNumberGuarantor,LoanType,Amount,DateStart,DateFinish from tbl_loan";
            dataTableForAddDataInDataGridView.Columns.Add("شناسه");
            dataTableForAddDataInDataGridView.Columns.Add("NumberLoan");
            dataTableForAddDataInDataGridView.Columns.Add("NameReciever");
            dataTableForAddDataInDataGridView.Columns.Add("CodeReciever");
            dataTableForAddDataInDataGridView.Columns.Add("NameZamen");
            dataTableForAddDataInDataGridView.Columns.Add("CodeZamen");
            dataTableForAddDataInDataGridView.Columns.Add("TypeLoan");
            dataTableForAddDataInDataGridView.Columns.Add("مبلغ");
            dataTableForAddDataInDataGridView.Columns.Add("تاریخ شروع");
            dataTableForAddDataInDataGridView.Columns.Add("تاریخ پایان");
            dataGridVam.DataSource = dataTableForAddDataInDataGridView;
            con.Open();
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                dataTableForAddDataInDataGridView.Rows.Add();
                dataTableForAddDataInDataGridView.Rows[i][0] = i + 1;
                dataTableForAddDataInDataGridView.Rows[i][1] = dataReader[0];
                dataTableForAddDataInDataGridView.Rows[i][2] = dataReader[1];
                dataTableForAddDataInDataGridView.Rows[i][3] = dataReader[2];
                dataTableForAddDataInDataGridView.Rows[i][4] = dataReader[3];
                dataTableForAddDataInDataGridView.Rows[i][5] = dataReader[4];
                dataTableForAddDataInDataGridView.Rows[i][6] = dataReader[5];
                dataTableForAddDataInDataGridView.Rows[i][7] = dataReader[6];
                dataTableForAddDataInDataGridView.Rows[i][8] = dataReader[7];
                dataTableForAddDataInDataGridView.Rows[i][9] = dataReader[8];

                i++;
            }
            dataGridVam.DataSource = dataTableForAddDataInDataGridView;
            dataReader.Close();
            for (int a = 0; a < dataGridVam.Rows.Count; a++)
            {
                dateSecond = dataTable.Rows[a][1].ToString().Split('/');
                if (dateSecond.Length == 1 && dataTable.Rows[a][0].ToString() == "0" && dataTable.Rows[a][2].ToString() == "1")
                {
                    dataGridVam.Rows[a].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dateSecond.Length == 3)
                {
                    secondYear = int.Parse(dateSecond[0]);
                    secondMonth = int.Parse(dateSecond[1]);
                    secondDay = int.Parse(dateSecond[2]);
                    //محاسبه تاریخ برای اینکه بفهمیم موعد تاریخ پرداخت رد شده یا نه
                    if (firstYear > secondYear)
                    {
                        dataGridVam.Rows[a].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (firstYear == secondYear)
                    {
                        if (firstMonth == secondMonth)
                        {
                            if (firstDay > secondDay)
                            {
                                dataGridVam.Rows[a].DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        else if (firstMonth > secondMonth)
                        {
                            dataGridVam.Rows[a].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
            dataReader.Close();
            dataGridVam.Columns[1].HeaderText = "شماره وام";
            dataGridVam.Columns[2].HeaderText = "وام گیرنده";
            dataGridVam.Columns[3].HeaderText = "کد عضویت وام گیرنده";
            dataGridVam.Columns[4].HeaderText = "ضامن";
            dataGridVam.Columns[5].HeaderText = "کد عضویت ضامن";
            dataGridVam.Columns[6].HeaderText = "نوع وام";
            //for disable sort datagrid View 
            foreach (DataGridViewColumn column in dataGridVam.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            if (dataGridVam.RowCount != 0)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                com.CommandText = "dbcc checkident (tbl_loan , reseed , 100000)";
                com.ExecuteNonQuery();
                com.CommandText = "dbcc checkident (tbl_installment , reseed , 100000)";
                com.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            if (dataGridVam.Rows.Count != 0)
            {
                dataGridVam.Rows[0].Selected = false;
                dataGridVam.Rows[dataGridVam.Rows.Count - 1].Selected = true;
            }
            con.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (rdoLoanNumber.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "NumberLoan like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoReciever.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "NameReciever like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoRecieverCode.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "CodeReciever like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoZamen.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "NameZamen like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoZamenCode.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "CodeZamen like '%" + txtSearch.Text.Trim() + "%'";
            }
            else if (rdoLoanType.Checked)
            {
                dataTableForAddDataInDataGridView.DefaultView.RowFilter = "TypeLoan like '%" + txtSearch.Text.Trim() + "%'";
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
                animatorPanelSearchVam.ShowSync(panelSearch);
                panelSearch.Visible = true;
            }
            
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdoLoanType.Checked  || rdoReciever.Checked || rdoZamen.Checked)
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

        private void rdoLoanNumber_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

            string[] dateFirst = ClassCurrentDate.currentDate.Split('/');
            string[] dateSecond;
            firstYear = int.Parse(dateFirst[0]);
            firstMonth = int.Parse(dateFirst[1]);
            firstDay = int.Parse(dateFirst[2]);

            btnRefresh.Enabled = false;
            dataTableForAddDataInDataGridView.Clear();
            comForTableInstallment.CommandText = "select NumberNonPayInstallment , DateNextPay , PayKarmozd from tbl_installment";
            Adapter.SelectCommand = comForTableInstallment;
            dataTable.Clear();
            Adapter.Fill(dataTable);
            com.CommandText = "select Loan,RecieverLoan,JoinNumberRecieverLoan,Guarantor,JoinNumberGuarantor,LoanType,Amount,DateStart,DateFinish from tbl_loan";
            con.Open();
            dataReader = com.ExecuteReader();
            int i = 0;
            while (dataReader.Read())
            {
                dataTableForAddDataInDataGridView.Rows.Add();
                dataTableForAddDataInDataGridView.Rows[i][0] = i + 1;
                dataTableForAddDataInDataGridView.Rows[i][1] = dataReader[0];
                dataTableForAddDataInDataGridView.Rows[i][2] = dataReader[1];
                dataTableForAddDataInDataGridView.Rows[i][3] = dataReader[2];
                dataTableForAddDataInDataGridView.Rows[i][4] = dataReader[3];
                dataTableForAddDataInDataGridView.Rows[i][5] = dataReader[4];
                dataTableForAddDataInDataGridView.Rows[i][6] = dataReader[5];
                dataTableForAddDataInDataGridView.Rows[i][7] = dataReader[6];
                dataTableForAddDataInDataGridView.Rows[i][8] = dataReader[7];
                dataTableForAddDataInDataGridView.Rows[i][9] = dataReader[8];

                dateSecond = dataTable.Rows[i][1].ToString().Split('/');
                if (dateSecond.Length == 1 && dataTable.Rows[i][0].ToString() == "0" && dataTable.Rows[i][2].ToString() == "1")
                {
                    dataGridVam.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                }
                else if (dateSecond.Length == 3)
                {
                    secondYear = int.Parse(dateSecond[0]);
                    secondMonth = int.Parse(dateSecond[1]);
                    secondDay = int.Parse(dateSecond[2]);

                    if (firstYear > secondYear)
                    {
                        dataGridVam.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    }
                    else if (firstYear == secondYear)
                    {
                        if (firstMonth == secondMonth)
                        {
                            if (firstDay > secondDay)
                            {
                                dataGridVam.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        else if (firstMonth > secondMonth)
                        {
                            dataGridVam.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
                i++;
            }
            dataReader.Close();
            if (dataGridVam.RowCount != 0)
            {
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
            else
            {
                com.CommandText = "dbcc checkident (tbl_loan , reseed , 100000)";
                com.ExecuteNonQuery();
                com.CommandText = "dbcc checkident (tbl_installment , reseed , 100000)";
                com.ExecuteNonQuery();
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            con.Close();
            if (dataGridVam.Rows.Count != 0 )
            {
                dataGridVam.Rows[0].Selected = false;
                dataGridVam.Rows[dataGridVam.Rows.Count - 1].Selected = true;
            }    
            btnRefresh.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("آیا از پاک کردن این وام اطمینان دارید؟", "!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                com.CommandText = "delete from tbl_loan where Loan =" + dataGridVam[1, dataGridVam.CurrentCell.RowIndex].Value;
                con.Open();
                com.ExecuteNonQuery();
                com.CommandText = "delete from tbl_installment where Loan =" + dataGridVam[1, dataGridVam.CurrentCell.RowIndex].Value;
                com.ExecuteNonQuery();
                con.Close();
            }
        }

        private void SectionVam_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width > 1084 && minmize == false)
            {
                dataGridVam.Width = (this.Width-15);
                minmize = true;
            }
            else if(this.Width <= 1084 && minmize == true)
            {
                dataGridVam.Width = 1069;
                minmize = false;
            }
        }

        private void dataGridVam_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FormInfoVam frm = new FormInfoVam(dataGridVam[1, dataGridVam.CurrentCell.RowIndex].Value.ToString());
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
    }
}
