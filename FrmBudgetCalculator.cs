using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class FrmBudgetCalculator : Form
    {
        public FrmBudgetCalculator()
        {
            InitializeComponent();
            ActiveControl = txtPartCust;
            TbStdValues_FillDataTable();
        }
        SqlConnection Con = new SqlConnection(ConString.Connection);
        DataTable dtStdValues = new DataTable();
        double laborValue = 0.00;
        double partCust = 0.00;
        double moneyPctCalc = 0.00;
        double creditPctCalc = 0.00;
        double parcelPctCalc = 0.00;
        string fullText = string.Empty;

        private void TbStdValues_FillDataTable()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from tbStdValues", Con);
            sda.Fill(dtStdValues);
            laborValue = Convert.ToDouble(dtStdValues.Rows[0]["laborValue"]);
            moneyPctCalc = Convert.ToDouble(dtStdValues.Rows[0]["moneyPctCalc"]) * 0.01;
            creditPctCalc = Convert.ToDouble(dtStdValues.Rows[0]["creditPctCalc"]) * 0.01;
            parcelPctCalc = Convert.ToDouble(dtStdValues.Rows[0]["parcelPctCalc"]) * 0.01;
            txtLabor.Text = "R$ " + laborValue.ToString("0.00");
        }

        private void Txt_KeyDown(object sender, KeyEventArgs e)
        {
            Control control = sender as Control;
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                SendKeys.Send("{Tab}");
                e.SuppressKeyPress = true;
            }
        }
        private void Txt_LostFocus(object sender, EventArgs e)
        {
            Calculate();
            txtLabor.Text = "R$ " + laborValue.ToString("0.00");
            txtPartCust.Text = "R$ " + partCust.ToString("0.00");
        }
        private void SelectAllText(object sender, EventArgs e)
        {
            txtParcelNumbers.SelectionStart = 0;
            txtParcelNumbers.SelectionLength = txtParcelNumbers.Text.Length;
           
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
        private void CopyToClipboard(object sender, EventArgs e)
        {
            Control control = sender as Control;
            int duration = 5000;
            switch (control.Name)
            {
                case "copylblMoney": Clipboard.SetText(lblMoneyResult.Text);
                    toolTip.Show(lblMoneyResult.Text + "\r\nCopiado", copylblMoney, duration);
                    break;
                case "copylblCredit": Clipboard.SetText(lblCreditResult.Text);
                    toolTip.Show(lblCreditResult.Text + "\r\nCopiado", copylblCredit, duration);
                    break;
                case "copylblParcel": Clipboard.SetText(lblParcelResult.Text);
                    toolTip.Show(lblParcelResult.Text + "\r\nCopiado", copylblParcel, duration);
                    break;
                case "copylblFullText": Clipboard.SetText(fullText);
                    toolTip.Show("Texto Copiado", copylblFullText, duration);
                    break;
                default:
                    break;
            }
        }
        private void TxtParcelNum_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtParcelNumbers.Text == string.Empty)
            {
                txtParcelNumbers.Text = 2.ToString();
            }
            Calculate();
        }



        private void ChkBoxRoundMatch_Enter(object sender, EventArgs e)
        {
            ActiveControl = txtLabor;
        }
        private void ChkBoxRoundMatch_CheckedChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            char[] MyChar = { 'R', '$', ' ' };
            double moneyResult;
            double creditResult;
            double parcelResult;


            /* //////////// THIS GETS THE TEXTBOX VALUES //////////// */
            try
            {
                if (txtPartCust.Text == string.Empty)
                {
                    partCust = 0.00;
                }
                else
                {
                    partCust = Convert.ToDouble(txtPartCust.Text.TrimStart(MyChar));
                }
                if (txtLabor.Text == string.Empty)
                {
                    laborValue = 0.00;
                }
                else
                {
                    laborValue = Convert.ToDouble(txtLabor.Text.Trim(MyChar));
                }

                /* //////////// THIS DOES THE CALC BASED ON TEXTBOX VALUES //////////// */
                moneyResult = laborValue + (partCust + (partCust * moneyPctCalc));
                creditResult = moneyResult + (moneyResult * creditPctCalc);
                parcelResult = moneyResult + (moneyResult * parcelPctCalc);

                if (chkRoundMatch.Checked)
                {
                    MathCeiling(moneyResult, creditResult, parcelResult);
                }
                else
                {
                    lblMoneyResult.Text = "R$ " + moneyResult.ToString("0.00");
                    lblCreditResult.Text = "R$ " + creditResult.ToString("0.00");
                    lblParcelResult.Text = "R$ " + parcelResult.ToString("0.00");
                }

                lblFullText.Text = lblParcelResult.Text + " (em até " + txtParcelNumbers.Text + "x) ou \r\n" + 
                    lblCreditResult.Text + " (no Crédito ou Débito) ou \r\n" +
                    lblMoneyResult.Text + " (em *DINHEIRO*)";

                fullText = lblParcelResult.Text + " (em até " + txtParcelNumbers.Text + "x) ou " +
                    lblCreditResult.Text + " (no Crédito ou Débito) ou " +
                    lblMoneyResult.Text + " (em *DINHEIRO*)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }

        /* //////////// THIS DOES MATH CEILING //////////// */
        private void MathCeiling(double moneyResult, double creditResult, double parcelResult)
        {
            int moneyFinalRes = 0;
            int creditFinalRes = 0;
            int parcelFinalRes = 0;

            double moneyMath = Math.Ceiling(moneyResult);
            double creditMath = Math.Ceiling(creditResult);
            double parcelMath = Math.Ceiling(parcelResult);

            int[] moneyArray = moneyMath.ToString().Where(c => char.IsDigit(c)).Select(c1 => Convert.ToInt32(c1.ToString())).ToArray();
            int[] creditArray = creditMath.ToString().Where(c => char.IsDigit(c)).Select(c1 => Convert.ToInt32(c1.ToString())).ToArray();
            int[] parcelArray = parcelMath.ToString().Where(c => char.IsDigit(c)).Select(c1 => Convert.ToInt32(c1.ToString())).ToArray();

            int moneyFstNum = moneyArray.Length - 1;
            int moneySecNum = moneyArray.Length - 2;
            int creditFstNum = creditArray.Length - 1;
            int creditSecNum = creditArray.Length - 2;
            int parcelFstNum = parcelArray.Length - 1;
            int parcelSecNum = parcelArray.Length - 2;
            try
            {
                if (moneyArray[moneyFstNum] == 0)
                {
                    lblMoneyResult.Text = "R$ " + moneyMath.ToString("0.00");
                }
                else
                {
                    moneyArray[moneyFstNum] = 0;
                    if (moneyArray.Length > 1)
                    {
                        moneyArray[moneySecNum] += 1;
                    }
                    else
                    {
                        moneyArray = moneyArray.Append(10).ToArray();
                    }

                    for (int i = 0; moneyArray.Length > i; i++)
                    {
                        moneyFinalRes = moneyFinalRes * 10 + moneyArray[i];
                    }
                    lblMoneyResult.Text = "R$ " + moneyFinalRes.ToString("0.00");
                }



                if (creditArray[creditFstNum] == 0)
                {
                    lblCreditResult.Text = "R$ " + creditMath.ToString("0.00");
                }
                else
                {
                    creditArray[creditFstNum] = 0;
                    if (creditArray.Length > 1)
                    {
                        creditArray[creditSecNum] += 1;
                    }
                    else
                    {
                        creditArray = creditArray.Append(10).ToArray();
                    }
                    

                    for (int i = 0; creditArray.Length > i; i++)
                    {
                        creditFinalRes = creditFinalRes * 10 + creditArray[i];
                    }
                    lblCreditResult.Text = "R$ " + creditFinalRes.ToString("0.00");
                }


                if (parcelArray[parcelFstNum] == 0)
                {
                    lblParcelResult.Text = "R$ " + parcelMath.ToString("0.00");
                }
                else
                {
                    parcelArray[parcelFstNum] = 0;
                    if (parcelArray.Length > 1)
                    {
                        parcelArray[parcelSecNum] += 1;
                    }
                    else
                    {
                        parcelArray = parcelArray.Append(10).ToArray();
                    }

                    for (int i = 0; parcelArray.Length > i; i++)
                    {
                        parcelFinalRes = parcelFinalRes * 10 + parcelArray[i];
                    }
                    lblParcelResult.Text = "R$ " + parcelFinalRes.ToString("0.00");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex);
            }
        }


    }
}
