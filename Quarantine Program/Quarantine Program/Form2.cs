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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //********************************
        public DataTable Almantiq = new DataTable();
        public DataTable City = new DataTable();
        public DataTable Quarry = new DataTable();
        public DataTable Room = new DataTable();
        bool new_1 = false;
        private void defulteControlsEnabled()
        {
            cmb_Almantiq.Enabled = false;
            cmb_city.Enabled = false;
            cmb_Quarry_GeneralNo.Enabled = false;
        }


        private void fill_lb_Almantiq()
        {
            try
            {

                Almantiq.Rows.Clear();
                cmb_Almantiq.DataSource = null;
                cmb_Almantiq.Items.Clear();

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
                        cmb_Almantiq.DataSource = Almantiq;
                        cmb_Almantiq.DisplayMember = "Almantiq_name";
                        cmb_Almantiq.ValueMember = "Almantiq_no";
                    }
                    con.Close();

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

                if (cmb_Almantiq.Items.Count > 0)
                {


                    City.Rows.Clear();
                    cmb_city.DataSource = null;
                    cmb_city.Items.Clear();



                    if (Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
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
                cmb_Quarry_GeneralNo.DataSource = null;
                cmb_Quarry_GeneralNo.Items.Clear();


                if (Program.userDt.Rows[0][8].ToString() == "True" || Program.userDt.Rows[0][6].ToString() == "True" || Program.userDt.Rows[0][4].ToString() == "True")
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
                    cmb_Quarry_GeneralNo.DataSource = dt1;
                    cmb_Quarry_GeneralNo.DisplayMember = "Quarry_QuarryName";
                    cmb_Quarry_GeneralNo.ValueMember = "Quarry_GeneralNo";
                    con2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                /*throw*/
                ;
            }



        }

        //***************************

        private void Form2_Load(object sender, EventArgs e)
        {

            fill_lb_Almantiq();

            
        }

        private void cmb_Almantiq_SelectedIndexChanged(object sender, EventArgs e)
        {

            fill_lb_City();
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {

            fill_lb_Quarry();
           
        }

        private void cmb_Quarry_GeneralNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con = new SqlConnection(conString);
                string comString = "select * from View_Entry where Quarry_QuarryName = '" + cmb_Quarry_GeneralNo.Text + "'";
                SqlCommand com = new SqlCommand(comString, con);
                DataTable dt = new DataTable();
                con.Open();
                com.CommandText = comString;
                dt.Load(com.ExecuteReader());
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }

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



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int height = 50;
            for(int xx = 0;xx<dataGridView1.Rows.Count;xx++)
            {
                dataGridView1.Rows[xx].Height = height;
            }

            dataGridView1.Columns[0].HeaderText = "رقم هوية النزيل";
            dataGridView1.Columns[0].Width = 130;

            dataGridView1.Columns[1].HeaderText = "نوع الهوية";
            dataGridView1.Columns[1].Width = 180;

            dataGridView1.Columns[2].HeaderText = "اسم النزيل";
            dataGridView1.Columns[2].Width = 200;

            dataGridView1.Columns[3].HeaderText = "الجنسية";
            dataGridView1.Columns[3].Width = 180;

            dataGridView1.Columns[4].HeaderText = "تاريخ الميلاد";
            dataGridView1.Columns[4].Width = 130;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "yyyy/MM/dd";

            dataGridView1.Columns[5].HeaderText = "الجنس";
            dataGridView1.Columns[5].Width = 70;

            dataGridView1.Columns[6].HeaderText = "العمر عند دخول الحجر";
            dataGridView1.Columns[6].Width = 350;

            dataGridView1.Columns[7].HeaderText = "رقم الملف";
            dataGridView1.Columns[7].Width = 100;

            dataGridView1.Columns[8].HeaderText = "رقم الحجز";
            dataGridView1.Columns[8].Width = 100;

            dataGridView1.Columns[9].HeaderText = "تاريخ ووقت دخول الحجر";
            dataGridView1.Columns[9].Width = 200;
            dataGridView1.Columns[9].DefaultCellStyle.Format = " yyyy/MM/dd _ hh:mm tt";

            dataGridView1.Columns[10].HeaderText = "الرقم العام للغرفة";
            dataGridView1.Columns[10].Width = 80;

            dataGridView1.Columns[11].HeaderText = "رقم الغرفة الخاص";
            dataGridView1.Columns[11].Width = 80;

            dataGridView1.Columns[12].HeaderText = "الدور";
            dataGridView1.Columns[12].Width = 80;

            dataGridView1.Columns[13].HeaderText = "رقم المحجر";
            dataGridView1.Columns[13].Width = 80;

            dataGridView1.Columns[14].HeaderText = "اسم المحجر";
            dataGridView1.Columns[14].Width = 200;

            dataGridView1.Columns[15].HeaderText = "المدينة";
            dataGridView1.Columns[15].Width = 100;

            dataGridView1.Columns[16].HeaderText = "المنطقة";
            dataGridView1.Columns[16].Width = 150;

        }
    }
}
