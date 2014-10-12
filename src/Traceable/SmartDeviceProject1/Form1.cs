using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.UserService;
using System.IO;

namespace SmartDeviceProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("密码不能为空！");
                return;
            }
            string name = textBox1.Text.Trim();
            string pwd = textBox2.Text.Trim();
            string gc = "2040";

            System.Net.NetworkCredential credent = new System.Net.NetworkCredential();
            credent.UserName = "sd02";
            credent.Password = "123456";
            ZUSER_CHACK c = new ZUSER_CHACK();

            c.Credentials = credent;
            c.Url = "http://114.251.177.94:8000/sap/bc/srt/rfc/sap/zuser_chack/500/zuser_chack/binding";
            ZuserChack io = new ZuserChack();

            io.Zusrd = name;
            io.Zpasw = pwd;
            io.Werks = gc;

            ZuserCheck[] zout = new ZuserCheck[20];
            //zout[0] = new ZuserCheck();
            io.Zuser = zout;
            ZuserChackResponse response = c.ZuserChack(io);

            ZuserCheck[] returnmsg = response.Zuser;
            string menu = "";
            for (int i = 0; i < returnmsg.Length; i++)
            {
                menu += returnmsg[i].Zfunc.ToString() + ",";
            }
            if (!string.IsNullOrEmpty(menu))
            {
                Main main = new Main(menu, name);
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("该用户没有可访问的功能菜单!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}