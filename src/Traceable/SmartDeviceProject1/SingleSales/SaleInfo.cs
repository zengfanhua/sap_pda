using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SmartDeviceProject1.SingleSales
{
    public partial class SaleInfo : Form
    {
        private string user = "";
        //选择日期
        private string selectdate = "";
        public SaleInfo()
        {
            InitializeComponent();
        }

        public SaleInfo(string userName)
        {
            this.user = userName;
            InitializeComponent();
        }
        // 确认订单
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("销售订单不能为空!");
                return;
            }
            if (string.IsNullOrEmpty(textBox2.Text.Trim()))
            {
                MessageBox.Show("装运地点不能为空!");
                return;
            }
            string order = textBox1.Text.Trim();
            string address = textBox2.Text.Trim();
            string date = dateTimePicker1.Text.Trim();
            //验证订单
            System.Net.NetworkCredential credent = new System.Net.NetworkCredential();
            credent.UserName = "sd02";
            credent.Password = "123456";
            WareSaleService_Order.ZSDI501 client = new SmartDeviceProject1.WareSaleService_Order.ZSDI501();
            client.Credentials = credent;
            client.Url = "http://10.66.1.98:8000/sap/bc/srt/rfc/sap/zsdi501/500/zsdi501/binding";
            WareSaleService_Order.Zsdi501 io = new SmartDeviceProject1.WareSaleService_Order.Zsdi501();
            io.Vbeln = order;
            io.Vkorg = "1101";
            io.Vstel = address;
            io.Edatu = DateTime.Parse(date).ToString("yyyyMMdd");
            WareSaleService_Order.Zsdmsg01[] outmess = new SmartDeviceProject1.WareSaleService_Order.Zsdmsg01[10];
            io.Return = outmess;
            WareSaleService_Order.Zsdi501Response response = client.Zsdi501(io);
            WareSaleService_Order.Zsdmsg01[] message = response.Return;
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
            else
            {
                selectdate = response.LDate;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                dateTimePicker1.Enabled = false;
                panel2.Visible = true;
            }
        }
        // 开始扫描
        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text.Trim()))
            {
                MessageBox.Show("产品存位不能为空！");
                return;
            }
            if (string.IsNullOrEmpty(textBox5.Text.Trim()))
            {
                MessageBox.Show("托盘/盖板存位不能为空！");
                return;
            }
            this.tabControl1.SelectedIndex = 1;
        }
        //完成扫描 
        private void button5_Click(object sender, EventArgs e)
        {
            #region 盖板确认框

            //扫码信息至SAP
            System.Net.NetworkCredential credent = new System.Net.NetworkCredential();
            credent.UserName = "sd02";
            credent.Password = "123456";
            ZSDI504.zsdi504 client = new SmartDeviceProject1.ZSDI504.zsdi504();
            client.Credentials = credent;
            client.Url = "http://10.66.1.98:8000/sap/bc/srt/rfc/sap/zsdi504/500/zsdi504/binding";
            ZSDI504.Zsdi5041 io = new SmartDeviceProject1.ZSDI504.Zsdi5041();
            io.Vbeln = textBox1.Text.Trim();
            io.Lgort = textBox4.Text.Trim();
            ZSDI504.Zsdi504[] outmess = new SmartDeviceProject1.ZSDI504.Zsdi504[20];
            io.Itab = outmess;
            ZSDI504.Zsdi504Response response = client.Zsdi504(io);
            ZSDI504.Zsdi504[] message = response.Itab;
            string hh = "";
            string remark = "";
            string store = "";
            string amount = "";
            for (int i = 0; i < message.Length; i++)
            {
                hh += message[i].Posnr + ",";
                remark += message[i].Maktx + ",";
                store += message[i].Zlgort + ",";
                amount += message[i].Menge + ",";
            }

            Dialog dialog = new Dialog(remark, store, amount);
            dialog.ShowDialog();

            #endregion

            this.tabControl1.SelectedIndex = 2;
        }
        // 撤销
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //返回
        private void button4_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedIndex = 1;
        }

        // page_load
        private void SaleInfo_Load(object sender, EventArgs e)
        {
            PageInit();
        }
        // 
        public DataTable GridDT
        {
            get;
            set;
        }
        private void PageInit()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("物料", "物料");
            dic.Add("版面", "版面");
            dic.Add("批次", "批次");
            dic.Add("包", "包");
            dic.Add("每包数量", "每包数量");
            dic.Add("包发货数量", "包发货数量");
            GridDT = CreateInitDT(dic);
            InitDGVColumn(GridDT);
            this.dataGrid1.DataSource = GridDT;
        }
        /// <summary>
        ///  初始化 DT列
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public DataTable CreateInitDT(Dictionary<string, string> dic)
        {
            DataTable table = new DataTable();
            foreach (string key in dic.Keys)
            {
                DataColumn col = new DataColumn(key, typeof(string));
                col.Caption = dic[key].ToString();
                table.Columns.Add(col);
                continue;
            }
            return table;
        }

        /// <summary>
        /// 初始化 DataGrid列
        /// </summary>
        /// <returns></returns>
        public DataGridTableStyle InitDGVColumn(DataTable table)
        {
            DataGridTableStyle tableStyle = new DataGridTableStyle();

            DataGridTextBoxColumn col = new DataGridTextBoxColumn();
            col.HeaderText = table.Columns[0].Caption;
            col.MappingName = table.Columns[0].ColumnName;
            col.Width = 40;
            tableStyle.GridColumnStyles.Add(col);

            DataGridTextBoxColumn colG = new DataGridTextBoxColumn();
            colG.HeaderText = table.Columns[1].Caption;
            colG.MappingName = table.Columns[1].ColumnName;
            colG.Width = 80;
            tableStyle.GridColumnStyles.Add(colG);


            return tableStyle;
        }
        private string material = "";
        private string batch = "";
        private string bnum = "";
        private string amount = "";

        // 二维码扫描
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                // 二维码
                string barcode = textBox3.Text.Trim();
                string code1 = UTF8ToGB2312(barcode);
                if (barcode != null)
                {

                    string[] code = barcode.Replace("||", ",").Split(',');

                    // 销售订单号
                    string order = textBox1.Text.Trim();
                    //成品库存地点
                    string cs = textBox4.Text.Trim();
                    //托盘盖板存位
                    string ts = textBox5.Text.Trim();
                    //物料编号 
                    string wl = code[11].ToString();
                    //物料描述
                    string remark = "";
                    //版面
                    string bm = code[1].ToString();
                    string[] bmla = bm.Split(':');
                    string layout = bmla[1].ToString();
                    //供应商批次
                    string pc = code[2].ToString();
                    string[] pcba = pc.Split(':');
                    batch = pcba[1].ToString();
                    //生产日期
                    string rq = code[7].ToString();
                    string[] rqda = rq.Split(':');

                    string date = rqda[1].ToString();
                    //包号
                    string bh = code[3].ToString();
                    string[] bhbn = bh.Split(':');
                    bnum = bhbn[1].ToString();
                    //数量
                    string sl = code[4].ToString();
                    string[] slam = sl.Split(':');
                    amount = slam[1].ToString();
                    //计量单位
                    string unit = code[5].ToString();

                    #region 判断物料是否合规

                    System.Net.NetworkCredential credent = new System.Net.NetworkCredential();
                    credent.UserName = "sd02";
                    credent.Password = "123456";
                    ZSDI502.ZSDI502 client = new SmartDeviceProject1.ZSDI502.ZSDI502();
                    client.Credentials = credent;
                    client.Url = "http://10.66.1.98:8000/sap/bc/srt/rfc/sap/zsdi502/500/zsdi502/binding";
                    ZSDI502.Zsdi502 io = new SmartDeviceProject1.ZSDI502.Zsdi502();
                    io.Vbeln = order;
                    //销售订单项目号
                    // io.Posnr = "";
                    io.Vstel = textBox2.Text.Trim();
                    io.Matnr = material;
                    io.Zfsla = textBox4.Text.Trim();
                    io.Charg = batch;
                    io.Zpnum = bnum;
                    io.Zdate = date;
                    //选择日期
                    io.Zdatum = selectdate;
                    io.Edatu = DateTime.Parse(dateTimePicker1.Text).ToString("yyyy-MM-dd");
                    io.Zbanm = layout;
                    io.Zmeng = decimal.Parse(amount);
                    io.Zfslb = textBox5.Text.Trim();
                    io.Zmein = unit;
                    //生产线
                    // io.Zline = "";
                    io.Maktx = remark;

                    ZSDI502.Zsdi5021 io2 = new SmartDeviceProject1.ZSDI502.Zsdi5021();
                    io2.Zbarcode = io;
                    io2.Zcheck = "";
                    io2.Vbeln = order;
                    ZSDI502.Zsdi502Response response = client.Zsdi502(io2);

                    ZSDI502.Zsdmsg01 mess = response.Return;
                    string str = mess.Message;
                    if (!string.IsNullOrEmpty(str))
                    {
                        MessageBox.Show(str);
                        return;

                    }
                    else
                    {
                        DataRow row = GridDT.NewRow();
                        row["物料"] = material;
                        row["版面"] = layout;
                        row["批次"] = batch;
                        row["包"] = bnum;
                        row["每包数量"] = amount;
                        row["包发货数量"] = (int.Parse(bnum) * int.Parse(amount)).ToString();
                        GridDT.Rows.Add(row);
                        // 包发货数量
                        string quantity = (int.Parse(bnum) * int.Parse(amount)).ToString();
                        //验证发货数量
                        System.Net.NetworkCredential val = new System.Net.NetworkCredential();
                        val.UserName = "sd02";
                        val.Password = "123456";
                        ZSDI503.ZSDI503 c = new SmartDeviceProject1.ZSDI503.ZSDI503();
                        c.Credentials = val;
                        c.Url = "http://10.66.1.98:8000/sap/bc/srt/rfc/sap/zsdi503/500/zsdi503/binding";
                        ZSDI503.Zsdi503 para = new SmartDeviceProject1.ZSDI503.Zsdi503();
                        para.Vbeln = order;
                        para.Mandt = material;
                        para.Lgort = textBox4.Text.Trim();
                        para.Charg = batch;
                        para.Zpnum = bnum;
                        para.Zmeng1 = decimal.Parse(amount);
                        //实际每包数量
                        para.Zmeng2 = 12;
                        para.Zbanm = layout;
                        //生产线
                        // para.Zline = ""; 
                        ZSDI503.Zsdi5031 para2 = new SmartDeviceProject1.ZSDI503.Zsdi5031();
                        para2.Zbarcode = para;
                        para2.Ernam = user;
                        para2.Ztest = "是";
                        ZSDI503.Zsdi503Response ret = c.Zsdi503(para2);
                        ZSDI503.Zsdmsg01 message = ret.Return;
                        string s = message.Message;
                        if (!string.IsNullOrEmpty(s))
                        {
                            MessageBox.Show(s);
                            return;
                        }
                        else
                        {
                            //  Dialog dialog = new Dialog(remark, textBox5.Text.Trim(), quantity);
                        }
                    }

                    #endregion
                }
            }
        }
        //确认提交 
        private void button7_Click(object sender, EventArgs e)
        {
            string txtJH = textBox6.Text.Trim();
            string name = textBox11.Text.Trim();
            string carnum = textBox10.Text.Trim();
            string phone = textBox9.Text.Trim();
            string id = textBox8.Text.Trim();
            string remark = textBox7.Text.Trim();
            string isgz = "";
            if (checkBox1.Checked)
            {
                isgz = "是";
            }
            else
            {
                isgz = "否";
            }

            // 交货单信息至SAP
            System.Net.NetworkCredential val = new System.Net.NetworkCredential();
            val.UserName = "sd02";
            val.Password = "123456";
            ZSDI505.ZSDI505 client = new SmartDeviceProject1.ZSDI505.ZSDI505();
            client.Credentials = val;
            // 输入参数
            ZSDI505.Zsdi505 io = new SmartDeviceProject1.ZSDI505.Zsdi505();
            io.Vbeln = textBox1.Text.Trim();
            io.Vstel = textBox2.Text.Trim();
            //过账日期
            io.Datum = "";
            io.Zmove = isgz;
            io.Ernam = user;
            //输入itab表
            ZSDI505.Zsdi503 itab = new SmartDeviceProject1.ZSDI505.Zsdi503();
            //销售分销凭证号
            itab.Vbeln = "";
            itab.Matnr = material;
            itab.Lgort = textBox5.Text.Trim();
            itab.Charg = batch;
            itab.Zpnum = bnum;
            itab.Zmeng1 = decimal.Parse(amount);
            //实际每包数量
            //  itab.Zmeng2 = decimal.Parse("");
            itab.Ernam = user;
            //生产线
            itab.Zline = "";

            // 输入l_zsdi504表
            ZSDI505.Zsdi504 l504 = new SmartDeviceProject1.ZSDI505.Zsdi504();
            l504.Vbeln = textBox1.Text.Trim();
            l504.Maktx = remark;
            //销售订单行号
            // l504.Posnr = "";
            l504.Zlgort = textBox4.Text.Trim();
            l504.Menge = decimal.Parse(amount);

            ZSDI505.Zsdi505Response response = client.Zsdi505(io);
            //ZSDI505.Zsdi504[] zsdl = response.LZsdi504;
            //ZSDI505.Zsdi503[] tab = response.Itab;

        }

        public string UTF8ToGB2312(string str)
        {
            try
            {
                Encoding utf8 = Encoding.GetEncoding(65001);
                Encoding gb2312 = Encoding.GetEncoding("gb2312");//Encoding.Default ,936
                byte[] temp = utf8.GetBytes(str);
                byte[] temp1 = Encoding.Convert(utf8, gb2312, temp);
                string result = gb2312.GetString(temp1, 0, 20);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }
    }
}