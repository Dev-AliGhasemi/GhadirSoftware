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
    public partial class SectionSetting : UserControl
    {
        public SectionSetting()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        IDataReader dataReader;
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if ( int.Parse(txtPercentEzdevagVam.Text) > 100 || int.Parse(txtPercentHomeVam.Text) > 100 || int.Parse(txtPercentImportantVam.Text) > 100  || int.Parse(txtPercentSampleVam.Text) > 100  || int.Parse(txtPercentZiaratVam.Text) > 100 || int.Parse(txtPercentDarmanLoan.Text) > 100)
                {
                    MessageBox.Show(".لطفا در صد های کارمزد ها را درست وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (MessageBox.Show("آیا از ذخیره تنظیمات اطمینان دارید؟", "!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        com.Connection = con;
                        com.Parameters.Clear();
                        com.Parameters.AddWithValue("@PricePerShare", txtPricePerShare.Text.Trim());
                        com.Parameters.AddWithValue("@PercentSampleLoan", txtPercentSampleVam.Text.Trim());
                        com.Parameters.AddWithValue("@PercentZiaratLoan", txtPercentZiaratVam.Text.Trim());
                        com.Parameters.AddWithValue("@PercentEzdevagLoan", txtPercentEzdevagVam.Text.Trim());
                        com.Parameters.AddWithValue("@PercentImportantLoan", txtPercentImportantVam.Text.Trim());
                        com.Parameters.AddWithValue("@PercentHomeLoan", txtPercentHomeVam.Text.Trim());
                        com.Parameters.AddWithValue("@DateSampleLoan", txtDateSampleVam.Text.Trim());
                        com.Parameters.AddWithValue("@DateZiaratLoan", txtDateZiaratVam.Text.Trim());
                        com.Parameters.AddWithValue("@DateEzdevagLoan", txtDateEzdevagVam.Text.Trim());
                        com.Parameters.AddWithValue("@DateImportantLoan", txtDateImportantVam.Text.Trim());
                        com.Parameters.AddWithValue("@DateHomeLoan", txtDateHomeVam.Text.Trim());
                        com.Parameters.AddWithValue("@PriceSampleLoan", txtPriceSampleVam.Text.Trim());
                        com.Parameters.AddWithValue("@PriceZiaratLoan", txtPriceZiaratVam.Text.Trim());
                        com.Parameters.AddWithValue("@PriceEzdevagLoan", txtPriceEzdevagVam.Text.Trim());
                        com.Parameters.AddWithValue("@PriceImportantLoan", txtPriceImportantVam.Text.Trim());
                        com.Parameters.AddWithValue("@PriceHomeLoan", txtPriceHomeVam.Text.Trim());
                        com.Parameters.AddWithValue("@AddressBackup", txtAddressBackup.Text.Trim());
                        com.CommandText = "update tbl_setting set PricePerShare = @PricePerShare , PercentSampleLoan = @PercentSampleLoan , PercentZiaratLoan = @PercentZiaratLoan" +
                             " , PercentEzdevagLoan = @PercentEzdevagLoan , PercentImportantLoan = @PercentImportantLoan , PercentHomeLoan = @PercentHomeLoan , DateSampleLoan = @DateSampleLoan" +
                             " , DateZiaratLoan = @DateZiaratLoan , DateEzdevagLoan = @DateEzdevagLoan , DateImportantLoan = @DateImportantLoan , DateHomeLoan = @DateHomeLoan , PriceSampleLoan = @PriceSampleLoan" +
                             " , PriceZiaratLoan = @PriceZiaratLoan , PriceEzdevagLoan = @PriceEzdevagLoan , PriceImportantLoan = @PriceImportantLoan , PriceHomeLoan = @PriceHomeLoan , AddressBackup = @AddressBackup";
                        con.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show(".اطلاعات با موفقیت ثبت شدند", "!!ثبت تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
             }
            catch
            {
                MessageBox.Show(".لطفا در صد های کارمزد ها را درست وارد کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
       }       
        private void txtPercentSampleVam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void SectionSetting_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select PricePerShare , PercentSampleLoan  , PercentZiaratLoan  , PercentEzdevagLoan , PercentImportantLoan  , PercentHomeLoan , DateSampleLoan  , DateZiaratLoan  , DateEzdevagLoan  , DateImportantLoan  , DateHomeLoan  , PriceSampleLoan , PriceZiaratLoan  , PriceEzdevagLoan  , PriceImportantLoan  , PriceHomeLoan  , AddressBackup , PercentDarmanLoan , DateDarmanLoan , PriceDarmanLoan  from tbl_setting";
            con.Open();
            dataReader = com.ExecuteReader();
            while (dataReader.Read())
            {
                txtPricePerShare.Text = dataReader[0].ToString();

                txtPercentSampleVam.Text = dataReader[1].ToString();
                txtPercentZiaratVam.Text = dataReader[2].ToString();
                txtPercentEzdevagVam.Text = dataReader[3].ToString();
                txtPercentImportantVam.Text = dataReader[4].ToString();
                txtPercentHomeVam.Text = dataReader[5].ToString();

                txtDateSampleVam.Text = dataReader[6].ToString();
                txtDateZiaratVam.Text = dataReader[7].ToString();
                txtDateEzdevagVam.Text = dataReader[8].ToString();
                txtDateImportantVam.Text = dataReader[9].ToString();
                txtDateHomeVam.Text = dataReader[10].ToString();

                txtPriceSampleVam.Text = dataReader[11].ToString();
                txtPriceZiaratVam.Text = dataReader[12].ToString();
                txtPriceEzdevagVam.Text = dataReader[13].ToString();
                txtPriceImportantVam.Text = dataReader[14].ToString();
                txtPriceHomeVam.Text = dataReader[15].ToString();

                txtAddressBackup.Text = dataReader[16].ToString();

                txtPercentDarmanLoan.Text = dataReader[17].ToString();
                txtDateDarmanVam.Text = dataReader[18].ToString();
                txtPriceDarmanVam.Text = dataReader[19].ToString();
            }
            con.Close();
        }

        private void btnChooseDirection_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "backup (*.bak) | *.bak";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                txtAddressBackup.Text = saveFileDialog1.FileName;
            }
        }
    }
}
