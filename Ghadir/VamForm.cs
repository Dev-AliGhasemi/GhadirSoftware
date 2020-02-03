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
    public partial class VamForm : Form
    {
        bool isGiveVam;
        int code;
        public VamForm(bool isGiveVam, int code)
        {
            InitializeComponent();
            this.isGiveVam = isGiveVam;
            this.code = code;
        }
        bool click = false;
        int mouseX, mouseY;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader dataReader;
        DataTable dataTable = new DataTable();
        DataTable dataTableUpdateFields = new DataTable();
        SqlDataAdapter dataAdapter = new SqlDataAdapter();
        List<string> nameOfRecieverVam = new List<string>();
        List<string> nameOfZamen = new List<string>();
        List<int> codeMembers = new List<int>();
        string codeLoan;
        int maxLoan;
        int year, month, day,YEAR,MONTH,DAY;
        bool isMonthEsfand = false,isFirstHalf = false,currentYear = false, ISMONTHESFAN = false , ISFIRSTHALF = false,CURRENTYEAR = false;
        int monthly;
        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void chkKarmozd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKarmozd.Checked == true)
            {
                txtPercentKarmozd.Enabled = true;
            }
            else
            {
                txtPercentKarmozd.Enabled = false;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void VamForm_Load(object sender, EventArgs e)
        {
            cboRecieverVam.Items.Clear();
            cboZamen.Items.Clear();
            com.Connection = con;
            com.CommandText = "select  PercentSampleLoan  , PercentZiaratLoan , PercentEzdevagLoan  , PercentImportantLoan  , PercentHomeLoan, PercentDarmanLoan , DateSampleLoan  , DateZiaratLoan  , DateEzdevagLoan  , DateImportantLoan  , DateHomeLoan, DateDarmanLoan  , PriceSampleLoan , PriceZiaratLoan  , PriceEzdevagLoan  , PriceImportantLoan  , PriceHomeLoan , PriceDarmanLoan   from tbl_setting";
            dataAdapter.SelectCommand = com;
            dataAdapter.Fill(dataTable);
            com.CommandText = "select Fname+' '+Lname+'   >   '+FatherName from tbl_members";
            con.Open();
            dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                nameOfRecieverVam.Add(dataReader[0].ToString());
            }
            nameOfZamen = nameOfRecieverVam;
            dataReader.Close();
            com.CommandText = "select Code from tbl_members";
            dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                codeMembers.Add(int.Parse(dataReader[0].ToString()));
            }
            dataReader.Close();
            if (isGiveVam)
            {
                com.CommandText = "select max(Loan) from tbl_loan";
                codeLoan = (com.ExecuteScalar()).ToString();
                if (codeLoan != "")
                {
                    maxLoan = int.Parse(codeLoan);
                    txtNumberVam.Text = (maxLoan + 1).ToString();
                }
                else
                {
                    com.CommandText = "dbcc checkident (tbl_loan , reseed , 100000)";
                    com.ExecuteNonQuery();
                    com.CommandText = "dbcc checkident (tbl_installment , reseed , 100000)";
                    com.ExecuteNonQuery();
                }
                con.Close();
                cboRecieverVam.Items.AddRange(nameOfRecieverVam.ToArray());
                cboZamen.Items.AddRange(nameOfZamen.ToArray());
                cboTypeVam.SelectedIndex = -1;
            }
            else
            {
                cboRecieverVam.Items.AddRange(nameOfRecieverVam.ToArray());
                cboZamen.Items.AddRange(nameOfZamen.ToArray());
                com.CommandText = "select * from tbl_loan where Loan = "+code;
                dataAdapter.SelectCommand = com;
                dataAdapter.Fill(dataTableUpdateFields);
                txtNumberVam.Text = dataTableUpdateFields.Rows[0][0].ToString();
                txtCodeVamReciever.Text = dataTableUpdateFields.Rows[0][2].ToString();
                txtCodeZamen.Text = dataTableUpdateFields.Rows[0][4].ToString();
                cboTypeVam.Text = dataTableUpdateFields.Rows[0][5].ToString();
                txtMablagh.Text = dataTableUpdateFields.Rows[0][6].ToString();
                txtPercentKarmozd.Text = dataTableUpdateFields.Rows[0][7].ToString();
                if (txtPercentKarmozd.Text != "0" )
                {
                    chkKarmozd.Checked = true;
                }
                txtDateBack.Text = dataTableUpdateFields.Rows[0][8].ToString();
                txtNumberAghsat.Text = dataTableUpdateFields.Rows[0][9].ToString();
                string dateStart = dataTableUpdateFields.Rows[0][10].ToString(); ;
                txtYear.Text = dateStart.Substring(0, dateStart.IndexOf("/"));
                txtMonth.Text = dateStart.Substring(dateStart.IndexOf("/") + 1, (dateStart.LastIndexOf("/") - dateStart.IndexOf("/")) - 1);
                txtDay.Text = dateStart.Substring(dateStart.LastIndexOf("/") + 1, (dateStart.Length) - (dateStart.LastIndexOf("/") + 1));
                dateStart = dataTableUpdateFields.Rows[0][11].ToString(); ;
                txtYearEnd.Text = dateStart.Substring(0, dateStart.IndexOf("/"));
                txtMonthEnd.Text = dateStart.Substring(dateStart.IndexOf("/") + 1, (dateStart.LastIndexOf("/") - dateStart.IndexOf("/")) - 1);
                txtDayEnd.Text = dateStart.Substring(dateStart.LastIndexOf("/") + 1, (dateStart.Length) - (dateStart.LastIndexOf("/") + 1));
            }
            con.Close();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }

        private void cboRecieverVam_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodeVamReciever.Text = codeMembers[nameOfRecieverVam.IndexOf(cboRecieverVam.Text)].ToString();
                cboZamen.Items.Clear();
                cboZamen.Items.AddRange(nameOfZamen.ToArray());
                cboZamen.Items.Remove(cboRecieverVam.Text);
                txtCodeZamen.Text = "";
            }
            catch 
            {
            }
        }

        private void txtCodeVamReciever_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeVamReciever.TextLength == 4)
            {
                if (codeMembers.IndexOf(int.Parse(txtCodeVamReciever.Text)) >=0 )
                {
                    cboRecieverVam.Text = cboRecieverVam.Items[codeMembers.IndexOf(int.Parse(txtCodeVamReciever.Text))].ToString();
                }
            }           
        }

        private void txtCodeVamReciever_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtCodeZamen_TextChanged(object sender, EventArgs e)
        {
            if (txtCodeZamen.TextLength == 4)
            {
                if (txtCodeZamen.Text == txtCodeVamReciever.Text)
                {
                    txtCodeZamen.Text = "";
                }
                else if (codeMembers.IndexOf(int.Parse(txtCodeZamen.Text)) >= 0)
                {
                    cboZamen.Text = nameOfZamen[codeMembers.IndexOf(int.Parse(txtCodeZamen.Text))];
                }
            }
        }

        private void cboZamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCodeZamen.Text = codeMembers[nameOfRecieverVam.IndexOf(cboZamen.Text)].ToString();
            }
            catch 
            {
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCodeZamen.TextLength == 0 || txtCodeVamReciever.TextLength == 0 || cboRecieverVam.Text.Length == 0 || cboZamen.Text.Length == 0 || txtMablagh.TextLength == 0 || txtDateBack.TextLength == 0 || txtNumberAghsat.TextLength == 0 || txtDay.TextLength == 0 || txtMonth.TextLength == 0 || txtYear.TextLength == 0 || txtDayEnd.TextLength == 0 || txtMonthEnd.TextLength == 0 || txtYearEnd.TextLength == 0)
            {
                MessageBox.Show(".بعضی از فیلد ها خالی می باشند", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtYear.TextLength !=4 || txtYearEnd.TextLength != 4)
            {
                MessageBox.Show(".لطفا فیلد های تاریخ را درست وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (chkKarmozd.Checked && txtPercentKarmozd.TextLength == 0)
            {
                MessageBox.Show(".لطفا فیلد کارمزد را پر کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (codeMembers.IndexOf(int.Parse(txtCodeVamReciever.Text.Trim())) < 0)
            {
                MessageBox.Show(".لطفا شماره عضویت گیرنده وام را با دقت وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (codeMembers.IndexOf(int.Parse(txtCodeZamen.Text.Trim())) < 0)
            {
                MessageBox.Show(".لطفا شماره عضویت ضامن  را با دقت وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isGiveVam)
                {
                    com.Connection = con;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@RecieverLoan", cboRecieverVam.Text.Substring(0,cboRecieverVam.Text.IndexOf(">")));
                    com.Parameters.AddWithValue("@JoinNumberRecieverLoan", txtCodeVamReciever.Text.Trim());
                    com.Parameters.AddWithValue("@Guarantor", cboZamen.Text.Substring(0, cboZamen.Text.IndexOf(">")));
                    com.Parameters.AddWithValue("@JoinNumberGuarantor", txtCodeZamen.Text.Trim());
                    com.Parameters.AddWithValue("@LoanType", cboTypeVam.Text.Trim());
                    com.Parameters.AddWithValue("@Amount", txtMablagh.Text.Trim());
                    if (chkKarmozd.Checked)
                    {
                        com.Parameters.AddWithValue("@PercentKarmozd", txtPercentKarmozd.Text.Trim());
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@PercentKarmozd", "0");
                    }
                    com.Parameters.AddWithValue("@DateBack", txtDateBack.Text.Trim());
                    com.Parameters.AddWithValue("@NumberOfAghsat", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@DateStart", txtYear.Text.Trim() + "/" + txtMonth.Text.Trim() + "/" + txtDay.Text.Trim());
                    com.Parameters.AddWithValue("@DateFinish", txtYearEnd.Text.Trim() + "/" + txtMonthEnd.Text.Trim() + "/" + txtDayEnd.Text.Trim());
                    com.CommandText = "insert into tbl_loan (RecieverLoan , JoinNumberRecieverLoan , Guarantor , JoinNumberGuarantor , LoanType , Amount , PercentKarmozd , DateBack , NumberOfAghsat , DateStart , DateFinish) values (@RecieverLoan , @JoinNumberRecieverLoan , @Guarantor , @JoinNumberGuarantor , @LoanType , @Amount , @PercentKarmozd , @DateBack , @NumberOfAghsat , @DateStart , @DateFinish)";
                    con.Open();
                    com.ExecuteNonQuery();

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@NumberOfInstallment", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@AmountPerInstallment", long.Parse(txtMablagh.Text)/long.Parse(txtNumberAghsat.Text));
                    com.Parameters.AddWithValue("@NumberPayInstallment", 0);
                    com.Parameters.AddWithValue("@NumberNonPayInstallment", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@NumberPayAmount", 0 );
                    if (chkKarmozd.Checked && txtPercentKarmozd.Text != "0")
                    {
                        long   karmozd = (long.Parse(txtMablagh.Text) * long.Parse(txtPercentKarmozd.Text)) / 100;
                        com.Parameters.AddWithValue("@NumberNonPayAmount", long.Parse(txtMablagh.Text) + karmozd);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@NumberNonPayAmount", txtMablagh.Text);
                    }
                    com.Parameters.AddWithValue("@DateLastPay", "-");

                    //-----------------------
                    DAY = int.Parse(txtDay.Text);
                    MONTH = int.Parse(txtMonth.Text);
                    YEAR = int.Parse(txtYear.Text);
                    //برای اسفند ماه
                    if ((MONTH + 1)   == 12 && (DAY == 30))
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
                    if (MONTH +1 <= 6 &&  MONTH+1 >= 1 && ISMONTHESFAN == false && ISFIRSTHALF == false)
                    {
                        ISFIRSTHALF = true;
                        MONTH +=1;
                    }
                    //برای نیمه دوم سال کنونی
                    if (MONTH+1 > 6 && MONTH+1 < 13 && ISFIRSTHALF == false && ISMONTHESFAN == false)
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
                        if (DAY == 31 &&  MONTH+1> 6)
                        {
                            DAY = 1;
                            MONTH += 1;
                        }
                        else
                        {
                            DAY = int.Parse(txtDay.Text);
                            MONTH += 1;
                        }
                    }
            //-----------------------
                    com.Parameters.AddWithValue("@DateNextPay", YEAR +"/"+MONTH+"/"+DAY );
                    if (chkKarmozd.Checked)
                    {
                        com.Parameters.AddWithValue("@PayKarmozd", "0");
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@PayKarmozd", "1");
                    }
                    com.CommandText = "insert into tbl_installment (NumberOfInstallment , AmountPerInstallment , NumberPayInstallment , NumberNonPayInstallment , NumberPayAmount , NumberNonPayAmount , DateLastPay , DateNextPay , PayKarmozd)  values (@NumberOfInstallment , @AmountPerInstallment , @NumberPayInstallment , @NumberNonPayInstallment , @NumberPayAmount , @NumberNonPayAmount , @DateLastPay , @DateNextPay , @PayKarmozd)";
                    com.ExecuteNonQuery();
                    MessageBox.Show(".وام مورد نظر با موفقیت ثبت شد", "!!پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    com.CommandText = "select max(Loan) from tbl_loan";
                    maxLoan = int.Parse(com.ExecuteScalar().ToString());
                    txtNumberVam.Text = (maxLoan + 1).ToString();
                    con.Close();
                    txtCodeVamReciever.Clear();
                    txtCodeZamen.Clear();
                    txtMablagh.Clear();
                    chkKarmozd.Checked = false;
                    txtDateBack.Clear();
                    txtNumberAghsat.Clear();
                    txtDay.Clear();
                    txtMonth.Clear();
                    txtYear.Clear();
                    txtDayEnd.Clear();
                    txtMonthEnd.Clear();
                    txtYearEnd.Clear();
                    txtPercentKarmozd.Clear();
                    cboTypeVam.SelectedIndex = -1;
                    cboRecieverVam.SelectedIndex = -1;
                    cboZamen.SelectedIndex = -1;
                    ISFIRSTHALF = false;
                    ISMONTHESFAN = false;
                    CURRENTYEAR = false;
                }
                else
                {
                    com.Connection = con;
                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@RecieverLoan", cboRecieverVam.Text.Substring(0, cboRecieverVam.Text.IndexOf(">")));
                    com.Parameters.AddWithValue("@JoinNumberRecieverLoan", txtCodeVamReciever.Text.Trim());
                    com.Parameters.AddWithValue("@Guarantor", cboZamen.Text.Substring(0, cboZamen.Text.IndexOf(">")));
                    com.Parameters.AddWithValue("@JoinNumberGuarantor", txtCodeZamen.Text.Trim());
                    com.Parameters.AddWithValue("@LoanType", cboTypeVam.Text.Trim());
                    com.Parameters.AddWithValue("@Amount", txtMablagh.Text.Trim());
                    if (chkKarmozd.Checked)
                    {
                        com.Parameters.AddWithValue("@PercentKarmozd", txtPercentKarmozd.Text.Trim());
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@PercentKarmozd", "0");
                    }
                    com.Parameters.AddWithValue("@DateBack", txtDateBack.Text.Trim());
                    com.Parameters.AddWithValue("@NumberOfAghsat", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@DateStart", txtYear.Text.Trim() + "/" + txtMonth.Text.Trim() + "/" + txtDay.Text.Trim());
                    com.Parameters.AddWithValue("@DateFinish", txtYearEnd.Text.Trim() + "/" + txtMonthEnd.Text.Trim() + "/" + txtDayEnd.Text.Trim());
                    com.CommandText = "update tbl_loan set RecieverLoan = @RecieverLoan, JoinNumberRecieverLoan = @JoinNumberRecieverLoan , Guarantor = @Guarantor , JoinNumberGuarantor  = @JoinNumberGuarantor , LoanType = @LoanType , Amount = @Amount , PercentKarmozd = @PercentKarmozd  , DateBack = @DateBack , NumberOfAghsat =@NumberOfAghsat , DateStart  = @DateStart, DateFinish = @DateFinish where Loan  =" + code ;
                    con.Open();
                    com.ExecuteNonQuery();

                    com.Parameters.Clear();
                    com.Parameters.AddWithValue("@NumberOfInstallment", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@AmountPerInstallment", long.Parse(txtMablagh.Text) / long.Parse(txtNumberAghsat.Text));
                    com.Parameters.AddWithValue("@NumberPayInstallment", 0);
                    com.Parameters.AddWithValue("@NumberNonPayInstallment", txtNumberAghsat.Text.Trim());
                    com.Parameters.AddWithValue("@NumberPayAmount", 0);
                    if (chkKarmozd.Checked && txtPercentKarmozd.Text != "0")
                    {
                        long karmozd = (long.Parse(txtMablagh.Text) * long.Parse(txtPercentKarmozd.Text)) / 100;
                        com.Parameters.AddWithValue("@NumberNonPayAmount", long.Parse(txtMablagh.Text) + karmozd);
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@NumberNonPayAmount", txtMablagh.Text);
                    }
                    com.Parameters.AddWithValue("@DateLastPay", "-");

                    //-----------------------
                    DAY = int.Parse(txtDay.Text);
                    MONTH = int.Parse(txtMonth.Text);
                    YEAR = int.Parse(txtYear.Text);
                    //برای اسفند ماه
                    if ((MONTH + 1) % 12 == 0 && (DAY == 31 || DAY == 30))
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
                            DAY = 1;
                        MONTH += 1;
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
                            DAY = int.Parse(txtDay.Text);
                            MONTH += 1;
                        }
                    }
                    //-----------------------
                    com.Parameters.AddWithValue("@DateNextPay", YEAR + "/" + MONTH + "/" + DAY);
                    if (chkKarmozd.Checked)
                    {
                        com.Parameters.AddWithValue("@PayKarmozd", "0");
                    }
                    else
                    {
                        com.Parameters.AddWithValue("@PayKarmozd", "1");
                    }
                    com.CommandText = "update  tbl_installment set NumberOfInstallment = @NumberOfInstallment , AmountPerInstallment = @AmountPerInstallment , NumberPayInstallment = @NumberPayInstallment , NumberNonPayInstallment = @NumberNonPayInstallment , NumberPayAmount = @NumberPayAmount , NumberNonPayAmount = @NumberNonPayAmount , DateLastPay = @DateLastPay , DateNextPay = @DateNextPay , PayKarmozd = @PayKarmozd where Loan =" + code;
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(".ویرایش با موفقیت انجام شد", "!!پیام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ISFIRSTHALF = false;
                    ISMONTHESFAN = false;
                    CURRENTYEAR = false;
                }
            }
        }

        private void txtDateBack_TextChanged(object sender, EventArgs e)
        {
            txtDay.Clear();
            txtMonth.Clear();
            txtYear.Clear();
            txtDayEnd.Clear();
            txtMonthEnd.Clear();
            txtYearEnd.Clear();
        }

        private void txtCodeVamReciever_TextChanged(object sender, KeyPressEventArgs e)
        {

        }

        private void chkKarmozd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkKarmozd.Checked)
            {
                txtPercentKarmozd.Enabled = true;
            }
            else
            {
                txtPercentKarmozd.Enabled = false;
            }
        }

        private void txtDay_TextChanged(object sender, EventArgs e)
        {
            monthly = 0;
            month = 0;
            day = 0;
            year = 0;
            isFirstHalf = false;
            isMonthEsfand = false;
            currentYear = false;
                if (txtDay.Text.Length == 0 || txtMonth.TextLength==0 || txtYear.TextLength==0)
            {
                txtYearEnd.Clear();
                txtMonthEnd.Clear();
                txtDayEnd.Clear();
            }
            isMonthEsfand = false;
            if (txtDay.Text.Length > 0 && txtMonth.Text.Length > 0 && ( txtYear.Text.Length == 4))
            {
                if (txtDateBack.Text != "")
                {
                    day = int.Parse(txtDay.Text);
                    month = int.Parse(txtMonth.Text);
                    year = int.Parse(txtYear.Text);
                    monthly = int.Parse(txtDateBack.Text);
                    //برای اسفند ماه
                    if ((month + monthly)%12 == 0 && (day == 31 || day == 30))
                    {
                        year += ((month + monthly) / 12);
                        day = 1;
                        month = 1;
                        isMonthEsfand = true;
                    }
                    //برای نیمه اول سال کنونی
                     if (month + monthly <= 6 && month + monthly >= 1 && isFirstHalf == false && isMonthEsfand == false)
                    {
                        isFirstHalf = true;
                        month +=monthly;
                    }
                    //برای نیمه دوم سال کنونی
                    if (month + monthly > 6 && month + monthly < 13 && isFirstHalf == false && isMonthEsfand == false)
                    {
                        if (day == 31)
                        {
                            day = 1;
                            month += monthly+1;
                        }
                        else
                        {
                            month += monthly;
                        }
                        currentYear = true;
                    }
                    
                    if ((month+monthly)> 12 && isMonthEsfand == false && currentYear ==false)
                    {
                        if((monthly+month)%12==0)
                        {
                            year += (monthly + month) / 12;
                            year--;
                        }
                        else
                            year += (monthly + month) / 12;
                        //برای نیمه دوم سال بعد
                        if (day==31 &&  (month + monthly) - (12 * ((month + monthly) / 12)) > 6)
                        {
                            day = 1;
                            month = (month + monthly) - (12*((month+monthly)/12));
                        }
                        else
                        {
                            day = int.Parse(txtDay.Text);
                            month = monthly - ((monthly / 12) * 12);
                            if (int.Parse(txtMonth.Text)+month>=12 && (day==30 || day == 31))
                            {
                                //day = 1;
                                month = (int.Parse(txtMonth.Text) + month) - 12;
                                //month++;
                            }
                            else if (int.Parse(txtMonth.Text) + month < 13)
                            {
                                month += int.Parse(txtMonth.Text);
                            }
                            else if (int.Parse(txtMonth.Text) + month > 12)
                            {
                                month = (int.Parse(txtMonth.Text)+month)-12;
                            }
                            //else if (int.Parse(txtMonth.Text) + month > 12)
                            //{
                            //    month += int.Parse(txtMonth.Text);
                            //}
                            if (month == 0)
                                month = 12;
                        }
                    }
                }
            }
            txtDayEnd.Text = day.ToString();
            txtMonthEnd.Text = month.ToString();
            txtYearEnd.Text = year.ToString();
        }

        private void cboTypeVam_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTypeVam.SelectedIndex)
            {
                case 0:
                    txtPercentKarmozd.Text = dataTable.Rows[0][0].ToString();
                    txtDateBack.Text = dataTable.Rows[0][6].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][12].ToString();
                    break;
                case 1:
                    txtPercentKarmozd.Text = dataTable.Rows[0][1].ToString();
                    txtDateBack.Text = dataTable.Rows[0][7].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][13].ToString();
                    break;
                case 2:
                    txtPercentKarmozd.Text = dataTable.Rows[0][2].ToString();
                    txtDateBack.Text = dataTable.Rows[0][8].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][14].ToString();
                    break;
                case 3:
                    txtPercentKarmozd.Text = dataTable.Rows[0][3].ToString();
                    txtDateBack.Text = dataTable.Rows[0][9].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][15].ToString();
                    break;
                case 4:
                    txtPercentKarmozd.Text = dataTable.Rows[0][4].ToString();
                    txtDateBack.Text = dataTable.Rows[0][10].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][16].ToString();
                    break;
                case 5:
                    txtPercentKarmozd.Text = dataTable.Rows[0][5].ToString();
                    txtDateBack.Text = dataTable.Rows[0][11].ToString();
                    txtNumberAghsat.Text = dataTable.Rows[0][17].ToString();
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void setMembers()
        {
           
        }
    }
}
