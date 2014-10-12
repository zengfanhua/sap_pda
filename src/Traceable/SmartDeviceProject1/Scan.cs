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
    public partial class Scan : Form
    {
        public Scan()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dialog log = new Dialog();
            log.ShowDialog();
        }

        private void Scan_Load(object sender, EventArgs e)
        {
            DataGridTextBoxColumn id = new DataGridTextBoxColumn();
            id.HeaderText = "序号";
            id.Width = 60;
            DataGridTextBoxColumn lable = new DataGridTextBoxColumn();
            lable.HeaderText = "检测标签";
            lable.Width = 60;
            DataGridTextBoxColumn scan = new DataGridTextBoxColumn();
            scan.HeaderText = "扫描标签";
            scan.Width = 60;
            DataGridTextBoxColumn status = new DataGridTextBoxColumn();
            status.HeaderText = "检测状态";
            status.Width = 60;
            
           

        }
    }
}