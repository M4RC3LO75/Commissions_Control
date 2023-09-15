namespace Controle_de_Comissões
{
    partial class FrmBudgetCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBudgetCalculator));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtPartCust = new System.Windows.Forms.TextBox();
            this.lblMoneyResult = new System.Windows.Forms.Label();
            this.copylblCredit = new System.Windows.Forms.PictureBox();
            this.lblCreditResult = new System.Windows.Forms.Label();
            this.lblParcelResult = new System.Windows.Forms.Label();
            this.copylblMoney = new System.Windows.Forms.PictureBox();
            this.copylblParcel = new System.Windows.Forms.PictureBox();
            this.chkRoundMatch = new System.Windows.Forms.CheckBox();
            this.lblFullText = new System.Windows.Forms.Label();
            this.txtParcelNumbers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copylblFullText = new System.Windows.Forms.LinkLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblParcel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22F);
            this.label1.Location = new System.Drawing.Point(8, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor da Mão de Obra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "CALCULADORA DE ORÇAMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 22F);
            this.label3.Location = new System.Drawing.Point(8, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 37);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor da(s) Peça(s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(10, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(232, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor em *DINHEIRO*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(10, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(328, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valor no *CRÉDITO OU DÉBITO*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(10, 354);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor *PARCELADO*";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 76);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtLabor
            // 
            this.txtLabor.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLabor.Location = new System.Drawing.Point(338, 100);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(198, 43);
            this.txtLabor.TabIndex = 0;
            this.txtLabor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLabor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            this.txtLabor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDecimals_KeyPress);
            this.txtLabor.Leave += new System.EventHandler(this.Txt_LostFocus);
            // 
            // txtPartCust
            // 
            this.txtPartCust.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartCust.Location = new System.Drawing.Point(338, 156);
            this.txtPartCust.Name = "txtPartCust";
            this.txtPartCust.Size = new System.Drawing.Size(198, 43);
            this.txtPartCust.TabIndex = 1;
            this.txtPartCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPartCust.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            this.txtPartCust.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowDecimals_KeyPress);
            this.txtPartCust.Leave += new System.EventHandler(this.Txt_LostFocus);
            // 
            // lblMoneyResult
            // 
            this.lblMoneyResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblMoneyResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoneyResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyResult.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMoneyResult.Location = new System.Drawing.Point(339, 253);
            this.lblMoneyResult.Name = "lblMoneyResult";
            this.lblMoneyResult.Size = new System.Drawing.Size(197, 36);
            this.lblMoneyResult.TabIndex = 3;
            this.lblMoneyResult.Text = "R$ 0,00";
            this.lblMoneyResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copylblCredit
            // 
            this.copylblCredit.BackColor = System.Drawing.Color.Tan;
            this.copylblCredit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copylblCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copylblCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copylblCredit.Image = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblCredit.InitialImage = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblCredit.Location = new System.Drawing.Point(534, 298);
            this.copylblCredit.Name = "copylblCredit";
            this.copylblCredit.Padding = new System.Windows.Forms.Padding(4);
            this.copylblCredit.Size = new System.Drawing.Size(35, 35);
            this.copylblCredit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copylblCredit.TabIndex = 11;
            this.copylblCredit.TabStop = false;
            this.copylblCredit.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // lblCreditResult
            // 
            this.lblCreditResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreditResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCreditResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditResult.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCreditResult.Location = new System.Drawing.Point(339, 298);
            this.lblCreditResult.Name = "lblCreditResult";
            this.lblCreditResult.Size = new System.Drawing.Size(197, 36);
            this.lblCreditResult.TabIndex = 4;
            this.lblCreditResult.Text = "R$ 0,00";
            this.lblCreditResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblParcelResult
            // 
            this.lblParcelResult.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblParcelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblParcelResult.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParcelResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblParcelResult.Location = new System.Drawing.Point(338, 349);
            this.lblParcelResult.Name = "lblParcelResult";
            this.lblParcelResult.Size = new System.Drawing.Size(197, 36);
            this.lblParcelResult.TabIndex = 5;
            this.lblParcelResult.Text = "R$ 0,00";
            this.lblParcelResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // copylblMoney
            // 
            this.copylblMoney.BackColor = System.Drawing.Color.Tan;
            this.copylblMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copylblMoney.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copylblMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copylblMoney.Image = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblMoney.InitialImage = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblMoney.Location = new System.Drawing.Point(534, 253);
            this.copylblMoney.Name = "copylblMoney";
            this.copylblMoney.Padding = new System.Windows.Forms.Padding(4);
            this.copylblMoney.Size = new System.Drawing.Size(35, 35);
            this.copylblMoney.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copylblMoney.TabIndex = 14;
            this.copylblMoney.TabStop = false;
            this.copylblMoney.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // copylblParcel
            // 
            this.copylblParcel.BackColor = System.Drawing.Color.Tan;
            this.copylblParcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copylblParcel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.copylblParcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copylblParcel.Image = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblParcel.InitialImage = global::Controle_de_Comissões.Properties.Resources.copy_black;
            this.copylblParcel.Location = new System.Drawing.Point(534, 349);
            this.copylblParcel.Name = "copylblParcel";
            this.copylblParcel.Padding = new System.Windows.Forms.Padding(4);
            this.copylblParcel.Size = new System.Drawing.Size(35, 35);
            this.copylblParcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.copylblParcel.TabIndex = 15;
            this.copylblParcel.TabStop = false;
            this.copylblParcel.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // chkRoundMatch
            // 
            this.chkRoundMatch.AutoSize = true;
            this.chkRoundMatch.Checked = true;
            this.chkRoundMatch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRoundMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRoundMatch.Font = new System.Drawing.Font("Calibri", 14F);
            this.chkRoundMatch.Location = new System.Drawing.Point(339, 212);
            this.chkRoundMatch.Name = "chkRoundMatch";
            this.chkRoundMatch.Size = new System.Drawing.Size(201, 27);
            this.chkRoundMatch.TabIndex = 16;
            this.chkRoundMatch.Text = "Valores Arredondados";
            this.chkRoundMatch.UseVisualStyleBackColor = true;
            this.chkRoundMatch.CheckedChanged += new System.EventHandler(this.ChkBoxRoundMatch_CheckedChanged);
            this.chkRoundMatch.Enter += new System.EventHandler(this.ChkBoxRoundMatch_Enter);
            // 
            // lblFullText
            // 
            this.lblFullText.Font = new System.Drawing.Font("Calibri", 16F);
            this.lblFullText.Location = new System.Drawing.Point(10, 442);
            this.lblFullText.Name = "lblFullText";
            this.lblFullText.Size = new System.Drawing.Size(559, 83);
            this.lblFullText.TabIndex = 17;
            this.lblFullText.Text = "R$ 0,00 (em até 2x) ou \r\nR$ 0,00 (no Crédito ou Débito) ou \r\nR$ 0,00 (em *DINHEIR" +
    "O*).";
            // 
            // txtParcelNumbers
            // 
            this.txtParcelNumbers.Font = new System.Drawing.Font("Calibri", 16F);
            this.txtParcelNumbers.Location = new System.Drawing.Point(212, 399);
            this.txtParcelNumbers.Name = "txtParcelNumbers";
            this.txtParcelNumbers.Size = new System.Drawing.Size(30, 34);
            this.txtParcelNumbers.TabIndex = 18;
            this.txtParcelNumbers.Text = "2";
            this.txtParcelNumbers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParcelNumbers.Click += new System.EventHandler(this.SelectAllText);
            this.txtParcelNumbers.Enter += new System.EventHandler(this.SelectAllText);
            this.txtParcelNumbers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AllowOnlyNumbers_KeyPress);
            this.txtParcelNumbers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtParcelNum_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 16F);
            this.label8.Location = new System.Drawing.Point(10, 402);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 27);
            this.label8.TabIndex = 19;
            this.label8.Text = "Número de Parcelas";
            // 
            // copylblFullText
            // 
            this.copylblFullText.AutoSize = true;
            this.copylblFullText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copylblFullText.Font = new System.Drawing.Font("Calibri", 14F);
            this.copylblFullText.Location = new System.Drawing.Point(11, 529);
            this.copylblFullText.Name = "copylblFullText";
            this.copylblFullText.Size = new System.Drawing.Size(104, 23);
            this.copylblFullText.TabIndex = 20;
            this.copylblFullText.TabStop = true;
            this.copylblFullText.Text = "Copiar Texto";
            this.copylblFullText.Click += new System.EventHandler(this.CopyToClipboard);
            // 
            // toolTip
            // 
            this.toolTip.ForeColor = System.Drawing.Color.Black;
            // 
            // FrmBudgetCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(576, 564);
            this.Controls.Add(this.copylblFullText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtParcelNumbers);
            this.Controls.Add(this.lblFullText);
            this.Controls.Add(this.chkRoundMatch);
            this.Controls.Add(this.copylblParcel);
            this.Controls.Add(this.copylblMoney);
            this.Controls.Add(this.copylblCredit);
            this.Controls.Add(this.lblParcelResult);
            this.Controls.Add(this.lblCreditResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMoneyResult);
            this.Controls.Add(this.txtPartCust);
            this.Controls.Add(this.txtLabor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 22F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBudgetCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Orçamento";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copylblParcel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtPartCust;
        private System.Windows.Forms.Label lblMoneyResult;
        private System.Windows.Forms.PictureBox copylblCredit;
        private System.Windows.Forms.Label lblCreditResult;
        private System.Windows.Forms.Label lblParcelResult;
        private System.Windows.Forms.PictureBox copylblMoney;
        private System.Windows.Forms.PictureBox copylblParcel;
        private System.Windows.Forms.CheckBox chkRoundMatch;
        private System.Windows.Forms.Label lblFullText;
        private System.Windows.Forms.TextBox txtParcelNumbers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel copylblFullText;
        private System.Windows.Forms.ToolTip toolTip;
    }
}