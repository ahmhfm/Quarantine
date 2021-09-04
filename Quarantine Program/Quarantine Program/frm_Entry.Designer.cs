namespace Quarantine_Program
{
    partial class frm_Entry
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
            this.txt_ReservationNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_QuestIdNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_RoomGeneralNo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ExitDateTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_EnterDateTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic_last = new System.Windows.Forms.PictureBox();
            this.pic_previous = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_firest = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_ExitQuest = new System.Windows.Forms.Button();
            this.btn_sarch = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Almantiq = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Quarry_GeneralNo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_firest)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_ReservationNo
            // 
            this.txt_ReservationNo.Enabled = false;
            this.txt_ReservationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ReservationNo.Location = new System.Drawing.Point(324, 208);
            this.txt_ReservationNo.Name = "txt_ReservationNo";
            this.txt_ReservationNo.Size = new System.Drawing.Size(522, 41);
            this.txt_ReservationNo.TabIndex = 8;
            this.txt_ReservationNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 41);
            this.label2.TabIndex = 10;
            this.label2.Text = "رقـــــم الحــجـــز :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_QuestIdNo
            // 
            this.txt_QuestIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_QuestIdNo.Location = new System.Drawing.Point(324, 255);
            this.txt_QuestIdNo.Name = "txt_QuestIdNo";
            this.txt_QuestIdNo.Size = new System.Drawing.Size(522, 41);
            this.txt_QuestIdNo.TabIndex = 11;
            this.txt_QuestIdNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_QuestIdNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuestIdNo_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 41);
            this.label1.TabIndex = 12;
            this.label1.Text = "رقـــم هوية النزيل :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_RoomGeneralNo
            // 
            this.cmb_RoomGeneralNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_RoomGeneralNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_RoomGeneralNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RoomGeneralNo.FormattingEnabled = true;
            this.cmb_RoomGeneralNo.Location = new System.Drawing.Point(324, 443);
            this.cmb_RoomGeneralNo.Name = "cmb_RoomGeneralNo";
            this.cmb_RoomGeneralNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_RoomGeneralNo.Size = new System.Drawing.Size(522, 41);
            this.cmb_RoomGeneralNo.TabIndex = 13;
            this.cmb_RoomGeneralNo.SelectedIndexChanged += new System.EventHandler(this.cmb_RoomGeneralNo_SelectedIndexChanged);
            this.cmb_RoomGeneralNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_RoomGeneralNo_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 41);
            this.label3.TabIndex = 14;
            this.label3.Text = "رقـــــم الغـــرفـــة :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ExitDateTime
            // 
            this.txt_ExitDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ExitDateTime.Location = new System.Drawing.Point(324, 537);
            this.txt_ExitDateTime.Name = "txt_ExitDateTime";
            this.txt_ExitDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ExitDateTime.Size = new System.Drawing.Size(522, 41);
            this.txt_ExitDateTime.TabIndex = 17;
            this.txt_ExitDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ExitDateTime.DoubleClick += new System.EventHandler(this.txt_ExitDateTime_DoubleClick);
            this.txt_ExitDateTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ExitDateTime_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 537);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(264, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "تاريخ ووقت الخروج :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_EnterDateTime
            // 
            this.txt_EnterDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EnterDateTime.Location = new System.Drawing.Point(324, 490);
            this.txt_EnterDateTime.Name = "txt_EnterDateTime";
            this.txt_EnterDateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_EnterDateTime.Size = new System.Drawing.Size(522, 41);
            this.txt_EnterDateTime.TabIndex = 15;
            this.txt_EnterDateTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_EnterDateTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_EnterDateTime_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 41);
            this.label5.TabIndex = 16;
            this.label5.Text = "تاريخ ووقت الدخول :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 157);
            this.panel1.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Monotype Koufi", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(615, 87);
            this.label6.TabIndex = 11;
            this.label6.Text = "دخول وخروج النزلاء";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.pic_last);
            this.panel2.Controls.Add(this.pic_previous);
            this.panel2.Controls.Add(this.pic_next);
            this.panel2.Controls.Add(this.pic_firest);
            this.panel2.Location = new System.Drawing.Point(53, 584);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 75);
            this.panel2.TabIndex = 21;
            // 
            // pic_last
            // 
            this.pic_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_last.Image = global::Quarantine_Program.Properties.Resources.iconfinder_backward_back_arrow_previous_left_4593199;
            this.pic_last.Location = new System.Drawing.Point(59, 8);
            this.pic_last.Name = "pic_last";
            this.pic_last.Size = new System.Drawing.Size(77, 57);
            this.pic_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_last.TabIndex = 3;
            this.pic_last.TabStop = false;
            this.pic_last.Click += new System.EventHandler(this.pic_last_Click);
            this.pic_last.DoubleClick += new System.EventHandler(this.pic_last_Click);
            // 
            // pic_previous
            // 
            this.pic_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_previous.Image = global::Quarantine_Program.Properties.Resources.iconfinder_next_music_player_play_media_4593176;
            this.pic_previous.Location = new System.Drawing.Point(453, 8);
            this.pic_previous.Name = "pic_previous";
            this.pic_previous.Size = new System.Drawing.Size(77, 57);
            this.pic_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_previous.TabIndex = 2;
            this.pic_previous.TabStop = false;
            this.pic_previous.Click += new System.EventHandler(this.pic_previous_Click);
            this.pic_previous.DoubleClick += new System.EventHandler(this.pic_previous_Click);
            // 
            // pic_next
            // 
            this.pic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_next.Image = global::Quarantine_Program.Properties.Resources.iconfinder_previous_arrow_back_left_music_4593162;
            this.pic_next.Location = new System.Drawing.Point(275, 8);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(77, 57);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_next.TabIndex = 1;
            this.pic_next.TabStop = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            this.pic_next.DoubleClick += new System.EventHandler(this.pic_next_Click);
            // 
            // pic_firest
            // 
            this.pic_firest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_firest.Image = global::Quarantine_Program.Properties.Resources.iconfinder_forward_arrow_next_right_direction_4593180;
            this.pic_firest.Location = new System.Drawing.Point(639, 8);
            this.pic_firest.Name = "pic_firest";
            this.pic_firest.Size = new System.Drawing.Size(77, 57);
            this.pic_firest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_firest.TabIndex = 0;
            this.pic_firest.TabStop = false;
            this.pic_firest.Click += new System.EventHandler(this.pic_firest_Click);
            this.pic_firest.DoubleClick += new System.EventHandler(this.pic_firest_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.btn_ExitQuest);
            this.panel3.Controls.Add(this.btn_sarch);
            this.panel3.Controls.Add(this.btn_new);
            this.panel3.Controls.Add(this.btn_Edit);
            this.panel3.Controls.Add(this.btn_Enter);
            this.panel3.Location = new System.Drawing.Point(53, 685);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(793, 74);
            this.panel3.TabIndex = 22;
            // 
            // btn_ExitQuest
            // 
            this.btn_ExitQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExitQuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExitQuest.Location = new System.Drawing.Point(22, 17);
            this.btn_ExitQuest.Name = "btn_ExitQuest";
            this.btn_ExitQuest.Size = new System.Drawing.Size(142, 42);
            this.btn_ExitQuest.TabIndex = 29;
            this.btn_ExitQuest.Text = "وضع الخروج";
            this.btn_ExitQuest.UseVisualStyleBackColor = true;
            this.btn_ExitQuest.Click += new System.EventHandler(this.btn_ExitQuest_Click);
            // 
            // btn_sarch
            // 
            this.btn_sarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sarch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sarch.Location = new System.Drawing.Point(318, 17);
            this.btn_sarch.Name = "btn_sarch";
            this.btn_sarch.Size = new System.Drawing.Size(159, 42);
            this.btn_sarch.TabIndex = 28;
            this.btn_sarch.Text = "وضع البحث";
            this.btn_sarch.UseVisualStyleBackColor = true;
            this.btn_sarch.Click += new System.EventHandler(this.btn_sarch_Click);
            // 
            // btn_new
            // 
            this.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_new.Location = new System.Drawing.Point(631, 17);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(142, 42);
            this.btn_new.TabIndex = 27;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Location = new System.Drawing.Point(170, 17);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(142, 42);
            this.btn_Edit.TabIndex = 26;
            this.btn_Edit.Text = "وضع التعديل";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Enter
            // 
            this.btn_Enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enter.Location = new System.Drawing.Point(483, 17);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(142, 42);
            this.btn_Enter.TabIndex = 24;
            this.btn_Enter.Text = "تسجيل دخول نزيل";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 41);
            this.label7.TabIndex = 24;
            this.label7.Text = "المنطقة :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Almantiq
            // 
            this.cmb_Almantiq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Almantiq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Almantiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Almantiq.FormattingEnabled = true;
            this.cmb_Almantiq.Location = new System.Drawing.Point(324, 302);
            this.cmb_Almantiq.Name = "cmb_Almantiq";
            this.cmb_Almantiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Almantiq.Size = new System.Drawing.Size(522, 41);
            this.cmb_Almantiq.TabIndex = 23;
            this.cmb_Almantiq.SelectedIndexChanged += new System.EventHandler(this.cmb_Almantiq_SelectedIndexChanged);
            this.cmb_Almantiq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almantiq_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(54, 349);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 41);
            this.label8.TabIndex = 26;
            this.label8.Text = "المدينة :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_city
            // 
            this.cmb_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(324, 349);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_city.Size = new System.Drawing.Size(522, 41);
            this.cmb_city.TabIndex = 25;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            this.cmb_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_city_KeyPress);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(54, 396);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 41);
            this.label9.TabIndex = 28;
            this.label9.Text = "الحجر الصحي :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Quarry_GeneralNo
            // 
            this.cmb_Quarry_GeneralNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Quarry_GeneralNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Quarry_GeneralNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Quarry_GeneralNo.FormattingEnabled = true;
            this.cmb_Quarry_GeneralNo.Location = new System.Drawing.Point(324, 396);
            this.cmb_Quarry_GeneralNo.Name = "cmb_Quarry_GeneralNo";
            this.cmb_Quarry_GeneralNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Quarry_GeneralNo.Size = new System.Drawing.Size(522, 41);
            this.cmb_Quarry_GeneralNo.TabIndex = 27;
            this.cmb_Quarry_GeneralNo.SelectedIndexChanged += new System.EventHandler(this.cmb_Quarry_GeneralNo_SelectedIndexChanged);
            this.cmb_Quarry_GeneralNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Quarry_GeneralNo_KeyPress);
            // 
            // frm_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(901, 802);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_Quarry_GeneralNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_Almantiq);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ExitDateTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_EnterDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_RoomGeneralNo);
            this.Controls.Add(this.txt_QuestIdNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ReservationNo);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Entry";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Entry";
            this.Load += new System.EventHandler(this.frm_Entry_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_firest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ReservationNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_QuestIdNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_RoomGeneralNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ExitDateTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_EnterDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_sarch;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.PictureBox pic_last;
        private System.Windows.Forms.PictureBox pic_previous;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_firest;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Almantiq;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Quarry_GeneralNo;
        private System.Windows.Forms.Button btn_ExitQuest;
    }
}