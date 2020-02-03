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
    public partial class CreateForm : Form
    {
        bool isCreateForm;
        string code = null;
        public CreateForm(bool isCreateForm,int code)
        {
            InitializeComponent();
            this.isCreateForm = isCreateForm;
            this.code = code.ToString();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        int AmuntPerShare;
        int maxCode;
        bool click = false;
        int mouseX, mouseY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Right && e.KeyChar != (char)Keys.Left && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFname.TextLength ==0 || txtLname.TextLength == 0 || txtFatherName.TextLength == 0 || txtSahm.TextLength == 0 || txtSarmaie.TextLength == 0)  
            {
                MessageBox.Show(".بعضی از فیلد ها پر نشده است", "!!هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isCreateForm == true)
                {
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    com.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    com.Parameters.AddWithValue("@FatherName", txtFatherName.Text.Trim());
                    com.Parameters.AddWithValue("@NationalCode", txtID.Text.Trim());
                    com.Parameters.AddWithValue("@AccountNumber", txtCardNumber.Text.Trim());
                    com.Parameters.AddWithValue("@DateBorn", txtYear.Text.Trim() + "/" + txtMonth.Text.Trim() + "/" + txtDay.Text.Trim());
                    com.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    com.Parameters.AddWithValue("@ShareNumber", txtSahm.Text.Trim());
                    com.Parameters.AddWithValue("@PrimitiveFund", txtSarmaie.Text.Trim());
                    com.CommandText = "insert into tbl_members (Fname,Lname,FatherName,DateBorn,AccountNumber,NationalCode,PhoneNumber,ShareNumber,PrimitiveFund) values(@Fname,@Lname,@FatherName,@DateBorn,@AccountNumber,@NationalCode,@PhoneNumber,@ShareNumber,@PrimitiveFund)";
                    con.Open();
                    com.ExecuteNonQuery();
                    //----------------
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    com.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    com.Parameters.AddWithValue("@NumberOfShare", txtSahm.Text);
                    com.Parameters.AddWithValue("@TotalFund", txtSarmaie.Text);
                    com.Parameters.AddWithValue("@PayMonthly", long.Parse(txtSahm.Text)*AmuntPerShare);
                    com.Parameters.AddWithValue("@DateLastPay", ClassCurrentDate.currentDate);
                    com.CommandText = "insert into tbl_fund ( Fname , Lname , NumberOfShare , TotalFund , PayMonthly , DateLastPay ) values(@Fname , @Lname , @NumberOfShare , @TotalFund , @PayMonthly , @DateLastPay )";
                    com.ExecuteNonQuery();
                    //----------------
                    com.CommandText = "select max(Code) from tbl_members";
                    maxCode = int.Parse(com.ExecuteScalar().ToString());
                    con.Close();
                    MessageBox.Show(".فرد مورد نظر به اعضا اضافه شد", "!!پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCardNumber.Clear();
                    txtID.Clear();
                    txtPhoneNumber.Clear();
                    txtYear.Clear();
                    txtMonth.Clear();
                    txtDay.Clear();
                    txtSahm.Clear();
                    txtSarmaie.Clear();
                    txtFname.Clear();
                    txtLname.Clear();
                    txtFatherName.Clear();
                    txtSarmaie.Clear();
                    txtCode.Text = (maxCode + 1).ToString();
                }
                else
                {
                    con.Open();
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    com.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    com.Parameters.AddWithValue("@FatherName", txtFatherName.Text.Trim());
                    com.Parameters.AddWithValue("@NationalCode", txtID.Text.Trim());
                    com.Parameters.AddWithValue("@AccountNumber", txtCardNumber.Text.Trim());
                    com.Parameters.AddWithValue("@DateBorn", txtYear.Text.Trim() + "/" + txtMonth.Text.Trim() + "/" + txtDay.Text.Trim());
                    com.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumber.Text.Trim());
                    com.Parameters.AddWithValue("@ShareNumber", txtSahm.Text.Trim());
                    com.Parameters.AddWithValue("@PrimitiveFund", txtSarmaie.Text.Trim());
                    com.CommandText = "update tbl_members set Fname = @Fname , Lname = @Lname , FatherName = @FatherName , DateBorn = @DateBorn , AccountNumber = @AccountNumber , NationalCode = @NationalCode , PhoneNumber = @PhoneNumber , ShareNumber  = @ShareNumber , PrimitiveFund = @PrimitiveFund where Code = '" + code + "'";
                    com.ExecuteNonQuery();
                    //-------------------
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@Fname", txtFname.Text.Trim());
                    com.Parameters.AddWithValue("@Lname", txtLname.Text.Trim());
                    com.Parameters.AddWithValue("@NumberOfShare", txtSahm.Text);
                    com.Parameters.AddWithValue("@TotalFund", txtSarmaie.Text);
                    com.Parameters.AddWithValue("@PayMonthly", long.Parse(txtSahm.Text) * AmuntPerShare);
                    com.CommandText = "update tbl_fund set Fname  = @Fname , Lname = @Lname , NumberOfShare = @NumberOfShare , TotalFund = @TotalFund , PayMonthly = @PayMonthly where Code="+code;
                    com.ExecuteNonQuery();
                    //-------------------
                    con.Close();
                    MessageBox.Show(".ویرایش با موفقیت انجام شد", "!!پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
            }
        }

        private void CreateForm_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            con.Open();
            com.CommandText = "select PricePerShare from tbl_setting ";
            AmuntPerShare = int.Parse(com.ExecuteScalar().ToString());
            if (isCreateForm == true)
            {
                com.CommandText = "select max(Code) from tbl_members";
                code = (com.ExecuteScalar().ToString());
                if (code != "")
                {
                    maxCode = int.Parse(code);
                    txtCode.Text = (maxCode + 1).ToString();
                }      
            }
            else
            {
                com.CommandText = "select * from tbl_members where Code = '" + code + "'";
                adapter.SelectCommand = com;
                adapter.Fill(dataTable);
                txtCode.Text = dataTable.Rows[0][0].ToString();
                txtFname.Text = dataTable.Rows[0][1].ToString();
                txtLname.Text = dataTable.Rows[0][2].ToString();
                txtFatherName.Text = dataTable.Rows[0][3].ToString();
                string dateBorn = dataTable.Rows[0][4].ToString(); ;
                txtYear.Text = dateBorn.Substring(0, dateBorn.IndexOf("/"));
                txtMonth.Text = dateBorn.Substring(dateBorn.IndexOf("/") + 1, (dateBorn.LastIndexOf("/") - dateBorn.IndexOf("/"))-1);
                txtDay.Text = dateBorn.Substring(dateBorn.LastIndexOf("/") + 1, (dateBorn.Length) - (dateBorn.LastIndexOf("/")+1));
                txtCardNumber.Text = dataTable.Rows[0][5].ToString();
                txtID.Text = dataTable.Rows[0][6].ToString();
                txtPhoneNumber.Text = dataTable.Rows[0][7].ToString();
                txtSahm.Text = dataTable.Rows[0][8].ToString();
                txtSarmaie.Text = dataTable.Rows[0][9].ToString();
            }
            con.Close();
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }
    }
}
