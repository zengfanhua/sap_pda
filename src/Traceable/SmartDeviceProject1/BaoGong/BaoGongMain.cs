using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.BaoGong
{
    public partial class BaoGongMain : Form
    {
        public BaoGongMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SubmitBaoGong bg = new SubmitBaoGong();
            bg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CancelBaoGong cbg=new CancelBaoGong();
            cbg.Show();

        }
    }
}