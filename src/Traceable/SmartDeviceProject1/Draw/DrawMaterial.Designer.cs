namespace SmartDeviceProject1.Draw
{
    partial class DrawMaterial
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
            this.txtReservedNumber = new System.Windows.Forms.TextBox();
            this.btnConform = new System.Windows.Forms.Button();
            this.btnReturn1 = new System.Windows.Forms.Button();
            this.pnlResearvedNumber = new System.Windows.Forms.Panel();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabConfirm = new System.Windows.Forms.TabPage();
            this.pnlLocation = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReceivingLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIssueLocation = new System.Windows.Forms.TextBox();
            this.tabScan = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMetrialNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPackNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBatchNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.btnConfirmDraw = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUploadDraw = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaterialNumber1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQty1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPack1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUnit1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBatchNumber1 = new System.Windows.Forms.TextBox();
            this.btnCancelDraw = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBarcode1 = new System.Windows.Forms.TextBox();
            this.pnlResearvedNumber.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabConfirm.SuspendLayout();
            this.pnlLocation.SuspendLayout();
            this.tabScan.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.Text = "预留号";
            // 
            // txtReservedNumber
            // 
            this.txtReservedNumber.Location = new System.Drawing.Point(81, 14);
            this.txtReservedNumber.Name = "txtReservedNumber";
            this.txtReservedNumber.Size = new System.Drawing.Size(132, 21);
            this.txtReservedNumber.TabIndex = 1;
            // 
            // btnConform
            // 
            this.btnConform.Location = new System.Drawing.Point(141, 52);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(72, 20);
            this.btnConform.TabIndex = 2;
            this.btnConform.Text = "确定";
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
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
            // pnlResearvedNumber
            // 
            this.pnlResearvedNumber.Controls.Add(this.label1);
            this.pnlResearvedNumber.Controls.Add(this.txtReservedNumber);
            this.pnlResearvedNumber.Controls.Add(this.btnConform);
            this.pnlResearvedNumber.Location = new System.Drawing.Point(9, 3);
            this.pnlResearvedNumber.Name = "pnlResearvedNumber";
            this.pnlResearvedNumber.Size = new System.Drawing.Size(224, 82);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabConfirm);
            this.tcMain.Controls.Add(this.tabScan);
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(240, 265);
            this.tcMain.TabIndex = 5;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tabConfirm
            // 
            this.tabConfirm.Controls.Add(this.pnlLocation);
            this.tabConfirm.Controls.Add(this.btnReturn1);
            this.tabConfirm.Controls.Add(this.pnlResearvedNumber);
            this.tabConfirm.Location = new System.Drawing.Point(0, 0);
            this.tabConfirm.Name = "tabConfirm";
            this.tabConfirm.Size = new System.Drawing.Size(240, 242);
            this.tabConfirm.Text = "领料确认";
            // 
            // pnlLocation
            // 
            this.pnlLocation.Controls.Add(this.label10);
            this.pnlLocation.Controls.Add(this.txtReceivingLocation);
            this.pnlLocation.Controls.Add(this.label2);
            this.pnlLocation.Controls.Add(this.txtIssueLocation);
            this.pnlLocation.Location = new System.Drawing.Point(9, 81);
            this.pnlLocation.Name = "pnlLocation";
            this.pnlLocation.Size = new System.Drawing.Size(224, 82);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.Text = "接收库位";
            // 
            // txtReceivingLocation
            // 
            this.txtReceivingLocation.Location = new System.Drawing.Point(81, 41);
            this.txtReceivingLocation.Name = "txtReceivingLocation";
            this.txtReceivingLocation.Size = new System.Drawing.Size(132, 21);
            this.txtReceivingLocation.TabIndex = 3;
            this.txtReceivingLocation.LostFocus += new System.EventHandler(this.txtReceivingLocation_LostFocus);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.Text = "发货库位";
            // 
            // txtIssueLocation
            // 
            this.txtIssueLocation.Location = new System.Drawing.Point(81, 14);
            this.txtIssueLocation.Name = "txtIssueLocation";
            this.txtIssueLocation.Size = new System.Drawing.Size(132, 21);
            this.txtIssueLocation.TabIndex = 1;
            this.txtIssueLocation.LostFocus += new System.EventHandler(this.txtIssueLocation_LostFocus);
            // 
            // tabScan
            // 
            this.tabScan.Controls.Add(this.panel3);
            this.tabScan.Location = new System.Drawing.Point(0, 0);
            this.tabScan.Name = "tabScan";
            this.tabScan.Size = new System.Drawing.Size(240, 242);
            this.tabScan.Text = "车间领料";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtMetrialNumber);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtPackNumber);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtUnit);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBatchNumber);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBarcode);
            this.panel3.Controls.Add(this.btnConfirmDraw);
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
            this.label8.Location = new System.Drawing.Point(4, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.Text = "数量";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(81, 141);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(140, 21);
            this.txtQty.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(4, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.Text = "包号";
            // 
            // txtPackNumber
            // 
            this.txtPackNumber.Enabled = false;
            this.txtPackNumber.Location = new System.Drawing.Point(81, 114);
            this.txtPackNumber.Name = "txtPackNumber";
            this.txtPackNumber.Size = new System.Drawing.Size(140, 21);
            this.txtPackNumber.TabIndex = 17;
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
            // btnConfirmDraw
            // 
            this.btnConfirmDraw.Location = new System.Drawing.Point(149, 209);
            this.btnConfirmDraw.Name = "btnConfirmDraw";
            this.btnConfirmDraw.Size = new System.Drawing.Size(72, 20);
            this.btnConfirmDraw.TabIndex = 2;
            this.btnConfirmDraw.Text = "确定领料";
            this.btnConfirmDraw.Click += new System.EventHandler(this.btnConfirmDraw_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(240, 242);
            this.tabPage1.Text = "提交领料";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUploadDraw);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtMaterialNumber1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtQty1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtPack1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtUnit1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtBatchNumber1);
            this.panel1.Controls.Add(this.btnCancelDraw);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.txtBarcode1);
            this.panel1.Location = new System.Drawing.Point(8, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 232);
            // 
            // btnUploadDraw
            // 
            this.btnUploadDraw.Location = new System.Drawing.Point(81, 209);
            this.btnUploadDraw.Name = "btnUploadDraw";
            this.btnUploadDraw.Size = new System.Drawing.Size(72, 20);
            this.btnUploadDraw.TabIndex = 34;
            this.btnUploadDraw.Text = "提交领料";
            this.btnUploadDraw.Click += new System.EventHandler(this.btnUploadDraw_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(4, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.Text = "物料号";
            // 
            // txtMaterialNumber1
            // 
            this.txtMaterialNumber1.Enabled = false;
            this.txtMaterialNumber1.Location = new System.Drawing.Point(81, 30);
            this.txtMaterialNumber1.Name = "txtMaterialNumber1";
            this.txtMaterialNumber1.Size = new System.Drawing.Size(140, 21);
            this.txtMaterialNumber1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(4, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.Text = "数量";
            // 
            // txtQty1
            // 
            this.txtQty1.Location = new System.Drawing.Point(81, 141);
            this.txtQty1.Name = "txtQty1";
            this.txtQty1.Size = new System.Drawing.Size(140, 21);
            this.txtQty1.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(4, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.Text = "包号";
            // 
            // txtPack1
            // 
            this.txtPack1.Enabled = false;
            this.txtPack1.Location = new System.Drawing.Point(81, 114);
            this.txtPack1.Name = "txtPack1";
            this.txtPack1.Size = new System.Drawing.Size(140, 21);
            this.txtPack1.TabIndex = 17;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(4, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.Text = "单位";
            // 
            // txtUnit1
            // 
            this.txtUnit1.Enabled = false;
            this.txtUnit1.Location = new System.Drawing.Point(81, 87);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Size = new System.Drawing.Size(140, 21);
            this.txtUnit1.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(4, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.Text = "批次号";
            // 
            // txtBatchNumber1
            // 
            this.txtBatchNumber1.Enabled = false;
            this.txtBatchNumber1.Location = new System.Drawing.Point(81, 60);
            this.txtBatchNumber1.Name = "txtBatchNumber1";
            this.txtBatchNumber1.Size = new System.Drawing.Size(140, 21);
            this.txtBatchNumber1.TabIndex = 8;
            // 
            // btnCancelDraw
            // 
            this.btnCancelDraw.Location = new System.Drawing.Point(159, 209);
            this.btnCancelDraw.Name = "btnCancelDraw";
            this.btnCancelDraw.Size = new System.Drawing.Size(62, 20);
            this.btnCancelDraw.TabIndex = 4;
            this.btnCancelDraw.Text = "取消领料";
            this.btnCancelDraw.Click += new System.EventHandler(this.btnCancelDraw_Click);
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(4, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.Text = "物料条码";
            // 
            // txtBarcode1
            // 
            this.txtBarcode1.Location = new System.Drawing.Point(81, 3);
            this.txtBarcode1.Name = "txtBarcode1";
            this.txtBarcode1.Size = new System.Drawing.Size(140, 21);
            this.txtBarcode1.TabIndex = 1;
            this.txtBarcode1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarcode1_KeyPress);
            // 
            // DrawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.ControlBox = false;
            this.Controls.Add(this.tcMain);
            this.Menu = this.mainMenu1;
            this.Name = "DrawMaterial";
            this.Text = "生产领料";
            this.Load += new System.EventHandler(this.InputMaterial_Load);
            this.pnlResearvedNumber.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabConfirm.ResumeLayout(false);
            this.pnlLocation.ResumeLayout(false);
            this.tabScan.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtReservedNumber;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.Button btnReturn1;
        private System.Windows.Forms.Panel pnlResearvedNumber;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabConfirm;
        private System.Windows.Forms.TabPage tabScan;
        private System.Windows.Forms.Panel pnlLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIssueLocation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Button btnConfirmDraw;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPackNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBatchNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMetrialNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReceivingLocation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUploadDraw;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaterialNumber1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQty1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPack1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUnit1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBatchNumber1;
        private System.Windows.Forms.Button btnCancelDraw;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBarcode1;
    }
}