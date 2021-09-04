namespace Quarantine_Program
{
    partial class frm_QuestReport
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_lastDate = new System.Windows.Forms.TextBox();
            this.txt_firstDate = new System.Windows.Forms.TextBox();
            this.cmb_reportDomain = new System.Windows.Forms.ComboBox();
            this.cmb_reportType = new System.Windows.Forms.ComboBox();
            this.cmb_Quarry = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.cmb_Almantiq = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new Quarantine_Program.CrystalReport1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_show);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_lastDate);
            this.panel1.Controls.Add(this.txt_firstDate);
            this.panel1.Controls.Add(this.cmb_reportDomain);
            this.panel1.Controls.Add(this.cmb_reportType);
            this.panel1.Controls.Add(this.cmb_Quarry);
            this.panel1.Controls.Add(this.cmb_city);
            this.panel1.Controls.Add(this.cmb_Almantiq);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 127);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(993, 85);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(219, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "التاريخ القديم :";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(993, 50);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(219, 29);
            this.label4.TabIndex = 21;
            this.label4.Text = "التاريخ القديم :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(993, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(219, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "التاريخ القديم :";
            this.label3.Visible = false;
            // 
            // btn_show
            // 
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.ForeColor = System.Drawing.Color.Gold;
            this.btn_show.Location = new System.Drawing.Point(12, 47);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(297, 67);
            this.btn_show.TabIndex = 19;
            this.btn_show.Text = "عرض التقرير";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightPink;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(560, 50);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "التاريخ القديم :";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightPink;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(560, 85);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "التاريخ الحديث :";
            this.label1.Visible = false;
            // 
            // txt_lastDate
            // 
            this.txt_lastDate.BackColor = System.Drawing.Color.MistyRose;
            this.txt_lastDate.Location = new System.Drawing.Point(315, 85);
            this.txt_lastDate.Name = "txt_lastDate";
            this.txt_lastDate.Size = new System.Drawing.Size(239, 29);
            this.txt_lastDate.TabIndex = 16;
            this.txt_lastDate.Visible = false;
            this.txt_lastDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lastDate_KeyPress);
            // 
            // txt_firstDate
            // 
            this.txt_firstDate.BackColor = System.Drawing.Color.MistyRose;
            this.txt_firstDate.Location = new System.Drawing.Point(315, 50);
            this.txt_firstDate.Name = "txt_firstDate";
            this.txt_firstDate.Size = new System.Drawing.Size(239, 29);
            this.txt_firstDate.TabIndex = 15;
            this.txt_firstDate.Visible = false;
            this.txt_firstDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_firstDate_KeyPress);
            // 
            // cmb_reportDomain
            // 
            this.cmb_reportDomain.FormattingEnabled = true;
            this.cmb_reportDomain.Location = new System.Drawing.Point(12, 9);
            this.cmb_reportDomain.Name = "cmb_reportDomain";
            this.cmb_reportDomain.Size = new System.Drawing.Size(297, 32);
            this.cmb_reportDomain.TabIndex = 14;
            this.cmb_reportDomain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_reportDomain_KeyPress);
            // 
            // cmb_reportType
            // 
            this.cmb_reportType.FormattingEnabled = true;
            this.cmb_reportType.Location = new System.Drawing.Point(315, 9);
            this.cmb_reportType.Name = "cmb_reportType";
            this.cmb_reportType.Size = new System.Drawing.Size(368, 32);
            this.cmb_reportType.TabIndex = 13;
            this.cmb_reportType.SelectedIndexChanged += new System.EventHandler(this.cmb_reportType_SelectedIndexChanged);
            this.cmb_reportType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_reportType_KeyPress);
            // 
            // cmb_Quarry
            // 
            this.cmb_Quarry.FormattingEnabled = true;
            this.cmb_Quarry.Location = new System.Drawing.Point(690, 85);
            this.cmb_Quarry.Name = "cmb_Quarry";
            this.cmb_Quarry.Size = new System.Drawing.Size(297, 32);
            this.cmb_Quarry.TabIndex = 2;
            this.cmb_Quarry.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Quarry_KeyPress);
            // 
            // cmb_city
            // 
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(690, 47);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.Size = new System.Drawing.Size(297, 32);
            this.cmb_city.TabIndex = 1;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            this.cmb_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_city_KeyPress);
            // 
            // cmb_Almantiq
            // 
            this.cmb_Almantiq.FormattingEnabled = true;
            this.cmb_Almantiq.Location = new System.Drawing.Point(690, 9);
            this.cmb_Almantiq.Name = "cmb_Almantiq";
            this.cmb_Almantiq.Size = new System.Drawing.Size(297, 32);
            this.cmb_Almantiq.TabIndex = 0;
            this.cmb_Almantiq.SelectedIndexChanged += new System.EventHandler(this.cmb_Almantiq_SelectedIndexChanged);
            this.cmb_Almantiq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almantiq_KeyPress);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 127);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1224, 675);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // frm_QuestReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1224, 802);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_QuestReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير";
            this.Load += new System.EventHandler(this.frm_QuestReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_reportDomain;
        private System.Windows.Forms.ComboBox cmb_reportType;
        private System.Windows.Forms.ComboBox cmb_Quarry;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.ComboBox cmb_Almantiq;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_lastDate;
        private System.Windows.Forms.TextBox txt_firstDate;
        private System.Windows.Forms.Button btn_show;
        private CrystalReport1 CrystalReport11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}