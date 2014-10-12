using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SmartDeviceProject1.Input;
using SmartDeviceProject1.Common;

namespace SmartDeviceProject1.Input
{
    public partial class InputMaterial : Form
    {
        public string ProductionOrder { get; set; }

        public string ProductionLine { get; set; }

        public ProductStatus CurrentState { get; set; }

        public InputMaterial()
        {
            InitializeComponent();
        }

        public void CloseForm()
        {
            this.Close();
        }

        private void btnReturn2_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void btnReturn1_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void SetInputStatus(ProductStatus status)
        {
            if (status == ProductStatus.Init)
            {
                pnlProductionOrder.Enabled = true;
                pnlProductionLine.Enabled = false;

                ProductionOrder = string.Empty;
                ProductionLine = string.Empty;

                CurrentState = ProductStatus.Init;
            }

            if (status == ProductStatus.OrderConfirmed)
            {
                pnlProductionOrder.Enabled = false;
                pnlProductionLine.Enabled = true;

                CurrentState = ProductStatus.OrderConfirmed;
            }

            if (status == ProductStatus.LineConfirmed)
            {
                pnlProductionOrder.Enabled = false;
                pnlProductionLine.Enabled = false;

                CurrentState = ProductStatus.LineConfirmed;
            }
        }

        private void InputMaterial_Load(object sender, EventArgs e)
        {
            SetInputStatus(ProductStatus.Init);
        }

        private void btnConformOrder_Click(object sender, EventArgs e)
        {
            string order = txtProductionOrder.Text.Trim();
            if (order == string.Empty)
                MessageBox.Show("请输入生产订单号");

            try
            {
                bool isSuccess = InputLogic.ConfirmOrder(order);
                if (isSuccess)
                {
                    ProductionOrder = order;
                    SetInputStatus(ProductStatus.OrderConfirmed);
                }
            }
            catch (BusinessException businessException)
            {
                MessageBox.Show(businessException.Message);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnConformLine_Click(object sender, EventArgs e)
        {
            try
            {
                string line = txtProductionLine.Text.Trim();
                ProductionLine = line;

                SetInputStatus(ProductStatus.LineConfirmed);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedIndex == 1)
            {
                if (CurrentState != ProductStatus.LineConfirmed)
                {
                    MessageBox.Show("请确认生产订单号及生产线。");
                    tcMain.SelectedIndex = 0;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelMaterial();
        }

        private void CancelMaterial()
        {
            txtBarcode.Text = string.Empty;
            txtBatchNumber.Text = string.Empty;
            txtPackNumber.Text = string.Empty;
            txtPackQty.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtMetrialNumber.Text = string.Empty;

            txtBarcode.Focus();
        }

        private void ExtractBarcode(string barcode)
        {
            try
            {
                string[] info = GlobalState.ExtractBarcode(barcode);

                txtMetrialNumber.Text = info[2];
                txtBatchNumber.Text = info[5];
                txtPackNumber.Text = info[6];
                txtPackQty.Text = info[7];
                txtQty.Text = info[7];
                txtUnit.Text = info[8];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmInput_Click(object sender, EventArgs e)
        {
            MaterialModel model = new MaterialModel();
            model.Aufnr = ProductionOrder;
            model.Charg = txtBatchNumber.Text.Trim();
            model.Matnr = txtMetrialNumber.Text.Trim();
            model.Meins = txtUnit.Text.Trim();
            model.Menge = decimal.Parse(txtQty.Text.Trim());
            model.Werks = GlobalState.Werks;
            model.Zgrop = GlobalState.UserID;
            model.Zmengd = decimal.Parse(txtPackQty.Text.Trim());
            model.Zplin = ProductionLine;
            model.Zpnum = txtPackNumber.Text.Trim();

            bool isSuccess = InputLogic.InputMaterial(model);
            if (!isSuccess)
            {
                MessageBox.Show("投料失败。");
            }
            else
            {
                CancelMaterial();
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ExtractBarcode(txtBarcode.Text.Trim());
                txtQty.Focus();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
                btnConfirmInput.Focus();
        }


    }
}