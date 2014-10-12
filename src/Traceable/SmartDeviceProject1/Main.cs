using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.SingleSales;
using SmartDeviceProject1.WareSales;

namespace SmartDeviceProject1
{
    public partial class Main : Form
    {
        private string func = "";
        private string str = "";
        private string[] main;
        private string userName = "";
        public Main()
        {
            InitializeComponent();
        }
        public Main(string menu, string user)
        {
            this.userName = user;
            this.func = menu;
            int count = func.Length;
            str = func.Remove(count - 1, 1);
            main = str.Split(',');
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            int x = 31;
            int y = 31;
            for (int i = 0; i < main.Length; i++)
            {
                Button btn = new Button();
                btn.Text = main[i].ToString();
                btn.Location = new Point(x, y);
                //  btn.BackColor = Color.Blue;
                btn.Size = new System.Drawing.Size(179, 37);
                this.Controls.Add(btn);
                y += 64;
            }
            Button button = new Button();
            button.Text = "返回";
            button.Location = new Point(x, y);
            button.Size = new System.Drawing.Size(179, 37);
            this.Controls.Add(button);
            button.Click += new System.EventHandler(this.button20_Click);

            foreach (Control c in this.Controls)
            {
                if (c is Button && c.Text == "按库发货-销售订单")
                {
                    c.Click += new System.EventHandler(this.btnWareSale_Click);
                }
                if (c is Button && c.Text == "按单发货-销售订单")
                {
                    c.Click += new System.EventHandler(this.btnSingleSale_Click);
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //按库发货-销售订单
        private void btnWareSale_Click(object sender, EventArgs e)
        {
            SaleInfo info = new SaleInfo(userName);
            info.ShowDialog();
        }
        //按单发货-销售订单
        private void btnSingleSale_Click(object sender, EventArgs e)
        {
            WaleSalesInfo info = new WaleSalesInfo(userName);
            info.ShowDialog();
        }
    }
}