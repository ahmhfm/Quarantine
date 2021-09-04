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

namespace Quarantine_Program
{
    public partial class frm_users : Form
    {
        public frm_users()
        {
            InitializeComponent();
        }

        private void defulteEnabale()
        {
            cb_Ministry.Enabled = false;

            cb_Almantiqa.Enabled = false;

            cb_city.Enabled = false;

            cb_Quarry.Enabled = false;

            cb_insert.Enabled = false;

            cb_Edit.Enabled = false;

            cb_delete.Enabled = false;

            cb_admin.Enabled = false;

            txt_account_UserLoginName.Enabled = false;

            txt_account_UserLoginPassword.Enabled = false;


            txt_account_UserMobile.Enabled = false;


            txt_account_UserName.Enabled = false;



            cmb_account_AlmantiqaName.Enabled = false;


            cmb_account_CityName.Enabled = false;


            cmb_account_QuarryName.Enabled = false;

            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "وضع التعديل";
            btn_search.Text = "نافذة البحث";



        }
        private void checkBox_Ministry_Click(object sender, EventArgs e)
        {
            cb_Almantiqa.Checked = false;
            cb_city.Checked = false;
            cb_Quarry.Checked = false;
            cb_Ministry.Checked = true;
        }

        private void checkBox_Almantiqa_Click(object sender, EventArgs e)
        {
            cb_Ministry.Checked = false;
            cb_city.Checked = false;
            cb_Quarry.Checked = false;
            cb_Almantiqa.Checked = true;
        }

        private void checkBoxcity_Click(object sender, EventArgs e)
        {
            cb_Almantiqa.Checked = false;
            cb_Ministry.Checked = false;
            cb_Quarry.Checked = false;
            cb_city.Checked = true;
        }

        private void checkBox_Quarry_Click(object sender, EventArgs e)
        {
            cb_Almantiqa.Checked = false;
            cb_Ministry.Checked = false;
            cb_Quarry.Checked = true;
            cb_city.Checked = false;
        }

        public DataTable Almantiq = new DataTable();
        public DataTable City = new DataTable();
        public DataTable Quarry = new DataTable();
        public DataTable Room = new DataTable();

