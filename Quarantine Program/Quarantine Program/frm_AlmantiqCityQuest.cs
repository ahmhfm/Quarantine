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
using System.Configuration;

namespace Quarantine_Program
{
    public partial class frm_AlmantiqCityQuest : Form
    {
        public frm_AlmantiqCityQuest()
        {
            InitializeComponent();
        }
        DataTable Almantiq = new DataTable();
        DataTable City = new DataTable();
        DataTable Quarry = new DataTable();
        DataTable Room = new DataTable();


        private void controlsEnabaldDefult()
        {
            if(Program.userDt.Rows[0][4].ToString() == "True")
            {
                btn_AlmantiqNew.Enabled = true;

            }
            else
            {
                btn_AlmantiqNew.Enabled = false;

            }
            btn_AlmantiqAdd.Enabled = false;
            btn_AlmantiqDelete.Enabled = false;
            btn_AlmantiqEdit.Enabled = false;
            txt_almantiq.Enabled = false;
            txt_almantiq.Clear();

            if(lb_Almantiq.Items.Count>0 && (Program.userDt.Rows[0][6].ToString()=="True"|| Program.userDt.Rows[0][4].ToString() == "True"))
            {
                btn_CityNew.Enabled = true;
            }
            else
            {
                btn_CityNew.Enabled = false;

            }
            btn_CityAdd.Enabled = false;
            btn_CityDelete.Enabled = false;
            btn_CityEdit.Enabled = false;
            txt_city.Enabled = false;
            txt_city.Clear();

            

            if(lb_city.Items.Count> 0 && (Program.userDt.Rows[0][8].ToString() == "True"|| Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True"))
            {
                btn_QuarryNew.Enabled = true;
            }
            else
            {
                btn_QuarryNew.Enabled = false;

            }
            btn_QuarryAdd.Enabled = false;
            btn_QuarryDelete.Enabled = false;
            btn_QuarryEdit.Enabled = false;
            txt_Quarry.Enabled = false;
            txt_Quarry.Clear();

            if(lb_Quarry.Items.Count> 0 && (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True"))
            {
                btn_newRoom.Enabled = true;
            }
            else
            {
                btn_newRoom.Enabled = false;

            }
            btn_AddRoom.Enabled = false;
            btn_DeleteRoom.Enabled = false;
            btn_EditRoom.Enabled = false;
            txt_Floor.Enabled = false;
            txt_room.Enabled = false;
            txt_room.Clear();
            txt_Floor.Enabled = false;
            txt_Floor.Clear();
        }

        private void fill_lb_Almantiq()
        {
            try
            {

                Almantiq.Rows.Clear();
                lb_Almantiq.DataSource = null;
                lb_Almantiq.Items.Clear();

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
                        lb_Almantiq.DataSource = Almantiq;
                        lb_Almantiq.DisplayMember = "Almantiq_name";
                        lb_Almantiq.ValueMember = "Almantiq_no";
                    }
                    con.Close();

                }
                else
                {
                    lb_Almantiq.Items.Add(Program.userDt.Rows[0][5].ToString());
                }

                if (lb_Almantiq.Items.Count > 1)
                {
                    lb_Almantiq.SelectedIndex = 1;
                    lb_Almantiq.SelectedIndex = 0;

                }
                else if (lb_Almantiq.Items.Count > 0)
                {
                    lb_Almantiq.SelectedIndex = 0;
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

                if (lb_Almantiq.Items.Count > 0)
                {


                    City.Rows.Clear();
                    lb_city.DataSource = null;
                    lb_city.Items.Clear();



                    if (Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con11 = new SqlConnection(conString);
                        string comString1 = "select city_name,City_no from tbl_city where city_Almantiqname = @city_Almantiqname";

                        SqlCommand com111 = new SqlCommand(comString1, con11);
                        com111.Parameters.AddWithValue("@city_Almantiqname", lb_Almantiq.Text);
                        con11.Open();
                        City.Load(com111.ExecuteReader());
                        Program.city = City;
                        con11.Close();

                        if (Program.city.Rows.Count > 0)
                        {
                            lb_city.DataSource = Program.city;
                            lb_city.DisplayMember = "city_name";
                            lb_city.ValueMember = "City_no";
                        }

                    }
                    else
                    {
                        lb_city.Items.Add(Program.userDt.Rows[0][7].ToString());
                    }

                }
                if (lb_city.Items.Count > 1)
                {
                    lb_city.SelectedIndex = 1;
                    lb_city.SelectedIndex = 0;
                }
                else if (lb_city.Items.Count > 0)
                {
                    lb_city.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }



        }

        private void fill_lb_Quarry()
        {
            try
            {

                Quarry.Rows.Clear();
                lb_Quarry.DataSource = null;
                lb_Quarry.Items.Clear();


                if (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con2 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con2;
                    con2.ConnectionString = conString;

                    comString = "select Quarry_GeneralNo,Quarry_QuarryName from tbl_Quarry where Quarry_CityName = '" + lb_city.Text + "'";
                    com.CommandText = comString;
                    con2.Open();
                    Quarry.Load(com.ExecuteReader());
                    Program.Quarry = Quarry;

                    con2.Close();


                    if (Program.Quarry.Rows.Count > 0)
                    {
                        lb_Quarry.DataSource = Quarry;
                        lb_Quarry.DisplayMember = "Quarry_QuarryName";
                        lb_Quarry.ValueMember = "Quarry_GeneralNo";
                    }

                    if (lb_Quarry.Items.Count > 1)
                    {
                        lb_Quarry.SelectedIndex = 1;
                        lb_Quarry.SelectedIndex = 0;
                    }
                    else if (lb_Quarry.Items.Count > 0)
                    {
                        lb_Quarry.SelectedIndex = 0;
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
                    lb_Quarry.DataSource = dt1;
                    lb_Quarry.DisplayMember = "Quarry_QuarryName";
                    lb_Quarry.ValueMember = "Quarry_GeneralNo";
                    con2.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

        }

        private void fill_lb_Room()
        {

            try
            {

                Room.Rows.Clear();
                lb_Room.DataSource = null;
                lb_Room.Items.Clear();



                if (lb_Quarry.Items.Count > 0 && lb_Quarry.SelectedValue != null)
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con3 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con3;


                    con3.ConnectionString = conString;

                    comString = "select Room_Floor,Room_no,Room_GeneralNo,'Floor '+Room_Floor+' /Room '+ Room_no as nameRoom from tbl_Room where Room_QuarryGeneralNo in ( select Quarry_GeneralNo from  tbl_Quarry where Quarry_QuarryName = '" + lb_Quarry.Text + "')";
                    com.CommandText = comString;
                    con3.Open();
                    Room.Load(com.ExecuteReader());
                    Program.Room = Room;
                    lb_Room.DataSource = Program.Room;
                    lb_Room.DisplayMember = "nameRoom";
                    lb_Room.ValueMember = "Room_Floor";
                    con3.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }

        private void frm_AlmantiqCityQuest_Load(object sender, EventArgs e)
        {

            fill_lb_Almantiq();
            controlsEnabaldDefult();
        }

        private void lb_Almantiq_SelectedIndexChanged(object sender, EventArgs e)
        {
                fill_lb_City();
            controlsEnabaldDefult();

        }

        private void btn_AlmantiqNew_Click(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][10].ToString() == "True")
            {
                controlsEnabaldDefult();
                txt_almantiq.Enabled = true;
                txt_almantiq.Clear();
                txt_almantiq.Focus();
                btn_AlmantiqAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }

        private void btn_AlmantiqAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("insert into tbl_Almantiq values (@txt_almantiq,'null')", con);
                com.Parameters.AddWithValue("@txt_almantiq", txt_almantiq.Text);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();

                fill_lb_Almantiq();
                controlsEnabaldDefult();
            }
            catch (Exception)
            {
                MessageBox.Show("تأكد من عدم تكرار القيمة او وجود مشكلة في الاتصال", "تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void btn_AlmantiqDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.userDt.Rows[0][12].ToString() == "True")
                {
                    if (lb_city.Items.Count == 0)
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        SqlCommand com = new SqlCommand("delete from tbl_Almantiq where Almantiq_name = @selectedvalue ", con);
                        com.Parameters.AddWithValue("@selectedvalue", lb_Almantiq.Text);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                        fill_lb_Almantiq();
                        controlsEnabaldDefult();
                    }
                    else
                    {
                        MessageBox.Show("فصلاً قم بحذف المدن أولاً", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                /*throw*/

            }

        }
        bool addCity = false;
        private void btn_CityNew_Click(object sender, EventArgs e)
        {

            if (Program.userDt.Rows[0][10].ToString() == "True")
            {
                if (lb_Almantiq.Items.Count > 0)
                {
                    controlsEnabaldDefult();
                    txt_city.Enabled = true;
                    btn_CityAdd.Enabled = true;
                    txt_city.Clear();
                    txt_city.Focus();
                    addCity = true;
                }
                else
                {
                    MessageBox.Show("تأكد من إختيار إختيار المنطقة التي ستتم إضافة المنطقة اليها", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            
        }

        private void lb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

            fill_lb_Quarry();
            controlsEnabaldDefult();
        }

        private void lb_Quarry_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlsEnabaldDefult();

            fill_lb_Room();

        }
        bool addQiarru = false;
        private void btn_QuarryNew_Click(object sender, EventArgs e)
        {
            if (Program.userDt.Rows[0][10].ToString() == "True")
            {
                if (lb_city.Items.Count > 0)
                {
                    controlsEnabaldDefult();
                    txt_Quarry.Enabled = true;
                    txt_Quarry.Clear();
                    txt_Quarry.Focus();
                    addQiarru = true;
                    btn_QuarryAdd.Enabled = true;

                }
                else
                {
                    MessageBox.Show("تأكد من إختيار مدينة لتتم إضافة المحجر الصحي إليها", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            


        }

        private void btn_CityAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(addCity==true)
                {
                    try
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        SqlCommand com = new SqlCommand("insert into tbl_city values (@city_name,@city_Almantiqname)", con);
                        com.Parameters.AddWithValue("@city_name", txt_city.Text);
                        com.Parameters.AddWithValue("@city_Almantiqname", lb_Almantiq.Text);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();

                        fill_lb_City();
                        addCity = false;
                        controlsEnabaldDefult();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }


                }
                else
                {
                    MessageBox.Show("فضلاً إختر جديد قبل محاولة الإضافة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("تأكد من عدم تكرار القيمة او وجود مشكلة في الاتصال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                /*throw*/;
            }


        }

        private void btn_AlmantiqEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.userDt.Rows[0][11].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("update tbl_Almantiq set Almantiq_name = @Almantiq_name where Almantiq_no= @Almantiq_no ", con);
                    com.Parameters.AddWithValue("@Almantiq_name", txt_almantiq.Text);
                    com.Parameters.AddWithValue("@Almantiq_no", lb_Almantiq.SelectedValue);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    fill_lb_Almantiq();
                    txt_almantiq.Text = lb_Almantiq.SelectedValue.ToString();
                    if (lb_Almantiq.Items.Count > 1)
                    {
                        lb_Almantiq.SelectedIndex = 1;
                        lb_Almantiq.SelectedIndex = 0;

                    }
                    controlsEnabaldDefult();
                }
                else
                {
                    MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

           
        }

        private void btn_CityEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.userDt.Rows[0][11].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("update tbl_city set city_name = @city_name where city_no =@city_no", con);
                    com.Parameters.AddWithValue("@city_name", txt_city.Text);
                    com.Parameters.AddWithValue("@city_no", lb_city.SelectedValue);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();

                    fill_lb_City();
                    controlsEnabaldDefult();
                }
                else
                {
                    MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

           
        }

        private void lb_Almantiq_DoubleClick(object sender, EventArgs e)
        {
            controlsEnabaldDefult();

            if(Program.userDt.Rows[0][4].ToString() == "True")
            {
                txt_almantiq.Text = lb_Almantiq.Text.ToString();
                txt_almantiq.Enabled = true;
                btn_AlmantiqEdit.Enabled = true;
                btn_AlmantiqDelete.Enabled = true;
            }



        }

        private void btn_CityDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (Program.userDt.Rows[0][12].ToString() == "True")
                {
                    if (lb_Quarry.Items.Count == 0)
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        SqlCommand com = new SqlCommand("delete from tbl_city where city_no =@city_no", con);
                        com.Parameters.AddWithValue("@city_no", lb_city.SelectedValue);
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        controlsEnabaldDefult();
                    }
                    else
                    {
                        MessageBox.Show("فضلاً قم بحذف المحاجر أولاً", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }


                    fill_lb_City();

                    btn_CityEdit.Enabled = false;
                    btn_CityDelete.Enabled = false;
                    txt_city.Enabled = false;
                }
                else
                {
                    MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }



            
        }

        private void lb_city_DoubleClick(object sender, EventArgs e)
        {
            controlsEnabaldDefult();

            if(Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
            {
                txt_city.Text = lb_city.Text.ToString();
                txt_city.Enabled = true;
                btn_CityEdit.Enabled = true;
                btn_CityDelete.Enabled = true;
            }

        }

        private void btn_QuarryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(addQiarru==true)
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("insert into tbl_Quarry values(@Quarry_QuarryName,@Quarry_CityName,@Quarry_AlmantiqaName);", con);
                    com.Parameters.AddWithValue("@Quarry_QuarryName", txt_Quarry.Text);
                    com.Parameters.AddWithValue("@Quarry_CityName", lb_city.Text);
                    com.Parameters.AddWithValue("@Quarry_AlmantiqaName", lb_Almantiq.Text);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    fill_lb_Quarry();
                    addQiarru = false;
                    controlsEnabaldDefult();
                }
                else
                {
                    MessageBox.Show("فضلاً إختر جديد قبل محاولة الإضافة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("تأكد من عدم وجود قيم مكررة او وجود مشكلة في الاتصال", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                /*throw*/
                ;
            }


        }

        private void btn_QuarryEdit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

            if (Program.userDt.Rows[0][11].ToString() == "True")
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                SqlCommand com = new SqlCommand("update tbl_Quarry set Quarry_QuarryName=@Quarry_QuarryName where Quarry_GeneralNo=@Quarry_GeneralNo ", con);
                com.Parameters.AddWithValue("@Quarry_QuarryName", txt_Quarry.Text);
                com.Parameters.AddWithValue("@Quarry_GeneralNo", lb_Quarry.SelectedValue);

                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                fill_lb_Quarry();

                controlsEnabaldDefult();
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void lb_Quarry_DoubleClick(object sender, EventArgs e)
        {
            controlsEnabaldDefult();

            if(Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
            {
                txt_Quarry.Text = lb_Quarry.Text;
                txt_Quarry.Enabled = true;
                btn_QuarryDelete.Enabled = true;
                btn_QuarryEdit.Enabled = true;
            }



        }

        private void btn_QuarryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (Program.userDt.Rows[0][12].ToString() == "True")
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("delete from tbl_Quarry where Quarry_GeneralNo=@Quarry_GeneralNo ", con);
                    com.Parameters.AddWithValue("@Quarry_GeneralNo", lb_Quarry.SelectedValue);

                    if (lb_Room.Items.Count == 0)
                    {
                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        fill_lb_Quarry();
                        controlsEnabaldDefult();
                    }
                    else
                    {
                        MessageBox.Show("فضلاً قم بحذف الغرف أولاً ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {


            if (Program.userDt.Rows[0][12].ToString() == "True")
            {

                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "delete from tbl_Room where Room_GeneralNo=@Room_GeneralNo";
                    SqlCommand com = new SqlCommand(comString, con);

                    com.Parameters.AddWithValue("@Room_GeneralNo", Room.Rows[lb_Room.SelectedIndex][2]);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    fill_lb_Room();
                    controlsEnabaldDefult();
                }
                catch (Exception)
                {
                    MessageBox.Show("تأكد من وجود اتصال وعدم وجود نزيل لم يتم تسجيل خروجه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    /*throw*/

                }

            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            //*********************



        }

        private void lb_Room_DoubleClick(object sender, EventArgs e)
        {
            controlsEnabaldDefult();
            if (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
            {
                txt_Floor.Text = Room.Rows[lb_Room.SelectedIndex][0].ToString();
                txt_room.Text = Room.Rows[lb_Room.SelectedIndex][1].ToString();
                btn_DeleteRoom.Enabled = true;
                btn_EditRoom.Enabled = true;
                txt_Floor.Enabled = true;
                txt_room.Enabled = true;
            }

        }

        private void btn_EditRoom_Click(object sender, EventArgs e)
        {
            if (Program.userDt.Rows[0][11].ToString() == "True")
            {
                try
                {

                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("update tbl_Room set Room_no=@Room_no,Room_Floor=@Room_Floor where Room_GeneralNo= @Room_GeneralNo ", con);
                    com.Parameters.AddWithValue("@Room_GeneralNo", Room.Rows[lb_Room.SelectedIndex][2]);
                    com.Parameters.AddWithValue("@Room_no", txt_room.Text);
                    com.Parameters.AddWithValue("@Room_Floor", txt_Floor.Text);
                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    fill_lb_Room();
                    controlsEnabaldDefult();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("تأكد من صحة الاتصال", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

           


           

        }

        private void lb_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlsEnabaldDefult();
        }

        bool addRoom = false;
        private void btn_newRoom_Click(object sender, EventArgs e)
        {

            if (Program.userDt.Rows[0][10].ToString() == "True")
            {
                if (lb_Quarry.Items.Count > 0)
                {
                    controlsEnabaldDefult();
                    txt_room.Enabled = true;
                    txt_room.Text = "";
                    txt_room.Focus();
                    txt_Floor.Text = "";
                    txt_Floor.Enabled = true;
                    addRoom = true;
                    btn_AddRoom.Enabled = true;
                }
                else
                {
                    MessageBox.Show("تأكد من إختيار محجر صحي لتتم إضافة الغرفة إليه", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (addRoom == true)
                {

                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    SqlCommand com = new SqlCommand("insert into tbl_Room values (@Room_QuarryGeneralNo,@Room_no,@Room_Floor)", con);
                    com.Parameters.AddWithValue("@Room_QuarryGeneralNo", lb_Quarry.SelectedValue);
                    com.Parameters.AddWithValue("@Room_no", txt_room.Text);
                    com.Parameters.AddWithValue("@Room_Floor", txt_Floor.Text);

                    con.Open();
                    com.ExecuteNonQuery();
                    con.Close();
                    fill_lb_Room();

                    controlsEnabaldDefult();
                    addRoom = false;
                }
                else
                {
                    MessageBox.Show("فضلاً إختر جديد قبل محاولة الإضافة", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
