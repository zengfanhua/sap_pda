namespace SmartDeviceProject1.Input
{
    partial class ReturnMaterial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductionOrder = new System.Windows.Forms.TextBox();
            this.btnConformOrder = new System.Windows.Forms.Button();
            this.btnReturn1 = new System.Windows.Forms.Button();
            this.pnlProductionOrder = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabConfirm = new System.Windows.Forms.TabPage();
            this.pnlProductionLine = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProductionLine = new System.Windows.Forms.TextBox();
            this.btnConformLine = new System.Windows.Forms.Button();
            this.tabScan = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMetrialNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPackQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnConfirmInput = new System.Windows.Forms.Button();
            this.pnlProductionOrder.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabConfirm.SuspendLayout();
            this.pnlProductionLine.SuspendLayout();
            this.tabScan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "生产订单号";
            // 
            // txtProductionOrder
            // 
            this.txtProductionOrder.Location = new System.Drawing.Point(81, 14);
            this.txtProductionOrder.Name = "txtProductionOrder";
            this.txtProductionOrder.Size = new System.Drawing.Size(132, 21);
            this.txtProductionOrder.TabIndex = 1;
            // 
            // btnConformOrder
            // 
            this.btnConformOrder.Location = new System.Drawing.Point(141, 52);
            this.btnConformOrder.Name = "btnConformOrder";
            this.btnConformOrder.Size = new System.Drawing.Size(72, 20);
            this.btnConformOrder.TabIndex = 2;
            this.btnConformOrder.Text = "确定";
            this.btnConformOrder.Click += new System.EventHandler(this.btnConformOrder_Click);
            // 
            // btnReturn1
            // 
            this.btnReturn1.Location = new System.Drawing.Point(150, 219);
            this.btnReturn1.Name = "btnReturn1";
            this.btnReturn1.Size = new System.Drawing.Size(72, 20);
            this.btnReturn1.TabIndex = 3;
            this.btnReturn1.Text = "返回";
            this.btnReturn1.Click += new System.EventHandler(this.btnReturn1_Click);
            // 
            // pnlProductionOrder
            // 
            this.pnlProductionOrder.Controls.Add(this.label1);
            this.pnlProductionOrder.Controls.Add(this.txtProductionOrder);
            this.pnlProductionOrder.Controls.Add(this.btnConformOrder);
            this.pnlProductionOrder.Location = new System.Drawing.Point(9, 3);
            this.pnlProductionOrder.Name = "pnlProductionOrder";
            this.pnlProductionOrder.Size = new System.Drawing.Size(224, 82);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabConfirm);
            this.tcMain.Controls.Add(this.tabScan);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(240, 265);
            this.tcMain.TabIndex = 5;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabConfirm
            // 
            this.tabConfirm.Controls.Add(this.pnlProductionLine);
            this.tabConfirm.Controls.Add(this.btnReturn1);
            this.tabConfirm.Controls.Add(this.pnlProductionOrder);
            this.tabConfirm.Location = new System.Drawing.Point(0, 0);
            this.tabConfirm.Name = "tabConfirm";
            this.tabConfirm.Size = new System.Drawing.Size(240, 242);
            this.tabConfirm.Text = "退料单确认";
            // 
            // pnlProductionLine
            // 
            this.pnlProductionLine.Controls.Add(this.label2);
            this.pnlProductionLine.Controls.Add(this.txtProductionLine);
            this.pnlProductionLine.Controls.Add(this.btnConformLine);
            this.pnlProductionLine.Location = new System.Drawing.Point(9, 81);
            this.pnlProductionLine.Name = "pnlProductionLine";
            this.pnlProductionLine.Size = new System.Drawing.Size(224, 82);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "生产线";
            // 
            // txtProductionLine
            // 
            this.txtProductionLine.Location = new System.Drawing.Point(81, 14);
            this.txtProductionLine.Name = "txtProductionLine";
            this.txtProductionLine.Size = new System.Drawing.Size(132, 21);
            this.txtProductionLine.TabIndex = 1;
            // 
            // btnConformLine
            // 
            this.btnConformLine.Location = new System.Drawing.Point(141, 41);
            this.btnConformLine.Name = "btnConformLine";
            this.btnConformLine.Size = new System.Drawing.Size(72, 20);
            this.btnConformLine.TabIndex = 2;
            this.btnConformLine.Text = "确定";
            this.btnConformLine.Click += new System.EventHandler(this.btnConformLine_Click);
            // 
            // tabScan
            // 
            this.tabScan.Controls.Add(this.panel3);
            this.tabScan.Location = new System.Drawing.Point(0, 0);
            this.tabScan.Name = "tabScan";
            this.tabScan.Size = new System.Drawing.Size(240, 242);
            this.tabScan.Text = "退料扫描";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtMetrialNumber);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtPackNumber);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtPackQty);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtUnit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBatchNumber);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnReturn2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBarcode);
            this.panel3.Controls.Add(this.btnConfirmInput);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 232);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(4, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.Text = "物料号";
            // 
            // txtMetrialNumber
            // 
            this.txtMetrialNumber.Enabled = false;
            this.txtMetrialNumber.Location = new System.Drawing.Point(81, 30);
            this.txtMetrialNumber.Name = "txtMetrialNumber";
            this.txtMetrialNumber.Size = new System.Drawing.Size(140, 21);
            this.txtMetrialNumber.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(4, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.Text = "数量";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(81, 168);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(140, 21);
            this.txtQty.TabIndex = 20;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.Text = "包号";
            // 
            // txtPackNumber
            // 
            this.txtPackNumber.Enabled = false;
            this.txtPackNumber.Location = new System.Drawing.Point(81, 141);
            this.txtPackNumber.Name = "txtPackNumber";
            this.txtPackNumber.Size = new System.Drawing.Size(140, 21);
            this.txtPackNumber.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.Text = "本包数量";
            // 
            // txtPackQty
            // 
            this.txtPackQty.Enabled = false;
            this.txtPackQty.Location = new System.Drawing.Point(81, 114);
            this.txtPackQty.Name = "txtPackQty";
            this.txtPackQty.Size = new System.Drawing.Size(140, 21);
            this.txtPackQty.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(4, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.Text = "单位";
            // 
            // txtUnit
            // 
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(81, 87);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(140, 21);
            this.txtUnit.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.Text = "批次号";
            // 
            // txtBatchNumber
            // 
            this.txtBatchNumber.Enabled = false;
            this.txtBatchNumber.Location = new System.Drawing.Point(81, 60);
            this.txtBatchNumber.Name = "txtBatchNumber";
            this.txtBatchNumber.Size = new System.Drawing.Size(140, 21);
            this.txtBatchNumber.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(81, 195);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 20);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消退料";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn2
            // 
            this.btnReturn2.Location = new System.Drawing.Point(149, 195);
            this.btnReturn2.Name = "btnReturn2";
            this.btnReturn2.Size = new System.Drawing.Size(72, 20);
            this.btnReturn2.TabIndex = 3;
            this.btnReturn2.Text = "返回";
            this.btnReturn2.Click += new System.EventHandler(this.btnReturn2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.Text = "物料条码";
            // 
            // txtBarcode
            // 
            this.txtBarcode.Location = new System.Drawing.Point(81, 3);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(140, 21);
            this.txtBarcode.TabIndex = 1;
            this.txtBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode_KeyPress);
            // 
            // btnConfirmInput
            // 
            this.btnConfirmInput.Location = new System.Drawing.Point(3, 195);
            this.btnConfirmInput.Name = "btnConfirmInput";
            this.btnConfirmInput.Size = new System.Drawing.Size(72, 20);
            this.btnConfirmInput.TabIndex = 2;
            this.btnConfirmInput.Text = "确定退料";
            this.btnConfirmInput.Click += new System.EventHandler(this.btnConfirmInput_Click);
            // 
            // ReturnMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.tcMain);
            this.Menu = this.mainMenu1;
            this.Name = "ReturnMaterial";
            this.Text = "生产退料";
            this.Load += new System.EventHandler(this.InputMaterial_Load);
            this.pnlProductionOrder.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabConfirm.ResumeLayout(false);
            this.pnlProductionLine.ResumeLayout(false);
            this.tabScan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductionOrder;
        private System.Windows.Forms.Button btnConformOrder;
        private System.Windows.Forms.Button btnReturn1;
        private System.Windows.Forms.Panel pnlProductionOrder;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.TabPage tabScan;
        private System.Windows.Forms.Panel pnlProductionLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProductionLine;
        private System.Windows.Forms.Button btnConformLine;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnConfirmInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPackQty;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMetrialNumber;
    }
}