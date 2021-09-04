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
using System.Linq.Expressions;
using System.Xml.Resolvers;

namespace Quarantine_Program
{
    public partial class frm_QuestReport : Form
    {
        public frm_QuestReport()
        {
            InitializeComponent();
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
                ////throw;
            }




        }

        private void fill_lb_Quarry()
        {
            try
            {

                Quarry.Rows.Clear();
                cmb_Quarry.DataSource = null;
                cmb_Quarry.Items.Clear();


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
                        cmb_Quarry.DataSource = Quarry;
                        cmb_Quarry.DisplayMember = "Quarry_QuarryName";
                        cmb_Quarry.ValueMember = "Quarry_GeneralNo";
                    }

                    if (cmb_Quarry.Items.Count > 1)
                    {
                        cmb_Quarry.SelectedIndex = 1;
                        cmb_Quarry.SelectedIndex = 0;
                    }
                    else if (cmb_Quarry.Items.Count > 0)
                    {
                        cmb_Quarry.SelectedIndex = 0;
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
                    cmb_Quarry.DataSource = dt1;
                    cmb_Quarry.DisplayMember = "Quarry_QuarryName";
                    cmb_Quarry.ValueMember = "Quarry_GeneralNo";
                    con2.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }


        }


        private void frm_QuestReport_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            fill_lb_Almantiq();
            cmb_reportType.Items.AddRange(new string[] {"حركة دخول النزلاء بين تاريخين","حركة خروج النزلاء بين تاريخين","نزلاء تحت الحجر حاليا","جميع النزلاء الذين تم خروجهم" });
            cmb_reportType.SelectedIndex = 0;
            if(Program.userDt.Rows[0][4].ToString()=="True")
            {
                cmb_reportDomain.Items.Add("على مستودى الدولة");
                cmb_reportDomain.Items.Add("على مستودى المنطقة");
                cmb_reportDomain.Items.Add("على مستودى المدينة");
                cmb_reportDomain.Items.Add("على مستودى المحجر");
                cmb_reportDomain.SelectedIndex = 0;
            }
            else if(Program.userDt.Rows[0][6].ToString() == "True")
            {
                cmb_reportDomain.Items.Add("على مستودى المنطقة");
                cmb_reportDomain.Items.Add("على مستودى المدينة");
                cmb_reportDomain.Items.Add("على مستودى المحجر");
                cmb_reportDomain.SelectedIndex = 0;

            }
            else if(Program.userDt.Rows[0][8].ToString() == "True")
            {
                cmb_reportDomain.Items.Add("على مستودى المدينة");
                cmb_reportDomain.Items.Add("على مستودى المحجر");
                cmb_reportDomain.SelectedIndex = 0;
            }
            else
            {
                cmb_reportDomain.Items.Add("على مستودى المحجر");
                cmb_reportDomain.SelectedIndex = 0;
            }

