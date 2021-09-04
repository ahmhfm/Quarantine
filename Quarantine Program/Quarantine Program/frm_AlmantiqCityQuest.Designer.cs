namespace Quarantine_Program
{
    partial class frm_AlmantiqCityQuest
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
            this.btn_AlmantiqNew = new System.Windows.Forms.Button();
            this.btn_AlmantiqAdd = new System.Windows.Forms.Button();
            this.btn_AlmantiqEdit = new System.Windows.Forms.Button();
            this.btn_AlmantiqDelete = new System.Windows.Forms.Button();
            this.lb_Almantiq = new System.Windows.Forms.ListBox();
            this.lb_city = new System.Windows.Forms.ListBox();
            this.btn_CityDelete = new System.Windows.Forms.Button();
            this.btn_CityEdit = new System.Windows.Forms.Button();
            this.btn_CityAdd = new System.Windows.Forms.Button();
            this.btn_CityNew = new System.Windows.Forms.Button();
            this.lb_Quarry = new System.Windows.Forms.ListBox();
            this.btn_QuarryDelete = new System.Windows.Forms.Button();
            this.btn_QuarryEdit = new System.Windows.Forms.Button();
            this.btn_QuarryAdd = new System.Windows.Forms.Button();
            this.btn_QuarryNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_almantiq = new System.Windows.Forms.TextBox();
            this.txt_city = new System.Windows.Forms.TextBox();
            this.txt_Quarry = new System.Windows.Forms.TextBox();
            this.txt_room = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_Room = new System.Windows.Forms.ListBox();
            this.btn_DeleteRoom = new System.Windows.Forms.Button();
            this.btn_EditRoom = new System.Windows.Forms.Button();
            this.btn_AddRoom = new System.Windows.Forms.Button();
            this.btn_newRoom = new System.Windows.Forms.Button();
            this.txt_Floor = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AlmantiqNew
            // 
            this.btn_AlmantiqNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlmantiqNew.Location = new System.Drawing.Point(7, 695);
            this.btn_AlmantiqNew.Name = "btn_AlmantiqNew";
            this.btn_AlmantiqNew.Size = new System.Drawing.Size(109, 40);
            this.btn_AlmantiqNew.TabIndex = 0;
            this.btn_AlmantiqNew.Text = "جديد";
            this.btn_AlmantiqNew.UseVisualStyleBackColor = true;
            this.btn_AlmantiqNew.Click += new System.EventHandler(this.btn_AlmantiqNew_Click);
            // 
            // btn_AlmantiqAdd
            // 
            this.btn_AlmantiqAdd.Enabled = false;
            this.btn_AlmantiqAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlmantiqAdd.Location = new System.Drawing.Point(122, 695);
            this.btn_AlmantiqAdd.Name = "btn_AlmantiqAdd";
            this.btn_AlmantiqAdd.Size = new System.Drawing.Size(109, 40);
            this.btn_AlmantiqAdd.TabIndex = 1;
            this.btn_AlmantiqAdd.Text = "إضافة";
            this.btn_AlmantiqAdd.UseVisualStyleBackColor = true;
            this.btn_AlmantiqAdd.Click += new System.EventHandler(this.btn_AlmantiqAdd_Click);
            // 
            // btn_AlmantiqEdit
            // 
            this.btn_AlmantiqEdit.Enabled = false;
            this.btn_AlmantiqEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlmantiqEdit.Location = new System.Drawing.Point(7, 741);
            this.btn_AlmantiqEdit.Name = "btn_AlmantiqEdit";
            this.btn_AlmantiqEdit.Size = new System.Drawing.Size(109, 40);
            this.btn_AlmantiqEdit.TabIndex = 2;
            this.btn_AlmantiqEdit.Text = "تعديل";
            this.btn_AlmantiqEdit.UseVisualStyleBackColor = true;
            this.btn_AlmantiqEdit.Click += new System.EventHandler(this.btn_AlmantiqEdit_Click);
            // 
            // btn_AlmantiqDelete
            // 
            this.btn_AlmantiqDelete.Enabled = false;
            this.btn_AlmantiqDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AlmantiqDelete.Location = new System.Drawing.Point(122, 741);
            this.btn_AlmantiqDelete.Name = "btn_AlmantiqDelete";
            this.btn_AlmantiqDelete.Size = new System.Drawing.Size(109, 40);
            this.btn_AlmantiqDelete.TabIndex = 3;
            this.btn_AlmantiqDelete.Text = "حذف";
            this.btn_AlmantiqDelete.UseVisualStyleBackColor = true;
            this.btn_AlmantiqDelete.Click += new System.EventHandler(this.btn_AlmantiqDelete_Click);
            // 
            // lb_Almantiq
            // 
            this.lb_Almantiq.FormattingEnabled = true;
            this.lb_Almantiq.ItemHeight = 24;
            this.lb_Almantiq.Location = new System.Drawing.Point(7, 185);
            this.lb_Almantiq.Name = "lb_Almantiq";
            this.lb_Almantiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lb_Almantiq.Size = new System.Drawing.Size(224, 460);
            this.lb_Almantiq.TabIndex = 4;
            this.lb_Almantiq.SelectedIndexChanged += new System.EventHandler(this.lb_Almantiq_SelectedIndexChanged);
            this.lb_Almantiq.DoubleClick += new System.EventHandler(this.lb_Almantiq_DoubleClick);
            // 
            // lb_city
            // 
            this.lb_city.FormattingEnabled = true;
            this.lb_city.ItemHeight = 24;
            this.lb_city.Location = new System.Drawing.Point(236, 185);
            this.lb_city.Name = "lb_city";
            this.lb_city.Size = new System.Drawing.Size(224, 460);
            this.lb_city.TabIndex = 9;
            this.lb_city.SelectedIndexChanged += new System.EventHandler(this.lb_city_SelectedIndexChanged);
            this.lb_city.DoubleClick += new System.EventHandler(this.lb_city_DoubleClick);
            // 
            // btn_CityDelete
            // 
            this.btn_CityDelete.Enabled = false;
            this.btn_CityDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CityDelete.Location = new System.Drawing.Point(351, 741);
            this.btn_CityDelete.Name = "btn_CityDelete";
            this.btn_CityDelete.Size = new System.Drawing.Size(109, 40);
            this.btn_CityDelete.TabIndex = 8;
            this.btn_CityDelete.Text = "حذف";
            this.btn_CityDelete.UseVisualStyleBackColor = true;
            this.btn_CityDelete.Click += new System.EventHandler(this.btn_CityDelete_Click);
            // 
            // btn_CityEdit
            // 
            this.btn_CityEdit.Enabled = false;
            this.btn_CityEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CityEdit.Location = new System.Drawing.Point(236, 741);
            this.btn_CityEdit.Name = "btn_CityEdit";
            this.btn_CityEdit.Size = new System.Drawing.Size(109, 40);
            this.btn_CityEdit.TabIndex = 7;
            this.btn_CityEdit.Text = "تعديل";
            this.btn_CityEdit.UseVisualStyleBackColor = true;
            this.btn_CityEdit.Click += new System.EventHandler(this.btn_CityEdit_Click);
            // 
            // btn_CityAdd
            // 
            this.btn_CityAdd.Enabled = false;
            this.btn_CityAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CityAdd.Location = new System.Drawing.Point(351, 695);
            this.btn_CityAdd.Name = "btn_CityAdd";
            this.btn_CityAdd.Size = new System.Drawing.Size(109, 40);
            this.btn_CityAdd.TabIndex = 6;
            this.btn_CityAdd.Text = "إضافة";
            this.btn_CityAdd.UseVisualStyleBackColor = true;
            this.btn_CityAdd.Click += new System.EventHandler(this.btn_CityAdd_Click);
            // 
            // btn_CityNew
            // 
            this.btn_CityNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CityNew.Location = new System.Drawing.Point(236, 695);
            this.btn_CityNew.Name = "btn_CityNew";
            this.btn_CityNew.Size = new System.Drawing.Size(109, 40);
            this.btn_CityNew.TabIndex = 5;
            this.btn_CityNew.Text = "جديد";
            this.btn_CityNew.UseVisualStyleBackColor = true;
            this.btn_CityNew.Click += new System.EventHandler(this.btn_CityNew_Click);
            // 
            // lb_Quarry
            // 
            this.lb_Quarry.FormattingEnabled = true;
            this.lb_Quarry.ItemHeight = 24;
            this.lb_Quarry.Location = new System.Drawing.Point(467, 185);
            this.lb_Quarry.Name = "lb_Quarry";
            this.lb_Quarry.Size = new System.Drawing.Size(224, 460);
            this.lb_Quarry.TabIndex = 14;
            this.lb_Quarry.SelectedIndexChanged += new System.EventHandler(this.lb_Quarry_SelectedIndexChanged);
            this.lb_Quarry.DoubleClick += new System.EventHandler(this.lb_Quarry_DoubleClick);
            // 
            // btn_QuarryDelete
            // 
            this.btn_QuarryDelete.Enabled = false;
            this.btn_QuarryDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuarryDelete.Location = new System.Drawing.Point(582, 741);
            this.btn_QuarryDelete.Name = "btn_QuarryDelete";
            this.btn_QuarryDelete.Size = new System.Drawing.Size(109, 40);
            this.btn_QuarryDelete.TabIndex = 13;
            this.btn_QuarryDelete.Text = "حذف";
            this.btn_QuarryDelete.UseVisualStyleBackColor = true;
            this.btn_QuarryDelete.Click += new System.EventHandler(this.btn_QuarryDelete_Click);
            // 
            // btn_QuarryEdit
            // 
            this.btn_QuarryEdit.Enabled = false;
            this.btn_QuarryEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuarryEdit.Location = new System.Drawing.Point(467, 741);
            this.btn_QuarryEdit.Name = "btn_QuarryEdit";
            this.btn_QuarryEdit.Size = new System.Drawing.Size(109, 40);
            this.btn_QuarryEdit.TabIndex = 12;
            this.btn_QuarryEdit.Text = "تعديل";
            this.btn_QuarryEdit.UseVisualStyleBackColor = true;
            this.btn_QuarryEdit.Click += new System.EventHandler(this.btn_QuarryEdit_Click);
            // 
            // btn_QuarryAdd
            // 
            this.btn_QuarryAdd.Enabled = false;
            this.btn_QuarryAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuarryAdd.Location = new System.Drawing.Point(582, 695);
            this.btn_QuarryAdd.Name = "btn_QuarryAdd";
            this.btn_QuarryAdd.Size = new System.Drawing.Size(109, 40);
            this.btn_QuarryAdd.TabIndex = 11;
            this.btn_QuarryAdd.Text = "إضافة";
            this.btn_QuarryAdd.UseVisualStyleBackColor = true;
            this.btn_QuarryAdd.Click += new System.EventHandler(this.btn_QuarryAdd_Click);
            // 
            // btn_QuarryNew
            // 
            this.btn_QuarryNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuarryNew.Location = new System.Drawing.Point(467, 695);
            this.btn_QuarryNew.Name = "btn_QuarryNew";
            this.btn_QuarryNew.Size = new System.Drawing.Size(109, 40);
            this.btn_QuarryNew.TabIndex = 10;
            this.btn_QuarryNew.Text = "جديد";
            this.btn_QuarryNew.UseVisualStyleBackColor = true;
            this.btn_QuarryNew.Click += new System.EventHandler(this.btn_QuarryNew_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(7, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "المناطق";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SlateGray;
            this.label2.Location = new System.Drawing.Point(236, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "المدن";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SlateGray;
            this.label3.Location = new System.Drawing.Point(463, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 28);
            this.label3.TabIndex = 17;
            this.label3.Text = "المحاجر الصحية";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 137);
            this.panel1.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(65, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(801, 68);
            this.label4.TabIndex = 17;
            this.label4.Text = "تحرير بيانات المناطق والمدن والمحاجر الصحية";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_almantiq
            // 
            this.txt_almantiq.Enabled = false;
            this.txt_almantiq.Location = new System.Drawing.Point(7, 651);
            this.txt_almantiq.Name = "txt_almantiq";
            this.txt_almantiq.Size = new System.Drawing.Size(224, 29);
            this.txt_almantiq.TabIndex = 19;
            // 
            // txt_city
            // 
            this.txt_city.Enabled = false;
            this.txt_city.Location = new System.Drawing.Point(236, 651);
            this.txt_city.Name = "txt_city";
            this.txt_city.Size = new System.Drawing.Size(224, 29);
            this.txt_city.TabIndex = 20;
            // 
            // txt_Quarry
            // 
            this.txt_Quarry.Enabled = false;
            this.txt_Quarry.Location = new System.Drawing.Point(467, 651);
            this.txt_Quarry.Name = "txt_Quarry";
            this.txt_Quarry.Size = new System.Drawing.Size(224, 29);
            this.txt_Quarry.TabIndex = 21;
            // 
            // txt_room
            // 
            this.txt_room.Enabled = false;
            this.txt_room.Location = new System.Drawing.Point(697, 651);
            this.txt_room.Name = "txt_room";
            this.txt_room.Size = new System.Drawing.Size(109, 29);
            this.txt_room.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(693, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 28);
            this.label5.TabIndex = 27;
            this.label5.Text = "الغرف";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Room
            // 
            this.lb_Room.FormattingEnabled = true;
            this.lb_Room.ItemHeight = 24;
            this.lb_Room.Location = new System.Drawing.Point(697, 185);
            this.lb_Room.Name = "lb_Room";
            this.lb_Room.Size = new System.Drawing.Size(224, 460);
            this.lb_Room.TabIndex = 26;
            this.lb_Room.SelectedIndexChanged += new System.EventHandler(this.lb_Room_SelectedIndexChanged);
            this.lb_Room.DoubleClick += new System.EventHandler(this.lb_Room_DoubleClick);
            // 
            // btn_DeleteRoom
            // 
            this.btn_DeleteRoom.Enabled = false;
            this.btn_DeleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRoom.Location = new System.Drawing.Point(812, 741);
            this.btn_DeleteRoom.Name = "btn_DeleteRoom";
            this.btn_DeleteRoom.Size = new System.Drawing.Size(109, 40);
            this.btn_DeleteRoom.TabIndex = 25;
            this.btn_DeleteRoom.Text = "حذف";
            this.btn_DeleteRoom.UseVisualStyleBackColor = true;
            this.btn_DeleteRoom.Click += new System.EventHandler(this.btn_DeleteRoom_Click);
            // 
            // btn_EditRoom
            // 
            this.btn_EditRoom.Enabled = false;
            this.btn_EditRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditRoom.Location = new System.Drawing.Point(697, 741);
            this.btn_EditRoom.Name = "btn_EditRoom";
            this.btn_EditRoom.Size = new System.Drawing.Size(109, 40);
            this.btn_EditRoom.TabIndex = 24;
            this.btn_EditRoom.Text = "تعديل";
            this.btn_EditRoom.UseVisualStyleBackColor = true;
            this.btn_EditRoom.Click += new System.EventHandler(this.btn_EditRoom_Click);
            // 
            // btn_AddRoom
            // 
            this.btn_AddRoom.Enabled = false;
            this.btn_AddRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRoom.Location = new System.Drawing.Point(812, 695);
            this.btn_AddRoom.Name = "btn_AddRoom";
            this.btn_AddRoom.Size = new System.Drawing.Size(109, 40);
            this.btn_AddRoom.TabIndex = 23;
            this.btn_AddRoom.Text = "إضافة";
            this.btn_AddRoom.UseVisualStyleBackColor = true;
            this.btn_AddRoom.Click += new System.EventHandler(this.btn_AddRoom_Click);
            // 
            // btn_newRoom
            // 
            this.btn_newRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newRoom.Location = new System.Drawing.Point(697, 695);
            this.btn_newRoom.Name = "btn_newRoom";
            this.btn_newRoom.Size = new System.Drawing.Size(109, 40);
            this.btn_newRoom.TabIndex = 22;
            this.btn_newRoom.Text = "جديد";
            this.btn_newRoom.UseVisualStyleBackColor = true;
            this.btn_newRoom.Click += new System.EventHandler(this.btn_newRoom_Click);
            // 
            // txt_Floor
            // 
            this.txt_Floor.Enabled = false;
            this.txt_Floor.Location = new System.Drawing.Point(812, 651);
            this.txt_Floor.Name = "txt_Floor";
            this.txt_Floor.Size = new System.Drawing.Size(109, 29);
            this.txt_Floor.TabIndex = 29;
            // 
            // frm_AlmantiqCityQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(932, 802);
            this.Controls.Add(this.txt_Floor);
            this.Controls.Add(this.txt_room);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_Room);
            this.Controls.Add(this.btn_DeleteRoom);
            this.Controls.Add(this.btn_EditRoom);
            this.Controls.Add(this.btn_AddRoom);
            this.Controls.Add(this.btn_newRoom);
            this.Controls.Add(this.txt_Quarry);
            this.Controls.Add(this.txt_city);
            this.Controls.Add(this.txt_almantiq);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Quarry);
            this.Controls.Add(this.btn_QuarryDelete);
            this.Controls.Add(this.btn_QuarryEdit);
            this.Controls.Add(this.btn_QuarryAdd);
            this.Controls.Add(this.btn_QuarryNew);
            this.Controls.Add(this.lb_city);
            this.Controls.Add(this.btn_CityDelete);
            this.Controls.Add(this.btn_CityEdit);
            this.Controls.Add(this.btn_CityAdd);
            this.Controls.Add(this.btn_CityNew);
            this.Controls.Add(this.lb_Almantiq);
            this.Controls.Add(this.btn_AlmantiqDelete);
            this.Controls.Add(this.btn_AlmantiqEdit);
            this.Controls.Add(this.btn_AlmantiqAdd);
            this.Controls.Add(this.btn_AlmantiqNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_AlmantiqCityQuest";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "frm_Almantiq";
            this.Load += new System.EventHandler(this.frm_AlmantiqCityQuest_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AlmantiqNew;
        private System.Windows.Forms.Button btn_AlmantiqAdd;
        private System.Windows.Forms.Button btn_AlmantiqEdit;
        private System.Windows.Forms.Button btn_AlmantiqDelete;
        private System.Windows.Forms.ListBox lb_Almantiq;
        private System.Windows.Forms.ListBox lb_city;
        private System.Windows.Forms.Button btn_CityDelete;
        private System.Windows.Forms.Button btn_CityEdit;
        private System.Windows.Forms.Button btn_CityAdd;
        private System.Windows.Forms.Button btn_CityNew;
        private System.Windows.Forms.ListBox lb_Quarry;
        private System.Windows.Forms.Button btn_QuarryDelete;
        private System.Windows.Forms.Button btn_QuarryEdit;
        private System.Windows.Forms.Button btn_QuarryAdd;
        private System.Windows.Forms.Button btn_QuarryNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_almantiq;
        private System.Windows.Forms.TextBox txt_city;
        private System.Windows.Forms.TextBox txt_Quarry;
        private System.Windows.Forms.TextBox txt_room;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lb_Room;
        private System.Windows.Forms.Button btn_DeleteRoom;
        private System.Windows.Forms.Button btn_EditRoom;
        private System.Windows.Forms.Button btn_AddRoom;
        private System.Windows.Forms.Button btn_newRoom;
        private System.Windows.Forms.TextBox txt_Floor;
    }
}