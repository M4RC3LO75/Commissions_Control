using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Controle_de_Comissões
{
    public partial class FrmCommNProd : Form
    {
        public FrmCommNProd()
        {
            InitializeComponent();
            DataGridView_Update();
            ClearFields(lblClearCommissions, null);
            ActiveControl = txtCommName;
        }
        SqlConnection Con = new SqlConnection(ConString.Connection);
        DataTable dtCommissions = new DataTable();
        DataTable dtProducts = new DataTable();
        int idCommission = -1;
        int idProduct = -1;



        /* //////////// BUTTONS //////////// */
        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /* //////////// FUNCTIONS //////////// */
        private void ClearFields(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control == lblClearCommissions)
            {
                idCommission = -1;
                txtCommName.Text = string.Empty;
                txtCommValue.Text = string.Empty;
                chkStdCommission.Checked = false;
                chkStdCommission.Enabled = true;
                ActiveControl = txtCommName;
            }
            else if (control == lblClearProducts)
            {
                idProduct = -1;
                txtProdName.Text = string.Empty;
                txtProdValue.Text = string.Empty;
                chkStdProduct.Checked = false;
                chkStdProduct.Enabled = true;
                ActiveControl = txtProdName;
            }
            ChkButtonsConditions(sender, null);
        }
        private void TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            Control control = sender as Control;
            if (e.KeyCode == Keys.Enter)
            {
                if (control == txtCommValue || control == txtProdValue)
                {
                    SaveOperation(sender, e);
                    e.SuppressKeyPress = true;
                }
                else
                {
                    e.Handled = true;
                    SendKeys.Send("{Tab}");
                    e.SuppressKeyPress = true;
                }
            }
        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
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
        private void ChkButtonsConditions(object sender, KeyEventArgs e)
        {
            if (sender == txtCommName || sender == txtCommValue || sender == dgvCommissions || sender == lblClearCommissions)
            {
                if (txtCommName.Text == string.Empty || txtCommValue.Text == string.Empty)
                {
                    btnSaveCommission.Enabled = false;
                    btnDeleteCommission.Enabled = false;
                }
                else
                {
                    btnSaveCommission.Enabled = true;
                    if (idCommission > 0)
                    {
                        btnDeleteCommission.Enabled = true;
                    }
                    else
                    {
                        btnDeleteCommission.Enabled = false;
                    }
                }
            }
            else if (sender == txtProdName || sender == txtProdValue || sender == dgvProducts || sender == lblClearProducts)
            {
                if (txtProdName.Text == string.Empty || txtProdValue.Text == string.Empty)
                {
                    btnSaveProduct.Enabled = false;
                    btnDeleteProduct.Enabled = false;
                }
                else
                {
                    btnSaveProduct.Enabled = true;
                    if (idProduct > 0)
                    {
                        btnDeleteProduct.Enabled = true;
                    }
                    else
                    {
                        btnDeleteProduct.Enabled = false;
                    }
                }
            }
        }
        private void DataGridView_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            Control control = sender as Control;
            if (e.RowIndex >= 0)
            {
                if (control == dgvCommissions)
                {
                    try
                    {
                        DataGridViewRow selectedrow = dgvCommissions.Rows[index];
                        idCommission = Convert.ToInt32(selectedrow.Cells["idCommissionType"].Value);
                        txtCommName.Text = selectedrow.Cells["commissionName"].Value.ToString();
                        txtCommValue.Text = selectedrow.Cells["value"].Value.ToString();
                        if (Convert.ToBoolean(selectedrow.Cells["stdCommission"].Value) == true)
                        {
                            chkStdCommission.Checked = true;
                            chkStdCommission.Enabled = false;
                        }
                        else
                        {
                            chkStdCommission.Checked = false;
                            chkStdCommission.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                else if (control == dgvProducts)
                {
                    try
                    {
                        DataGridViewRow selectedrow = dgvProducts.Rows[index];
                        idProduct = Convert.ToInt32(selectedrow.Cells["idPromoProductType"].Value);
                        txtProdName.Text = selectedrow.Cells["PromoProductName"].Value.ToString();
                        txtProdValue.Text = selectedrow.Cells["value"].Value.ToString();
                        if (Convert.ToBoolean(selectedrow.Cells["stdPromoProduct"].Value) == true)
                        {
                            chkStdProduct.Checked = true;
                            chkStdProduct.Enabled = false;
                        }
                        else
                        {
                            chkStdProduct.Checked = false;
                            chkStdProduct.Enabled = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                ChkButtonsConditions(sender, null);
            }
        }



        /* //////////// SQL OPERATIONS //////////// */
        private void DataGridView_Update()
        {
            try
            {
                dtCommissions.Clear();
                dtProducts.Clear();
                SqlDataAdapter sdaCommissions = new SqlDataAdapter("SELECT * FROM tbCommissionsTypes", Con);
                sdaCommissions.Fill(dtCommissions);
                dgvCommissions.DataSource = dtCommissions;
                dgvCommissions.Columns["idCommissionType"].Visible = false;
                dgvCommissions.Columns["commissionName"].HeaderText = "Tipo Comissão";
                dgvCommissions.Columns["value"].HeaderText = "Valor";
                dgvCommissions.Columns["stdCommission"].HeaderText = "Padrão";
                dgvCommissions.ClearSelection();

                SqlDataAdapter sdaProducts = new SqlDataAdapter("SELECT * FROM tbPromoProductsTypes", Con);
                sdaProducts.Fill(dtProducts);
                dgvProducts.DataSource = dtProducts;
                dgvProducts.Columns["idPromoProductType"].Visible = false;
                dgvProducts.Columns["PromoProductName"].HeaderText = "Produto";
                dgvProducts.Columns["value"].HeaderText = "Valor";
                dgvProducts.Columns["stdPromoProduct"].HeaderText = "Padrão";
                dgvProducts.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void SaveOperation(object sender, EventArgs e)
        {
            Control control = sender as Control;
            
            if (control == txtCommValue || control == btnSaveCommission)
            {
                if (idCommission == -1)
                {
                    try
                    {
                        Con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbCommissionsTypes (commissionName, value, stdCommission) " +
                            "VALUES(@commissionName, @value, @stdCommission)", Con);
                        cmd.Parameters.AddWithValue("commissionName", txtCommName.Text);
                        cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtCommValue.Text));

                        /* //////////// CHECK STANDARD COMMISSION //////////// */
                        if (dtCommissions.Rows.Count == 0)
                        {
                            cmd.Parameters.AddWithValue("stdCommission", 1);
                        }
                        else if(dtCommissions.Rows.Count > 0 && chkStdCommission.Checked == true)
                        {
                            SqlCommand clearStdCommissions = new SqlCommand("UPDATE tbCommissionsTypes SET stdCommission = 0", Con);
                            clearStdCommissions.ExecuteNonQuery();
                            cmd.Parameters.AddWithValue("stdCommission", 1);
                        }
                        else if (dtCommissions.Rows.Count > 0 && chkStdCommission.Checked == false)
                        {
                            cmd.Parameters.AddWithValue("stdCommission", 0);
                        }

                        cmd.ExecuteNonQuery();
                        ClearFields(lblClearCommissions, e);
                        DataGridView_Update();
                        Con.Close();
                    }
                    catch (Exception ex)
                    {
                        Con.Close();
                        MessageBox.Show("ERRO: " + ex);
                    }
                }
                else
                {
                    Con.Close();
                    UpdateOperation(sender, e);
                }
            }
            else if (control == txtProdValue || control == btnSaveProduct)
            {
                try
                {
                    Con.Open();
                    if (idProduct == -1)
                    {
                        SqlCommand cmd = new SqlCommand("INSERT INTO tbPromoProductsTypes (PromoProductName, value, stdPromoProduct) " +
                            "VALUES(@productName, @value, @stdProduct)", Con);
                        cmd.Parameters.AddWithValue("productName", txtProdName.Text);
                        cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtProdValue.Text));

                        /* //////////// CHECK STANDARD PRODUCT //////////// */
                        if (dtProducts.Rows.Count == 0)
                        {
                            cmd.Parameters.AddWithValue("stdProduct", 1);
                        }
                        else if (dtProducts.Rows.Count > 0 && chkStdProduct.Checked == true)
                        {
                            SqlCommand clearStdCommissions = new SqlCommand("UPDATE tbPromoProductsTypes SET stdPromoProduct = 0", Con);
                            clearStdCommissions.ExecuteNonQuery();
                            cmd.Parameters.AddWithValue("stdProduct", 1);
                        }
                        else if (dtProducts.Rows.Count > 0 && chkStdProduct.Checked == false)
                        {
                            cmd.Parameters.AddWithValue("stdProduct", 0);
                        }

                        cmd.ExecuteNonQuery();
                        ClearFields(lblClearProducts, e);
                        DataGridView_Update();
                        Con.Close();
                    }
                    else
                    {
                        Con.Close();
                        UpdateOperation(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    Con.Close();
                    MessageBox.Show("ERRO: " + ex);
                }
            }
        }
        private void UpdateOperation(object sender, EventArgs e)
        {
            Control control = sender as Control;
            try
            {
                Con.Open();
                if (control == txtCommValue || control == btnSaveCommission)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tbCommissionsTypes SET commissionName=@commName, value=@value, stdCommission=@stdComm " +
                        "WHERE idCommissionType = " + idCommission + "", Con);
                    cmd.Parameters.AddWithValue("commName", txtCommName.Text);
                    cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtCommValue.Text));
                    if (chkStdCommission.Checked == true)
                    {
                        SqlCommand clearStdCommissions = new SqlCommand("UPDATE tbCommissionsTypes SET stdCommission = 0", Con);
                        clearStdCommissions.ExecuteNonQuery();
                        cmd.Parameters.AddWithValue("stdComm", 1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("stdComm", 0);
                    }

                    cmd.ExecuteNonQuery();
                    ClearFields(lblClearCommissions, e);
                    DataGridView_Update();
                    Con.Close();
                }
                else if (control == txtProdValue || control == btnSaveProduct)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE tbPromoProductsTypes SET PromoProductName=@prodName, value=@value, stdPromoProduct=@stdProd " +
                        "WHERE idPromoProductType = " + idProduct + "", Con);
                    cmd.Parameters.AddWithValue("prodName", txtProdName.Text);
                    cmd.Parameters.AddWithValue("value", Convert.ToDouble(txtProdValue.Text));
                    if (chkStdProduct.Checked == true)
                    {
                        SqlCommand clearStdCommissionsProducts = new SqlCommand("UPDATE tbPromoProductsTypes SET stdPromoProduct = 0", Con);
                        clearStdCommissionsProducts.ExecuteNonQuery();
                        cmd.Parameters.AddWithValue("stdProd", 1);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("stdProd", 0);
                    }

                    cmd.ExecuteNonQuery();
                    ClearFields(lblClearProducts, e);
                    DataGridView_Update();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void DeleteOperation(object sender, EventArgs e)
        {
            Control control = sender as Control;
            try
            {
                Con.Open();
                if (control == btnDeleteCommission)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbCommissionsTypes WHERE idCommissionType = " + idCommission + "", Con);
                    cmd.ExecuteNonQuery();

                    /* //////////// CHECK IF COMMISSION IS STANDARD AND PASSES THE QUALIFY TO THE FIRST IN THE TABLE //////////// */
                    if (dtCommissions.Rows.Count > 0 && chkStdCommission.Checked == true)
                    {
                        SqlCommand cmdStd = new SqlCommand("UPDATE tbCommissionsTypes set stdCommission = 1 WHERE idCommissionType = (SELECT MIN(idCommissionType) from tbCommissionsTypes)", Con);
                        cmdStd.ExecuteNonQuery();
                    }

                    /* //////////// RESEED THE TABLE //////////// */
                    SqlCommand cmdReseed = new SqlCommand("DECLARE @MAX int " +
                    "SELECT @MAX = MAX([idCommissionType]) FROM[tbCommissionsTypes] " +
                    "IF @MAX IS NULL " +
                    "SET @MAX = 0 " +
                    "DBCC CHECKIDENT('[tbCommissionsTypes]', RESEED, @MAX)", Con);
                    cmdReseed.ExecuteNonQuery();

                    ClearFields(lblClearCommissions, e);
                    DataGridView_Update();
                    Con.Close();
                }
                else if (control == btnDeleteProduct)
                {
                    SqlCommand cmd = new SqlCommand("DELETE FROM tbPromoProductsTypes WHERE idPromoProductType = " + idProduct + "", Con);
                    cmd.ExecuteNonQuery();

                    /* //////////// CHECK IF COMMISSION IS STANDARD AND PASSES THE QUALIFY TO THE FIRST IN THE TABLE //////////// */
                    if (dtProducts.Rows.Count > 0 && chkStdProduct.Checked == true)
                    {
                        SqlCommand cmdStd = new SqlCommand("UPDATE tbPromoProductsTypes set stdPromoProduct = 1 WHERE idPromoProductType = (SELECT MIN(idPromoProductType) from tbPromoProductsTypes)", Con);
                        cmdStd.ExecuteNonQuery();
                    }

                    /* //////////// RESEED THE TABLE //////////// */
                    SqlCommand cmdReseed = new SqlCommand("DECLARE @MAX int " +
                    "SELECT @MAX = MAX([idPromoProductType]) FROM[tbPromoProductsTypes] " +
                    "IF @MAX IS NULL " +
                    "SET @MAX = 0 " +
                    "DBCC CHECKIDENT('[tbPromoProductsTypes]', RESEED, @MAX)", Con);
                    cmdReseed.ExecuteNonQuery();

                    ClearFields(lblClearProducts, e);
                    DataGridView_Update();
                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }

    }
}
