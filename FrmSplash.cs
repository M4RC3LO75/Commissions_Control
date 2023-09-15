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
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Controle_de_Comissões
{
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
            progressBar.Value = 0;
            Timer.Start();
        }

        SqlConnection Con = new SqlConnection(ConString.Connection);


        DataTable dtbStdValues = new DataTable();
        DataTable dtbCommissionsTypes = new DataTable();
        DataTable dtbPromoProductsTypes = new DataTable();

        private async void Timer_Tick(object sender, EventArgs e)
        {
            progressBar.Value += 1;
            if (progressBar.Value == 100)
            {
                Timer.Stop();
                await Task.Delay(600);
                CheckTables();
            }
        }
        private async void CheckTables()
        {
            Dtb_Update();
            if (dtbStdValues.Rows.Count == 0)
            {
                FrmStdValues frmStdValues = new FrmStdValues();
                this.Hide();
                frmStdValues.ShowDialog();
                this.Show();
                await Task.Delay(600);
            }

            Dtb_Update();
            if (dtbCommissionsTypes.Rows.Count == 0 || dtbPromoProductsTypes.Rows.Count == 0)
            {
                FrmCommNProd frmCommNProd = new FrmCommNProd();
                this.Hide();
                frmCommNProd.ShowDialog();
                this.Show();
                await Task.Delay(600);
            }

            Dtb_Update();
            if (dtbStdValues.Rows.Count > 0 && dtbCommissionsTypes.Rows.Count > 0 && dtbPromoProductsTypes.Rows.Count > 0)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                Application.Exit();
            }
        }

        private void Dtb_Update()
        {
            dtbStdValues.Clear();
            dtbCommissionsTypes.Clear();
            dtbPromoProductsTypes.Clear();
            try
            {
                SqlDataAdapter sdaStdValues = new SqlDataAdapter("SELECT idStdValue from tbStdValues", Con);
                sdaStdValues.Fill(dtbStdValues);
                SqlDataAdapter sdaCommTypes = new SqlDataAdapter("SELECT idCommissionType from tbCommissionsTypes", Con);
                sdaCommTypes.Fill(dtbCommissionsTypes);
                SqlDataAdapter sdaPromoProdTypes = new SqlDataAdapter("SELECT idPromoProductType from tbPromoProductsTypes", Con);
                sdaPromoProdTypes.Fill(dtbPromoProductsTypes);
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
    }
}
