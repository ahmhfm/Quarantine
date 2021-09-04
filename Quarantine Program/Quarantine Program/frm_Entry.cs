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
    public partial class frm_Entry : Form
    {
        public frm_Entry()
        {
            InitializeComponent();
        }

        public  DataTable Almantiq = new DataTable();
        public  DataTable City = new DataTable();
        public  DataTable Quarry = new DataTable();
        public  DataTable Room = new DataTable();
        bool new_1 = false;
        private void defulteControlsEnabled()
        {
            txt_EnterDateTime.Enabled = false;
            txt_ExitDateTime.Enabled = false;
            txt_QuestIdNo.Enabled = false;
            txt_ReservationNo.Enabled = false;
            cmb_Almantiq.Enabled = false;
            cmb_city.Enabled = false;
            cmb_Quarry_GeneralNo.Enabled = false;
            cmb_RoomGeneralNo.Enabled = false;
            btn_new.Enabled = true;
            btn_Enter.Enabled = false;
            btn_ExitQuest.Enabled = true;
            btn_sarch.Enabled = true;
            btn_Edit.Enabled = true;

            btn_Edit.Text = "وضع التعديل";
            btn_sarch.Text = "وضع البحث";
            btn_ExitQuest.Text = "وضع الخروج";
              
        }

        private void fill_lb_Almantiq()
        {

            Almantiq.Rows.Clear();
            cmb_Almantiq.DataSource = null;
            cmb_Almantiq.Items.Clear();

            if (Program.userDt.Rows[0][4].ToString() == "True")
            {
                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "select Almantiq_name,Almantiq_no from tbl_Almantiq";
                    SqlCommand com = new SqlCommand(comString, con);

                    con.Open();
                    Almantiq.Load(com.ExecuteReader());
                    if (Almantiq.Rows.Count > 0)
                    {
                        cmb_Almantiq.DataSource = Almantiq;
                        cmb_Almantiq.DisplayMember = "Almantiq_name";
                        cmb_Almantiq.ValueMember = "Almantiq_no";
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ////throw;
                }

            }
            else
            {
                cmb_Almantiq.Items.Add(Program.userDt.Rows[0][5].ToString());
            }

            if (cmb_Almantiq.Items.Count > 1)
            {
                cmb_Almantiq.SelectedIndex = 1;
                cmb_Almantiq.SelectedIndex = 0;

            }
            else if (cmb_Almantiq.Items.Count > 0)
            {
                cmb_Almantiq.SelectedIndex = 0;
            }
        }


        private void fill_lb_City()
        {

            if (cmb_Almantiq.Items.Count > 0)
            {


                City.Rows.Clear();
                cmb_city.DataSource = null;
                cmb_city.Items.Clear();



                if (Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
                {
                    try
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con11 = new SqlConnection(conString);
                        string comString1 = "select city_name,City_no from tbl_city where city_Almantiqname = @city_Almantiqname";

                        SqlCommand com111 = new SqlCommand(comString1, con11);
                        com111.Parameters.AddWithValue("@city_Almantiqname", cmb_Almantiq.Text);
                        con11.Open();
                        City.Load(com111.ExecuteReader());
                        Program.city = City;
                        con11.Close();

                        if (Program.city.Rows.Count > 0)
                        {
                            cmb_city.DataSource = Program.city;
                            cmb_city.DisplayMember = "city_name";
                            cmb_city.ValueMember = "City_no";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        //throw;
                    }



                }
                else
                {
                    cmb_city.Items.Add(Program.userDt.Rows[0][7].ToString());
                }

            }
            if (cmb_city.Items.Count > 1)
            {
                cmb_city.SelectedIndex = 1;
                cmb_city.SelectedIndex = 0;
            }
            else if (cmb_city.Items.Count > 0)
            {
                cmb_city.SelectedIndex = 0;
            }

        }

        private void fill_lb_Quarry()
        {

            Quarry.Rows.Clear();
            cmb_Quarry_GeneralNo.DataSource = null;
            cmb_Quarry_GeneralNo.Items.Clear();


            if (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
            {
                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con2 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con2;
                    con2.ConnectionString = conString;

                    comString = "select Quarry_GeneralNo,Quarry_QuarryName from tbl_Quarry where Quarry_CityName = '" + cmb_city.Text + "'";
                    com.CommandText = comString;
                    con2.Open();
                    Quarry.Load(com.ExecuteReader());
                    Program.Quarry = Quarry;

                    con2.Close();


                    if (Program.Quarry.Rows.Count > 0)
                    {
                        cmb_Quarry_GeneralNo.DataSource = Quarry;
                        cmb_Quarry_GeneralNo.DisplayMember = "Quarry_QuarryName";
                        cmb_Quarry_GeneralNo.ValueMember = "Quarry_GeneralNo";
                    }

                    if (cmb_Quarry_GeneralNo.Items.Count > 1)
                    {
                        cmb_Quarry_GeneralNo.SelectedIndex = 1;
                        cmb_Quarry_GeneralNo.SelectedIndex = 0;
                    }
                    else if (cmb_Quarry_GeneralNo.Items.Count > 0)
                    {
                        cmb_Quarry_GeneralNo.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }


            }
            else
            {
                try
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
                    cmb_Quarry_GeneralNo.DataSource = dt1;
                    cmb_Quarry_GeneralNo.DisplayMember = "Quarry_QuarryName";
                    cmb_Quarry_GeneralNo.ValueMember = "Quarry_GeneralNo";
                    con2.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

            }


        }

        private void fill_lb_Room()
        {


            Room.Rows.Clear();
            cmb_RoomGeneralNo.DataSource = null;
            cmb_RoomGeneralNo.Items.Clear();


            if (new_1==false)
            {
                if (cmb_Quarry_GeneralNo.Items.Count > 0 && cmb_Quarry_GeneralNo.SelectedValue != null)
                {
                    try
                    {

                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con3 = new SqlConnection(conString);
                        string comString;
                        SqlCommand com = new SqlCommand();
                        com.Connection = con3;


                        con3.ConnectionString = conString;

                        comString = "select Room_Floor,Room_no,Room_GeneralNo,'Floor '+Room_Floor+' /Room '+ Room_no as nameRoom from tbl_Room where Room_QuarryGeneralNo in ( select Quarry_GeneralNo from  tbl_Quarry where Quarry_QuarryName = '" + cmb_Quarry_GeneralNo.Text + "')";
                        com.CommandText = comString;
                        con3.Open();
                        Room.Load(com.ExecuteReader());
                        Program.Room = Room;
                        cmb_RoomGeneralNo.DataSource = Program.Room;
                        cmb_RoomGeneralNo.DisplayMember = "nameRoom";
                        cmb_RoomGeneralNo.ValueMember = "Room_GeneralNo";
                        con3.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        ////throw;
                    }

                }
            }
            else
            {
                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con3 = new SqlConnection(conString);
                    string comString;
                    SqlCommand com = new SqlCommand();
                    com.Connection = con3;


                    con3.ConnectionString = conString;

                    //comString = "select Room_GeneralNo,'Floor '+Room_Floor+' /Room '+ Room_no as nameRoom from tbl_Room where Room_QuarryGeneralNo in ( select Quarry_GeneralNo from  tbl_Quarry where Quarry_QuarryName = '" + cmb_Quarry_GeneralNo.Text + "')";
                    comString = "select Room_GeneralNo,'Floor '+Room_Floor+' /Room '+ Room_no as nameRoom from view_freeRooms where Quarry_GeneralNo in ( select Quarry_GeneralNo from  tbl_Quarry where Quarry_QuarryName = '" + cmb_Quarry_GeneralNo.Text + "')";
                    com.CommandText = comString;
                    con3.Open();
                    Room.Load(com.ExecuteReader());
                    Program.Room = Room;
                    cmb_RoomGeneralNo.DataSource = Program.Room;
                    cmb_RoomGeneralNo.DisplayMember = "nameRoom";
                    cmb_RoomGeneralNo.ValueMember = "Room_GeneralNo";
                    con3.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }


            }

        }


        private void frm_Entry_Load(object sender, EventArgs e)
        {

            fill_lb_Almantiq();



                 if (cmb_Almantiq.Items.Count > 0)  cmb_Almantiq.SelectedIndex = 0;
                 if (cmb_city.Items.Count > 0)  cmb_city.SelectedIndex = 0;
                 if(cmb_Quarry_GeneralNo.Items.Count>0)  cmb_Quarry_GeneralNo.SelectedIndex = 0;
                 if (cmb_RoomGeneralNo.Items.Count > 0) cmb_RoomGeneralNo.SelectedIndex = 0;

                 txt_EnterDateTime.Enabled = false;
                 txt_ExitDateTime.Enabled = false;
                 cmb_Almantiq.Enabled = false;
                 cmb_city.Enabled = false;
                 cmb_Quarry_GeneralNo.Enabled = false;
                 cmb_RoomGeneralNo.Enabled = false;
                 txt_QuestIdNo.Enabled = false;

                 pic_firest_Click(sender, e);
        }




        private void cmb_Almantiq_SelectedIndexChanged(object sender, EventArgs e)
        {

            fill_lb_City();

        }




        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            fill_lb_Quarry();

        }


        //bool roomForInsert = false;
        private void cmb_Quarry_GeneralNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            fill_lb_Room();

        }

        private void cmb_Almantiq_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_Quarry_GeneralNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_RoomGeneralNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        private void txt_ExitDateTime_DoubleClick(object sender, EventArgs e)
        {

            txt_ExitDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt").Replace("م", "pm").Replace("ص","AM");

            btn_ExitQuest.Enabled = true;

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {


            if (new_1)
            {
                if (txt_QuestIdNo.Text != string.Empty && txt_EnterDateTime.Text != string.Empty && cmb_Almantiq.SelectedIndex != -1 && cmb_city.SelectedIndex != -1 && cmb_Quarry_GeneralNo.SelectedIndex != -1 && cmb_RoomGeneralNo.SelectedIndex != -1)
                {
                    try
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con1 = new SqlConnection(conString);
                        string comString = "insert into Tbl_Entry values ('" + txt_QuestIdNo.Text + "'," + cmb_RoomGeneralNo.SelectedValue.ToString() + ",'" + txt_EnterDateTime.Text + "',null)";
                        SqlCommand com = new SqlCommand(comString, con1);
                        con1.Open();
                        com.ExecuteNonQuery();
                        con1.Close();

                        string conString4 = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con4 = new SqlConnection(conString4);
                        string comString4 = "select ident_current ('Tbl_Entry')";
                        SqlCommand com4 = new SqlCommand(comString4, con4);
                        DataTable dtt = new DataTable();
                        con4.Open();
                        dtt.Load(com4.ExecuteReader());
                        txt_ReservationNo.Text = dtt.Rows[0][0].ToString();
                        con4.Close();
                        dtt.Rows.Clear();



                        txt_QuestIdNo.Enabled = false;
                        txt_EnterDateTime.Enabled = false;
                        txt_ExitDateTime.Enabled = false;
                        cmb_Almantiq.Enabled = false;
                        cmb_city.Enabled = false;
                        cmb_Quarry_GeneralNo.Enabled = false;
                        cmb_RoomGeneralNo.Enabled = false;
                        new_1 = false;
                        btn_Enter.Enabled = false;
                        btn_Edit.Enabled = true;
                        btn_ExitQuest.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("رجاء تأكد من عدم تسجيلك لنزيل سابق بنفس رقم الهوية","تنبيه",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        //throw;
                    }
                }
                else
                {
                    MessageBox.Show("رجاء قم بتعبئة جميع الحقوق");
                }

            }


            //roomForInsert = false;


        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][10].ToString() == "True")
            {
                new_1 = true;
                defulteControlsEnabled();
                //roomForInsert = true;
                fill_lb_Room();


                txt_EnterDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                if (cmb_Almantiq.Items.Count > 0) cmb_Almantiq.SelectedIndex = 0;
                if (cmb_city.Items.Count > 0) cmb_city.SelectedIndex = 0;
                if (cmb_Quarry_GeneralNo.Items.Count > 0) cmb_Quarry_GeneralNo.SelectedIndex = 0;
                if (cmb_RoomGeneralNo.Items.Count > 0) cmb_RoomGeneralNo.SelectedIndex = 0;
                txt_QuestIdNo.Clear();
                txt_ReservationNo.Clear();
                txt_ExitDateTime.Clear();

                txt_QuestIdNo.Enabled = true;
                txt_EnterDateTime.Enabled = true;
                txt_ExitDateTime.Enabled = false;
                cmb_Almantiq.Enabled = true;
                cmb_city.Enabled = true;
                cmb_Quarry_GeneralNo.Enabled = true;
                cmb_RoomGeneralNo.Enabled = true;
                btn_Enter.Enabled = true;
                btn_Edit.Enabled = false;
                btn_ExitQuest.Enabled = false;

            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }


        public int returnIndexcombobox(ComboBox cmb, string itemName)
        {

            for (int x = 0; x < cmb.Items.Count; x++)
            {
                cmb.SelectedIndex = x;

                if (cmb.Text == itemName)
                {
                    return x;
                    break;
                }
            }
            return -1;
        }


        private void btn_sarch_Click(object sender, EventArgs e)
        {
            new_1 = false;
            if (btn_sarch.Text == "وضع البحث")
            {
                defulteControlsEnabled();
                btn_sarch.Text = "بحث";
                txt_QuestIdNo.Enabled = true;
                txt_QuestIdNo.Clear();

                txt_EnterDateTime.Enabled = false;
                txt_ExitDateTime.Enabled = false;
                cmb_Almantiq.Enabled = false;
                cmb_city.Enabled = false;
                cmb_Quarry_GeneralNo.Enabled = false;
                cmb_RoomGeneralNo.Enabled = false;

                //roomForInsert = false;
                txt_QuestIdNo.Focus();
            }
            else
            {
                btn_sarch.Text = "وضع البحث";

                txt_QuestIdNo.Enabled = false;

                try
                {

                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = " select * from View_Entry where Quest_IdNo='" + txt_QuestIdNo.Text.Trim() + "' ";
                    SqlCommand com = new SqlCommand(comString, con);
                    DataTable dt = new DataTable();
                    con.Open();
                    SqlDataReader dr = com.ExecuteReader();
                    dt.Load(dr);
                    con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        txt_QuestIdNo.Text = dt.Rows[0][0].ToString();
                        txt_ReservationNo.Text = dt.Rows[0][8].ToString();
                        txt_EnterDateTime.Text = Convert.ToDateTime(dt.Rows[0][9]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");

                        string almantiq1 = dt.Rows[0][16].ToString();
                        string city1 = dt.Rows[0][15].ToString();
                        string quarry1 = dt.Rows[0][14].ToString();
                        string room1 = "Floor " + dt.Rows[0][12].ToString() + " /Room " + dt.Rows[0][11].ToString();

                        int almantiqIndex = returnIndexcombobox(cmb_Almantiq, almantiq1);
                        int cityIndex = returnIndexcombobox(cmb_city, city1);
                        int quarryIndex = returnIndexcombobox(cmb_Quarry_GeneralNo, quarry1);
                        int roomIndex = returnIndexcombobox(cmb_RoomGeneralNo, room1);

                        cmb_Almantiq.SelectedIndex = almantiqIndex;
                        cmb_city.SelectedIndex = cityIndex;
                        cmb_Quarry_GeneralNo.SelectedIndex = quarryIndex;
                        cmb_RoomGeneralNo.SelectedIndex = roomIndex;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    ////throw;
                }

            }
        }



        int x=0;
        private void pic_firest_Click(object sender, EventArgs e)
        {
            try
            {

                new_1 = false;
                x = 0;
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                string comString = "";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select* from View_Entry";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_AlmantiqaName = '" + Program.userDt.Rows[0][5].ToString() + "'";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_CityName = '" + Program.userDt.Rows[0][7].ToString() + "'";
                }
                else
                {
                    comString = "select* from View_Entry where Quarry_QuarryName = '" + Program.userDt.Rows[0][9].ToString() + "'";
                }

                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_ReservationNo.Text = dt.Rows[x][8].ToString();
                    ////-------2
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------3
                    txt_EnterDateTime.Text = Convert.ToDateTime(dt.Rows[0][9]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------4
                    //cmb_Almantiq.SelectedIndex = returnIndexcombobox(cmb_Almantiq, dt.Rows[x][16].ToString());
                    cmb_Almantiq.SelectedIndex = cmb_Almantiq.FindStringExact(dt.Rows[x][16].ToString());
                    ////-------5
                    //cmb_city.SelectedIndex = returnIndexcombobox(cmb_city, dt.Rows[x][15].ToString());
                    cmb_city.SelectedIndex = cmb_city.FindStringExact(dt.Rows[x][15].ToString());
                    ////-------6
                    //cmb_Quarry_GeneralNo.SelectedIndex = returnIndexcombobox(cmb_Quarry_GeneralNo, dt.Rows[x][14].ToString());
                    cmb_Quarry_GeneralNo.SelectedIndex = cmb_Quarry_GeneralNo.FindStringExact(dt.Rows[x][14].ToString());

                    ////-------7
                    string room1 = "Floor " + dt.Rows[x][12].ToString() + " /Room " + dt.Rows[x][11].ToString();
                    //cmb_RoomGeneralNo.SelectedIndex = returnIndexcombobox(cmb_RoomGeneralNo, room1);
                    cmb_RoomGeneralNo.SelectedIndex = cmb_RoomGeneralNo.FindStringExact(room1);





                }
                else
                {
                    txt_ReservationNo.Text = "";
                    txt_QuestIdNo.Text = "";
                    txt_EnterDateTime.Text = "";
                    cmb_Almantiq.SelectedIndex = -1;
                    cmb_city.SelectedIndex = -1;
                    cmb_Quarry_GeneralNo.SelectedIndex = -1;
                    cmb_RoomGeneralNo.SelectedIndex = -1;
                }
                defulteControlsEnabled();
                btn_Edit.Enabled = true;
                btn_ExitQuest.Enabled = true;
                txt_ExitDateTime.Text = "";
                btn_ExitQuest.Text = "وضع الخروج";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

        }

        private void pic_previous_Click(object sender, EventArgs e)
        {
            try
            {

                new_1 = false;
                x -= 1;
                if (x < 0)
                {
                    x = 0;
                    MessageBox.Show("لا توجد سجلات قبل هذا السجل");
                }

                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select* from View_Entry";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_AlmantiqaName = '" + Program.userDt.Rows[0][5].ToString() + "'";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_CityName = '" + Program.userDt.Rows[0][7].ToString() + "'";
                }
                else
                {
                    comString = "select* from View_Entry where Quarry_QuarryName = '" + Program.userDt.Rows[0][9].ToString() + "'";
                }
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_ReservationNo.Text = dt.Rows[x][8].ToString();
                    ////-------2
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------3
                    txt_EnterDateTime.Text = Convert.ToDateTime(dt.Rows[0][9]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------4
                    //cmb_Almantiq.SelectedIndex = returnIndexcombobox(cmb_Almantiq, dt.Rows[x][16].ToString());
                    cmb_Almantiq.SelectedIndex = cmb_Almantiq.FindStringExact(dt.Rows[x][16].ToString());
                    ////-------5
                    //cmb_city.SelectedIndex = returnIndexcombobox(cmb_city, dt.Rows[x][15].ToString());
                    cmb_city.SelectedIndex = cmb_city.FindStringExact(dt.Rows[x][15].ToString());
                    ////-------6
                    //cmb_Quarry_GeneralNo.SelectedIndex = returnIndexcombobox(cmb_Quarry_GeneralNo, dt.Rows[x][14].ToString());
                    cmb_Quarry_GeneralNo.SelectedIndex = cmb_Quarry_GeneralNo.FindStringExact(dt.Rows[x][14].ToString());

                    ////-------7
                    string room1 = "Floor " + dt.Rows[x][12].ToString() + " /Room " + dt.Rows[x][11].ToString();
                    //cmb_RoomGeneralNo.SelectedIndex = returnIndexcombobox(cmb_RoomGeneralNo, room1);
                    cmb_RoomGeneralNo.SelectedIndex = cmb_RoomGeneralNo.FindStringExact(room1);

                }
                defulteControlsEnabled();
                btn_Edit.Enabled = true;
                btn_ExitQuest.Enabled = true;
                txt_ExitDateTime.Text = "";
                btn_ExitQuest.Text = "وضع الخروج";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }


        }

        private void pic_next_Click(object sender, EventArgs e)
        {
            try
            {
                new_1 = false;
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select* from View_Entry";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_AlmantiqaName = '" + Program.userDt.Rows[0][5].ToString() + "'";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_CityName = '" + Program.userDt.Rows[0][7].ToString() + "'";
                }
                else
                {
                    comString = "select* from View_Entry where Quarry_QuarryName = '" + Program.userDt.Rows[0][9].ToString() + "'";
                }
                SqlCommand com = new SqlCommand(comString, con);
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
                    txt_ReservationNo.Text = dt.Rows[x][8].ToString();
                    ////-------2
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------3
                    txt_EnterDateTime.Text = Convert.ToDateTime(dt.Rows[0][9]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------4
                    //cmb_Almantiq.SelectedIndex = returnIndexcombobox(cmb_Almantiq, dt.Rows[x][16].ToString());
                    cmb_Almantiq.SelectedIndex = cmb_Almantiq.FindStringExact(dt.Rows[x][16].ToString());
                    ////-------5
                    //cmb_city.SelectedIndex = returnIndexcombobox(cmb_city, dt.Rows[x][15].ToString());
                    cmb_city.SelectedIndex = cmb_city.FindStringExact(dt.Rows[x][15].ToString());
                    ////-------6
                    //cmb_Quarry_GeneralNo.SelectedIndex = returnIndexcombobox(cmb_Quarry_GeneralNo, dt.Rows[x][14].ToString());
                    cmb_Quarry_GeneralNo.SelectedIndex = cmb_Quarry_GeneralNo.FindStringExact(dt.Rows[x][14].ToString());

                    ////-------7
                    string room1 = "Floor " + dt.Rows[x][12].ToString() + " /Room " + dt.Rows[x][11].ToString();
                    //cmb_RoomGeneralNo.SelectedIndex = returnIndexcombobox(cmb_RoomGeneralNo, room1);
                    cmb_RoomGeneralNo.SelectedIndex = cmb_RoomGeneralNo.FindStringExact(room1);
                }
                defulteControlsEnabled();
                btn_Edit.Enabled = true;
                btn_ExitQuest.Enabled = true;
                txt_ExitDateTime.Text = "";
                btn_ExitQuest.Text = "وضع الخروج";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }


        }

        private void pic_last_Click(object sender, EventArgs e)
        {
            try
            {

                new_1 = false;
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "";
                if (Program.userDt.Rows[0][4].ToString() == "True")
                {
                    comString = "select* from View_Entry";
                }
                else if (Program.userDt.Rows[0][6].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_AlmantiqaName = '" + Program.userDt.Rows[0][5].ToString() + "'";
                }
                else if (Program.userDt.Rows[0][8].ToString() == "True")
                {
                    comString = "select* from View_Entry where Quarry_CityName = '" + Program.userDt.Rows[0][7].ToString() + "'";
                }
                else
                {
                    comString = "select* from View_Entry where Quarry_QuarryName = '" + Program.userDt.Rows[0][9].ToString() + "'";
                }
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();

                x = dt.Rows.Count - 1;

                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_ReservationNo.Text = dt.Rows[x][8].ToString();
                    ////-------2
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------3
                    txt_EnterDateTime.Text = Convert.ToDateTime(dt.Rows[0][9]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------4
                    //cmb_Almantiq.SelectedIndex = returnIndexcombobox(cmb_Almantiq, dt.Rows[x][16].ToString());
                    cmb_Almantiq.SelectedIndex = cmb_Almantiq.FindStringExact(dt.Rows[x][16].ToString());
                    ////-------5
                    //cmb_city.SelectedIndex = returnIndexcombobox(cmb_city, dt.Rows[x][15].ToString());
                    cmb_city.SelectedIndex = cmb_city.FindStringExact(dt.Rows[x][15].ToString());
                    ////-------6
                    //cmb_Quarry_GeneralNo.SelectedIndex = returnIndexcombobox(cmb_Quarry_GeneralNo, dt.Rows[x][14].ToString());
                    cmb_Quarry_GeneralNo.SelectedIndex = cmb_Quarry_GeneralNo.FindStringExact(dt.Rows[x][14].ToString());

                    ////-------7
                    string room1 = "Floor " + dt.Rows[x][12].ToString() + " /Room " + dt.Rows[x][11].ToString();
                    //cmb_RoomGeneralNo.SelectedIndex = returnIndexcombobox(cmb_RoomGeneralNo, room1);
                    cmb_RoomGeneralNo.SelectedIndex = cmb_RoomGeneralNo.FindStringExact(room1);
                }
                defulteControlsEnabled();
                btn_Edit.Enabled = true;
                btn_ExitQuest.Enabled = true;
                txt_ExitDateTime.Text = "";
                btn_ExitQuest.Text = "وضع الخروج";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

        }

        private void btn_ExitQuest_Click(object sender, EventArgs e)
        {
            if(Program.userDt.Rows[0][12].ToString() == "True")
            {
                if (txt_QuestIdNo.Text != string.Empty)
                {


                    if (btn_ExitQuest.Text == "وضع الخروج")
                    {
                        defulteControlsEnabled();

                        txt_ExitDateTime.Enabled = true;
                        btn_ExitQuest.Enabled = false;
                        btn_ExitQuest.Text = "تسجيل الخروج";
                    }
                    else
                    {
                        try
                        {
                            string conString5 = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                            SqlConnection con5 = new SqlConnection(conString5);
                            string comString5 = "update Tbl_Entry set Entry_DateTimeOfExit = '" + txt_ExitDateTime.Text + "'  where Entry_ReservationNo= " + txt_ReservationNo.Text;
                            SqlCommand com5 = new SqlCommand(comString5, con5);
                            con5.Open();
                            com5.ExecuteNonQuery();
                            con5.Close();


                            string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                            SqlConnection con = new SqlConnection(conString);
                            string comString = "delete from Tbl_Entry where Entry_ReservationNo= " + txt_ReservationNo.Text;
                            SqlCommand com = new SqlCommand(comString, con);
                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();

                            pic_firest_Click(null, null);
                            txt_ExitDateTime.Enabled = false;
                            txt_ExitDateTime.Clear();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            //throw;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("رجاء قم بتحديد سجل النزيل المراد تسجيل خروجه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            new_1 = false;
            if (Program.userDt.Rows[0][11].ToString()=="True")
            {
                if(txt_QuestIdNo.Text!=string.Empty)
                {
                    if (btn_Edit.Text == "وضع التعديل")
                    {
                        defulteControlsEnabled();

                        btn_Edit.Text = "إعتماد التعديلات";

                        txt_QuestIdNo.Enabled = true;
                        txt_EnterDateTime.Enabled = true;
                        txt_ExitDateTime.Enabled = false;
                        cmb_Almantiq.Enabled = true;
                        cmb_city.Enabled = true;
                        cmb_Quarry_GeneralNo.Enabled = true;
                        cmb_RoomGeneralNo.Enabled = true;

                    }
                    else
                    {
                        try
                        {
                            string conString5 = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                            SqlConnection con5 = new SqlConnection(conString5);
                            string comString5 = "update Tbl_Entry set Entry_QuestIdNo = @Entry_QuestIdNo , Entry_RoomGeneralNo = @Entry_RoomGeneralNo ,Entry_DateTimeOfEntry = @Entry_DateTimeOfEntry  where Entry_ReservationNo= @Entry_ReservationNo";
                            SqlCommand com5 = new SqlCommand(comString5, con5);
                            com5.Parameters.AddWithValue("@Entry_QuestIdNo", txt_QuestIdNo.Text);
                            com5.Parameters.AddWithValue("@Entry_RoomGeneralNo", cmb_RoomGeneralNo.SelectedValue);
                            com5.Parameters.AddWithValue("@Entry_DateTimeOfEntry", txt_EnterDateTime.Text);
                            com5.Parameters.AddWithValue("@Entry_ReservationNo", txt_ReservationNo.Text);


                            con5.Open();
                            com5.ExecuteNonQuery();
                            con5.Close();
                            btn_Edit.Text = "وضع التعديل";

                            txt_QuestIdNo.Enabled = false;
                            txt_EnterDateTime.Enabled = false;
                            txt_ExitDateTime.Enabled = false;
                            cmb_Almantiq.Enabled = false;
                            cmb_city.Enabled = false;
                            cmb_Quarry_GeneralNo.Enabled = false;
                            cmb_RoomGeneralNo.Enabled = false;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("فضلاً تأكد من أن الغرفة المختارة غير مشغولة وأنه لم يتم إدخال هذا المريض سابقا", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            //throw;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("فضلاً قم بتحديد السجل المراد التعديل عليه", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_RoomGeneralNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_QuestIdNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_EnterDateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == 'a' || e.KeyChar == 'A' || e.KeyChar == 'p' || e.KeyChar == 'P' || e.KeyChar == 'm' || e.KeyChar == 'M' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == ' ' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_ExitDateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == 'a' || e.KeyChar == 'A' || e.KeyChar == 'p' || e.KeyChar == 'P' || e.KeyChar == 'm' || e.KeyChar == 'M' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == ' ' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
