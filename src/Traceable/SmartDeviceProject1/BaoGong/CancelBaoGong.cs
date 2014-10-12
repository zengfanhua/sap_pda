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
    public partial class CancelBaoGong : Form
    {
        public CancelBaoGong()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBarCode.Text = "";
            txtBarCode.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 取消报工
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            string BarCode = txtBarCode.Text.Trim();
            if (BarCode == "")
            {
                MessageBox.Show("请扫描条码！");
                return;
            }
            string aa = "||";
            char[] bb = aa.ToCharArray();
            string[] values = BarCode.Split(bb);
            if (values.Length > 0)
            {
                SmartDeviceProject1.Webservice1.Zppi505 io = new SmartDeviceProject1.Webservice1.Zppi505();
                io.Werks = "";
                io.Zpdte = NowDay;
                io.Aufnr = values[0].ToString();
                io.Charg = values[10].ToString();
                io.Zpnum = values[6].ToString();
                io.Matnr = values[2].ToString();
                io.Menge = decimal.Parse(values[7].ToString());
                io.Zbanm = values[4].ToString();
                io.Zusrd = "";
                Webservice1.Zsdmsg01[] outmess = new SmartDeviceProject1.Webservice1.Zsdmsg01[10];
                io.Return = outmess;
                SmartDeviceProject1.Webservice1.zdev02_webservice pda = new SmartDeviceProject1.Webservice1.zdev02_webservice();
                SmartDeviceProject1.Webservice1.Zppi505Response response = pda.Zppi505(io);
                SmartDeviceProject1.Webservice1.Zsdmsg01[] message = response.Return;
                string str = "";
                for (int i = 0; i < message.Length; i++)
                {
                    str += message[i].Message.ToString() + "\r";
                }
                if (!string.IsNullOrEmpty(str))
                {
                    MessageBox.Show(str);
                    return;
                }
            }
            else
            {
                MessageBox.Show("条码不符");
            }
        }
        public DateTime NowDay = DateTime.Now;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                NowDay = dateTimePicker1.Value;
                tabControl1.SelectedIndex = 1;
            }
            catch {
            
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                SmartDeviceProject1.Webservice1.Zppi501 io = new SmartDeviceProject1.Webservice1.Zppi501();
                string OrderNum = txtOrderNum.Text.Trim();
                string Factory = txtFactory.Text.Trim();
                io.Aufnr = OrderNum;
                Webservice1.Zsdmsg01[] outmess = new SmartDeviceProject1.Webservice1.Zsdmsg01[10];
                io.Return = outmess;
                SmartDeviceProject1.Webservice1.zdev02_webservice pda = new SmartDeviceProject1.Webservice1.zdev02_webservice();
                SmartDeviceProject1.Webservice1.Zppi501Response response = pda.Zppi501(io);
                SmartDeviceProject1.Webservice1.Zsdmsg01[] message = response.Return;
                string str = "";
                for (int i = 0; i < message.Length; i++)
                {
                    str += message[i].Message.ToString() + "\r";
                }
                if (!string.IsNullOrEmpty(str))
                {
                    MessageBox.Show(str);
                    return;
                }
            }
            catch
            { 
            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBarCode.Text = "";
            txtFactory.Text = "";
            txtBarCode.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}