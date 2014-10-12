using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1
{
    public partial class Print : Form
    {
        private string order = "";

        public Print()
        {
            InitializeComponent();
        }

        public Print(string jhnum)
        {
            this.order = jhnum;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}