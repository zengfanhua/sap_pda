using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.SingleSales;

namespace SmartDeviceProject1
{
    public partial class Dialog : Form
    {
        private string remark = "";
        private string gbcw = "";
        private string quantity = "";

        public Dialog()
        {
            InitializeComponent();
        }

        public Dialog(string des, string Zfslb, string num)
        {
            this.remark = des;
            this.gbcw = Zfslb;
            this.quantity = num;

            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {
            PageInit();
        }

        public DataTable GridDT
        {
            get;
            set;
        }
        private void PageInit()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("行项目", "行项目");
            dic.Add("描述", "描述");
            dic.Add("托盘/盖板存位", "托盘/盖板存位");
            dic.Add("数量", "数量");
            GridDT = CreateInitDT(dic);

            //datagrid添加行
            if (!string.IsNullOrEmpty(remark) && !string.IsNullOrEmpty(gbcw) && !string.IsNullOrEmpty(quantity))
            {
                int count = remark.Length;
                string mark = remark.Remove(count - 1, 1);
                string[] m = mark.Split(',');

                string cw = gbcw.Remove(count - 1, 1);
                string[] w = cw.Split(',');

                string quan = quantity.Remove(count - 1, 1);
                string[] q = quan.Split(',');

                for (int i = 0; i < m.Length; i++)
                {

                    DataRow row = GridDT.NewRow();
                    //  row["行项目"] = "1";
                    row["描述"] = m[i];
                    row["托盘/盖板存位"] = w[i];
                    row["数量"] = q[i];
                    GridDT.Rows.Add(row);
                }

            }

            InitDGVColumn(GridDT);
            this.dataGrid1.DataSource = GridDT;
        }

        private DataGridCell editCell;
        //是否在编辑状态
        bool inEditMode = false;
        //是否正在更新
        bool inUpdateMode = false;
        //一个TextBox的隐藏控件
        TextBox txtEdit = new TextBox();
        string txtName = "";
        /// <summary>
        ///DataGrid的编辑状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgProduct_CurrentCellChanged(object sender, EventArgs e)
        {
            if (!inUpdateMode)
            {
                if (inEditMode && !dataGrid1.CurrentCell.Equals(editCell))
                {
                    foreach (Control c in this.dataGrid1.Controls)
                    {
                        if (c.Name == txtName)
                            c.Visible = false;
                    }
                    if (!string.IsNullOrEmpty(txtEdit.Text) && txtEdit.Text != "0")
                    {
                        // dataGrid1[editCell.RowNumber][editCell.ColumnNumber] = txtEdit.Text;
                    }
                    this.dataGrid1.Controls.Remove(txtEdit);
                    inUpdateMode = true;
                    DataGridCell currentCell = dataGrid1.CurrentCell;
                    dataGrid1.CurrentCell = currentCell;
                    inUpdateMode = false;
                    inEditMode = false;
                }
                editCell = dataGrid1.CurrentCell;
                txtEdit = new TextBox();
                txtName = "txt" + editCell.RowNumber + editCell.ColumnNumber;
                txtEdit.Name = txtName;
                txtEdit.Text = (string)dataGrid1[editCell.RowNumber, editCell.ColumnNumber];
                txtEdit.Multiline = true;
                txtEdit.Font = new Font("Arial", 8, FontStyle.Regular);
                Rectangle cellPos = dataGrid1.GetCellBounds(editCell.RowNumber, editCell.ColumnNumber);
                txtEdit.Left = cellPos.Left;
                txtEdit.Top = cellPos.Top;
                txtEdit.Width = cellPos.Width;
                txtEdit.Height = cellPos.Height + 2;
                txtEdit.Visible = true;
                inEditMode = true;
                this.dataGrid1.Controls.Add(txtEdit);
                txtEdit.Focus();
            }

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

        #region DataGrid添加Checkbox列

        public class DataGridCheckBoxColumn : DataGridColumnStyle
        {
            private DataGrid Parent;

            public DataGridCheckBoxColumn(DataGrid parent)
            {
                Parent = parent;
            }
            protected override void Paint(Graphics g, Rectangle bounds, CurrencyManager source, int rowNum, Brush backBrush, Brush foreBrush, bool alignToRight)
            {
                object cellValue = this.PropertyDescriptor.GetValue(source.List[rowNum]); //取得该列的值
                Image image;

                g.FillRectangle(backBrush, bounds);


                Rectangle tempSrc;
                int x;
                int y;

                if (cellValue == null || cellValue == DBNull.Value || !Convert.ToBoolean(cellValue))
                {
                    tempSrc = new Rectangle(0, 0, 20, 20);
                    // image = Assay.Properties.Resources._unchecked;

                }
                else
                {
                    tempSrc = new Rectangle(0, 0, 20, 20);
                    // image = Assay.Properties.Resources._checkbox;
                }

                x = bounds.Left + (bounds.Width - tempSrc.Width) / 2 - 3;  //-3:与编辑的CheckBox距离。试试就知道了
                y = bounds.Top + (bounds.Height - tempSrc.Height) / 2;

                g.DrawImage(null, x, y);
            }
        }
        #endregion

        //返回
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //确认
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}