        private void fill_lb_Almantiq()
        {
            try
            {

                Almantiq.Rows.Clear();
                cmb_account_AlmantiqaName.DataSource = null;
                cmb_account_AlmantiqaName.Items.Clear();

                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "select Almantiq_name,Almantiq_no from tbl_Almantiq";
                    SqlCommand com = new SqlCommand(comString, con);

                    con.Open();
                    Almantiq.Load(com.ExecuteReader());
                    if (Almantiq.Rows.Count > 0)
                    {
                        cmb_account_AlmantiqaName.DataSource = Almantiq;
                        cmb_account_AlmantiqaName.DisplayMember = "Almantiq_name";
                        cmb_account_AlmantiqaName.ValueMember = "Almantiq_no";
                    }
                    con.Close();

                }
                else
                {
                    cmb_account_AlmantiqaName.Items.Add(Program.userDt.Rows[0][5].ToString());
                }

                if (cmb_account_AlmantiqaName.Items.Count > 1)
                {
                    cmb_account_AlmantiqaName.SelectedIndex = 1;
                    cmb_account_AlmantiqaName.SelectedIndex = 0;

                }
                else if (cmb_account_AlmantiqaName.Items.Count > 0)
                {
                    cmb_account_AlmantiqaName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }


        private void fill_lb_City()
        {
            try
            {
                if (cmb_account_AlmantiqaName.Items.Count > 0)
                {


                    City.Rows.Clear();
                    cmb_account_CityName.DataSource = null;
                    cmb_account_CityName.Items.Clear();



                    if (Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con11 = new SqlConnection(conString);
                        string comString1 = "select city_name,City_no from tbl_city where city_Almantiqname = @city_Almantiqname";

                        SqlCommand com111 = new SqlCommand(comString1, con11);
                        com111.Parameters.AddWithValue("@city_Almantiqname", cmb_account_AlmantiqaName.Text);
                        con11.Open();
                        City.Load(com111.ExecuteReader());
                        Program.city = City;
                        con11.Close();

                        if (Program.city.Rows.Count > 0)
                        {
                            cmb_account_CityName.DataSource = Program.city;
                            cmb_account_CityName.DisplayMember = "city_name";
                            cmb_account_CityName.ValueMember = "City_no";
                        }

                    }
                    else
                    {
                        cmb_account_CityName.Items.Add(Program.userDt.Rows[0][7].ToString());
                    }

                }
                if (cmb_account_CityName.Items.Count > 1)
                {
                    cmb_account_CityName.SelectedIndex = 1;
                    cmb_account_CityName.SelectedIndex = 0;
                }
                else if (cmb_account_CityName.Items.Count > 0)
                {
                    cmb_account_CityName.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void fill_lb_Quarry()
        {
            try
            {

                Quarry.Rows.Clear();
                cmb_account_QuarryName.DataSource = null;
                cmb_account_QuarryName.Items.Clear();


                if (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con2 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con2;
                    con2.ConnectionString = conString;

                    comString = "select Quarry_GeneralNo,Quarry_QuarryName from tbl_Quarry where Quarry_CityName = '" + cmb_account_CityName.Text + "'";
                    com.CommandText = comString;
                    con2.Open();
                    Quarry.Load(com.ExecuteReader());
                    Program.Quarry = Quarry;

                    con2.Close();


                    if (Program.Quarry.Rows.Count > 0)
                    {
                        cmb_account_QuarryName.DataSource = Quarry;
                        cmb_account_QuarryName.DisplayMember = "Quarry_QuarryName";
                        cmb_account_QuarryName.ValueMember = "Quarry_GeneralNo";
                    }

                    if (cmb_account_QuarryName.Items.Count > 1)
                    {
                        cmb_account_QuarryName.SelectedIndex = 1;
                        cmb_account_QuarryName.SelectedIndex = 0;
                    }
                    else if (cmb_account_QuarryName.Items.Count > 0)
                    {
                        cmb_account_QuarryName.SelectedIndex = 0;
                    }
                }
                else
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con2 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con2;

                    DataTable dt1 = new DataTable();
                    con2.ConnectionString = conString;
                    con2.Open();
                    comString = "select Quarry_GeneralNo,Quarry_QuarryName from tbl_Quarry where Quarry_QuarryName = @Quarry_QuarryName";
                    com.CommandText = comString;
                    com.Parameters.AddWithValue("@Quarry_QuarryName", Program.userDt.Rows[0][9].ToString());
                    dt1.Load(com.ExecuteReader());
                    cmb_account_QuarryName.DataSource = dt1;
                    cmb_account_QuarryName.DisplayMember = "Quarry_QuarryName";
                    cmb_account_QuarryName.ValueMember = "Quarry_GeneralNo";
                    con2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if(btn_add.Text== "وضع الإضافة")
            {
                btn_add.Text = "حفظ";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    cb_Ministry.Enabled = true;
                    cb_Ministry.Checked = false;

                    cb_Almantiqa.Enabled = true;
                    cb_Almantiqa.Checked = false;

                    cb_city.Enabled = true;
                    cb_city.Checked = false;

                    cb_Quarry.Enabled = true;
                    cb_Quarry.Checked = false;

                    cb_insert.Enabled = true;
                    cb_insert.Checked = false;

                    cb_Edit.Enabled = true;
                    cb_Edit.Checked = false;

                    cb_delete.Enabled = true;
                    cb_delete.Checked = false;

                    cb_admin.Enabled = true;
                    cb_admin.Checked = false;

                    txt_account_UserLoginName.Enabled = true;
                    txt_account_UserLoginName.Text = "";

                    txt_account_UserLoginPassword.Enabled = true;
                    txt_account_UserLoginPassword.Text = "";

                    txt_account_UserMobile.Enabled = true;
                    txt_account_UserMobile.Text = "";

                    txt_account_UserName.Enabled = true;
                    txt_account_UserName.Text = "";

                    txt_search.Enabled = true;
                    txt_search.Text = "";

                    cmb_account_AlmantiqaName.Enabled = true;
                    try
                    {

                    }
                    catch 
                    {
                        cmb_account_AlmantiqaName.SelectedIndex = 0;
                    }


                    cmb_account_CityName.Enabled = true;
                    try
                    {

                    }
                    catch
                    {
                        cmb_account_CityName.SelectedIndex = 0;
                    }


                    cmb_account_QuarryName.Enabled = true;
                    try
                    {

                    }
                    catch
                    {
                        cmb_account_QuarryName.SelectedIndex = 0;
                    }


                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    cb_Ministry.Enabled = false;
                    cb_Ministry.Checked = false;

                    cb_Almantiqa.Enabled = false;
                    cb_Almantiqa.Checked = false;

                    cb_city.Enabled = true;
                    cb_city.Checked = false;

                    cb_Quarry.Enabled = true;
                    cb_Quarry.Checked = false;

                    cb_insert.Enabled = true;
                    cb_insert.Checked = false;

                    cb_Edit.Enabled = true;
                    cb_Edit.Checked = false;

                    cb_delete.Enabled = true;
                    cb_delete.Checked = false;

                    cb_admin.Enabled = true;
                    cb_admin.Checked = false;

                    txt_account_UserLoginName.Enabled = true;
                    txt_account_UserLoginName.Text = "";

                    txt_account_UserLoginPassword.Enabled = true;
                    txt_account_UserLoginPassword.Text = "";

                    txt_account_UserMobile.Enabled = true;
                    txt_account_UserMobile.Text = "";

                    txt_account_UserName.Enabled = true;
                    txt_account_UserName.Text = "";

                    txt_search.Enabled = true;
                    txt_search.Text = "";

                    cmb_account_AlmantiqaName.Enabled = true;
                    cmb_account_AlmantiqaName.SelectedIndex = 0;

                    cmb_account_CityName.Enabled = true;
                    cmb_account_CityName.SelectedIndex = 0;

                    cmb_account_QuarryName.Enabled = true;
                    cmb_account_QuarryName.SelectedIndex = 0;
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    cb_Ministry.Enabled = false;
                    cb_Ministry.Checked = false;

                    cb_Almantiqa.Enabled = false;
                    cb_Almantiqa.Checked = false;

                    cb_city.Enabled = false;
                    cb_city.Checked = false;

                    cb_Quarry.Enabled = true;
                    cb_Quarry.Checked = false;

                    cb_insert.Enabled = true;
                    cb_insert.Checked = false;

                    cb_Edit.Enabled = true;
                    cb_Edit.Checked = false;

                    cb_delete.Enabled = true;
                    cb_delete.Checked = false;

                    cb_admin.Enabled = true;
                    cb_admin.Checked = false;

                    txt_account_UserLoginName.Enabled = true;
                    txt_account_UserLoginName.Text = "";

                    txt_account_UserLoginPassword.Enabled = true;
                    txt_account_UserLoginPassword.Text = "";

                    txt_account_UserMobile.Enabled = true;
                    txt_account_UserMobile.Text = "";

                    txt_account_UserName.Enabled = true;
                    txt_account_UserName.Text = "";

                    txt_search.Enabled = true;
                    txt_search.Text = "";

                    cmb_account_AlmantiqaName.Enabled = true;
                    cmb_account_AlmantiqaName.SelectedIndex = 0;

                    cmb_account_CityName.Enabled = true;
                    cmb_account_CityName.SelectedIndex = 0;

                    cmb_account_QuarryName.Enabled = true;
                    cmb_account_QuarryName.SelectedIndex = 0;
                }
                else
                {
                    cb_Ministry.Enabled = false;
                    cb_Ministry.Checked = false;

                    cb_Almantiqa.Enabled = false;
                    cb_Almantiqa.Checked = false;

                    cb_city.Enabled = false;
                    cb_city.Checked = false;

                    cb_Quarry.Enabled = false;
                    cb_Quarry.Checked = false;

                    cb_insert.Enabled = true;
                    cb_insert.Checked = false;

                    cb_Edit.Enabled = true;
                    cb_Edit.Checked = false;

                    cb_delete.Enabled = true;
                    cb_delete.Checked = false;

                    cb_admin.Enabled = true;
                    cb_admin.Checked = false;

                    txt_account_UserLoginName.Enabled = true;
                    txt_account_UserLoginName.Text = "";

                    txt_account_UserLoginPassword.Enabled = true;
                    txt_account_UserLoginPassword.Text = "";

                    txt_account_UserMobile.Enabled = true;
                    txt_account_UserMobile.Text = "";

                    txt_account_UserName.Enabled = true;
                    txt_account_UserName.Text = "";

                    txt_search.Enabled = true;
                    txt_search.Text = "";

                    cmb_account_AlmantiqaName.Enabled = true;
                    cmb_account_AlmantiqaName.SelectedIndex = 0;

                    cmb_account_CityName.Enabled = true;
                    cmb_account_CityName.SelectedIndex = 0;

                    cmb_account_QuarryName.Enabled = true;
                    cmb_account_QuarryName.SelectedIndex = 0;
                }
            }
            else
            {
                if(txt_account_UserLoginName.Text!=string.Empty&&txt_account_UserLoginPassword.Text!=string.Empty&&txt_account_UserMobile.Text!=string.Empty&&txt_account_UserName.Text!=string.Empty)
                {
                    try
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        string comString = "  insert into tbl_account values(@account_UserLoginName,@account_UserLoginPassword,@account_UserName,@account_UserMobile,@account_AllCities,@account_AlmantiqaName,@account_AlmantiqaName_work,@account_CityName,@account_CityName_work,@account_QuarryName,@account_insert,@account_update,@account_delete,@account_admin,@account_QuarryName_work);";
                        SqlCommand com = new SqlCommand(comString, con);


                        com.Parameters.AddWithValue("@account_UserLoginName", txt_account_UserLoginName.Text);
                        com.Parameters.AddWithValue("@account_UserLoginPassword", incryption.Encrypt(txt_account_UserLoginPassword.Text));
                        com.Parameters.AddWithValue("@account_UserName", txt_account_UserName.Text);
                        com.Parameters.AddWithValue("@account_UserMobile", txt_account_UserMobile.Text);
                        com.Parameters.AddWithValue("@account_AllCities", cb_Ministry.Checked);
                        com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                        com.Parameters.AddWithValue("@account_AlmantiqaName_work", cb_Almantiqa.Checked); 
                        com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                        com.Parameters.AddWithValue("@account_CityName_work", cb_city.Checked);
                        com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);
                        com.Parameters.AddWithValue("@account_insert", cb_insert.Checked);
                        com.Parameters.AddWithValue("@account_update", cb_Edit.Checked);
                        com.Parameters.AddWithValue("@account_delete", cb_delete.Checked);
                        com.Parameters.AddWithValue("@account_admin", cb_admin.Checked);
                        com.Parameters.AddWithValue("@account_QuarryName_work", cb_Quarry.Checked);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("تم الحفظ بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        defulteEnabale();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }


                }
                else
                {
                    MessageBox.Show("فضلا قم بتعبئة جميع الحقول", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }

        }

        private void frm_users_Load(object sender, EventArgs e)
        {
            fill_lb_Almantiq();
            pic_first_Click(null, null);
        }

        private void cmb_account_CityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_lb_Quarry();
        }

        private void cmb_account_AlmantiqaName_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_lb_City();
        }




        int x = 0;
        private void pic_first_Click(object sender, EventArgs e)
        {
            try
            {

                x = 0;
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString;
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select * from tbl_account";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_AlmantiqaName=@account_AlmantiqaName";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_CityName=@account_CityName";
                }
                else
                {
                    comString = "select * from tbl_account where account_QuarryName=@account_QuarryName";
                }

                SqlCommand com = new SqlCommand(comString, con);
                com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);

                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_account_UserLoginName.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt.Rows[x][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt.Rows[x][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt.Rows[x][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt.Rows[x][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt.Rows[x][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt.Rows[x][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt.Rows[x][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt.Rows[x][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt.Rows[x][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt.Rows[x][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt.Rows[x][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt.Rows[x][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt.Rows[x][14]);


                }
                else
                {
                    ////-------1
                    txt_account_UserLoginName.Text = "";
                    ////-------2
                    txt_account_UserLoginPassword.Text = "";

                    ////-------3
                    txt_account_UserName.Text = "";

                    ////-------4
                    txt_account_UserMobile.Text = "";

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = -1;

                    ////-------6
                    cmb_account_CityName.SelectedIndex = -1;

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = -1;

                    ////-------8
                    cb_Ministry.Checked = false;

                    ////-------9
                    cb_Almantiqa.Checked = false;

                    ////-------10
                    cb_city.Checked = false;

                    ////-------11
                    cb_insert.Checked = false;

                    ////-------12
                    cb_Edit.Checked = false;

                    ////-------13
                    cb_delete.Checked = false;

                    ////-------14
                    cb_admin.Checked = false;

                    ////-------15
                    cb_Quarry.Checked = false;

                }
                defulteEnabale();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }



        }

        private void pic_previous_Click(object sender, EventArgs e)
        {
            try
            {


                x -= 1;
                if (x < 0)
                {
                    x = 0;
                    MessageBox.Show("لا توجد سجلات قبل هذا السجل");
                }

                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString;
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select * from tbl_account";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_AlmantiqaName=@account_AlmantiqaName";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_CityName=@account_CityName";
                }
                else
                {
                    comString = "select * from tbl_account where account_QuarryName=@account_QuarryName";
                }

                SqlCommand com = new SqlCommand(comString, con);
                com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_account_UserLoginName.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt.Rows[x][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt.Rows[x][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt.Rows[x][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt.Rows[x][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt.Rows[x][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt.Rows[x][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt.Rows[x][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt.Rows[x][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt.Rows[x][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt.Rows[x][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt.Rows[x][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt.Rows[x][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt.Rows[x][14]);

                }
                else
                {
                    ////-------1
                    txt_account_UserLoginName.Text = "";
                    ////-------2
                    txt_account_UserLoginPassword.Text = "";

                    ////-------3
                    txt_account_UserName.Text = "";

                    ////-------4
                    txt_account_UserMobile.Text = "";

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = -1;

                    ////-------6
                    cmb_account_CityName.SelectedIndex = -1;

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = -1;

                    ////-------8
                    cb_Ministry.Checked = false;

                    ////-------9
                    cb_Almantiqa.Checked = false;

                    ////-------10
                    cb_city.Checked = false;

                    ////-------11
                    cb_insert.Checked = false;

                    ////-------12
                    cb_Edit.Checked = false;

                    ////-------13
                    cb_delete.Checked = false;

                    ////-------14
                    cb_admin.Checked = false;

                    ////-------15
                    cb_Quarry.Checked = false;

                }
                defulteEnabale();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }


        private void pic_next_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString;
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select * from tbl_account";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_AlmantiqaName=@account_AlmantiqaName";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_CityName=@account_CityName";
                }
                else
                {
                    comString = "select * from tbl_account where account_QuarryName=@account_QuarryName";
                }

                SqlCommand com = new SqlCommand(comString, con);
                com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();

                x += 1;
                if (x > dt.Rows.Count - 1)
                {
                    x = dt.Rows.Count - 1;
                    MessageBox.Show("لا توجد سجلات بعد هذا السجل");
                }




                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_account_UserLoginName.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt.Rows[x][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt.Rows[x][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt.Rows[x][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt.Rows[x][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt.Rows[x][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt.Rows[x][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt.Rows[x][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt.Rows[x][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt.Rows[x][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt.Rows[x][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt.Rows[x][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt.Rows[x][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt.Rows[x][14]);

                }
                else
                {
                    ////-------1
                    txt_account_UserLoginName.Text = "";
                    ////-------2
                    txt_account_UserLoginPassword.Text = "";

                    ////-------3
                    txt_account_UserName.Text = "";

                    ////-------4
                    txt_account_UserMobile.Text = "";

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = -1;

                    ////-------6
                    cmb_account_CityName.SelectedIndex = -1;

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = -1;

                    ////-------8
                    cb_Ministry.Checked = false;

                    ////-------9
                    cb_Almantiqa.Checked = false;

                    ////-------10
                    cb_city.Checked = false;

                    ////-------11
                    cb_insert.Checked = false;

                    ////-------12
                    cb_Edit.Checked = false;

                    ////-------13
                    cb_delete.Checked = false;

                    ////-------14
                    cb_admin.Checked = false;

                    ////-------15
                    cb_Quarry.Checked = false;

                }
                defulteEnabale();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }


        private void pic_last_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString;
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select * from tbl_account";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_AlmantiqaName=@account_AlmantiqaName";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_CityName=@account_CityName";
                }
                else
                {
                    comString = "select * from tbl_account where account_QuarryName=@account_QuarryName";
                }

                SqlCommand com = new SqlCommand(comString, con);
                com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();

                x = dt.Rows.Count - 1;


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_account_UserLoginName.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt.Rows[x][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt.Rows[x][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt.Rows[x][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt.Rows[x][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt.Rows[x][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt.Rows[x][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt.Rows[x][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt.Rows[x][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt.Rows[x][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt.Rows[x][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt.Rows[x][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt.Rows[x][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt.Rows[x][14]);

                }
                else
                {
                    ////-------1
                    txt_account_UserLoginName.Text = "";
                    ////-------2
                    txt_account_UserLoginPassword.Text = "";

                    ////-------3
                    txt_account_UserName.Text = "";

                    ////-------4
                    txt_account_UserMobile.Text = "";

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = -1;

                    ////-------6
                    cmb_account_CityName.SelectedIndex = -1;

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = -1;

                    ////-------8
                    cb_Ministry.Checked = false;

                    ////-------9
                    cb_Almantiqa.Checked = false;

                    ////-------10
                    cb_city.Checked = false;

                    ////-------11
                    cb_insert.Checked = false;

                    ////-------12
                    cb_Edit.Checked = false;

                    ////-------13
                    cb_delete.Checked = false;

                    ////-------14
                    cb_admin.Checked = false;

                    ////-------15
                    cb_Quarry.Checked = false;

                }
                defulteEnabale();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }




        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (btn_search.Text == "نافذة البحث")
            {
                
                cmb_search.Items.Clear();
                btn_search.Text = "اغلاق نافذة البحث";
                panel4.Visible = true;
                cmb_search.Items.Add("اسم المستخدم");
                cmb_search.Items.Add("رقم الجوال");
                cmb_search.Items.Add("الاسم الكامل");
                cmb_search.SelectedIndex = 0;

            }
            else
            {
                panel4.Visible = false;
                btn_search.Text = "نافذة البحث";
            }
                 
        }
        DataTable dt99 = new DataTable();
        int xx = 0;

        private void btn_search2_Click(object sender, EventArgs e)
        {
            xx = 0;
            try
            {

                dt99.Rows.Clear();
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString;
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select * from tbl_account";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_AlmantiqaName=@account_AlmantiqaName";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select * from tbl_account where account_CityName=@account_CityName";
                }
                else
                {
                    comString = "select * from tbl_account where account_QuarryName=@account_QuarryName";
                }

                SqlCommand com = new SqlCommand(comString, con);
                com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);

                DataTable dt1 = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt1.Load(dr);
                con.Close();

                if (dt99.Columns.Count == 0)
                {
                    foreach (DataColumn dc in dt1.Columns)
                    {
                        dt99.Columns.Add(dc.ColumnName, dc.DataType);
                    }
                }



                DataRow[] drr = null;

                if (cmb_search.Text == "رقم الجوال")
                {

                    drr = dt1.Select("account_UserMobile='" + txt_search.Text + "'");
                }
                else if (cmb_search.Text == "اسم المستخدم")
                {
                    drr = dt1.Select("account_UserLoginName='" + txt_search.Text + "'");

                }
                else if (cmb_search.Text == "الاسم الكامل")
                {
                    drr = dt1.Select("account_UserName='" + txt_search.Text + "'");
                }
                else
                {
                    MessageBox.Show("فضلا قم بتحديد معيار البحث", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (DataRow d in drr)
                {
                    dt99.ImportRow(d);
                }

                if (dt99.Rows.Count == 0)
                {
                    lbl_rowsCount.Text = "0";
                    lbl_rowsCount_no.Text = "0";
                }
                else
                {
                    pic_search_previous_Click(null, null);
                    lbl_rowsCount.Text = dt99.Rows.Count.ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }



        }

        private void pic_search_previous_Click(object sender, EventArgs e)
        {
            try
            {

                if (xx != 0)
                {
                    xx -= 1;
                }
                if (xx < dt99.Rows.Count && xx >= 0)
                {
                    lbl_rowsCount.Text = dt99.Rows.Count.ToString();
                    lbl_rowsCount_no.Text = (xx + 1).ToString();

                    ////-------1
                    txt_account_UserLoginName.Text = dt99.Rows[xx][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt99.Rows[xx][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt99.Rows[xx][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt99.Rows[xx][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt99.Rows[xx][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt99.Rows[xx][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt99.Rows[xx][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt99.Rows[xx][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt99.Rows[xx][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt99.Rows[xx][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt99.Rows[xx][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt99.Rows[xx][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt99.Rows[xx][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt99.Rows[xx][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt99.Rows[x][14]);

                }
                else
                {
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //dt99.Rows.Clear();
                //cmb_search.SelectedIndex = 0;
                ////throw;
            }



        }

        private void pic_search_next_Click(object sender, EventArgs e)
        {
            try
            {

                if (xx < dt99.Rows.Count - 1)
                {
                    xx += 1;
                }

                if (xx < dt99.Rows.Count)
                {
                    lbl_rowsCount.Text = dt99.Rows.Count.ToString();
                    lbl_rowsCount_no.Text = (xx + 1).ToString();
                    ////-------1
                    txt_account_UserLoginName.Text = dt99.Rows[xx][0].ToString();
                    ////-------2
                    txt_account_UserLoginPassword.Text = dt99.Rows[xx][1].ToString();

                    ////-------3
                    txt_account_UserName.Text = dt99.Rows[xx][2].ToString();

                    ////-------4
                    txt_account_UserMobile.Text = dt99.Rows[xx][3].ToString();

                    ////-------5
                    cmb_account_AlmantiqaName.SelectedIndex = cmb_account_AlmantiqaName.FindStringExact(dt99.Rows[xx][5].ToString());

                    ////-------6
                    cmb_account_CityName.SelectedIndex = cmb_account_CityName.FindStringExact(dt99.Rows[xx][7].ToString());

                    ////-------7
                    cmb_account_QuarryName.SelectedIndex = cmb_account_QuarryName.FindStringExact(dt99.Rows[xx][9].ToString());

                    ////-------8
                    cb_Ministry.Checked = Convert.ToBoolean(dt99.Rows[xx][4]);

                    ////-------9
                    cb_Almantiqa.Checked = Convert.ToBoolean(dt99.Rows[xx][6]);

                    ////-------10
                    cb_city.Checked = Convert.ToBoolean(dt99.Rows[xx][8]);

                    ////-------11
                    cb_insert.Checked = Convert.ToBoolean(dt99.Rows[xx][10]);

                    ////-------12
                    cb_Edit.Checked = Convert.ToBoolean(dt99.Rows[xx][11]);

                    ////-------13
                    cb_delete.Checked = Convert.ToBoolean(dt99.Rows[xx][12]);

                    ////-------14
                    cb_admin.Checked = Convert.ToBoolean(dt99.Rows[xx][13]);

                    ////-------15
                    cb_Quarry.Checked = Convert.ToBoolean(dt99.Rows[x][14]);

                }
                else
                {
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                //dt99.Rows.Clear();
                //cmb_search.SelectedIndex = 0;

                ////throw;
            }



        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (btn_edit.Text == "وضع التعديل")
            {
                btn_edit.Text = "حفظ التعديلات";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    cb_Ministry.Enabled = true;
                    cb_Almantiqa.Enabled = true;
                    cb_city.Enabled = true;
                    cb_Quarry.Enabled = true;

                    cb_insert.Enabled = true;
                    cb_Edit.Enabled = true;
                    cb_delete.Enabled = true;
                    cb_admin.Enabled = true;

                    txt_account_UserLoginName.Enabled = false;
                    txt_account_UserLoginPassword.Enabled = false;
                    txt_account_UserMobile.Enabled = true;
                    txt_account_UserName.Enabled = true;
                    txt_search.Enabled = true;

                    cmb_account_AlmantiqaName.Enabled = true;
                    cmb_account_CityName.Enabled = true;
                    cmb_account_QuarryName.Enabled = true;


                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    if(cb_Ministry.Checked==false && cb_Almantiqa.Checked == false)
                    {
                        cb_Ministry.Enabled = false;
                        cb_Almantiqa.Enabled = false;
                        cb_city.Enabled = true;
                        cb_Quarry.Enabled = true;

                        cb_insert.Enabled = true;
                        cb_Edit.Enabled = true;
                        cb_delete.Enabled = true;
                        cb_admin.Enabled = true;

                        txt_account_UserLoginName.Enabled = false;
                        txt_account_UserLoginPassword.Enabled = false;
                        txt_account_UserMobile.Enabled = true;
                        txt_account_UserName.Enabled = true;
                        txt_search.Enabled = true;

                        cmb_account_AlmantiqaName.Enabled = true;
                        cmb_account_CityName.Enabled = true;
                        cmb_account_QuarryName.Enabled = true;
                    }
                    else
                    {
                        cb_Ministry.Enabled = false;
                        cb_Almantiqa.Enabled = false;
                        cb_city.Enabled = false;
                        cb_Quarry.Enabled = false;

                        cb_insert.Enabled = false;
                        cb_Edit.Enabled = false;
                        cb_delete.Enabled = false;
                        cb_admin.Enabled = false;

                        txt_account_UserLoginName.Enabled = false;
                        txt_account_UserLoginPassword.Enabled = false;
                        txt_account_UserMobile.Enabled = false;
                        txt_account_UserName.Enabled = false;
                        txt_search.Enabled = false;

                        cmb_account_AlmantiqaName.Enabled = false;
                        cmb_account_CityName.Enabled = false;
                        cmb_account_QuarryName.Enabled = false;
                    }


                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    if (cb_Ministry.Checked == false && cb_Almantiqa.Checked == false && cb_city.Checked == false)
                    {
                        cb_Ministry.Enabled = false;
                        cb_Almantiqa.Enabled = false;
                        cb_city.Enabled = false;
                        cb_Quarry.Enabled = true;

                        cb_insert.Enabled = true;
                        cb_Edit.Enabled = true;
                        cb_delete.Enabled = true;
                        cb_admin.Enabled = true;

                        txt_account_UserLoginName.Enabled = false;
                        txt_account_UserLoginPassword.Enabled = false;
                        txt_account_UserMobile.Enabled = true;
                        txt_account_UserName.Enabled = true;
                        txt_search.Enabled = true;

                        cmb_account_AlmantiqaName.Enabled = true;
                        cmb_account_CityName.Enabled = true;
                        cmb_account_QuarryName.Enabled = true;
                    }
                    else
                    {
                        cb_Ministry.Enabled = false;
                        cb_Almantiqa.Enabled = false;
                        cb_city.Enabled = false;
                        cb_Quarry.Enabled = false;

                        cb_insert.Enabled = false;
                        cb_Edit.Enabled = false;
                        cb_delete.Enabled = false;
                        cb_admin.Enabled = false;

                        txt_account_UserLoginName.Enabled = false;
                        txt_account_UserLoginPassword.Enabled = false;
                        txt_account_UserMobile.Enabled = false;
                        txt_account_UserName.Enabled = false;
                        txt_search.Enabled = false;

                        cmb_account_AlmantiqaName.Enabled = false;
                        cmb_account_CityName.Enabled = false;
                        cmb_account_QuarryName.Enabled = false;
                    }




                }
                else
                {
                    cb_Ministry.Enabled = false;
                    cb_Almantiqa.Enabled = false;
                    cb_city.Enabled = false;
                    cb_Quarry.Enabled = false;

                    cb_insert.Enabled = false;
                    cb_Edit.Enabled = false;
                    cb_delete.Enabled = false;
                    cb_admin.Enabled = false;

                    txt_account_UserLoginName.Enabled = false;
                    txt_account_UserLoginPassword.Enabled = false;
                    txt_account_UserMobile.Enabled = false;
                    txt_account_UserName.Enabled = false;
                    txt_search.Enabled = false;

                    cmb_account_AlmantiqaName.Enabled = false;
                    cmb_account_CityName.Enabled = false;
                    cmb_account_QuarryName.Enabled = false;
                }
            }
            else
            {
                try
                {

                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "  update tbl_account set account_UserName=@account_UserName,account_UserMobile=@account_UserMobile,account_AllCities=@account_AllCities,account_AlmantiqaName=@account_AlmantiqaName,account_AlmantiqaName_work=@account_AlmantiqaName_work,account_CityName=@account_CityName,account_CityName_work=@account_CityName_work,account_QuarryName=@account_QuarryName,account_insert=@account_insert,account_update=@account_update,account_delete=@account_delete,account_admin=@account_admin,account_QuarryName_work=@account_QuarryName_work where account_UserLoginName=@account_UserLoginName";
                    SqlCommand com = new SqlCommand(comString, con);

                    com.Parameters.AddWithValue("@account_UserLoginName", txt_account_UserLoginName.Text);
                    com.Parameters.AddWithValue("@account_UserName", txt_account_UserName.Text);
                    com.Parameters.AddWithValue("@account_UserMobile", txt_account_UserMobile.Text);
                    com.Parameters.AddWithValue("@account_AllCities", cb_Ministry.Checked);
                    com.Parameters.AddWithValue("@account_AlmantiqaName", cmb_account_AlmantiqaName.Text);
                    com.Parameters.AddWithValue("@account_AlmantiqaName_work", cb_Almantiqa.Checked); ;
                    com.Parameters.AddWithValue("@account_CityName", cmb_account_CityName.Text);
                    com.Parameters.AddWithValue("@account_CityName_work", cb_city.Checked);
                    com.Parameters.AddWithValue("@account_QuarryName", cmb_account_QuarryName.Text);
                    com.Parameters.AddWithValue("@account_insert", cb_insert.Checked);
                    com.Parameters.AddWithValue("@account_update", cb_Edit.Checked);
                    com.Parameters.AddWithValue("@account_delete", cb_delete.Checked);
                    com.Parameters.AddWithValue("@account_admin", cb_admin.Checked);
                    com.Parameters.AddWithValue("@account_QuarryName_work", cb_Quarry.Checked);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    btn_edit.Text = "وضع التعديل";
                    defulteEnabale();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }


            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("هل انت مأكد من رغبتك حذف هذا الحساب","تنبيه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                try
                {
                    defulteEnabale();
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "  delete from tbl_account where account_UserLoginName=@account_UserLoginName";
                    SqlCommand com = new SqlCommand(comString, con);
                    com.Parameters.AddWithValue("@account_UserLoginName", txt_account_UserLoginName.Text);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("تم الحذف بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pic_first_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }
            }
        }

        private void cmb_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_account_UserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9')
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void txt_account_UserMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_ministry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_account_AlmantiqaName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_account_CityName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_account_QuarryName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
