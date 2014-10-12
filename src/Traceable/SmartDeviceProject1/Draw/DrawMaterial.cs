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

namespace SmartDeviceProject1.Draw
{
    public partial class DrawMaterial : Form
    {
        public string ReservedNumber { get; set; }

        public string IssueLocation { get; set; }

        public string ReceivingLocation { get; set; }

        public DrawStatus CurrentState { get; set; }

        public List<MaterialModel> ConfirmedMatetials = new List<MaterialModel>();

        public List<MaterialModel> UploadedMatetials = new List<MaterialModel>();

        public DrawMaterial()
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

        private void SetDrawStatus(DrawStatus status)
        {
            if (status == DrawStatus.Init)
            {
                pnlResearvedNumber.Enabled = true;
                pnlLocation.Enabled = false;

                ReservedNumber = string.Empty;
                IssueLocation = string.Empty;
                ReceivingLocation = string.Empty;

                CurrentState = DrawStatus.Init;
            }

            if (status == DrawStatus.ReservedConfirmed)
            {
                pnlResearvedNumber.Enabled = false;
                pnlLocation.Enabled = false;

                CurrentState = DrawStatus.ReservedConfirmed;
            }
        }

        private void InputMaterial_Load(object sender, EventArgs e)
        {
            SetDrawStatus(DrawStatus.Init);
        }

        private void btnConform_Click(object sender, EventArgs e)
        {
            string number = txtReservedNumber.Text.Trim();
            if (number == string.Empty)
                MessageBox.Show("请输入预留号");

            try
            {
                string issueLocation = string.Empty;
                string receivingLocation = string.Empty;

                bool isSuccess = DrawLogic.ConfirmReservedNumber(number, out receivingLocation, out issueLocation);
                if (isSuccess)
                {
                    ReservedNumber = number;
                    txtReceivingLocation.Text = receivingLocation;
                    txtIssueLocation.Text = issueLocation;

                    IssueLocation = issueLocation;
                    ReceivingLocation = receivingLocation;

                    SetDrawStatus(DrawStatus.ReservedConfirmed);
                }
                else
                {
                    pnlLocation.Enabled = true;
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

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcMain.SelectedIndex == 1)
            {
                if (CurrentState != DrawStatus.ReservedConfirmed)
                {
                    MessageBox.Show("请确认预留号。");
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
            txtQty.Text = string.Empty;
            txtUnit.Text = string.Empty;
            txtMetrialNumber.Text = string.Empty;

            txtBarcode.Focus();
        }

        private void CancelMaterial1()
        {
            txtBarcode1.Text = string.Empty;
            txtBatchNumber1.Text = string.Empty;
            txtPack1.Text = string.Empty;
            txtQty1.Text = string.Empty;
            txtUnit1.Text = string.Empty;
            txtMaterialNumber1.Text = string.Empty;

            txtBarcode1.Focus();
        }

        private void ExtractBarcode(string barcode)
        {
            try
            {
                string[] info = GlobalState.ExtractBarcode(barcode);

                txtMetrialNumber.Text = info[2];
                txtBatchNumber.Text = info[5];
                txtPackNumber.Text = info[6];
                txtQty.Text = info[7];
                txtUnit.Text = info[8];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmDraw_Click(object sender, EventArgs e)
        {
            MaterialModel model = new MaterialModel();
            model.Aufnr = ReservedNumber;
            model.Charg = txtBatchNumber.Text.Trim();
            model.Matnr = txtMetrialNumber.Text.Trim();
            model.Meins = txtUnit.Text.Trim();
            model.Menge = decimal.Parse(txtQty.Text.Trim());
            model.Werks = GlobalState.Werks;
            model.Zgrop = GlobalState.UserID;
            model.Zmengd = decimal.Parse(txtQty.Text.Trim());
            model.Zplin = IssueLocation;
            model.Zpnum = txtPackNumber.Text.Trim();
            model.Zissl = IssueLocation;
            model.Zgetl = ReceivingLocation;
            model.Zusrd = GlobalState.UserID;
            model.Rsnum = ReservedNumber;

            bool isSuccess = DrawLogic.ConfirmDrawMaterial(model);
            if (!isSuccess)
            {
                MessageBox.Show("确认领料失败。");
            }
            else
            {
                ConfirmedMatetials.Add(model);
                CancelMaterial();
            }
        }

        private void txtIssueLocation_LostFocus(object sender, EventArgs e)
        {
            IssueLocation = txtIssueLocation.Text.Trim();
        }

        private void txtReceivingLocation_LostFocus(object sender, EventArgs e)
        {
            ReceivingLocation = txtReceivingLocation.Text.Trim();
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ExtractBarcode(txtBarcode.Text.Trim());
                btnConfirmDraw.Focus();
            }
        }

        private void txtBarcode1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                ExtractBarcode(txtBarcode1.Text.Trim());

                MaterialModel model = new MaterialModel();
                model.Aufnr = ReservedNumber;
                model.Charg = txtBatchNumber1.Text.Trim();
                model.Matnr = txtMaterialNumber1.Text.Trim();
                model.Meins = txtUnit1.Text.Trim();
                model.Menge = decimal.Parse(txtQty1.Text.Trim());
                model.Werks = GlobalState.Werks;
                model.Zgrop = GlobalState.UserID;
                model.Zmengd = decimal.Parse(txtQty1.Text.Trim());
                model.Zplin = IssueLocation;
                model.Zpnum = txtPack1.Text.Trim();
                model.Zissl = IssueLocation;
                model.Zgetl = ReceivingLocation;
                model.Zusrd = GlobalState.UserID;
                model.Rsnum = ReservedNumber;

                bool isFound = FindMaterial(model);
                if (!isFound)
                {
                    MessageBox.Show("该包号物料未确认领料。");
                    CancelMaterial1();
                    return;
                }

                UploadedMatetials.Add(model);
                CancelMaterial1();
            }

        }

        private void btnCancelDraw_Click(object sender, EventArgs e)
        {
            foreach (MaterialModel model in UploadedMatetials)
            {
                try
                {
                    DrawLogic.DeleteDrawMaterial(model);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(string.Format("物料号：{0} 包号：{1}", model.Matnr, model.Zpnum));
                }
            }

            MessageBox.Show("取消领料信息结束。");
            UploadedMatetials.Clear();
            ConfirmedMatetials.Clear();
            CancelMaterial1();
        }

        private void btnUploadDraw_Click(object sender, EventArgs e)
        {
            foreach (MaterialModel model in UploadedMatetials)
            {
                try
                {
                    DrawLogic.UploadDrawMaterial(model);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(string.Format("物料号：{0} 包号：{1}", model.Matnr, model.Zpnum));
                }
            }

            MessageBox.Show("提交领料信息结束。");
            UploadedMatetials.Clear();
        }

        private bool FindMaterial(MaterialModel model)
        {
            foreach (MaterialModel material in ConfirmedMatetials)
            {
                if (material.Zpnum == model.Zpnum && material.Matnr == model.Matnr)
                    return true;
            }

            return false;
        }
    }
}