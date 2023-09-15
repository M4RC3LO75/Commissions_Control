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

namespace Controle_de_Comissões
{
    public partial class FrmSuppliers : Form
    {
        public FrmSuppliers()
        {
            InitializeComponent();
            DgvSuppliers_Update();
        }

        SqlConnection Con = new SqlConnection(ConString.Connection);

        int idSupplier = 0;
        DataTable dtSuppliers = new DataTable();


        /* //////////// BUTTONS //////////// */
        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        private void BtnSaveCommission_Click(object sender, EventArgs e)
        {
            SaveSupplier();
        }
        private void BtnDeleteCommission_Click(object sender, EventArgs e)
        {
            DeleteSupplier();
        }


        /* //////////// FUNCTIONS //////////// */
        private void ClearFields()
        {
            idSupplier = 0;
            foreach (TextBox textbox in pnFields.Controls.OfType<TextBox>())
            {
                textbox.Text = string.Empty;
            }
            txtSite.Text = string.Empty;
            ChkButtonsCondition();
            ActiveControl = txtSupplierName;
        }
        private void ChkButtonsCondition()
        {
            if (idSupplier > 0)
            {
                btnDeleteCommission.Enabled = true;
            }
            else
            {
                btnDeleteCommission.Enabled = false;
            }
            if (txtSupplierName.Text != string.Empty)
            {
                btnSaveCommission.Enabled = true;
            }
            else
            {
                btnSaveCommission.Enabled= false;
            }
        }
        private void Txt_KeyUp(object sender, KeyEventArgs e)
        {
            ChkButtonsCondition();
        }
        private void DgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedrow = dgvSuppliers.Rows[index];
                    idSupplier = Convert.ToInt32(selectedrow.Cells["idSupplier"].Value);
                    txtSupplierName.Text = selectedrow.Cells["supplierName"].Value.ToString();
                    txtContact.Text = selectedrow.Cells["contact"].Value.ToString();
                    txtPhone1.Text = selectedrow.Cells["Phone1"].Value.ToString();
                    txtPhone2.Text = selectedrow.Cells["Phone2"].Value.ToString();
                    txtAddress.Text = selectedrow.Cells["address"].Value.ToString();
                    txtCity.Text = selectedrow.Cells["city"].Value.ToString();
                    txtState.Text = selectedrow.Cells["state"].Value.ToString();
                    txtSite.Text = selectedrow.Cells["site"].Value.ToString();
                    txtEmail.Text = selectedrow.Cells["email"].Value.ToString();
                    txtDescription.Text = selectedrow.Cells["description"].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO: " + ex);
                }
                ChkButtonsCondition();
            }
        }


        /* //////////// SQL OPERATIONS //////////// */
        private void DgvSuppliers_Update()
        {
            try
            {
                dtSuppliers.Clear();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbSuppliers ORDER BY supplierName", Con);
                sda.Fill(dtSuppliers);
                dgvSuppliers.DataSource = dtSuppliers;
                
                for (int i = 0; dgvSuppliers.Columns.Count > i; i++)
                {
                    dgvSuppliers.Columns[i].Visible = false;
                }

                dgvSuppliers.Columns["supplierName"].HeaderText = "Nome";
                dgvSuppliers.Columns["supplierName"].Visible = true;
                dgvSuppliers.Columns["contact"].HeaderText = "Contato";
                dgvSuppliers.Columns["contact"].Visible = true;
                dgvSuppliers.Columns["Phone1"].HeaderText = "Telefone";
                dgvSuppliers.Columns["Phone1"].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
            
        }
        private void SaveSupplier()
        {
            try
            {
                if (idSupplier == 0)
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbSuppliers (supplierName, contact, Phone1, Phone2, address, city, state, site, email, description) " +
                        "VALUES (@supplierName, @contact, @Phone1, @Phone2, @address, @city, @state, @site, @email, @description)", Con);
                    cmd.Parameters.AddWithValue("supplierName", txtSupplierName.Text);
                    cmd.Parameters.AddWithValue("contact", txtContact.Text);
                    cmd.Parameters.AddWithValue("Phone1", txtPhone1.Text);
                    cmd.Parameters.AddWithValue("Phone2", txtPhone2.Text);
                    cmd.Parameters.AddWithValue("address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("city", txtCity.Text);
                    cmd.Parameters.AddWithValue("state", txtState.Text);
                    cmd.Parameters.AddWithValue("site", txtSite.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("description", txtDescription.Text);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    DgvSuppliers_Update();
                    ClearFields();
                }
                else
                {
                    UpdateSupplier();
                }
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void UpdateSupplier()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbSuppliers SET supplierName=@supplierName, contact=@contact, Phone1=@Phone1, Phone2=@Phone2, address=@address, city=@city, state=@state, site=@site, email=@email, description=@description " +
                    "WHERE idSupplier = " + idSupplier + "", Con);
                cmd.Parameters.AddWithValue("supplierName", txtSupplierName.Text);
                cmd.Parameters.AddWithValue("contact", txtContact.Text);
                cmd.Parameters.AddWithValue("Phone1", txtPhone1.Text);
                cmd.Parameters.AddWithValue("Phone2", txtPhone2.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("city", txtCity.Text);
                cmd.Parameters.AddWithValue("state", txtState.Text);
                cmd.Parameters.AddWithValue("site", txtSite.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("description", txtDescription.Text);
                cmd.ExecuteNonQuery();
                Con.Close();
                DgvSuppliers_Update();
                ClearFields();
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void DeleteSupplier()
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM tbSuppliers WHERE idSupplier = " + idSupplier + "", Con);
                cmd.ExecuteNonQuery();

                /* //////////// RESEED THE TABLE //////////// */
                SqlCommand cmdReseed = new SqlCommand("DECLARE @MAX int " +
                "SELECT @MAX = MAX([idSupplier]) FROM[tbSuppliers] " +
                "IF @MAX IS NULL " +
                "SET @MAX = 0 " +
                "DBCC CHECKIDENT('[tbSuppliers]', RESEED, @MAX)", Con);
                cmdReseed.ExecuteNonQuery();
                Con.Close();
                DgvSuppliers_Update();
                ClearFields();
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }

    }
}
