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
    public partial class FormNote : Form
    {
        public FormNote()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\v11.0;AttachDbFilename=" + Application.StartupPath + "\\db_ghadir.mdf;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dataTable = new DataTable();
        Button btnClick;
        int mouseX, mouseY;
        bool click = false; 
        private void picClose_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click == true)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
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

        private void FormNote_Load(object sender, EventArgs e)
        {
            com.Connection = con;
            com.CommandText = "select * from tbl_note";
            adapter.SelectCommand = com;
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(13, 14, 23);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 14, 23);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 30, 51);
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("B Roya", 12, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Size = new Size(141, 51);
                btn.MouseClick += btn_MouseClick;
                btn.Text = dataTable.Rows[i][1].ToString();
                btn.Tag = dataTable.Rows[i][0].ToString();
                flowListNotes.Controls.Add(btn);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                click = false;
            }
        }

        private void picRefresh_MouseClick(object sender, MouseEventArgs e)
        {
            flowListNotes.Controls.Clear();
            dataTable.Clear();
            picRefresh.Enabled = false;
            flowListNotes.Enabled = false;
            com.CommandText = "select * from tbl_note";
            adapter.SelectCommand = com;
            adapter.Fill(dataTable);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(13, 14, 23);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 14, 23);
                btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 30, 51);
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("B Roya", 12, FontStyle.Bold);
                btn.ForeColor = Color.White;
                btn.Size = new Size(141, 51);
                btn.MouseClick += btn_MouseClick;
                btn.Text = dataTable.Rows[i][1].ToString();
                btn.Tag = dataTable.Rows[i][0].ToString();
                flowListNotes.Controls.Add(btn);          
            }
            flowListNotes.Enabled = true;
            picRefresh.Enabled = true;
        }

        private void picDelete_MouseClick(object sender, MouseEventArgs e)
        {
            if (lblTitle.Text.Length == 0)
            {
                MessageBox.Show(".لطفا یادداشت مورد نظر را انتخاب کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (MessageBox.Show("آیا از پاک کردن این یادداشت اطمینان دارید؟", "!!هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                com.CommandText = "delete from tbl_note where ID =" + btnClick.Tag.ToString();
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                txtText.Clear();
                lblTitle.Text = "";
                MessageBox.Show(".یادداست با موفقیت پاک شد", "!!موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClick.Tag = null;
            }
        }

        private void picNewNote_MouseClick(object sender, MouseEventArgs e)
        {
            FormAddNote frm = new FormAddNote(true,0);
            frm.Show();
        }

        private void picSave_MouseClick(object sender, MouseEventArgs e)
        {
            if (lblTitle.Text == "")
            {
                MessageBox.Show(".لطفا یادداشت مورد نظر را انتخاب کنید", "!!خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAddNote frm = new FormAddNote(false, int.Parse(btnClick.Tag.ToString()));
                frm.Show();
            }
        }

        private void btn_MouseClick(object sender, MouseEventArgs e)
        {
            btnClick = (Button)sender;
            if (btnClick.Tag != null)
            {
                lblTitle.Text = btnClick.Text;
                lblTitle.Left = (txtText.Width / 2) - (lblTitle.Width / 2);
                com.CommandText = "select Text from tbl_note where ID =" + btnClick.Tag.ToString();
                con.Open();
                txtText.Text = com.ExecuteScalar().ToString();
                con.Close();
            }      
        }
    }
}
