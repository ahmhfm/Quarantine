namespace Quarantine_Program
{
    partial class frm_users
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bic_last = new System.Windows.Forms.PictureBox();
            this.bic_next = new System.Windows.Forms.PictureBox();
            this.bic_previous = new System.Windows.Forms.PictureBox();
            this.bic_first = new System.Windows.Forms.PictureBox();
            this.cb_Ministry = new System.Windows.Forms.CheckBox();
            this.cb_Almantiqa = new System.Windows.Forms.CheckBox();
            this.cb_city = new System.Windows.Forms.CheckBox();
            this.cmb_ministry = new System.Windows.Forms.ComboBox();
            this.cmb_account_AlmantiqaName = new System.Windows.Forms.ComboBox();
            this.cmb_account_CityName = new System.Windows.Forms.ComboBox();
            this.cmb_account_QuarryName = new System.Windows.Forms.ComboBox();
            this.txt_account_UserLoginName = new System.Windows.Forms.TextBox();
            this.txt_account_UserLoginPassword = new System.Windows.Forms.TextBox();
            this.txt_account_UserName = new System.Windows.Forms.TextBox();
            this.txt_account_UserMobile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_admin = new System.Windows.Forms.CheckBox();
            this.cb_insert = new System.Windows.Forms.CheckBox();
            this.cb_Edit = new System.Windows.Forms.CheckBox();
            this.cb_delete = new System.Windows.Forms.CheckBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_rowsCount_no = new System.Windows.Forms.Label();
            this.lbl_rowsCount = new System.Windows.Forms.Label();
            this.pic_search_next = new System.Windows.Forms.PictureBox();
            this.pic_search_previous = new System.Windows.Forms.PictureBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_search2 = new System.Windows.Forms.Button();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            this.cb_Quarry = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bic_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_first)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_previous)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 178);
            this.panel1.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Impact", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(234, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(465, 46);
            this.label9.TabIndex = 0;
            this.label9.Text = "حسابات المستخدمين وصلاحياتهم";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.bic_last);
            this.panel2.Controls.Add(this.bic_next);
            this.panel2.Controls.Add(this.bic_previous);
            this.panel2.Controls.Add(this.bic_first);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 621);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 178);
            this.panel2.TabIndex = 1;
            // 
            // bic_last
            // 
            this.bic_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bic_last.Image = global::Quarantine_Program.Properties.Resources.iconfinder_backward_back_arrow_previous_left_4593199;
            this.bic_last.Location = new System.Drawing.Point(211, 51);
            this.bic_last.Name = "bic_last";
            this.bic_last.Size = new System.Drawing.Size(100, 76);
            this.bic_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bic_last.TabIndex = 3;
            this.bic_last.TabStop = false;
            this.bic_last.Click += new System.EventHandler(this.pic_last_Click);
            this.bic_last.DoubleClick += new System.EventHandler(this.pic_last_Click);
            // 
            // bic_next
            // 
            this.bic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bic_next.Image = global::Quarantine_Program.Properties.Resources.iconfinder_previous_arrow_back_left_music_4593162;
            this.bic_next.Location = new System.Drawing.Point(346, 51);
            this.bic_next.Name = "bic_next";
            this.bic_next.Size = new System.Drawing.Size(100, 76);
            this.bic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bic_next.TabIndex = 2;
            this.bic_next.TabStop = false;
            this.bic_next.Click += new System.EventHandler(this.pic_next_Click);
            this.bic_next.DoubleClick += new System.EventHandler(this.pic_next_Click);
            // 
            // bic_previous
            // 
            this.bic_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bic_previous.Image = global::Quarantine_Program.Properties.Resources.iconfinder_next_music_player_play_media_4593176;
            this.bic_previous.Location = new System.Drawing.Point(492, 51);
            this.bic_previous.Name = "bic_previous";
            this.bic_previous.Size = new System.Drawing.Size(100, 76);
            this.bic_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bic_previous.TabIndex = 1;
            this.bic_previous.TabStop = false;
            this.bic_previous.Click += new System.EventHandler(this.pic_previous_Click);
            this.bic_previous.DoubleClick += new System.EventHandler(this.pic_previous_Click);
            // 
            // bic_first
            // 
            this.bic_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bic_first.Image = global::Quarantine_Program.Properties.Resources.iconfinder_forward_arrow_next_right_direction_4593180;
            this.bic_first.Location = new System.Drawing.Point(622, 51);
            this.bic_first.Name = "bic_first";
            this.bic_first.Size = new System.Drawing.Size(100, 76);
            this.bic_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bic_first.TabIndex = 0;
            this.bic_first.TabStop = false;
            this.bic_first.Click += new System.EventHandler(this.pic_first_Click);
            this.bic_first.DoubleClick += new System.EventHandler(this.pic_first_Click);
            // 
            // cb_Ministry
            // 
            this.cb_Ministry.AutoSize = true;
            this.cb_Ministry.Enabled = false;
            this.cb_Ministry.Location = new System.Drawing.Point(389, 346);
            this.cb_Ministry.Name = "cb_Ministry";
            this.cb_Ministry.Size = new System.Drawing.Size(123, 28);
            this.cb_Ministry.TabIndex = 5;
            this.cb_Ministry.Text = "مشرف بالوزارة";
            this.cb_Ministry.UseVisualStyleBackColor = true;
            this.cb_Ministry.Click += new System.EventHandler(this.checkBox_Ministry_Click);
            // 
            // cb_Almantiqa
            // 
            this.cb_Almantiqa.AutoSize = true;
            this.cb_Almantiqa.Enabled = false;
            this.cb_Almantiqa.Location = new System.Drawing.Point(389, 383);
            this.cb_Almantiqa.Name = "cb_Almantiqa";
            this.cb_Almantiqa.Size = new System.Drawing.Size(123, 28);
            this.cb_Almantiqa.TabIndex = 6;
            this.cb_Almantiqa.Text = "مشرف بالمنطقة";
            this.cb_Almantiqa.UseVisualStyleBackColor = true;
            this.cb_Almantiqa.Click += new System.EventHandler(this.checkBox_Almantiqa_Click);
            // 
            // cb_city
            // 
            this.cb_city.AutoSize = true;
            this.cb_city.Enabled = false;
            this.cb_city.Location = new System.Drawing.Point(389, 418);
            this.cb_city.Name = "cb_city";
            this.cb_city.Size = new System.Drawing.Size(118, 28);
            this.cb_city.TabIndex = 7;
            this.cb_city.Text = "مشرف بالمدينة";
            this.cb_city.UseVisualStyleBackColor = true;
            this.cb_city.Click += new System.EventHandler(this.checkBoxcity_Click);
            // 
            // cmb_ministry
            // 
            this.cmb_ministry.Enabled = false;
            this.cmb_ministry.FormattingEnabled = true;
            this.cmb_ministry.Location = new System.Drawing.Point(163, 341);
            this.cmb_ministry.Name = "cmb_ministry";
            this.cmb_ministry.Size = new System.Drawing.Size(220, 32);
            this.cmb_ministry.TabIndex = 10;
            this.cmb_ministry.Text = "وزارة الصحة";
            this.cmb_ministry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_ministry_KeyPress);
            // 
            // cmb_account_AlmantiqaName
            // 
            this.cmb_account_AlmantiqaName.Enabled = false;
            this.cmb_account_AlmantiqaName.FormattingEnabled = true;
            this.cmb_account_AlmantiqaName.Location = new System.Drawing.Point(163, 377);
            this.cmb_account_AlmantiqaName.Name = "cmb_account_AlmantiqaName";
            this.cmb_account_AlmantiqaName.Size = new System.Drawing.Size(220, 32);
            this.cmb_account_AlmantiqaName.TabIndex = 11;
            this.cmb_account_AlmantiqaName.SelectedIndexChanged += new System.EventHandler(this.cmb_account_AlmantiqaName_SelectedIndexChanged);
            this.cmb_account_AlmantiqaName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_account_AlmantiqaName_KeyPress);
            // 
            // cmb_account_CityName
            // 
            this.cmb_account_CityName.Enabled = false;
            this.cmb_account_CityName.FormattingEnabled = true;
            this.cmb_account_CityName.Location = new System.Drawing.Point(163, 413);
            this.cmb_account_CityName.Name = "cmb_account_CityName";
            this.cmb_account_CityName.Size = new System.Drawing.Size(220, 32);
            this.cmb_account_CityName.TabIndex = 12;
            this.cmb_account_CityName.SelectedIndexChanged += new System.EventHandler(this.cmb_account_CityName_SelectedIndexChanged);
            this.cmb_account_CityName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_account_CityName_KeyPress);
            // 
            // cmb_account_QuarryName
            // 
            this.cmb_account_QuarryName.Enabled = false;
            this.cmb_account_QuarryName.FormattingEnabled = true;
            this.cmb_account_QuarryName.Location = new System.Drawing.Point(163, 449);
            this.cmb_account_QuarryName.Name = "cmb_account_QuarryName";
            this.cmb_account_QuarryName.Size = new System.Drawing.Size(220, 32);
            this.cmb_account_QuarryName.TabIndex = 13;
            this.cmb_account_QuarryName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_account_QuarryName_KeyPress);
            // 
            // txt_account_UserLoginName
            // 
            this.txt_account_UserLoginName.Enabled = false;
            this.txt_account_UserLoginName.Location = new System.Drawing.Point(163, 209);
            this.txt_account_UserLoginName.Name = "txt_account_UserLoginName";
            this.txt_account_UserLoginName.Size = new System.Drawing.Size(388, 29);
            this.txt_account_UserLoginName.TabIndex = 14;
            // 
            // txt_account_UserLoginPassword
            // 
            this.txt_account_UserLoginPassword.Enabled = false;
            this.txt_account_UserLoginPassword.Location = new System.Drawing.Point(163, 242);
            this.txt_account_UserLoginPassword.Name = "txt_account_UserLoginPassword";
            this.txt_account_UserLoginPassword.Size = new System.Drawing.Size(388, 29);
            this.txt_account_UserLoginPassword.TabIndex = 15;
            this.txt_account_UserLoginPassword.UseSystemPasswordChar = true;
            // 
            // txt_account_UserName
            // 
            this.txt_account_UserName.Enabled = false;
            this.txt_account_UserName.Location = new System.Drawing.Point(163, 275);
            this.txt_account_UserName.Name = "txt_account_UserName";
            this.txt_account_UserName.Size = new System.Drawing.Size(388, 29);
            this.txt_account_UserName.TabIndex = 16;
            this.txt_account_UserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_account_UserName_KeyPress);
            // 
            // txt_account_UserMobile
            // 
            this.txt_account_UserMobile.Enabled = false;
            this.txt_account_UserMobile.Location = new System.Drawing.Point(163, 308);
            this.txt_account_UserMobile.Name = "txt_account_UserMobile";
            this.txt_account_UserMobile.Size = new System.Drawing.Size(388, 29);
            this.txt_account_UserMobile.TabIndex = 17;
            this.txt_account_UserMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_account_UserMobile_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(34, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "اسم المستخدم :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(34, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "كلمة المرور :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(34, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "الإسم كاملا :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(34, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "رقم الجوال :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(34, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "الوزارة :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(34, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 31);
            this.label6.TabIndex = 23;
            this.label6.Text = "المنطقة :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Location = new System.Drawing.Point(34, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "المدينة :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Location = new System.Drawing.Point(34, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 31);
            this.label8.TabIndex = 25;
            this.label8.Text = "المحجر الصحي :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.cb_admin);
            this.panel3.Controls.Add(this.cb_insert);
            this.panel3.Controls.Add(this.cb_Edit);
            this.panel3.Controls.Add(this.cb_delete);
            this.panel3.Location = new System.Drawing.Point(34, 487);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 62);
            this.panel3.TabIndex = 27;
            // 
            // cb_admin
            // 
            this.cb_admin.AutoSize = true;
            this.cb_admin.Enabled = false;
            this.cb_admin.Location = new System.Drawing.Point(17, 15);
            this.cb_admin.Name = "cb_admin";
            this.cb_admin.Size = new System.Drawing.Size(110, 28);
            this.cb_admin.TabIndex = 13;
            this.cb_admin.Text = "ادارة البرنامج";
            this.cb_admin.UseVisualStyleBackColor = true;
            // 
            // cb_insert
            // 
            this.cb_insert.AutoSize = true;
            this.cb_insert.Enabled = false;
            this.cb_insert.Location = new System.Drawing.Point(424, 15);
            this.cb_insert.Name = "cb_insert";
            this.cb_insert.Size = new System.Drawing.Size(75, 28);
            this.cb_insert.TabIndex = 10;
            this.cb_insert.Text = "الإضافة";
            this.cb_insert.UseVisualStyleBackColor = true;
            // 
            // cb_Edit
            // 
            this.cb_Edit.AutoSize = true;
            this.cb_Edit.Enabled = false;
            this.cb_Edit.Location = new System.Drawing.Point(296, 15);
            this.cb_Edit.Name = "cb_Edit";
            this.cb_Edit.Size = new System.Drawing.Size(62, 28);
            this.cb_Edit.TabIndex = 11;
            this.cb_Edit.Text = "تعديل";
            this.cb_Edit.UseVisualStyleBackColor = true;
            // 
            // cb_delete
            // 
            this.cb_delete.AutoSize = true;
            this.cb_delete.Enabled = false;
            this.cb_delete.Location = new System.Drawing.Point(170, 15);
            this.cb_delete.Name = "cb_delete";
            this.cb_delete.Size = new System.Drawing.Size(60, 28);
            this.cb_delete.TabIndex = 12;
            this.cb_delete.Text = "حذف";
            this.cb_delete.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(36, 559);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 38);
            this.btn_add.TabIndex = 28;
            this.btn_add.Text = "وضع الإضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(216, 559);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 38);
            this.btn_edit.TabIndex = 29;
            this.btn_edit.Text = "وضع التعديل";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(396, 559);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 38);
            this.btn_delete.TabIndex = 30;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(585, 209);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(309, 38);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "نافذة البحث";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.lbl_rowsCount_no);
            this.panel4.Controls.Add(this.lbl_rowsCount);
            this.panel4.Controls.Add(this.pic_search_next);
            this.panel4.Controls.Add(this.pic_search_previous);
            this.panel4.Controls.Add(this.txt_search);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.btn_search2);
            this.panel4.Controls.Add(this.cmb_search);
            this.panel4.Location = new System.Drawing.Point(585, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(309, 217);
            this.panel4.TabIndex = 32;
            this.panel4.Visible = false;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkBlue;
            this.label12.Location = new System.Drawing.Point(139, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 33);
            this.label12.TabIndex = 40;
            this.label12.Text = "من";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rowsCount_no
            // 
            this.lbl_rowsCount_no.BackColor = System.Drawing.Color.DarkBlue;
            this.lbl_rowsCount_no.Location = new System.Drawing.Point(176, 160);
            this.lbl_rowsCount_no.Name = "lbl_rowsCount_no";
            this.lbl_rowsCount_no.Size = new System.Drawing.Size(40, 33);
            this.lbl_rowsCount_no.TabIndex = 39;
            this.lbl_rowsCount_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rowsCount
            // 
            this.lbl_rowsCount.BackColor = System.Drawing.Color.DarkBlue;
            this.lbl_rowsCount.Location = new System.Drawing.Point(93, 160);
            this.lbl_rowsCount.Name = "lbl_rowsCount";
            this.lbl_rowsCount.Size = new System.Drawing.Size(40, 33);
            this.lbl_rowsCount.TabIndex = 38;
            this.lbl_rowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_search_next
            // 
            this.pic_search_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_search_next.Image = global::Quarantine_Program.Properties.Resources.A_0٨;
            this.pic_search_next.Location = new System.Drawing.Point(13, 154);
            this.pic_search_next.Name = "pic_search_next";
            this.pic_search_next.Size = new System.Drawing.Size(74, 49);
            this.pic_search_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search_next.TabIndex = 37;
            this.pic_search_next.TabStop = false;
            this.pic_search_next.Click += new System.EventHandler(this.pic_search_next_Click);
            this.pic_search_next.DoubleClick += new System.EventHandler(this.pic_search_next_Click);
            // 
            // pic_search_previous
            // 
            this.pic_search_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_search_previous.Image = global::Quarantine_Program.Properties.Resources.A_0٧;
            this.pic_search_previous.Location = new System.Drawing.Point(219, 154);
            this.pic_search_previous.Name = "pic_search_previous";
            this.pic_search_previous.Size = new System.Drawing.Size(74, 49);
            this.pic_search_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_search_previous.TabIndex = 36;
            this.pic_search_previous.TabStop = false;
            this.pic_search_previous.Click += new System.EventHandler(this.pic_search_previous_Click);
            this.pic_search_previous.DoubleClick += new System.EventHandler(this.pic_search_previous_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(13, 69);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(171, 29);
            this.txt_search.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.Location = new System.Drawing.Point(190, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 31);
            this.label11.TabIndex = 34;
            this.label11.Text = "بحث عن :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.RoyalBlue;
            this.label10.Location = new System.Drawing.Point(190, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 31);
            this.label10.TabIndex = 33;
            this.label10.Text = "معيار البحث :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_search2
            // 
            this.btn_search2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search2.Location = new System.Drawing.Point(13, 110);
            this.btn_search2.Name = "btn_search2";
            this.btn_search2.Size = new System.Drawing.Size(280, 37);
            this.btn_search2.TabIndex = 32;
            this.btn_search2.Text = "بحث";
            this.btn_search2.UseVisualStyleBackColor = true;
            this.btn_search2.Click += new System.EventHandler(this.btn_search2_Click);
            // 
            // cmb_search
            // 
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(13, 20);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(171, 32);
            this.cmb_search.TabIndex = 0;
            this.cmb_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_search_KeyPress);
            // 
            // cb_Quarry
            // 
            this.cb_Quarry.AutoSize = true;
            this.cb_Quarry.Enabled = false;
            this.cb_Quarry.Location = new System.Drawing.Point(389, 453);
            this.cb_Quarry.Name = "cb_Quarry";
            this.cb_Quarry.Size = new System.Drawing.Size(162, 28);
            this.cb_Quarry.TabIndex = 26;
            this.cb_Quarry.Text = "يعمل بالمحجر الصحي";
            this.cb_Quarry.UseVisualStyleBackColor = true;
            this.cb_Quarry.Click += new System.EventHandler(this.checkBox_Quarry_Click);
            // 
            // frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(932, 799);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cb_Quarry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_account_UserMobile);
            this.Controls.Add(this.txt_account_UserName);
            this.Controls.Add(this.txt_account_UserLoginPassword);
            this.Controls.Add(this.txt_account_UserLoginName);
            this.Controls.Add(this.cmb_account_QuarryName);
            this.Controls.Add(this.cmb_account_CityName);
            this.Controls.Add(this.cmb_account_AlmantiqaName);
            this.Controls.Add(this.cmb_ministry);
            this.Controls.Add(this.cb_city);
            this.Controls.Add(this.cb_Almantiqa);
            this.Controls.Add(this.cb_Ministry);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_users";
            this.Load += new System.EventHandler(this.frm_users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bic_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bic_first)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_search_previous)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cb_Ministry;
        private System.Windows.Forms.CheckBox cb_Almantiqa;
        private System.Windows.Forms.CheckBox cb_city;
        private System.Windows.Forms.ComboBox cmb_ministry;
        private System.Windows.Forms.ComboBox cmb_account_AlmantiqaName;
        private System.Windows.Forms.ComboBox cmb_account_CityName;
        private System.Windows.Forms.ComboBox cmb_account_QuarryName;
        private System.Windows.Forms.TextBox txt_account_UserLoginName;
        private System.Windows.Forms.TextBox txt_account_UserLoginPassword;
        private System.Windows.Forms.TextBox txt_account_UserName;
        private System.Windows.Forms.TextBox txt_account_UserMobile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cb_admin;
        private System.Windows.Forms.CheckBox cb_insert;
        private System.Windows.Forms.CheckBox cb_Edit;
        private System.Windows.Forms.CheckBox cb_delete;
        private System.Windows.Forms.PictureBox bic_last;
        private System.Windows.Forms.PictureBox bic_next;
        private System.Windows.Forms.PictureBox bic_previous;
        private System.Windows.Forms.PictureBox bic_first;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_search2;
        private System.Windows.Forms.ComboBox cmb_search;
        private System.Windows.Forms.PictureBox pic_search_next;
        private System.Windows.Forms.PictureBox pic_search_previous;
        private System.Windows.Forms.Label lbl_rowsCount;
        private System.Windows.Forms.Label lbl_rowsCount_no;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cb_Quarry;
    }
}