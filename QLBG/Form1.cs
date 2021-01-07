using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            Form2 dk = new Form2();
            dk.ShowDialog();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string user = "NV1";
            string pass = "01";
            if (user.Equals(txtTDN.Text) && pass.Equals(txtMK.Text))
            {
                Form3 frm = new Form3();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tai khoan hoac mat khau");
            }
        }
    }
}
