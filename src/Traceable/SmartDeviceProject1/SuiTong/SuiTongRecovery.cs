using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.SuiTong
{
    public partial class SuiTongRecovery : Form
    {
        public SuiTongRecovery()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtBarCode.Text = "";
            txtBarCode.Focus();
            if (textBox1.Text.Trim() != "")
            {
                decimal count = decimal.Parse(textBox1.Text.Trim());
                if (AllCount > count)
                {
                    MessageBox.Show("本次回收数量超过预计数量!");
                }
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public decimal AllCount = 0;
        /// <summary>
        /// 确认回收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            //调用Zppi514接口
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
                //io.Rsnum = values[0].ToString();  
                io.Matnr = values[2].ToString(); 
                io.Menge = decimal.Parse(values[7].ToString());
                //io.Meins = values[8].ToString();
                io.Zpnum = values[6].ToString();
                //io.Lgort = txtSHKC.Text.Trim();
                io.Zusrd = "";
                if (!values[2].ToString().StartsWith("1"))
                {
                    MessageBox.Show("扫描到不是铜线！");
                    return;
                }
                else
                {
                    io.Matnr = txtMaterialCode.Text.Trim();
                }
                AllCount += decimal.Parse(values[6].ToString());
              
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

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {
            txtNum.Text = "";
            txtMaterialCode.Text = "";
            txtSHKC.Text = "";
            txtNum.Focus();
            textBox1.Text = "";
        }

        private void txtNum_LostFocus(object sender, EventArgs e)
        {
            try
            {
                SmartDeviceProject1.Webservice1.Zppi513 io = new SmartDeviceProject1.Webservice1.Zppi513();
                string Num = txtNum.Text.Trim();
                io.Rsnum = Num;
                Webservice1.Zsdmsg01[] outmess = new SmartDeviceProject1.Webservice1.Zsdmsg01[10];
                io.Return = outmess;
                SmartDeviceProject1.Webservice1.zdev02_webservice pda = new SmartDeviceProject1.Webservice1.zdev02_webservice();
                SmartDeviceProject1.Webservice1.Zppi513Response response = pda.Zppi513(io);
                if (response != null)
                {
                    if (!response.Matnr.StartsWith("8"))
                    {
                        MessageBox.Show("物料编号不正确!");
                        Clear();
                        return;
                    } 
                    txtSHKC.Text = response.Lgort;
                    txtMaterialCode.Text = response.Matnr;
                    textBox1.Text = response.Znmng.ToString();
                }
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

        private void txtBarCode_LostFocus(object sender, EventArgs e)
        {

        }
    }
}