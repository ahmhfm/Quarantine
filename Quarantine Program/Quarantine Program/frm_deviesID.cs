using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quarantine_Program.Properties;

namespace Quarantine_Program
{
    public partial class frm_deviesID : Form
    {
        public frm_deviesID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");

            if (textBox1.Text== incryption.Encrypt(specialDevies.getUniqueID("c")))
            {
                Settings.Default["deviesNo"] = textBox1.Text;
                Settings.Default.Save();

                this.Close();
            }
            else
            {
                MessageBox.Show("الرقم غير صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_deviesID_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
            textBox1.Text= specialDevies.getUniqueID("c");
        }
    }
}
