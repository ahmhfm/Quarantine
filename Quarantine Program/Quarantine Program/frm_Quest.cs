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
    public partial class frm_Quest : Form
    {
        public frm_Quest()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------------------------------ الوضع الافتراضي لعناصر الشاشة
        private void defulte_ControlsEnabled()
        {
            lbl_warning.Text = "";
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_sarch.Enabled = true;
            txt_QuestDateOfBirth.Enabled = false;
            txt_QuestFileNo.Enabled = false;
            txt_QuestIdNo.Enabled = false;
            txt_QuestName.Enabled = false;
            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "وضع التعديل";
            btn_sarch.Text = "وضع البحث";
            cmb_QuestGender.SelectedIndex = 0;
            cmb_QuestIdType.SelectedIndex = 0;
            cmb_QuestNationality.SelectedIndex = 0;
            cmb_QuestGender.Enabled = false;
            cmb_QuestIdType.Enabled = false;
            cmb_QuestNationality.Enabled = false;
        }


        // ------------------------------------------------------------------------------------------ وضع عناصر الشاشة عند الضغط على زر وضع الاضافة
        private void Add_ControlsEnabled()
        {
            lbl_warning.Text = "";
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_sarch.Enabled = true;
            txt_QuestDateOfBirth.Enabled = true;
            txt_QuestFileNo.Enabled = true;
            txt_QuestIdNo.Enabled = true;
            txt_QuestName.Enabled = true;
            btn_add.Text = "إضافة نزيل";
            btn_edit.Text = "وضع التعديل";
            btn_sarch.Text = "وضع البحث";
            cmb_QuestGender.SelectedIndex = 0;
            cmb_QuestIdType.SelectedIndex = 0;
            cmb_QuestNationality.SelectedIndex = 0;
            cmb_QuestGender.Enabled = true;
            cmb_QuestIdType.Enabled = true;
            cmb_QuestNationality.Enabled = true;
            txt_QuestDateOfBirth.Clear();
            txt_QuestFileNo.Clear();
            txt_QuestIdNo.Clear();
            txt_QuestName.Clear();
        }

        // ------------------------------------------------------------------------------------------ وضع عناصر الشاشة عند الضغط على زر  التعديل
        private void Edit_ControlsEnabled()
        {
            lbl_warning.Text = "";
            btn_add.Enabled = false;
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_sarch.Enabled = true;
            txt_QuestDateOfBirth.Enabled = true;
            txt_QuestFileNo.Enabled = true;
            txt_QuestIdNo.Enabled = false;
            txt_QuestName.Enabled = true;
            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "حفظ التعديلات";
            btn_sarch.Text = "وضع البحث";
            cmb_QuestGender.Enabled = true;
            cmb_QuestIdType.Enabled = true;
            cmb_QuestNationality.Enabled = true;
        }


        // ------------------------------------------------------------------------------------------ وضع عناصر الشاشة عند الضغط على زر   وضع البحث

        private void Search_ControlsEnabled()
        {
            lbl_warning.Text = "";
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_sarch.Enabled = true;

            txt_QuestDateOfBirth.Enabled = false;
            txt_QuestDateOfBirth.Text="";

            txt_QuestFileNo.Enabled = false;
            txt_QuestFileNo.Text = "";

            txt_QuestIdNo.Enabled = true;
            txt_QuestIdNo.Text = "";
            txt_QuestIdNo.Focus();


            txt_QuestName.Enabled = false;
            txt_QuestName.Text = "";

            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "وضع التعديل";
            btn_sarch.Text = "بحث";

            cmb_QuestGender.SelectedIndex = -1;
            cmb_QuestIdType.SelectedIndex = -1;
            cmb_QuestNationality.SelectedIndex = -1;
            cmb_QuestGender.Enabled=false;
            cmb_QuestIdType.Enabled = false;
            cmb_QuestNationality.Enabled = false;
        }
        // ------------------------------------------------------------------------------------------ وضع عناصر الشاشة عند الضغط على زر  البحث 

        private void afterSearch_ControlsEnabled()
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = true;
            btn_edit.Enabled = true;
            btn_sarch.Enabled = true;
            txt_QuestDateOfBirth.Enabled = false;
            txt_QuestFileNo.Enabled = false;
            txt_QuestIdNo.Enabled = false;
            txt_QuestName.Enabled = false;
            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "وضع التعديل";
            btn_sarch.Text = "وضع البحث";

        }

        // ------------------------------------------------------------------------------------------ وضع عناصر الشاشة عند الضغط على زر الاضافة
        private void afterAdd_ControlsEnabled()
        {
            btn_add.Enabled = true;
            btn_delete.Enabled = false;
            btn_edit.Enabled = false;
            btn_sarch.Enabled = true;
            txt_QuestDateOfBirth.Enabled = false;
            txt_QuestFileNo.Enabled = false;
            txt_QuestIdNo.Enabled = false;
            txt_QuestName.Enabled = false;
            btn_add.Text = "وضع الإضافة";
            btn_edit.Text = "وضع التعديل";
            btn_sarch.Text = "وضع البحث";
            cmb_QuestGender.Enabled = false;
            cmb_QuestIdType.Enabled = false;
            cmb_QuestNationality.Enabled = false;

        }






        // ------------------------------------------------------------------------------------------ تحميل عناصر قائمة انواع الهوية
        private void load_IdTypeItimse()
        {
            try
            {

                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "select IdType_Arabic,IdType_Einglish from tbl_IdType";
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();

                con.Open();
                dt.Load(com.ExecuteReader());
                cmb_QuestIdType.DataSource = dt;
                cmb_QuestIdType.DisplayMember = "IdType_Arabic";
                cmb_QuestIdType.ValueMember = "IdType_Einglish";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }


        // ------------------------------------------------------------------------------------------ تحميل قائمة الجنسيات
        private void load_NationalityItimse()
        {
            try
            {
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "select Nationality_Arabic,Nationality_Einglish from tbl_Nationality";
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();

                con.Open();
                dt.Load(com.ExecuteReader());
                cmb_QuestNationality.DataSource = dt;
                cmb_QuestNationality.DisplayMember = "Nationality_Arabic";
                cmb_QuestNationality.ValueMember = "Nationality_Einglish";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }


        // ------------------------------------------------------------------------------------------ تحميل قائمة انواع الجنس
        private void load_GenderItimse()
        {
            cmb_QuestGender.Items.AddRange(new string[] { "ذكر", "انثى" });
            cmb_QuestGender.SelectedIndex = 0;
        }



        // ------------------------------------------------------------------------------------------ حدث تحميل الفورم 
        private void frm_Quest_Load(object sender, EventArgs e)
        {
            load_IdTypeItimse();
            load_NationalityItimse();
            load_GenderItimse();
            defulte_ControlsEnabled();
            pic_first_Click(null,null);
        }


        int x = 0;
        private void pic_first_Click(object sender, EventArgs e)
        {
            try
            {
                x = 0;
                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);

                //string comString = "select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo,dbo.FnCoputeDifferenceBetweenTwoDatesByDay(Quest_DateOfBirth,getdate()) as age from Tbl_Quest";
                string comString = "select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo as age from Tbl_Quest";


                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = cmb_QuestIdType.FindStringExact(dt.Rows[x][1].ToString());

                    ////-------3
                    txt_QuestName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    cmb_QuestNationality.SelectedIndex = cmb_QuestNationality.FindStringExact(dt.Rows[x][3].ToString());

                    ////-------5
                    txt_QuestDateOfBirth.Text = Convert.ToDateTime(dt.Rows[x][4]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------6
                    cmb_QuestGender.SelectedIndex = cmb_QuestGender.FindStringExact(dt.Rows[x][5].ToString());
                    ////-------7
                    txt_QuestFileNo.Text = dt.Rows[x][6].ToString();

                    lbl_warning.Text = "";

                }
                else
                {
                    ////-------1
                    txt_QuestIdNo.Text = "";
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = -1;
                    ////-------3
                    txt_QuestName.Text = "";
                    ////-------4
                    cmb_QuestNationality.SelectedIndex = -1;

                    ////-------5
                    txt_QuestDateOfBirth.Text = "";

                    ////-------6
                    cmb_QuestGender.SelectedIndex = -1;
                    ////-------7
                    txt_QuestFileNo.Text = "";

                }
                afterAdd_ControlsEnabled();
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
                string comString = "select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo as age from Tbl_Quest";
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                SqlDataReader dr = com.ExecuteReader();
                dt.Load(dr);
                con.Close();


                if (dt.Rows.Count > 0)
                {
                    ////-------1
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = cmb_QuestIdType.FindStringExact(dt.Rows[x][1].ToString());

                    ////-------3
                    txt_QuestName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    cmb_QuestNationality.SelectedIndex = cmb_QuestNationality.FindStringExact(dt.Rows[x][3].ToString());

                    ////-------5
                    txt_QuestDateOfBirth.Text = Convert.ToDateTime(dt.Rows[x][4]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------6
                    cmb_QuestGender.SelectedIndex = cmb_QuestGender.FindStringExact(dt.Rows[x][5].ToString());
                    ////-------7
                    txt_QuestFileNo.Text = dt.Rows[x][6].ToString();



                }
                else
                {
                    ////-------1
                    txt_QuestIdNo.Text = "";
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = -1;
                    ////-------3
                    txt_QuestName.Text = "";
                    ////-------4
                    cmb_QuestNationality.SelectedIndex = -1;

                    ////-------5
                    txt_QuestDateOfBirth.Text = "";

                    ////-------6
                    cmb_QuestGender.SelectedIndex = -1;
                    ////-------7
                    txt_QuestFileNo.Text = "";
                }
                lbl_warning.Text = "";
                afterAdd_ControlsEnabled();
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
                string comString = "select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo as age from Tbl_Quest";
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
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = cmb_QuestIdType.FindStringExact(dt.Rows[x][1].ToString());

                    ////-------3
                    txt_QuestName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    cmb_QuestNationality.SelectedIndex = cmb_QuestNationality.FindStringExact(dt.Rows[x][3].ToString());

                    ////-------5
                    txt_QuestDateOfBirth.Text = Convert.ToDateTime(dt.Rows[x][4]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------6
                    cmb_QuestGender.SelectedIndex = cmb_QuestGender.FindStringExact(dt.Rows[x][5].ToString());
                    ////-------7
                    txt_QuestFileNo.Text = dt.Rows[x][6].ToString();


                }
                else
                {
                    ////-------1
                    txt_QuestIdNo.Text = "";
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = -1;
                    ////-------3
                    txt_QuestName.Text = "";
                    ////-------4
                    cmb_QuestNationality.SelectedIndex = -1;

                    ////-------5
                    txt_QuestDateOfBirth.Text = "";

                    ////-------6
                    cmb_QuestGender.SelectedIndex = -1;
                    ////-------7
                    txt_QuestFileNo.Text = "";

                }
                lbl_warning.Text = "";
                afterAdd_ControlsEnabled();
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
                string comString = "select Quest_IdNo,Quest_IdType,Quest_Name,Quest_Nationality,Quest_DateOfBirth,Quest_Gender,Quest_FileNo as age from Tbl_Quest";
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
                    txt_QuestIdNo.Text = dt.Rows[x][0].ToString();
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = cmb_QuestIdType.FindStringExact(dt.Rows[x][1].ToString());

                    ////-------3
                    txt_QuestName.Text = dt.Rows[x][2].ToString();

                    ////-------4
                    cmb_QuestNationality.SelectedIndex = cmb_QuestNationality.FindStringExact(dt.Rows[x][3].ToString());

                    ////-------5
                    txt_QuestDateOfBirth.Text = Convert.ToDateTime(dt.Rows[x][4]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                    ////-------6
                    cmb_QuestGender.SelectedIndex = cmb_QuestGender.FindStringExact(dt.Rows[x][5].ToString());
                    ////-------7
                    txt_QuestFileNo.Text = dt.Rows[x][6].ToString();

                }
                else
                {
                    ////-------1
                    txt_QuestIdNo.Text = "";
                    ////-------2
                    cmb_QuestIdType.SelectedIndex = -1;
                    ////-------3
                    txt_QuestName.Text = "";
                    ////-------4
                    cmb_QuestNationality.SelectedIndex = -1;

                    ////-------5
                    txt_QuestDateOfBirth.Text = "";

                    ////-------6
                    cmb_QuestGender.SelectedIndex = -1;
                    ////-------7
                    txt_QuestFileNo.Text = "";
                }
                lbl_warning.Text = "";
                afterAdd_ControlsEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (Program.userDt.Rows[0][10].ToString() == "True")
            {

                if (btn_add.Text == "وضع الإضافة")
                {
                    Add_ControlsEnabled();
                }
                else
                {
                    try
                    {
                        if(txt_QuestDateOfBirth.Text!=string.Empty&& txt_QuestIdNo.Text != string.Empty &&txt_QuestName.Text != string.Empty )
                        {
                            string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                            SqlConnection con = new SqlConnection(conString);
                            string comString = "insert into Tbl_Quest values (@Quest_IdNo,@Quest_IdType,@Quest_Name,@Quest_Nationality,@Quest_DateOfBirth,@Quest_Gender,@Quest_FileNo)";
                            SqlCommand com = new SqlCommand(comString, con);
                            com.Parameters.AddWithValue("@Quest_IdNo", txt_QuestIdNo.Text);
                            com.Parameters.AddWithValue("@Quest_IdType", cmb_QuestIdType.Text);
                            com.Parameters.AddWithValue("@Quest_Name", txt_QuestName.Text);
                            com.Parameters.AddWithValue("@Quest_Nationality", cmb_QuestNationality.Text);
                            com.Parameters.AddWithValue("@Quest_DateOfBirth", txt_QuestDateOfBirth.Text);
                            com.Parameters.AddWithValue("@Quest_Gender", cmb_QuestGender.Text);
                            com.Parameters.AddWithValue("@Quest_FileNo", txt_QuestFileNo.Text);

                            con.Open();
                            com.ExecuteNonQuery();
                            con.Close();
                            afterAdd_ControlsEnabled();
                        }
                        else
                        {
                            MessageBox.Show("فضلاً قم بتعبئة جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //throw;
                    }
                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_sarch_Click(object sender, EventArgs e)
        {
            if (btn_sarch.Text == "وضع البحث")
            {
                Search_ControlsEnabled();
            }
            else
            {

                try
                {
                    if (txt_QuestIdNo.Text != string.Empty)
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        string comString = "select * from Tbl_Quest where Quest_IdNo=@Quest_IdNo ";
                        SqlCommand com = new SqlCommand(comString, con);
                        com.Parameters.AddWithValue("@Quest_IdNo", txt_QuestIdNo.Text);
                        DataTable dt = new DataTable();

                        con.Open();
                        dt.Load(com.ExecuteReader());
                        if (dt.Rows.Count > 0)
                        {
                            txt_QuestDateOfBirth.Text = Convert.ToDateTime(dt.Rows[0][4]).ToString("yyyy/MM/dd hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
                            txt_QuestFileNo.Text = dt.Rows[0][6].ToString();
                            txt_QuestIdNo.Text = dt.Rows[0][0].ToString();
                            txt_QuestName.Text = dt.Rows[0][2].ToString();
                            cmb_QuestGender.SelectedIndex = cmb_QuestGender.FindStringExact(dt.Rows[0][5].ToString());
                            cmb_QuestIdType.SelectedIndex = cmb_QuestIdType.FindStringExact(dt.Rows[0][1].ToString());
                            cmb_QuestNationality.SelectedIndex = cmb_QuestNationality.FindStringExact(dt.Rows[0][3].ToString());
                            afterSearch_ControlsEnabled();
                        }
                        else
                        {
                            MessageBox.Show("لم نجد نزيل بهذه البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                        con.Close();

                    }
                    else
                    {
                        MessageBox.Show("فضلاً قم بتسجيل رقم هوية النزيل", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //throw;
                }

            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {


            if (Program.userDt.Rows[0][11].ToString() == "True")
            {


                if (btn_edit.Text == "وضع التعديل")
                {
                    Edit_ControlsEnabled();
                }
                else
                {
                    try
                    {
                        string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con = new SqlConnection(conString);
                        string comString = "update  Tbl_Quest  set  Quest_IdType=@Quest_IdType,Quest_Name=@Quest_Name,Quest_Nationality=@Quest_Nationality,Quest_DateOfBirth=@Quest_DateOfBirth,Quest_Gender=@Quest_Gender,Quest_FileNo=@Quest_FileNo where Quest_IdNo=@Quest_IdNo ";
                        SqlCommand com = new SqlCommand(comString, con);
                        com.Parameters.AddWithValue("@Quest_IdNo", txt_QuestIdNo.Text);
                        com.Parameters.AddWithValue("@Quest_IdType", cmb_QuestIdType.Text);
                        com.Parameters.AddWithValue("@Quest_Name", txt_QuestName.Text);
                        com.Parameters.AddWithValue("@Quest_Nationality", cmb_QuestNationality.Text);
                        com.Parameters.AddWithValue("@Quest_DateOfBirth", txt_QuestDateOfBirth.Text);
                        com.Parameters.AddWithValue("@Quest_Gender", cmb_QuestGender.Text);
                        com.Parameters.AddWithValue("@Quest_FileNo", txt_QuestFileNo.Text);

                        con.Open();
                        com.ExecuteNonQuery();
                        con.Close();
                        defulte_ControlsEnabled();
                        lbl_warning.Text = "تم تعديل بيانات النزيل حامل الهوية رقم " + txt_QuestIdNo.Text + "بنجاح";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }

                }
            }
            else
            {
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (Program.userDt.Rows[0][12].ToString() == "True")
            {

                try
                {
                    string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                    SqlConnection con = new SqlConnection(conString);
                    string comString = "select * from View_Entry where Quest_IdNo=@Quest_IdNo";
                    SqlCommand com = new SqlCommand(comString, con);
                    com.Parameters.AddWithValue("@Quest_IdNo", txt_QuestIdNo.Text);
                    DataTable dt = new DataTable();

                    con.Open();
                    dt.Load(com.ExecuteReader());
                    con.Close();

                    if (dt.Rows.Count > 0)
                    {
                        lbl_warning.Text = "هذا النزيل لديه إقامة في الغرفة رقم" + dt.Rows[0][11] + "  في الدور رقم " + dt.Rows[0][12] + "  بمنطقة " + dt.Rows[0][16] + "  بمدينة " + dt.Rows[0][15] + "  بمحجر  " + dt.Rows[0][14];

                    }
                    else
                    {
                        string conString1 = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                        SqlConnection con1 = new SqlConnection(conString1);
                        string comString1 = "delete from Tbl_Quest where Quest_IdNo=@Quest_IdNo ";
                        SqlCommand com1 = new SqlCommand(comString1, con1);
                        com1.Parameters.AddWithValue("@Quest_IdNo", txt_QuestIdNo.Text);

                        con1.Open();
                        com1.ExecuteNonQuery();
                        con1.Close();

                        defulte_ControlsEnabled();
                        lbl_warning.Text = "تم حذف النزيل حامل الهوية رقم  " + txt_QuestIdNo.Text + "  بنجاح ";
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
                MessageBox.Show("فضلاً تواصل مع مدير النظام لمنحك صلاحية إستخدام هذه الوظيفة", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void txt_QuestIdNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar=='0'|| e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_QuestIdNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_QuestIdType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_QuestName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9')
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void cmb_QuestGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_QuestDateOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == 'a' || e.KeyChar == 'A' || e.KeyChar == 'p' || e.KeyChar == 'P' || e.KeyChar == 'm' || e.KeyChar == 'M' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == ' ' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void cmb_QuestNationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
            
        

    

