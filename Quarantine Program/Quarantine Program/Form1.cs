using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Quarantine_Program.Properties;
using System.Data.SqlTypes;
using System.Data.Linq.SqlClient;
using System.Xml;

namespace Quarantine_Program
{
    public partial class Form1 : Form
    {
        DataTable userDt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string inc = incryption.Encrypt(txt_UserLoginPassword.Text);
                string comString = "select * from tbl_account where account_UserLoginPassword='" + inc + "'";
                SqlCommand com = new SqlCommand(comString, con);
                con.Open();
                userDt.Load(com.ExecuteReader());
                Program.userDt = userDt;
                con.Close();
                if (Program.userDt.Rows.Count > 0)
                {

                    lbl_userName.Text = Program.userDt.Rows[0][2].ToString();
                    lbl_userMobile.Text = Program.userDt.Rows[0][3].ToString();
                    pic_user.Visible = true;
                    panel2.Visible = true;
                    txt_UserLoginName.Enabled = false;
                    txt_UserLoginPassword.Enabled = false;
                    btn_Enter.Enabled = false;
                    btn_userExit.Visible = true;

                }
                else
                {
                    MessageBox.Show("تأكد من صحة كلمة المرور وإسم المستخدم");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }

        private void btn_userExit_Click(object sender, EventArgs e)
        {
            Program.userDt.Rows.Clear();
            lbl_userName.Text = "";
            lbl_userMobile.Text = "";
            pic_user.Visible = false;
            panel2.Visible = false;
            txt_UserLoginName.Enabled = true;
            txt_UserLoginPassword.Enabled = true;
            btn_Enter.Enabled = true;
            txt_UserLoginName.Clear();
            txt_UserLoginPassword.Clear();
            btn_userExit.Visible = false;


            panel6.Controls.Clear();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            if(panel5.Visible==false)
            {
                panel7.Visible = true;
                panel5.Visible = true;

            }
            else
            {
                panel7.Visible = false;
                panel5.Visible = false;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            if (panel9.Visible == false)
            {
                panel11.Visible = true;
                panel10.Visible = true;
                panel9.Visible = true;

            }
            else
            {
                panel11.Visible = false;
                panel10.Visible = false;
                panel9.Visible = false;


            }
        }

        private void label11_Click(object sender, EventArgs e)
        {

                if (panel13.Visible == false)
                {
                    panel17.Visible = true;
                    panel16.Visible = true;
                    panel15.Visible = true;
                    panel14.Visible = true;
                    panel13.Visible = true;

                }
                else
                {
                    panel13.Visible = false;
                    panel14.Visible = false;
                    panel15.Visible = false;
                    panel16.Visible = false;
                    panel17.Visible = false;
                }

        }

        private void lbl_EnterAndExit_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            frm_Entry frm1 = new frm_Entry() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel6.Controls.Add(frm1);
            frm1.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel6.Controls.Clear();
            Form2 frm1 = new Form2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm1.FormBorderStyle = FormBorderStyle.None;
            panel6.Controls.Add(frm1);
            frm1.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][4].ToString()=="True" && Program.userDt.Rows[0][14].ToString() == "True")
            {

            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][13].ToString() == "True")
            {
                panel6.Controls.Clear();
                frm_AlmantiqCityQuest frm1 = new frm_AlmantiqCityQuest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm1.FormBorderStyle = FormBorderStyle.None;
                panel6.Controls.Add(frm1);
                frm1.Show();
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

                panel6.Controls.Clear();
                frm_Quest frm1 = new frm_Quest() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm1.FormBorderStyle = FormBorderStyle.None;
                panel6.Controls.Add(frm1);
                frm1.Show();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][13].ToString() == "True")
            {
                panel6.Controls.Clear();
                frm_users frm1 = new frm_users() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                frm1.FormBorderStyle = FormBorderStyle.None;
                panel6.Controls.Add(frm1);
                frm1.Show();
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void label8_Click(object sender, EventArgs e)
        {
            frm_QuestReport frm1 = new frm_QuestReport();
            frm1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //////////Settings.Default["deviesNo"] = "new";
            //////////Settings.Default.Save();


            //// هنا يتم تفعيل قواعد حماية البرنامج
            //// تم اقفال تلك الحماية لتسهيل دخول المبرمجين بسدايا وفحص البرنامج
            //if (Settings.Default["deviesNo"].ToString() == "new")
            //{
            //    frm_deviesID frm = new frm_deviesID();
            //    frm.ShowDialog();
            //}
            //else
            //{
            //    string x = incryption.Encrypt(specialDevies.getUniqueID("c"));
            //    string xx = Settings.Default["deviesNo"].ToString();
            //    if (x==xx)
            //    {
            //        return;
            //    }
            //    else
            //    {
            //        MessageBox.Show("لا يوجد ترخيص لاتخدام هذا البرنامج","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //        Settings.Default["deviesNo"] = "new";
            //        Settings.Default.Save();
            //        Application.Exit();
            //    }
            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (panel18.Visible)
            {
                panel18.Visible = false;
            }
            else
            {
                panel18.Visible = true;
            }

    }

        private void button2_Click(object sender, EventArgs e)
        {
            panel18.Visible = false;
        }



        Configuration config;
        private void btn_saveConnectionString_Click(object sender, EventArgs e)
        {
            string ConString = string.Format("Data Source ={0}; Initial Catalog = {1}; User ID = {2}; Password = {3};", txt_server.Text, txt_database.Text, txt_user.Text, txt_password.Text);

            //config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            //config.ConnectionStrings.ConnectionStrings["conn"].ConnectionString = ConString;
            //config.ConnectionStrings.ConnectionStrings["conn"].ProviderName = "System.Data.SqlClient";
            ////config.Save(ConfigurationSaveMode.Modified);

            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings["conn"].ConnectionString = ConString;
            config.Save();

            Application.Exit();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

        }
    }
}
