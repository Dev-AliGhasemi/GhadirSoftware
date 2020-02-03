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
    public partial class SectionStatusOfSandoogh : UserControl
    {
        public SectionStatusOfSandoogh()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlCommand comForTableInstallment = new SqlCommand();
        SqlDataAdapter Adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        long Mojoodi;
        private void SectionStatusOfSandoogh_Load(object sender, EventArgs e)
        {
            btnRefresh.Enabled = false;
            com.Connection = con;
            com.CommandText = "select sum(TotalFund) from tbl_fund";
            con.Open();
            lblTotalSandoogh.Text = com.ExecuteScalar().ToString();
            if (lblTotalSandoogh.Text == "")
            {
                lblTotalSandoogh.Text = "0";
            }
            com.CommandText = "select Loan from tbl_installment where NumberNonPayInstallment != 0 or PayKarmozd = 0";
            Adapter.SelectCommand = com;
            Adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count ; i++)
            {
                com.CommandText = "select NumberNonPayAmount from tbl_installment where Loan =" + dataTable.Rows[i][0];
                Mojoodi += long.Parse(com.ExecuteScalar().ToString());
            }
            lblTotalMojodiSandoogh.Text = ((long.Parse(lblTotalSandoogh.Text)) - (Mojoodi)).ToString();
            com.CommandText = "select count(Loan) from tbl_Loan";
            lblTotalVam.Text = com.ExecuteScalar().ToString();
            com.CommandText = "select sum(ShareNumber) from tbl_members";
            lblTotalSahm.Text = com.ExecuteScalar().ToString();
            if (lblTotalSahm.Text == "")
            {
                lblTotalSahm.Text = "0";
            }
            com.CommandText = "select count(Code) from tbl_members";
            lblMembers.Text = com.ExecuteScalar().ToString();
            lblVamJary.Text = dataTable.Rows.Count.ToString();
            con.Close();
            Mojoodi = 0;
            dataTable.Clear();
            btnRefresh.Enabled = true;
        }

        private void btnOK_MouseClick(object sender, MouseEventArgs e)
        {
            SectionStatusOfSandoogh_Load(null, null);
        }
    }
}
