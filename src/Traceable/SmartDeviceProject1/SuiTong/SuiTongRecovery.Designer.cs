namespace SmartDeviceProject1.SuiTong
{
    partial class SuiTongRecovery
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSHKC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaterialCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "预留号码";
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(103, 5);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(126, 21);
            this.txtNum.TabIndex = 3;
            this.txtNum.LostFocus += new System.EventHandler(this.txtNum_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "总重量";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(90, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 20);
            this.button6.TabIndex = 19;
            this.button6.Text = "取消回收";
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.Text = "条码";
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(103, 193);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(126, 21);
            this.txtBarCode.TabIndex = 16;
            this.txtBarCode.LostFocus += new System.EventHandler(this.txtBarCode_LostFocus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 20);
            this.button3.TabIndex = 17;
            this.button3.Text = "确认回收";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 20);
            this.button1.TabIndex = 17;
            this.button1.Text = "清空记录";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSHKC
            // 
            this.txtSHKC.Location = new System.Drawing.Point(103, 38);
            this.txtSHKC.Name = "txtSHKC";
            this.txtSHKC.Size = new System.Drawing.Size(126, 21);
            this.txtSHKC.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.Text = "收货库存地";
            // 
            // txtMaterialCode
            // 
            this.txtMaterialCode.Location = new System.Drawing.Point(103, 71);
            this.txtMaterialCode.Name = "txtMaterialCode";
            this.txtMaterialCode.Size = new System.Drawing.Size(126, 21);
            this.txtMaterialCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.Text = "物料编号";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(188, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 20);
            this.button5.TabIndex = 23;
            this.button5.Text = "返回";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // SuiTongRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaterialCode);
            this.Controls.Add(this.txtSHKC);
            this.Controls.Add(this.txtNum);
            this.Menu = this.mainMenu1;
            this.Name = "SuiTongRecovery";
            this.Text = "碎铜回收";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSHKC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaterialCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
    }
}