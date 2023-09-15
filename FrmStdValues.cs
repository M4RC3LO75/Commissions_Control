using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Comissões
{
    public partial class FrmStdValues : Form
    {
        public FrmStdValues()
        {
            InitializeComponent();
            GetDataTableValues();
        }
        SqlConnection Con = new SqlConnection(ConString.Connection);
        DataTable dtStdValues = new DataTable();


        /* //////////// BUTTONS //////////// */
        private void PicClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        /* //////////// FUNCTIONS //////////// */
        private void ChkBtnSaveCondition(object sender, KeyEventArgs e)
        {
            if (pnMain.Controls.OfType<TextBox>().Any(textBox => string.IsNullOrWhiteSpace(textBox.Text)))
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }
        private void TxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (sender == txtParcelPctCalc)
                {
                    SaveStdValues(null, null);
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
        private void TxtBox_Leave(object sender, EventArgs e)
        {
            if (sender == txtCommValue)
            {
                char[] MyChar = { 'R', '$', ' ' };
                txtCommValue.Text = "R$ " + Convert.ToDouble(txtCommValue.Text.TrimStart(MyChar)).ToString("0.00");
            }
        }
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] MyChar = { 'R', '$', ' ' };
            Control control = sender as Control;
            string numberString = control.Text.TrimStart(MyChar);

            if (sender == txtTechniciansNumb)
            {
                if (char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            else
            {
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

                /* //////////// ALLOW TWO DECIMAL DIGITS //////////// */
                if (Regex.IsMatch(numberString, @"\,\d\d") || Regex.IsMatch(numberString, @"\,\d\d"))
                {
                    //if (e.KeyChar == (char)Keys.Back)
                    //{
                    //    e.Handled = false;
                    //}
                    //else
                    //{
                    //    e.Handled = true;
                    //}
                }
            }
        }



        /* //////////// SQL OPERATIONS //////////// */
        private void GetDataTableValues()
        {
            try
            {
                dtStdValues.Clear();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * from tbStdValues", Con);
                sda.Fill(dtStdValues);
                if (dtStdValues.Rows.Count > 0)
                {
                    txtCommValue.Text = "R$ " + dtStdValues.Rows[0]["laborValue"].ToString();
                    txtTechniciansNumb.Text = dtStdValues.Rows[0]["techniciansNumber"].ToString();
                    txtMoneyPctCalc.Text = dtStdValues.Rows[0]["moneyPctCalc"].ToString();
                    txtCreditPctCalc.Text = dtStdValues.Rows[0]["creditPctCalc"].ToString();
                    txtParcelPctCalc.Text = dtStdValues.Rows[0]["ParcelPctCalc"].ToString();
                }
                ChkBtnSaveCondition(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }
        private void SaveStdValues(object sender, EventArgs e)
        {
            char[] MyChar = { 'R', '$', ' ' };
            try
            {
                if (dtStdValues.Rows.Count == 0)
                {
                    Con.Open();
                    //INSERT
                    SqlCommand cmd = new SqlCommand("INSERT INTO tbStdValues (laborValue, techniciansNumber, moneyPctCalc, creditPctCalc, parcelPctCalc) " +
                        "VALUES (@laborValue, @techniciansNumber, @moneyPctCalc, @creditPctCalc, @parcelPctCalc)", Con);
                    cmd.Parameters.AddWithValue("laborValue", Convert.ToDouble(txtCommValue.Text.TrimStart(MyChar)));
                    cmd.Parameters.AddWithValue("techniciansNumber", Convert.ToInt32(txtTechniciansNumb.Text));
                    cmd.Parameters.AddWithValue("moneyPctCalc", Convert.ToDouble(txtMoneyPctCalc.Text));
                    cmd.Parameters.AddWithValue("creditPctCalc", Convert.ToDouble(txtCreditPctCalc.Text));
                    cmd.Parameters.AddWithValue("parcelPctCalc", Convert.ToDouble(txtParcelPctCalc.Text));

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    GetDataTableValues();
                    MessageBox.Show("Dados salvos com sucesso.", "Informação",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    Con.Open();
                    //UPDATE
                    SqlCommand cmd = new SqlCommand("UPDATE tbStdValues SET laborValue=@laborValue, techniciansNumber=@techniciansNumber, moneyPctCalc=@moneyPctCalc, creditPctCalc=@creditPctCalc, parcelPctCalc=@parcelPctCalc", Con);
                    cmd.Parameters.AddWithValue("laborValue", Convert.ToDouble(txtCommValue.Text.TrimStart(MyChar)));
                    cmd.Parameters.AddWithValue("techniciansNumber", Convert.ToInt32(txtTechniciansNumb.Text));
                    cmd.Parameters.AddWithValue("moneyPctCalc", Convert.ToDouble(txtMoneyPctCalc.Text));
                    cmd.Parameters.AddWithValue("creditPctCalc", Convert.ToDouble(txtCreditPctCalc.Text));
                    cmd.Parameters.AddWithValue("parcelPctCalc", Convert.ToDouble(txtParcelPctCalc.Text));

                    cmd.ExecuteNonQuery();
                    Con.Close();
                    GetDataTableValues();
                    MessageBox.Show("Dados atualizados com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                ActiveControl = txtCommValue;
            }
            catch (Exception ex)
            {
                Con.Close();
                MessageBox.Show("ERRO: " + ex);
            }
        }
    }
}
