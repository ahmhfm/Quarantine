namespace Quarantine_Program
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_Quarry_GeneralNo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Almantiq = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 157);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Monotype Koufi", 44F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(143, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(615, 87);
            this.label6.TabIndex = 11;
            this.label6.Text = "الغرف المشغولة";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridView1.Location = new System.Drawing.Point(58, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(794, 416);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.RoyalBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(60, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 41);
            this.label9.TabIndex = 36;
            this.label9.Text = "الحجر الصحي :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Quarry_GeneralNo
            // 
            this.cmb_Quarry_GeneralNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Quarry_GeneralNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Quarry_GeneralNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Quarry_GeneralNo.FormattingEnabled = true;
            this.cmb_Quarry_GeneralNo.Location = new System.Drawing.Point(330, 269);
            this.cmb_Quarry_GeneralNo.Name = "cmb_Quarry_GeneralNo";
            this.cmb_Quarry_GeneralNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Quarry_GeneralNo.Size = new System.Drawing.Size(522, 41);
            this.cmb_Quarry_GeneralNo.TabIndex = 35;
            this.cmb_Quarry_GeneralNo.SelectedIndexChanged += new System.EventHandler(this.cmb_Quarry_GeneralNo_SelectedIndexChanged);
            this.cmb_Quarry_GeneralNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Quarry_GeneralNo_KeyPress);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RoyalBlue;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(264, 41);
            this.label8.TabIndex = 34;
            this.label8.Text = "المدينة :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_city
            // 
            this.cmb_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_city.FormattingEnabled = true;
            this.cmb_city.Location = new System.Drawing.Point(330, 222);
            this.cmb_city.Name = "cmb_city";
            this.cmb_city.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_city.Size = new System.Drawing.Size(522, 41);
            this.cmb_city.TabIndex = 33;
            this.cmb_city.SelectedIndexChanged += new System.EventHandler(this.cmb_city_SelectedIndexChanged);
            this.cmb_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_city_KeyPress);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.RoyalBlue;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(264, 41);
            this.label7.TabIndex = 32;
            this.label7.Text = "المنطقة :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_Almantiq
            // 
            this.cmb_Almantiq.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_Almantiq.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_Almantiq.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Almantiq.FormattingEnabled = true;
            this.cmb_Almantiq.Location = new System.Drawing.Point(330, 175);
            this.cmb_Almantiq.Name = "cmb_Almantiq";
            this.cmb_Almantiq.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmb_Almantiq.Size = new System.Drawing.Size(522, 41);
            this.cmb_Almantiq.TabIndex = 31;
            this.cmb_Almantiq.SelectedIndexChanged += new System.EventHandler(this.cmb_Almantiq_SelectedIndexChanged);
            this.cmb_Almantiq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmb_Almantiq_KeyPress);
            // 
            // Form2
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
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form2";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_Quarry_GeneralNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Almantiq;
    }
}