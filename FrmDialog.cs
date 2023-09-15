using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Comissões
{
    public partial class FrmDialog : Form
    {
        public FrmDialog(string dialog)
        {
            InitializeComponent();
            lblDialog.Text = dialog;
            ActiveControl = btnYes;
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
