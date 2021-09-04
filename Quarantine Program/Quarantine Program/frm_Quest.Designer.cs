namespace Quarantine_Program
{
    partial class frm_Quest
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_QuestGender = new System.Windows.Forms.ComboBox();
            this.cmb_QuestNationality = new System.Windows.Forms.ComboBox();
            this.cmb_QuestIdType = new System.Windows.Forms.ComboBox();
            this.txt_QuestName = new System.Windows.Forms.TextBox();
            this.txt_QuestDateOfBirth = new System.Windows.Forms.TextBox();
            this.txt_QuestIdNo = new System.Windows.Forms.TextBox();
            this.txt_QuestFileNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.pic_first = new System.Windows.Forms.PictureBox();
            this.pic_previous = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_last = new System.Windows.Forms.PictureBox();
            this.btn_sarch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 163);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DecoType Naskh", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(270, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "شاشة تسجيل بيانات النزلاء";
            // 
            // cmb_QuestGender
            // 
            this.cmb_QuestGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_QuestGender.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_QuestGender.FormattingEnabled = true;
            this.cmb_QuestGender.Location = new System.Drawing.Point(308, 357);
            this.cmb_QuestGender.Name = "cmb_QuestGender";
            this.cmb_QuestGender.Size = new System.Drawing.Size(477, 32);
            this.cmb_QuestGender.TabIndex = 2;
            this.cmb_QuestGender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_QuestGender_KeyPress);
            // 
            // cmb_QuestNationality
            // 
            this.cmb_QuestNationality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_QuestNationality.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_QuestNationality.FormattingEnabled = true;
            this.cmb_QuestNationality.Location = new System.Drawing.Point(308, 457);
            this.cmb_QuestNationality.Name = "cmb_QuestNationality";
            this.cmb_QuestNationality.Size = new System.Drawing.Size(477, 32);
            this.cmb_QuestNationality.TabIndex = 4;
            this.cmb_QuestNationality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_QuestNationality_KeyPress);
            // 
            // cmb_QuestIdType
            // 
            this.cmb_QuestIdType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_QuestIdType.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_QuestIdType.FormattingEnabled = true;
            this.cmb_QuestIdType.Location = new System.Drawing.Point(308, 257);
            this.cmb_QuestIdType.Name = "cmb_QuestIdType";
            this.cmb_QuestIdType.Size = new System.Drawing.Size(477, 32);
            this.cmb_QuestIdType.TabIndex = 6;
            this.cmb_QuestIdType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_QuestIdType_KeyPress);
            // 
            // txt_QuestName
            // 
            this.txt_QuestName.Location = new System.Drawing.Point(308, 307);
            this.txt_QuestName.Multiline = true;
            this.txt_QuestName.Name = "txt_QuestName";
            this.txt_QuestName.Size = new System.Drawing.Size(477, 32);
            this.txt_QuestName.TabIndex = 1;
            this.txt_QuestName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuestName_KeyPress);
            // 
            // txt_QuestDateOfBirth
            // 
            this.txt_QuestDateOfBirth.Location = new System.Drawing.Point(308, 407);
            this.txt_QuestDateOfBirth.Multiline = true;
            this.txt_QuestDateOfBirth.Name = "txt_QuestDateOfBirth";
            this.txt_QuestDateOfBirth.Size = new System.Drawing.Size(477, 32);
            this.txt_QuestDateOfBirth.TabIndex = 3;
            this.txt_QuestDateOfBirth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuestDateOfBirth_KeyPress);
            // 
            // txt_QuestIdNo
            // 
            this.txt_QuestIdNo.Location = new System.Drawing.Point(308, 207);
            this.txt_QuestIdNo.Multiline = true;
            this.txt_QuestIdNo.Name = "txt_QuestIdNo";
            this.txt_QuestIdNo.Size = new System.Drawing.Size(477, 32);
            this.txt_QuestIdNo.TabIndex = 5;
            this.txt_QuestIdNo.TextChanged += new System.EventHandler(this.txt_QuestIdNo_TextChanged);
            this.txt_QuestIdNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_QuestIdNo_KeyPress);
            // 
            // txt_QuestFileNo
            // 
            this.txt_QuestFileNo.Location = new System.Drawing.Point(308, 505);
            this.txt_QuestFileNo.Multiline = true;
            this.txt_QuestFileNo.Name = "txt_QuestFileNo";
            this.txt_QuestFileNo.Size = new System.Drawing.Size(477, 32);
            this.txt_QuestFileNo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(149, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "رقم الهوية :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.RoyalBlue;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(149, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "نوع الهوية :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.RoyalBlue;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(149, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "الإسم :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.RoyalBlue;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(149, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "الجنسية :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.RoyalBlue;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(149, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "تاريخ الميلاد :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(149, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 32);
            this.label7.TabIndex = 13;
            this.label7.Text = "الجنس";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label8.Location = new System.Drawing.Point(149, 505);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "رقم الملف :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Location = new System.Drawing.Point(469, 553);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(155, 43);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "وضع التعديل";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Location = new System.Drawing.Point(147, 553);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(155, 43);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "وضع الإضافة";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(630, 553);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(155, 43);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lbl_warning);
            this.panel2.Controls.Add(this.pic_first);
            this.panel2.Controls.Add(this.pic_previous);
            this.panel2.Controls.Add(this.pic_next);
            this.panel2.Controls.Add(this.pic_last);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 636);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 163);
            this.panel2.TabIndex = 19;
            // 
            // lbl_warning
            // 
            this.lbl_warning.BackColor = System.Drawing.Color.RoyalBlue;
            this.lbl_warning.ForeColor = System.Drawing.Color.Salmon;
            this.lbl_warning.Location = new System.Drawing.Point(12, 113);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(908, 32);
            this.lbl_warning.TabIndex = 27;
            this.lbl_warning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_first
            // 
            this.pic_first.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_first.Image = global::Quarantine_Program.Properties.Resources.iconfinder_forward_arrow_next_right_direction_4593180;
            this.pic_first.Location = new System.Drawing.Point(630, 33);
            this.pic_first.Name = "pic_first";
            this.pic_first.Size = new System.Drawing.Size(155, 65);
            this.pic_first.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_first.TabIndex = 26;
            this.pic_first.TabStop = false;
            this.pic_first.Click += new System.EventHandler(this.pic_first_Click);
            this.pic_first.DoubleClick += new System.EventHandler(this.pic_first_Click);
            // 
            // pic_previous
            // 
            this.pic_previous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_previous.Image = global::Quarantine_Program.Properties.Resources.iconfinder_next_music_player_play_media_4593176;
            this.pic_previous.Location = new System.Drawing.Point(469, 33);
            this.pic_previous.Name = "pic_previous";
            this.pic_previous.Size = new System.Drawing.Size(155, 65);
            this.pic_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_previous.TabIndex = 25;
            this.pic_previous.TabStop = false;
            this.pic_previous.Click += new System.EventHandler(this.pic_previous_Click);
            this.pic_previous.DoubleClick += new System.EventHandler(this.pic_previous_Click);
            // 
            // pic_next
            // 
            this.pic_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_next.Image = global::Quarantine_Program.Properties.Resources.iconfinder_previous_arrow_back_left_music_4593162;
            this.pic_next.Location = new System.Drawing.Point(308, 33);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(155, 65);
            this.pic_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_next.TabIndex = 24;
            this.pic_next.TabStop = false;
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            this.pic_next.DoubleClick += new System.EventHandler(this.pic_next_Click);
            // 
            // pic_last
            // 
            this.pic_last.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_last.Image = global::Quarantine_Program.Properties.Resources.iconfinder_backward_back_arrow_previous_left_4593199;
            this.pic_last.Location = new System.Drawing.Point(147, 33);
            this.pic_last.Name = "pic_last";
            this.pic_last.Size = new System.Drawing.Size(155, 65);
            this.pic_last.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_last.TabIndex = 23;
            this.pic_last.TabStop = false;
            this.pic_last.Click += new System.EventHandler(this.pic_last_Click);
            this.pic_last.DoubleClick += new System.EventHandler(this.pic_last_Click);
            // 
            // btn_sarch
            // 
            this.btn_sarch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sarch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sarch.Location = new System.Drawing.Point(308, 553);
            this.btn_sarch.Name = "btn_sarch";
            this.btn_sarch.Size = new System.Drawing.Size(155, 43);
            this.btn_sarch.TabIndex = 8;
            this.btn_sarch.Text = "وضع البحث";
            this.btn_sarch.UseVisualStyleBackColor = false;
            this.btn_sarch.Click += new System.EventHandler(this.btn_sarch_Click);
            // 
            // frm_Quest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(932, 799);
            this.Controls.Add(this.btn_sarch);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_QuestFileNo);
            this.Controls.Add(this.txt_QuestIdNo);
            this.Controls.Add(this.txt_QuestDateOfBirth);
            this.Controls.Add(this.txt_QuestName);
            this.Controls.Add(this.cmb_QuestIdType);
            this.Controls.Add(this.cmb_QuestNationality);
            this.Controls.Add(this.cmb_QuestGender);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_Quest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Quest";
            this.Load += new System.EventHandler(this.frm_Quest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_QuestGender;
        private System.Windows.Forms.ComboBox cmb_QuestNationality;
        private System.Windows.Forms.ComboBox cmb_QuestIdType;
        private System.Windows.Forms.TextBox txt_QuestName;
        private System.Windows.Forms.TextBox txt_QuestDateOfBirth;
        private System.Windows.Forms.TextBox txt_QuestIdNo;
        private System.Windows.Forms.TextBox txt_QuestFileNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_first;
        private System.Windows.Forms.PictureBox pic_previous;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_last;
        private System.Windows.Forms.Button btn_sarch;
        private System.Windows.Forms.Label lbl_warning;
    }
}