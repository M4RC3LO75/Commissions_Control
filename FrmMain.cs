using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Bunifu.UI.WinForms.BunifuButton;

namespace Controle_de_Comissões
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            ShowSplashForm();
            pnCommissions.BringToFront();
            GetLastIndexValue();
            DataTables_Update();
            ActiveControl = txtComOsNum;
            System.Timers.Timer timer = new System.Timers.Timer(600000);
            timer.AutoReset = true; // the key is here so it repeats
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        SqlConnection Con = new SqlConnection(ConString.Connection);

        int idCommissionsIndex = 0;
        int idCommission = -1;
        int idStdCommissionType = 0;
        int idCommissionType = 0;
        int idPromoProductsIndex = 0;
        int idPromoProduct = -1;
        int idStdPromoProductType = 0;
        int idPromoProductType = 0;

        DataTable dtCommissionsIndex = new DataTable();
        DataTable dtCommissions = new DataTable();
        DataTable dtCommissionsTypes = new DataTable();
        DataTable dtPromoProductsIndex = new DataTable();
        DataTable dtPromoProducts = new DataTable();
        DataTable dtPromoProductsTypes = new DataTable();
        DataTable dtStdValues = new DataTable();
        DataTable dtSuppliers = new DataTable();


        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            CalculateLabels();
        }
        private void ShowSplashForm()
        {
            this.Hide();
            FrmSplash frmSplash = new FrmSplash();
            frmSplash.ShowDialog();
            if (frmSplash.DialogResult == DialogResult.OK)
            {
                this.Show();
            }
            else if (frmSplash.DialogResult == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }


        /* //////////// FORM BUTTONS //////////// */
        private void PicClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        /* //////////// MENU BUTTONS //////////// */
        private void ComissõesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pnCommissions.BringToFront();
            GetLastIndexValue();
            DataTables_Update();
            ActiveControl = txtComOsNum;
        }
        private void FechamentosAnterioresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPanelPreviousRecords();
        }
        private void CalculadoraDeOrçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenBudgetCalculator();
        }
        private void FornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuppliers frmSuppliers = new FrmSuppliers();
            frmSuppliers.ShowDialog();
        }
        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TiposDeComissãoEProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCommNProd frmCommNProd = new FrmCommNProd();
            frmCommNProd.ShowDialog();
            ClearFields(lblClearPromoProducts, null);
            ClearFields(lblClearCommissions, null);
            DataTables_Update();
        }
        private void AlterarValoresPadrãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStdValues frmStdValues = new FrmStdValues();
            frmStdValues.ShowDialog();
            ClearFields(lblClearPromoProducts, null);
            ClearFields(lblClearCommissions, null);
            DataTables_Update();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }



        /* //////////// SIDE MENU BUTTONS //////////// */
        private void BtnCommissions_Click(object sender, EventArgs e)
        {
            GetLastIndexValue();
            DataTables_Update();
            pnCommissions.BringToFront();
            ActiveControl = txtComOsNum;
        }
        private void BtnPreviousRecords_Click(object sender, EventArgs e)
        {
            OpenPanelPreviousRecords();
        }
        private void BtnBudgetCalculator_Click(object sender, EventArgs e)
        {
            OpenBudgetCalculator();
        }
        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            FrmSuppliers frmSuppliers = new FrmSuppliers();
            frmSuppliers.ShowDialog();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        /* //////////// FUNCTIONS //////////// */
        private void OpenBudgetCalculator()
        {
            FrmBudgetCalculator frmBudgetCalculator = new FrmBudgetCalculator();
            frmBudgetCalculator.Show();
        }
        private void OpenPanelPreviousRecords()
        {
            foreach (BunifuButton button in pnPrevRecComm.Controls.OfType<BunifuButton>())
            {
                button.Enabled = false;
            }
            foreach (BunifuButton button in pnPrevRecPromoProd.Controls.OfType<BunifuButton>())
            {
                button.Enabled = false;
            }
            DgvPreviousRecords_Update();
            pnPreviousRecords.BringToFront();
        }
        private void ClearFields(object sender, EventArgs e)
        {
            try
            {
                DataRowView drvComm = cbCommissionName.SelectedItem as DataRowView;
                DataRowView drvPromoProd = cbPromoProdName.SelectedItem as DataRowView;
                if (sender == lblClearCommissions)
                {
                    idCommission = -1;
                    txtComOsNum.Text = string.Empty;
                    cbCommissionName.SelectedIndex = idStdCommissionType -1;
                    CbBoxSelect_SelectedIndexChanged(sender, e);
                    ActiveControl = txtComOsNum;
                }
                else if (sender == lblClearPromoProducts)
                {
                    idPromoProduct = -1;
                    txtPromoProdOSNum.Text = string.Empty;
                    cbPromoProdName.SelectedIndex = idStdPromoProductType -1;
                    CbBoxSelect_SelectedIndexChanged(sender, e);
                    ActiveControl = txtPromoProdOSNum;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void ChkBtnsConditions(object sender, KeyEventArgs e)
        {
            if (pnCommDataWork.Controls.OfType<TextBox>().Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)) || cbCommissionName.Text == string.Empty)
            {
                btnSaveCommission.Enabled = false;
            }
            else
            {
                btnSaveCommission.Enabled = true;
            }

            if (pnPromoProductsDataWork.Controls.OfType<TextBox>().Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)) || cbPromoProdName.Text == string.Empty)
            {
                btnSavePromoProduct.Enabled = false;
            }
            else
            {
                btnSavePromoProduct.Enabled = true;
            }

            if (idCommission == -1)
            {
                btnDeleteCommission.Enabled = false;
            }
            else
            {
                btnDeleteCommission.Enabled= true;
            }

            if (idPromoProduct == -1)
            {
                btnDeletePromoProduct.Enabled = false;
            }
            else
            {
                btnDeletePromoProduct.Enabled= true;
            }

            if (dtCommissionsIndex.Rows[0]["closureDate"].ToString() == string.Empty && dgvCommissions.Rows.Count > 0)
            {
                btnClosureDateComm.Enabled = true;
            }
            else
            {
                btnClosureDateComm.Enabled = false;
            }

            if (dtPromoProductsIndex.Rows[0]["closureDate"].ToString() == string.Empty && dgvPromoProducts.Rows.Count > 0)
            {
                btnClosureDatePromoProd.Enabled = true;
            }
            else
            {
                btnClosureDatePromoProd.Enabled = false;
            }
        }
        private void TxtTechNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (sender == txtTecNumComm)
            {
                if (txtTecNumComm.Text == string.Empty)
                {
                    txtTecNumComm.Text = 1.ToString();
                }
            }
            else if (sender == txtTecNumProd)
            {
                if(txtTecNumProd.Text == string.Empty)
                {
                    txtTecNumProd.Text = 1.ToString();
                }
            }
            CalculateLabels();
        }
        private void SelectAllText(object sender, EventArgs e)
        {
            if (sender == txtTecNumComm)
            {
                txtTecNumComm.SelectionStart = 0;
                txtTecNumComm.SelectionLength = txtTecNumComm.Text.Length;
            }
            else if(sender == txtTecNumProd)
            {
                txtTecNumProd.SelectionStart = 0;
                txtTecNumProd.SelectionLength = txtTecNumComm.Text.Length;
            }
        }
        private void TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (sender == txtComOsNum)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSaveCommission.Enabled)
                    {
                        SaveOperation(btnSaveCommission, null);
                    }
                }
            }
            else if (sender == txtPromoProdOSNum)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (btnSavePromoProduct.Enabled)
                    {
                        SaveOperation(btnSavePromoProduct, null);
                    }
                }
            }
        }
        private void AllowOnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled |= true;
            }
        }
        private void AllowDecimals_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] MyChar = { 'R', '$', ' ' };
            Control control = sender as Control;
            string numberString = control.Text.TrimStart(MyChar);

            if (e.KeyChar == '.')
            {
                e.Handled = true;
                SendKeys.Send("{,}");
            }
            if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            /* //////////// ALLOW ONE COMMA //////////// */
            if (e.KeyChar == ',' && numberString.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                if (sender == dgvCommissions)
                {
                    try
                    {
                        DataGridViewRow selectedrow = dgvCommissions.Rows[index];
                        idCommission = Convert.ToInt32(selectedrow.Cells["idCommission"].Value);
                        txtComOsNum.Text = selectedrow.Cells["N. da O.S."].Value.ToString();
                        cbCommissionName.SelectedIndex = Convert.ToInt32(selectedrow.Cells["idCommissionType"].Value) -1;
                        txtCommValue.Text = selectedrow.Cells["Valor"].Value.ToString();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                else if (sender == dgvPromoProducts)
                {
                    try
                    {
                        DataGridViewRow selectedrow = dgvPromoProducts.Rows[index];
                        idPromoProduct = Convert.ToInt32(selectedrow.Cells["idPromoProduct"].Value);
                        txtPromoProdOSNum.Text = selectedrow.Cells["N. da O.S."].Value.ToString();
                        cbPromoProdName.SelectedIndex = Convert.ToInt32(selectedrow.Cells["idPromoProductType"].Value) -1;
                        txtPromoProductValue.Text = selectedrow.Cells["Valor"].Value.ToString();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                ChkBtnsConditions(sender, null);
            }
        }
        private string CalculateWorkedDays(DateTime startDate, DateTime closureDate)
        {
            string workedDays = string.Empty;
            int restResult = 0;
            try
            {
                TimeSpan timeSpan = closureDate - startDate;
                int totalDays = Convert.ToInt32(timeSpan.ToString("dd"));
                restResult = totalDays / 365;
                if (restResult >= 1 && restResult < 2)
                {
                    workedDays += restResult.ToString() + " Ano";
                    restResult = totalDays % 365;
                    restResult = restResult / 30;
                    if (restResult >= 1 && restResult < 2)
                    {
                        workedDays += " e " + restResult.ToString() + " Mês";
                    }
                    else if (restResult >= 2)
                    {
                        workedDays += " e " + restResult.ToString() + " Meses";
                    }
                }
                else if (restResult >= 2)
                {
                    workedDays += restResult.ToString() + " Anos";
                    restResult = restResult % 12;
                    if (restResult >= 1 && restResult < 2)
                    {
                        workedDays += " e " + restResult.ToString() + " Mês";
                    }
                    else if (restResult >= 2)
                    {
                        workedDays += " e " + restResult.ToString() + " Meses";
                    }
                }
                else
                {
                    restResult = totalDays / 30;
                    if (restResult >= 1 && restResult < 2)
                    {
                        workedDays += restResult.ToString() + " Mês";
                    }
                    else if (restResult >= 2)
                    {
                        workedDays += restResult.ToString() + " Meses";
                    }
                }

                if (totalDays / 30 >= 1)
                {
                    workedDays += " e ";
                }

                restResult = totalDays % 30;
                if (restResult <= 1)
                {
                    workedDays += restResult.ToString() + " dia";
                }
                else if (restResult > 1)
                {
                    workedDays += restResult.ToString() + " dias";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
            return workedDays;
        }




        /* //////////// SQL OPERATIONS //////////// */
        private void CalculateLabels()
        {
            try
            {
                char[] MyChar = { 'R', '$', ' ' };
                double sumComm = 0;
                double sumPromoProd = 0;
                DateTime startDateComm = Convert.ToDateTime(dtCommissionsIndex.Rows[0]["startDate"]);
                DateTime startDatePromoProd = Convert.ToDateTime(dtPromoProductsIndex.Rows[0]["startDate"]);
                DateTime closureDateComm = DateTime.Now;
                DateTime closurePromoProduct = DateTime.Now;

                /* //////////// COMMISSIONS DATES //////////// */
                if (dtCommissionsIndex.Rows[0]["closureDate"].ToString() == string.Empty)
                {
                    lblCommOpenedInterval.Text = CalculateWorkedDays(startDateComm, closureDateComm);
                }
                else
                {
                    closureDateComm = Convert.ToDateTime(dtCommissionsIndex.Rows[0]["closureDate"]);
                    lblCommOpenedInterval.Text = CalculateWorkedDays(startDateComm, closureDateComm);
                }


                for (int i = 0; dgvCommissions.Rows.Count > i; i++)
                {
                    sumComm += Convert.ToDouble(dgvCommissions.Rows[i].Cells["Valor"].Value);
                }
                lblCommissionsCount.Text = dgvCommissions.Rows.Count.ToString();
                lblSumCommissions.Text = "R$ " + sumComm.ToString("0.00");
                double commissionsSum = Convert.ToDouble(lblSumCommissions.Text.TrimStart(MyChar));
                int techNumCom = Convert.ToInt32(txtTecNumComm.Text);
                lblTotalCommisionsSplited.Text = "R$ " + (commissionsSum / techNumCom).ToString("0.00");

                /* //////////// PROMO PRODUCTS DATES //////////// */
                if (dtPromoProductsIndex.Rows[0]["closureDate"].ToString() == string.Empty)
                {
                    lblPromoProdOpenedInterval.Text = CalculateWorkedDays(startDatePromoProd, closurePromoProduct);
                }
                else
                {
                    closurePromoProduct = Convert.ToDateTime(dtPromoProductsIndex.Rows[0]["closureDate"]);
                    lblPromoProdOpenedInterval.Text = CalculateWorkedDays(startDatePromoProd, closurePromoProduct);
                }

                for (int i = 0; dgvPromoProducts.Rows.Count > i; i++)
                {
                    sumPromoProd += Convert.ToDouble(dgvPromoProducts.Rows[i].Cells["Valor"].Value);
                }
                lblPromoProductsCount.Text = dgvPromoProducts.Rows.Count.ToString();
                lblSumPromoProducts.Text = "R$ " + sumPromoProd.ToString("0.00");
                double promoProductsSum = Convert.ToDouble(lblSumPromoProducts.Text.TrimStart(MyChar));
                int techNumProd = Convert.ToInt32(txtTecNumProd.Text);
                lblTotalPromoProductsSplited.Text = "R$ " + (promoProductsSum / techNumProd).ToString("0.00");

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO:" + ex);
            }
        }
        private void GetStdTypesValues()
        {
            try
            {
                SqlDataAdapter sdaStdCommTypes = new SqlDataAdapter("Select * from tbCommissionsTypes WHERE stdCommission = 1", Con);
                DataTable dtStdCommTypes = new DataTable();
                sdaStdCommTypes.Fill(dtStdCommTypes);
                if (dtStdCommTypes.Rows.Count > 0)
                {
                    idStdCommissionType = Convert.ToInt32(dtStdCommTypes.Rows[0]["idCommissionType"]);
                }
                dtStdCommTypes.Clear();

                SqlDataAdapter sdaStdPromoProdTypes = new SqlDataAdapter("Select * from tbPromoProductsTypes WHERE stdPromoProduct = 1", Con);
                DataTable dtStdPromoProdTypes = new DataTable();
                sdaStdPromoProdTypes.Fill(dtStdPromoProdTypes);
                if (dtStdPromoProdTypes.Rows.Count > 0)
                {
                    idStdPromoProductType = Convert.ToInt32(dtStdPromoProdTypes.Rows[0]["idPromoProductType"]);
                }
                dtStdPromoProdTypes.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void GetLastIndexValue()
        {
            try
            {
                SqlDataAdapter sdaComm = new SqlDataAdapter("Select * from tbCommissionsIndex " +
                    "WHERE closureDate IS NULL", Con);
                DataTable dtComm = new DataTable();
                sdaComm.Fill(dtComm);
                if (dtComm.Rows.Count > 0)
                {
                    idCommissionsIndex = Convert.ToInt32(dtComm.Rows[0]["idCommissionIndex"]);
                }
                else
                {
                    NewIndexOperation("Commissions");
                }

                SqlDataAdapter sdaPromoProd = new SqlDataAdapter("Select * from tbPromoProductsIndex " +
                    "WHERE closureDate IS NULL", Con);
                DataTable dtPromoProd = new DataTable();
                sdaPromoProd.Fill(dtPromoProd);
                if (dtPromoProd.Rows.Count > 0)
                {
                    idPromoProductsIndex = Convert.ToInt32(dtPromoProd.Rows[0]["idPromoProductIndex"]);
                }
                else
                {
                    NewIndexOperation("PromoProducts");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void NewIndexOperation(string tableName)
        {
            if (tableName == "Commissions")
            {
                try
                {
                    Con.Open();
                    SqlCommand cmdIndex = new SqlCommand("INSERT INTO tbCommissionsIndex (startDATE) " +
                        "VALUES (@startDate)", Con);
                    cmdIndex.Parameters.AddWithValue("startDate", DateTime.Now);
                    cmdIndex.ExecuteNonQuery();
                    Con.Close();
                    GetLastIndexValue();
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
            else if (tableName == "PromoProducts")
            {
                try
                {
                    Con.Open();
                    SqlCommand cmdIndex = new SqlCommand("INSERT INTO tbPromoProductsIndex (startDATE) " +
                        "VALUES (@startDate)", Con);
                    cmdIndex.Parameters.AddWithValue("startDate", DateTime.Now);
                    cmdIndex.ExecuteNonQuery();
                    GetLastIndexValue();
                    Con.Close();
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }
        private void DataTables_Update()
        {
            GetStdTypesValues();
            try
            {
                dtCommissionsTypes.Clear();
                dtCommissionsIndex.Clear();
                dtCommissions.Clear();

                dtPromoProductsTypes.Clear();
                dtPromoProductsIndex.Clear();
                dtPromoProducts.Clear();

                dtStdValues.Clear();

                SqlDataAdapter sdaStdValues = new SqlDataAdapter("Select * from tbStdValues", Con);
                sdaStdValues.Fill(dtStdValues);
                txtTecNumComm.Text = dtStdValues.Rows[0]["techniciansNumber"].ToString();
                txtTecNumProd.Text = dtStdValues.Rows[0]["techniciansNumber"].ToString();


                /* //////////// DATETIMEPICKER //////////// */
                SqlDataAdapter sdaCommissionsIndex = new SqlDataAdapter("SELECT * from tbCommissionsIndex " +
                    "WHERE idCommissionIndex = " + idCommissionsIndex + "", Con);
                sdaCommissionsIndex.Fill(dtCommissionsIndex);
                dtpCommStartDate.Value = Convert.ToDateTime(dtCommissionsIndex.Rows[0]["startDate"]);
                if (dtCommissionsIndex.Rows[0]["closureDate"].ToString() == string.Empty)
                {
                    dtpCommClosureDate.Enabled = false;
                    dtpCommClosureDate.CustomFormat = " ";
                    dtpCommClosureDate.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtpCommClosureDate.Enabled = true;
                    dtpCommClosureDate.CustomFormat = null;
                    dtpCommClosureDate.Value = Convert.ToDateTime(dtCommissionsIndex.Rows[0]["closureDate"]);
                }

                SqlDataAdapter sdaPromoProductsIndex = new SqlDataAdapter("SELECT * from tbPromoProductsIndex " +
                    "WHERE idPromoProductIndex = " + idPromoProductsIndex + "", Con);
                sdaPromoProductsIndex.Fill(dtPromoProductsIndex);
                dtpPromoProdStartDate.Value = Convert.ToDateTime(dtPromoProductsIndex.Rows[0]["startDate"]);
                if (dtPromoProductsIndex.Rows[0]["closureDate"].ToString() == string.Empty)
                {
                    dtpPromoProdClosureDate.Enabled = false;
                    dtpPromoProdClosureDate.CustomFormat = " ";
                    dtpPromoProdClosureDate.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtpPromoProdClosureDate.Enabled = true;
                    dtpPromoProdClosureDate.CustomFormat = null;
                    dtpPromoProdClosureDate.Value = Convert.ToDateTime(dtPromoProductsIndex.Rows[0]["closureDate"]);
                }


                /* //////////// COMBOBOX //////////// */
                SqlDataAdapter sdaCommissionTypes = new SqlDataAdapter("Select * from tbCommissionsTypes", Con);
                sdaCommissionTypes.Fill(dtCommissionsTypes);
                cbCommissionName.DataSource = dtCommissionsTypes;
                cbCommissionName.ValueMember = "idCommissionType";
                cbCommissionName.DisplayMember = "commissionName";
                if (dtCommissionsTypes.Rows.Count > 0)
                {
                    cbCommissionName.SelectedIndex = idStdCommissionType - 1;
                }

                SqlDataAdapter sdaPromoProdTypes = new SqlDataAdapter("Select * from tbPromoProductsTypes", Con);
                sdaPromoProdTypes.Fill(dtPromoProductsTypes);
                cbPromoProdName.DataSource = dtPromoProductsTypes;
                cbPromoProdName.ValueMember = "idPromoProductType";
                cbPromoProdName.DisplayMember = "PromoProductName";
                if (dtPromoProductsTypes.Rows.Count > 0)
                {
                    cbPromoProdName.SelectedIndex = idStdPromoProductType - 1;
                }



                /* //////////// DATAGRIDVIEW //////////// */
                SqlDataAdapter sdaDgvCommissions = new SqlDataAdapter("Select idCommission, TC.idCommissionIndex, osNumber AS [N. da O.S.], TC.idCommissionType, TCT.commissionName AS [Tipo de Comissão], TC.value AS Valor from tbCommissions TC " +
                    "JOIN tbCommissionsIndex TCI ON TCI.idCommissionIndex = TC.idCommissionIndex " +
                    "JOIN tbCommissionsTypes TCT ON TCT.idCommissionType = TC.idCommissionType " +
                    "WHERE TC.idCommissionIndex = " + idCommissionsIndex + " " +
                    "ORDER BY idCommission DESC", Con);
                sdaDgvCommissions.Fill(dtCommissions);
                dgvCommissions.DataSource = dtCommissions;
                dgvCommissions.Columns["idCommission"].Visible = false;
                dgvCommissions.Columns["idCommissionIndex"].Visible = false;
                dgvCommissions.Columns["idCommissionType"].Visible = false;


                SqlDataAdapter sdaDgvPromoProducts = new SqlDataAdapter("Select idPromoProduct, TP.idPromoProductIndex, osNumber AS [N. da O.S.], TP.idPromoProductType, TPT.PromoProductName AS [Nome do Produto], TP.value AS Valor from tbPromoProducts TP " +
                    "JOIN tbPromoProductsIndex TPI ON TPI.idPromoProductIndex = TP.idPromoProductIndex " +
                    "JOIN tbPromoProductsTypes TPT ON TPT.idPromoProductType = TP.idPromoProductType " +
                    "WHERE TP.idPromoProductIndex = " + idPromoProductsIndex + " " +
                    "ORDER BY idPromoProduct DESC", Con);
                sdaDgvPromoProducts.Fill(dtPromoProducts);
                dgvPromoProducts.DataSource = dtPromoProducts;
                dgvPromoProducts.Columns["idPromoProduct"].Visible = false;
                dgvPromoProducts.Columns["idPromoProductIndex"].Visible = false;
                dgvPromoProducts.Columns["idPromoProductType"].Visible = false;


                CalculateLabels();
                ChkBtnsConditions(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void CbBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drvComm = cbCommissionName.SelectedItem as DataRowView;
                DataRowView drvPromoProd = cbPromoProdName.SelectedItem as DataRowView;
                if (drvComm != null)
                {
                    idCommissionType = Convert.ToInt32(drvComm.Row["idCommissionType"]);
                    txtCommValue.Text = "R$ " + Convert.ToDouble(drvComm.Row["value"]).ToString("0.00");
                }

                if (drvPromoProd != null)
                {
                    idPromoProductType = Convert.ToInt32(drvPromoProd.Row["idPromoProductType"]);
                    txtPromoProductValue.Text = "R$ " + Convert.ToDouble(drvPromoProd.Row["value"]).ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void SaveOperation(object sender, EventArgs e)
        {
            char[] MyChar = { 'R', '$', ' ' };
            if (sender == btnSaveCommission)
            {
                if (idCommission == -1)
                {
                    try
                    {
                        FrmDialog frmDialog = new FrmDialog("Deseja incluir Produto Promocional para esta O.S.?");
                        frmDialog.ShowDialog();

                        Con.Open();
                        if (frmDialog.DialogResult == DialogResult.Yes)
                        {
                            SqlCommand cmdIncludePromoProd = new SqlCommand("INSERT INTO tbPromoProducts (idPromoProductIndex, date, osNumber, idPromoProductType, value)" +
                            "VALUES (@idPromoProductIndex, @date, @osNumber, @idPromoProductType, @value)", Con);
                            cmdIncludePromoProd.Parameters.AddWithValue("idPromoProductIndex", idPromoProductsIndex);
                            cmdIncludePromoProd.Parameters.AddWithValue("date", DateTime.Now);
                            cmdIncludePromoProd.Parameters.AddWithValue("osNumber", Convert.ToInt32(txtComOsNum.Text));
                            cmdIncludePromoProd.Parameters.AddWithValue("idPromoProductType", idPromoProductType);
                            cmdIncludePromoProd.Parameters.AddWithValue("value", Convert.ToDouble(txtPromoProductValue.Text.TrimStart(MyChar)));
                            cmdIncludePromoProd.ExecuteNonQuery();
                        }

                        SqlCommand cmd = new SqlCommand("INSERT INTO tbCommissions (idCommissionIndex, date, osNumber, idCommissionType, value)" +
                            "VALUES (@idCommissionIndex, @date, @osNumber, @idCommissionType, @value)", Con);
                        cmd.Parameters.AddWithValue("idCommissionIndex", idCommissionsIndex);
                        cmd.Parameters.AddWithValue("date", DateTime.Now);
                        cmd.Parameters.AddWithValue("osNumber", Convert.ToInt32(txtComOsNum.Text));
                        cmd.Parameters.AddWithValue("idCommissionType", idCommissionType);
                        cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtCommValue.Text.TrimStart(MyChar)));
                        cmd.ExecuteNonQuery();
                        Con.Close();

                        ClearFields(lblClearCommissions, null);
                    }
                    catch (Exception ex)
                    {
                        Con.Close();
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                else
                {
                    UpdateOperation(btnSaveCommission, null);
                }
            }
            else if (sender == btnSavePromoProduct)
            {
                if (idPromoProduct == -1)
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbPromoProducts (idPromoProductIndex, date, osNumber, idPromoProductType, value)" +
                            "VALUES (@idPromoProductIndex, @date, @osNumber, @idPromoProductType, @value)", Con);
                        cmd.Parameters.AddWithValue("idPromoProductIndex", idPromoProductsIndex);
                        cmd.Parameters.AddWithValue("date", DateTime.Now);
                        cmd.Parameters.AddWithValue("osNumber", Convert.ToInt32(txtPromoProdOSNum.Text));
                        cmd.Parameters.AddWithValue("idPromoProductType", idPromoProductType);
                        cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtPromoProductValue.Text.TrimStart(MyChar)));
                        cmd.ExecuteNonQuery();
                        Con.Close();

                        ClearFields(lblClearPromoProducts, null);
                    }
                    catch (Exception ex)
                    {
                        Con.Close();
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                else
                {
                    UpdateOperation(btnSavePromoProduct, null);
                }
            }

            UpdateIndexTablesDate();
            DataTables_Update();
            ChkBtnsConditions(sender, null);
        }
        private void UpdateOperation(object sender, EventArgs e)
        {
            char[] MyChar = { 'R', '$', ' ' };
            if (sender == btnSaveCommission)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbCommissions SET osNumber=@osNumber, idCommissionType=@idCommissionType, value=@value " +
                            "WHERE idCommission = " + idCommission + "", Con);
                    cmd.Parameters.AddWithValue("osNumber", Convert.ToInt32(txtComOsNum.Text));
                    cmd.Parameters.AddWithValue("idCommissionType", idCommissionType);
                    cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtCommValue.Text.TrimStart(MyChar)));
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    ClearFields(lblClearCommissions, null);
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
            else if (sender == btnSavePromoProduct)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE tbPromoProducts SET osNumber=@osNumber, idPromoProductType=@idPromoProductType, value=@value " +
                            "WHERE idPromoProduct = " + idPromoProduct + "", Con);
                    cmd.Parameters.AddWithValue("osNumber", Convert.ToInt32(txtPromoProdOSNum.Text));
                    cmd.Parameters.AddWithValue("idPromoProductType", idPromoProductType);
                    cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtPromoProductValue.Text.TrimStart(MyChar)));
                    cmd.ExecuteNonQuery();
                    Con.Close();

                    ClearFields(lblClearPromoProducts, null);
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }

            UpdateIndexTablesDate();
            DataTables_Update();
            ChkBtnsConditions(sender, null);
        }
        private void UpdateIndexTablesDate()
        {
            try
            {
                Con.Open();
                SqlCommand cmdUSD_Comm = new SqlCommand("UPDATE tbCommissionsIndex SET startDate=@startDate " +
                    "WHERE idCommissionIndex = " + idCommissionsIndex + "", Con);
                cmdUSD_Comm.Parameters.AddWithValue("startDate", dtpCommStartDate.Value);
                cmdUSD_Comm.ExecuteNonQuery();
                if (dtpCommClosureDate.Enabled == true)
                {
                    SqlCommand cmdUCD_Comm = new SqlCommand("UPDATE tbCommissionsIndex SET closureDate=@closureDate " +
                        "WHERE idCommissionIndex = " + idCommissionsIndex + "", Con);
                    cmdUCD_Comm.Parameters.AddWithValue("closureDate", dtpCommClosureDate.Value);
                    cmdUCD_Comm.ExecuteNonQuery();
                }

                SqlCommand cmdUSDPromoProd = new SqlCommand("UPDATE tbPromoProductsIndex SET startDate=@startDate " +
                    "WHERE idPromoProductIndex = " + idPromoProductsIndex + "", Con);
                cmdUSDPromoProd.Parameters.AddWithValue("startDate", dtpPromoProdStartDate.Value);
                cmdUSDPromoProd.ExecuteNonQuery();
                if (dtpPromoProdClosureDate.Enabled == true)
                {
                    SqlCommand cmdUCD_PromoProd = new SqlCommand("UPDATE tbPromoProductsIndex SET closureDate=@closureDate " +
                        "WHERE idPromoProductIndex = " + idPromoProductsIndex + "", Con);
                    cmdUCD_PromoProd.Parameters.AddWithValue("closureDate", dtpPromoProdClosureDate.Value);
                    cmdUCD_PromoProd.ExecuteNonQuery();
                }
                Con.Close();
            }

            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void DeleteOperation(object sender, EventArgs e)
        {
            if (sender == btnDeleteCommission)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbCommissions WHERE idCommission = " + idCommission + "", Con);
                    cmd.ExecuteNonQuery();

                    /* //////////// RESEED THE TABLE //////////// */
                    SqlCommand cmdReseed = new SqlCommand("DECLARE @MAX int " +
                    "SELECT @MAX = MAX([idCommission]) FROM[tbCommissions] " +
                    "IF @MAX IS NULL " +
                    "SET @MAX = 0 " +
                    "DBCC CHECKIDENT('[tbCommissions]', RESEED, @MAX)", Con);
                    cmdReseed.ExecuteNonQuery();

                    Con.Close();

                    ClearFields(lblClearCommissions, null);
                    DataTables_Update();
                    ChkBtnsConditions(sender, null);
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
            else if (sender == btnDeletePromoProduct)
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbPromoProducts WHERE idPromoProduct = " + idPromoProduct + "", Con);
                    cmd.ExecuteNonQuery();

                    /* //////////// RESEED THE TABLE //////////// */
                    SqlCommand cmdReseed = new SqlCommand("DECLARE @MAX int " +
                    "SELECT @MAX = MAX([idPromoProduct]) FROM[tbPromoProducts] " +
                    "IF @MAX IS NULL " +
                    "SET @MAX = 0 " +
                    "DBCC CHECKIDENT('[tbPromoProducts]', RESEED, @MAX)", Con);
                    cmdReseed.ExecuteNonQuery();

                    Con.Close();

                    ClearFields(lblClearPromoProducts, null);
                    DataTables_Update();
                    ChkBtnsConditions(sender, null);
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }
        private void CloseDateOperation(object sender, EventArgs e)
        {
            FrmDialog frmClosureDialog = new FrmDialog("Deseja mesmo fazer o Fechamento?");
            if (frmClosureDialog.ShowDialog() == DialogResult.Yes)
            {
                try
                {
                    if (sender == btnClosureDateComm)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE tbCommissionsIndex SET closureDATE=@closureDate", Con);
                        cmd.Parameters.AddWithValue("closureDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        GetLastIndexValue();
                        DataTables_Update();
                        ClearFields(lblClearCommissions, null);
                        ChkBtnsConditions(sender, null);
                    }
                    else if (sender == btnClosureDatePromoProd)
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE tbPromoProductsIndex SET closureDATE=@closureDate", Con);
                        cmd.Parameters.AddWithValue("closureDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        Con.Close();
                        GetLastIndexValue();
                        DataTables_Update();
                        ClearFields(lblClearPromoProducts, null);
                        ChkBtnsConditions(sender, null);
                    }
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }



        /* //////////// PREVIOUS RECORDS //////////// */
        private void DgvPreviousRecords_Update()
        {
            try
            {
                SqlDataAdapter sdaCommissions = new SqlDataAdapter("SELECT TCI.idCommissionIndex, startDate AS [Data de Início], closureDate AS [Data de Fechamento], COUNT (TC.idCommission) AS [Comissões], SUM (TC.value) AS [Total] from tbCommissionsIndex TCI " +
                    "JOIN tbCommissions TC ON TC.idCommissionIndex = TCI.idCommissionIndex " +
                    "WHERE closureDate IS NOT NULL " +
                    "GROUP BY TCI.idCommissionIndex, startDate, closureDate " +
                    "ORDER BY startDate DESC", Con);
                DataTable dtCommissions = new DataTable();
                sdaCommissions.Fill(dtCommissions);
                dgvPrevRecComm.DataSource = dtCommissions;
                dgvPrevRecComm.Columns["idCommissionIndex"].Visible = false;

                SqlDataAdapter sdaPromoProducts = new SqlDataAdapter("SELECT TPI.idPromoProductIndex, startDate AS [Data de Início], closureDate AS [Data de Fechamento], COUNT (TP.idPromoProduct) AS [Produtos], SUM (TP.value) AS [Total] from tbPromoProductsIndex TPI " +
                    "JOIN tbPromoProducts TP ON TP.idPromoProductIndex = TPI.idPromoProductIndex " +
                    "WHERE closureDate IS NOT NULL " +
                    "GROUP BY TPI.idPromoProductIndex, startDate, closureDate " +
                    "ORDER BY startDate DESC", Con);
                DataTable dtPromoProducts = new DataTable();
                sdaPromoProducts.Fill(dtPromoProducts);
                dgvPrevRecPromoProd.DataSource = dtPromoProducts;
                dgvPrevRecPromoProd.Columns["idPromoProductIndex"].Visible = false;
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
            
        }
        private void DgvPreviousRecords_CellClick (object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                try
                {
                    if (sender == dgvPrevRecComm)
                    {
                        DataGridViewRow selectedrow = dgvPrevRecComm.Rows[index];
                        idCommissionsIndex = Convert.ToInt32(selectedrow.Cells["idCommissionIndex"].Value);
                        DateTime startDate = Convert.ToDateTime(selectedrow.Cells["Data de Início"].Value);
                        DateTime closureDate = Convert.ToDateTime(selectedrow.Cells["Data de Fechamento"].Value);
                        lblPrevRecCommWorkedDays.Text = CalculateWorkedDays(startDate, closureDate);
                        foreach (BunifuButton button in pnPrevRecComm.Controls.OfType<BunifuButton>())
                        {
                            button.Enabled = true;
                        }
                    }
                    else if (sender == dgvPrevRecPromoProd)
                    {
                        DataGridViewRow selectedrow = dgvPrevRecPromoProd.Rows[index];
                        idPromoProductsIndex = Convert.ToInt32(selectedrow.Cells["idPromoProductIndex"].Value);
                        DateTime startDate = Convert.ToDateTime(selectedrow.Cells["Data de Início"].Value);
                        DateTime closureDate = Convert.ToDateTime(selectedrow.Cells["Data de Fechamento"].Value);
                        lblPrevRecPromoProdWorkedDays.Text = CalculateWorkedDays(startDate, closureDate);
                        foreach (BunifuButton button in pnPrevRecPromoProd.Controls.OfType<BunifuButton>())
                        {
                            button.Enabled = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }
        private void DgvPreviousRecords_CellDoubleClick (object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                DataTables_Update();
                pnCommissions.BringToFront();
            }
        }
        private void BtnPrevRecEdit_Click (object sender, EventArgs e)
        {
            DataTables_Update();
            pnCommissions.BringToFront();
        }
        private void BtnPrevRecDelete_Click (object sender, EventArgs e)
        {
            FrmDialog dlg = new FrmDialog("Tem certeza que deseja excluir este fechamento?");
            dlg.ShowDialog();
            if (dlg.DialogResult == DialogResult.Yes)
            {
                try
                {
                    if (sender == btnPrevRecCommDelete)
                    {
                        Con.Open();
                        SqlCommand cmdCommDelete = new SqlCommand("DELETE FROM tbCommissions WHERE idCommissionIndex = " + idCommissionsIndex + "", Con);
                        cmdCommDelete.ExecuteNonQuery();
                        /* //////////// RESEED THE TABLE //////////// */
                        SqlCommand cmdReseedCommissions = new SqlCommand("DECLARE @MAX int " +
                        "SELECT @MAX = MAX([idCommission]) FROM[tbCommissions] " +
                        "IF @MAX IS NULL " +
                        "SET @MAX = 0 " +
                        "DBCC CHECKIDENT('[tbCommissions]', RESEED, @MAX)", Con);
                        cmdReseedCommissions.ExecuteNonQuery ();

                        SqlCommand cmdCommIndexDelete = new SqlCommand("DELETE FROM tbCommissionsIndex WHERE idCommissionIndex = " + idCommissionsIndex + "", Con);
                        cmdCommIndexDelete.ExecuteNonQuery();
                        /* //////////// RESEED THE TABLE //////////// */
                        SqlCommand cmdReseedCommissionsIndex = new SqlCommand("DECLARE @MAX int " +
                        "SELECT @MAX = MAX([idCommissionIndex]) FROM[tbCommissionsIndex] " +
                        "IF @MAX IS NULL " +
                        "SET @MAX = 0 " +
                        "DBCC CHECKIDENT('[tbCommissionsIndex]', RESEED, @MAX)", Con);
                        cmdReseedCommissionsIndex.ExecuteNonQuery();
                        Con.Close();

                        lblPrevRecCommWorkedDays.Text = string.Empty;
                        foreach (BunifuButton button in pnPrevRecComm.Controls.OfType<BunifuButton>())
                        {
                            button.Enabled = false;
                        }
                    }
                    else if (sender == btnPrevRecPromoProdDelete)
                    {
                        Con.Open();
                        SqlCommand cmdPromoProdDelete = new SqlCommand("DELETE FROM tbPromoProducts WHERE idPromoProductIndex = " + idPromoProductsIndex + "", Con);
                        cmdPromoProdDelete.ExecuteNonQuery();
                        /* //////////// RESEED THE TABLE //////////// */
                        SqlCommand cmdReseedPromoProducts = new SqlCommand("DECLARE @MAX int " +
                        "SELECT @MAX = MAX([idPromoProduct]) FROM[tbPromoProducts] " +
                        "IF @MAX IS NULL " +
                        "SET @MAX = 0 " +
                        "DBCC CHECKIDENT('[tbPromoProducts]', RESEED, @MAX)", Con);
                        cmdReseedPromoProducts.ExecuteNonQuery();

                        SqlCommand cmdPromoProdIndexDelete = new SqlCommand("DELETE FROM tbPromoProductsIndex WHERE idPromoProductIndex = " + idPromoProductsIndex + "", Con);
                        cmdPromoProdIndexDelete.ExecuteNonQuery();
                        /* //////////// RESEED THE TABLE //////////// */
                        SqlCommand cmdReseedPromoProductsIndex = new SqlCommand("DECLARE @MAX int " +
                        "SELECT @MAX = MAX([idPromoProductIndex]) FROM[tbPromoProductsIndex] " +
                        "IF @MAX IS NULL " +
                        "SET @MAX = 0 " +
                        "DBCC CHECKIDENT('[tbPromoProductsIndex]', RESEED, @MAX)", Con);
                        cmdReseedPromoProductsIndex.ExecuteNonQuery();
                        Con.Close();

                        lblPrevRecPromoProdWorkedDays.Text = string.Empty;
                        foreach (BunifuButton button in pnPrevRecPromoProd.Controls.OfType<BunifuButton>())
                        {
                            button.Enabled = false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
                
                DgvPreviousRecords_Update();
            }
        }

    }
}