            txt_firstDate.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
            txt_lastDate.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss tt").Replace("م", "pm").Replace("ص", "AM");
            
        }

        private void cmb_Almantiq_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_lb_City();
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            fill_lb_Quarry();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void btn_show_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                string xx = "";

                string conString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
                SqlConnection con2 = new SqlConnection(conString);
                string comString = "";
                SqlCommand com = new SqlCommand();
                com.Connection = con2;



                if (cmb_reportType.Text == "حركة دخول النزلاء بين تاريخين")
                {


                    if (cmb_reportDomain.Text == "على مستودى الدولة")
                    {
                        xx = "1";
                        comString = "  select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where DateTimeOfEntry between @DateTimeOfEntry1 and @DateTimeOfEntry2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المنطقة")
                    {
                        xx = "2";
                        comString = " select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = @Quarry_AlmantiqaName and DateTimeOfEntry between @DateTimeOfEntry1 and @DateTimeOfEntry2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المدينة")
                    {
                        xx = "3";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_CityName = @Quarry_CityName and DateTimeOfEntry between @DateTimeOfEntry1 and @DateTimeOfEntry2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المحجر")
                    {
                        xx = "4";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = @Quarry_QuarryName and DateTimeOfEntry between @DateTimeOfEntry1 and @DateTimeOfEntry2 ";
                    }


                }
                else if (cmb_reportType.Text == "حركة خروج النزلاء بين تاريخين")
                {
                    if (cmb_reportDomain.Text == "على مستودى الدولة")
                    {
                        xx = "5";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where DateTimeOfExit between @DateTimeOfExit1 and @DateTimeOfExit2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المنطقة")
                    {
                        xx = "6";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_AlmantiqaName = @Quarry_AlmantiqaName and DateTimeOfExit between @DateTimeOfExit1 and @DateTimeOfExit2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المدينة")
                    {
                        xx = "7";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit  where Quarry_CityName = @Quarry_CityName and DateTimeOfExit between @DateTimeOfExit1 and @DateTimeOfExit2 ";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المحجر")
                    {
                        xx = "8";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where Quarry_QuarryName = @Quarry_QuarryName and DateTimeOfExit between @DateTimeOfExit1 and @DateTimeOfExit2  ";
                    }
                }
                else if (cmb_reportType.Text == "نزلاء تحت الحجر حاليا")
                {
                    if (cmb_reportDomain.Text == "على مستودى الدولة")
                    {
                        xx = "9";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where  DateTimeOfExit = '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المنطقة")
                    {
                        xx = "10";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where  Quarry_AlmantiqaName = @Quarry_AlmantiqaName and DateTimeOfExit = '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المدينة")
                    {
                        xx = "11";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where   Quarry_CityName = @Quarry_CityName and DateTimeOfExit = '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المحجر")
                    {
                        xx = "12";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where   Quarry_QuarryName = @Quarry_QuarryName and DateTimeOfExit = '1900-01-01 00:00:00.000'";
                    }
                }
                else if (cmb_reportType.Text == "جميع النزلاء الذين تم خروجهم")
                {
                    if (cmb_reportDomain.Text == "على مستودى الدولة")
                    {
                        xx = "13";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where  DateTimeOfExit != '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المنطقة")
                    {
                        xx = "14";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where  Quarry_AlmantiqaName = @Quarry_AlmantiqaName and DateTimeOfExit != '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المدينة")
                    {
                        xx = "15";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where   Quarry_CityName = @Quarry_CityName and DateTimeOfExit != '1900-01-01 00:00:00.000'";
                    }
                    else if (cmb_reportDomain.Text == "على مستودى المحجر")
                    {
                        xx = "16";
                        comString = "select Quest_IdNo ,Quest_IdType ,Quest_Name , Quest_Nationality , Quest_DateOfBirth , age, Quest_Gender, Quest_FileNo  , ReservationNo,  DateTimeOfEntry,DateTimeOfExit, asdurationOfStay ,Room_no  ,Room_Floor ,Quarry_QuarryName ,Quarry_CityName ,Quarry_AlmantiqaName from EntryAndExit where   Quarry_QuarryName = @Quarry_QuarryName and DateTimeOfExit != '1900-01-01 00:00:00.000'";
                    }
                }

                com.CommandText = comString;

                string datetime1 = txt_firstDate.Text;
                string datetime2 = txt_lastDate.Text;

                string Almantiq = cmb_Almantiq.Text;
                string city = cmb_city.Text;
                string quarry = cmb_Quarry.Text;



                if (xx == "1")
                {
                    com.Parameters.AddWithValue("@DateTimeOfEntry1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfEntry2", datetime2);
                }
                else if (xx == "2")
                {
                    com.Parameters.AddWithValue("@DateTimeOfEntry1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfEntry2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_AlmantiqaName ", Almantiq);
                }
                else if (xx == "3")
                {
                    com.Parameters.AddWithValue("@DateTimeOfEntry1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfEntry2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_CityName", city);
                }
                else if (xx == "4")
                {
                    com.Parameters.AddWithValue("@DateTimeOfEntry1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfEntry2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_QuarryName", quarry);
                }
                else if (xx == "5")
                {
                    com.Parameters.AddWithValue("@DateTimeOfExit1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfExit2", datetime2);
                }
                else if (xx == "6")
                {
                    com.Parameters.AddWithValue("@DateTimeOfExit1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfExit2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_AlmantiqaName ", Almantiq);
                }
                else if (xx == "7")
                {
                    com.Parameters.AddWithValue("@DateTimeOfExit1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfExit2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_CityName", city);
                }
                else if (xx == "8")
                {
                    com.Parameters.AddWithValue("@DateTimeOfExit1", datetime1);
                    com.Parameters.AddWithValue("@DateTimeOfExit2", datetime2);
                    com.Parameters.AddWithValue("@Quarry_QuarryName", quarry);
                }
                else if (xx == "9")
                {

                }
                else if (xx == "10")
                {
                    com.Parameters.AddWithValue("@Quarry_AlmantiqaName ", Almantiq);
                }
                else if (xx == "11")
                {
                    com.Parameters.AddWithValue("@Quarry_CityName", city);
                }
                else if (xx == "12")
                {
                    com.Parameters.AddWithValue("@Quarry_QuarryName", quarry);
                }
                else if (xx == "13")
                {

                }
                else if (xx == "14")
                {
                    com.Parameters.AddWithValue("@Quarry_AlmantiqaName ", Almantiq);
                }
                else if (xx == "15")
                {
                    com.Parameters.AddWithValue("@Quarry_CityName", city);
                }
                else if (xx == "16")
                {
                    com.Parameters.AddWithValue("@Quarry_QuarryName", quarry);
                }

                con2.Open();
                dt.Load(com.ExecuteReader());
                con2.Close();


                //1900-01-01 00:00:00.000

                DataTable dt2 = new DataTable();
                int xxxx = -1;
                foreach(DataColumn dc in dt.Columns)
                {
                    xxxx++;
                    if(xxxx!=10)
                    {
                        dt2.Columns.Add(dc.ColumnName, dc.DataType);
                    }
                    else
                    {
                        dt2.Columns.Add(dc.ColumnName, typeof(string) );

                    }

                }


                for(int x = 0; x<dt.Rows.Count;x++)
                {
                    DataRow dr;
                    dr = dt2.NewRow();
                    if (dt.Rows[x][10].ToString()== "01/01/1900 12:00:00 ص")
                    {
                        dr[0] = dt.Rows[x][0].ToString();
                        dr[1] = dt.Rows[x][1].ToString();
                        dr[2] = dt.Rows[x][2].ToString();
                        dr[3] = dt.Rows[x][3].ToString();
                        dr[4] = dt.Rows[x][4].ToString();
                        dr[5] = dt.Rows[x][5].ToString();
                        dr[6] = dt.Rows[x][6].ToString();
                        dr[7] = dt.Rows[x][7].ToString();
                        dr[8] = dt.Rows[x][8].ToString();
                        dr[9] = dt.Rows[x][9].ToString();
                        dr[10] = "";
                        dr[11] = dt.Rows[x][11].ToString();
                        dr[12] = dt.Rows[x][12].ToString();
                        dr[13] = dt.Rows[x][13].ToString();
                        dr[14] = dt.Rows[x][14].ToString();
                        dr[15] = dt.Rows[x][15].ToString();
                        dr[16] = dt.Rows[x][16].ToString();
                        dt2.Rows.Add(dr);

                    }
                    else
                    {
                        dr[0] = dt.Rows[x][0].ToString();
                        dr[1] = dt.Rows[x][1].ToString();
                        dr[2] = dt.Rows[x][2].ToString();
                        dr[3] = dt.Rows[x][3].ToString();
                        dr[4] = dt.Rows[x][4].ToString();
                        dr[5] = dt.Rows[x][5].ToString();
                        dr[6] = dt.Rows[x][6].ToString();
                        dr[7] = dt.Rows[x][7].ToString();
                        dr[8] = dt.Rows[x][8].ToString();
                        dr[9] = dt.Rows[x][9].ToString();
                        dr[10] = dt.Rows[x][10].ToString();
                        dr[11] = dt.Rows[x][11].ToString();
                        dr[12] = dt.Rows[x][12].ToString();
                        dr[13] = dt.Rows[x][13].ToString();
                        dr[14] = dt.Rows[x][14].ToString();
                        dr[15] = dt.Rows[x][15].ToString();
                        dr[16] = dt.Rows[x][16].ToString();
                        dt2.Rows.Add(dr);
                    }
                }




                // ثالثا ربط الداتاتيبل بالكريستال ريبورت
                CrystalReport1 cr = new CrystalReport1();
                cr.SetDataSource(dt2);


                //  رابعا ربط مستعرض الكريستال ريبورت بالكريستال ريبورت وعرض الفورم
                frm_QuestReport frm = new frm_QuestReport();
                frm.crystalReportViewer1.ReportSource = cr;
                this.Hide();
                frm.ShowDialog();
                this.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ////throw;
            }



        }


        private void cmb_reportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_reportType.Text == "حركة دخول النزلاء بين تاريخين" || cmb_reportType.Text == "حركة خروج النزلاء بين تاريخين")
            {
                txt_firstDate.Visible = true;
                txt_lastDate.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                txt_firstDate.Visible = false;
                txt_lastDate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
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

        private void cmb_Quarry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_reportType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_reportDomain_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_firstDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0' || e.KeyChar == '1' || e.KeyChar == '2' || e.KeyChar == '3' || e.KeyChar == '4' || e.KeyChar == '5' || e.KeyChar == '6' || e.KeyChar == '7' || e.KeyChar == '8' || e.KeyChar == '9' || e.KeyChar == 'a' || e.KeyChar == 'A' || e.KeyChar == 'p' || e.KeyChar == 'P' || e.KeyChar == 'm' || e.KeyChar == 'M' || e.KeyChar == '/' || e.KeyChar == ':' || e.KeyChar == ' ' || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_lastDate_KeyPress(object sender, KeyPressEventArgs e)
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
