namespace Controle_de_Comissões
{
    partial class FrmSuppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuppliers));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnMain = new System.Windows.Forms.Panel();
            this.BtnNew = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnFields = new System.Windows.Forms.Panel();
            this.txtSite = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveCommission = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDeleteCommission = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMain.SuspendLayout();
            this.pnFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Controls.Add(this.BtnNew);
            this.pnMain.Controls.Add(this.pnFields);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Controls.Add(this.btnSaveCommission);
            this.pnMain.Controls.Add(this.btnDeleteCommission);
            this.pnMain.Controls.Add(this.PicClose);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1063, 654);
            this.pnMain.TabIndex = 0;
            // 
            // BtnNew
            // 
            this.BtnNew.AllowAnimations = true;
            this.BtnNew.AllowMouseEffects = true;
            this.BtnNew.AllowToggling = false;
            this.BtnNew.AnimationSpeed = 200;
            this.BtnNew.AutoGenerateColors = false;
            this.BtnNew.AutoRoundBorders = false;
            this.BtnNew.AutoSizeLeftIcon = true;
            this.BtnNew.AutoSizeRightIcon = true;
            this.BtnNew.BackColor = System.Drawing.Color.Transparent;
            this.BtnNew.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.BtnNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNew.BackgroundImage")));
            this.BtnNew.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNew.ButtonText = "Limpar /\r\nNovo";
            this.BtnNew.ButtonTextMarginLeft = 0;
            this.BtnNew.ColorContrastOnClick = 45;
            this.BtnNew.ColorContrastOnHover = 45;
            this.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnNew.CustomizableEdges = borderEdges1;
            this.BtnNew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnNew.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNew.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNew.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNew.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.BtnNew.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnNew.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNew.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnNew.IconMarginLeft = 11;
            this.BtnNew.IconPadding = 10;
            this.BtnNew.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNew.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnNew.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnNew.IconSize = 25;
            this.BtnNew.IdleBorderColor = System.Drawing.Color.DarkBlue;
            this.BtnNew.IdleBorderRadius = 40;
            this.BtnNew.IdleBorderThickness = 1;
            this.BtnNew.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.BtnNew.IdleIconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.BtnNew.IdleIconRightImage = null;
            this.BtnNew.IndicateFocus = true;
            this.BtnNew.Location = new System.Drawing.Point(245, 598);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnNew.OnDisabledState.BorderRadius = 40;
            this.BtnNew.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNew.OnDisabledState.BorderThickness = 1;
            this.BtnNew.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnNew.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnNew.OnDisabledState.IconLeftImage = null;
            this.BtnNew.OnDisabledState.IconRightImage = null;
            this.BtnNew.onHoverState.BorderColor = System.Drawing.Color.DarkBlue;
            this.BtnNew.onHoverState.BorderRadius = 40;
            this.BtnNew.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNew.onHoverState.BorderThickness = 1;
            this.BtnNew.onHoverState.FillColor = System.Drawing.Color.Cyan;
            this.BtnNew.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.onHoverState.IconLeftImage = null;
            this.BtnNew.onHoverState.IconRightImage = null;
            this.BtnNew.OnIdleState.BorderColor = System.Drawing.Color.DarkBlue;
            this.BtnNew.OnIdleState.BorderRadius = 40;
            this.BtnNew.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNew.OnIdleState.BorderThickness = 1;
            this.BtnNew.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.BtnNew.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.OnIdleState.IconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.BtnNew.OnIdleState.IconRightImage = null;
            this.BtnNew.OnPressedState.BorderColor = System.Drawing.Color.DarkBlue;
            this.BtnNew.OnPressedState.BorderRadius = 40;
            this.BtnNew.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnNew.OnPressedState.BorderThickness = 1;
            this.BtnNew.OnPressedState.FillColor = System.Drawing.Color.MediumBlue;
            this.BtnNew.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.BtnNew.OnPressedState.IconLeftImage = null;
            this.BtnNew.OnPressedState.IconRightImage = null;
            this.BtnNew.Size = new System.Drawing.Size(159, 47);
            this.BtnNew.TabIndex = 27;
            this.BtnNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNew.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnNew.TextMarginLeft = 0;
            this.BtnNew.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.BtnNew.UseDefaultRadiusAndThickness = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // pnFields
            // 
            this.pnFields.BackColor = System.Drawing.Color.DarkGray;
            this.pnFields.Controls.Add(this.txtSite);
            this.pnFields.Controls.Add(this.txtDescription);
            this.pnFields.Controls.Add(this.label11);
            this.pnFields.Controls.Add(this.txtEmail);
            this.pnFields.Controls.Add(this.label10);
            this.pnFields.Controls.Add(this.label9);
            this.pnFields.Controls.Add(this.txtState);
            this.pnFields.Controls.Add(this.label8);
            this.pnFields.Controls.Add(this.txtCity);
            this.pnFields.Controls.Add(this.label7);
            this.pnFields.Controls.Add(this.txtAddress);
            this.pnFields.Controls.Add(this.label6);
            this.pnFields.Controls.Add(this.txtPhone2);
            this.pnFields.Controls.Add(this.label5);
            this.pnFields.Controls.Add(this.txtPhone1);
            this.pnFields.Controls.Add(this.label4);
            this.pnFields.Controls.Add(this.txtContact);
            this.pnFields.Controls.Add(this.label3);
            this.pnFields.Controls.Add(this.dgvSuppliers);
            this.pnFields.Controls.Add(this.txtSupplierName);
            this.pnFields.Controls.Add(this.label1);
            this.pnFields.Location = new System.Drawing.Point(14, 75);
            this.pnFields.Name = "pnFields";
            this.pnFields.Size = new System.Drawing.Size(1035, 513);
            this.pnFields.TabIndex = 26;
            // 
            // txtSite
            // 
            this.txtSite.ForeColor = System.Drawing.Color.Black;
            this.txtSite.Location = new System.Drawing.Point(147, 250);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(321, 27);
            this.txtSite.TabIndex = 44;
            this.txtSite.Text = "";
            this.txtSite.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(147, 316);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(321, 178);
            this.txtDescription.TabIndex = 43;
            this.txtDescription.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 19);
            this.label11.TabIndex = 42;
            this.label11.Text = "Descrição:";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(147, 283);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(321, 27);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 19);
            this.label10.TabIndex = 40;
            this.label10.Text = "E-mail:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 38;
            this.label9.Text = "Endereço do Site:";
            // 
            // txtState
            // 
            this.txtState.ForeColor = System.Drawing.Color.Black;
            this.txtState.Location = new System.Drawing.Point(147, 217);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(321, 27);
            this.txtState.TabIndex = 37;
            this.txtState.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "Estado:";
            // 
            // txtCity
            // 
            this.txtCity.ForeColor = System.Drawing.Color.Black;
            this.txtCity.Location = new System.Drawing.Point(147, 184);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(321, 27);
            this.txtCity.TabIndex = 35;
            this.txtCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cidade:";
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(147, 151);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(321, 27);
            this.txtAddress.TabIndex = 33;
            this.txtAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Endereço:";
            // 
            // txtPhone2
            // 
            this.txtPhone2.ForeColor = System.Drawing.Color.Black;
            this.txtPhone2.Location = new System.Drawing.Point(147, 118);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(321, 27);
            this.txtPhone2.TabIndex = 31;
            this.txtPhone2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefone 2:";
            // 
            // txtPhone1
            // 
            this.txtPhone1.ForeColor = System.Drawing.Color.Black;
            this.txtPhone1.Location = new System.Drawing.Point(147, 85);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(321, 27);
            this.txtPhone1.TabIndex = 29;
            this.txtPhone1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Telefone 1:";
            // 
            // txtContact
            // 
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(147, 50);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(321, 27);
            this.txtContact.TabIndex = 27;
            this.txtContact.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Nome do Contato:";
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuppliers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSuppliers.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuppliers.EnableHeadersVisualStyles = false;
            this.dgvSuppliers.Location = new System.Drawing.Point(485, 17);
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(534, 477);
            this.dgvSuppliers.TabIndex = 25;
            this.dgvSuppliers.TabStop = false;
            this.dgvSuppliers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSuppliers_CellClick);
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.ForeColor = System.Drawing.Color.Black;
            this.txtSupplierName.Location = new System.Drawing.Point(147, 17);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(321, 27);
            this.txtSupplierName.TabIndex = 14;
            this.txtSupplierName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1035, 42);
            this.label2.TabIndex = 24;
            this.label2.Text = "Cadastro de Fornecedores";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveCommission
            // 
            this.btnSaveCommission.AllowAnimations = true;
            this.btnSaveCommission.AllowMouseEffects = true;
            this.btnSaveCommission.AllowToggling = false;
            this.btnSaveCommission.AnimationSpeed = 200;
            this.btnSaveCommission.AutoGenerateColors = false;
            this.btnSaveCommission.AutoRoundBorders = false;
            this.btnSaveCommission.AutoSizeLeftIcon = true;
            this.btnSaveCommission.AutoSizeRightIcon = true;
            this.btnSaveCommission.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCommission.BackColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveCommission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCommission.BackgroundImage")));
            this.btnSaveCommission.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveCommission.ButtonText = "Salvar";
            this.btnSaveCommission.ButtonTextMarginLeft = 0;
            this.btnSaveCommission.ColorContrastOnClick = 45;
            this.btnSaveCommission.ColorContrastOnHover = 45;
            this.btnSaveCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnSaveCommission.CustomizableEdges = borderEdges2;
            this.btnSaveCommission.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveCommission.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveCommission.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveCommission.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveCommission.Enabled = false;
            this.btnSaveCommission.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnSaveCommission.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCommission.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCommission.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCommission.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveCommission.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveCommission.IconMarginLeft = 11;
            this.btnSaveCommission.IconPadding = 10;
            this.btnSaveCommission.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCommission.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveCommission.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveCommission.IconSize = 25;
            this.btnSaveCommission.IdleBorderColor = System.Drawing.Color.Green;
            this.btnSaveCommission.IdleBorderRadius = 40;
            this.btnSaveCommission.IdleBorderThickness = 1;
            this.btnSaveCommission.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveCommission.IdleIconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.btnSaveCommission.IdleIconRightImage = null;
            this.btnSaveCommission.IndicateFocus = true;
            this.btnSaveCommission.Location = new System.Drawing.Point(452, 598);
            this.btnSaveCommission.Name = "btnSaveCommission";
            this.btnSaveCommission.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveCommission.OnDisabledState.BorderRadius = 40;
            this.btnSaveCommission.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveCommission.OnDisabledState.BorderThickness = 1;
            this.btnSaveCommission.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveCommission.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveCommission.OnDisabledState.IconLeftImage = null;
            this.btnSaveCommission.OnDisabledState.IconRightImage = null;
            this.btnSaveCommission.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveCommission.onHoverState.BorderRadius = 40;
            this.btnSaveCommission.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveCommission.onHoverState.BorderThickness = 1;
            this.btnSaveCommission.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveCommission.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCommission.onHoverState.IconLeftImage = null;
            this.btnSaveCommission.onHoverState.IconRightImage = null;
            this.btnSaveCommission.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveCommission.OnIdleState.BorderRadius = 40;
            this.btnSaveCommission.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveCommission.OnIdleState.BorderThickness = 1;
            this.btnSaveCommission.OnIdleState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveCommission.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCommission.OnIdleState.IconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.btnSaveCommission.OnIdleState.IconRightImage = null;
            this.btnSaveCommission.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveCommission.OnPressedState.BorderRadius = 40;
            this.btnSaveCommission.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveCommission.OnPressedState.BorderThickness = 1;
            this.btnSaveCommission.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnSaveCommission.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveCommission.OnPressedState.IconLeftImage = null;
            this.btnSaveCommission.OnPressedState.IconRightImage = null;
            this.btnSaveCommission.Size = new System.Drawing.Size(159, 47);
            this.btnSaveCommission.TabIndex = 11;
            this.btnSaveCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCommission.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveCommission.TextMarginLeft = 0;
            this.btnSaveCommission.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSaveCommission.UseDefaultRadiusAndThickness = true;
            this.btnSaveCommission.Click += new System.EventHandler(this.BtnSaveCommission_Click);
            // 
            // btnDeleteCommission
            // 
            this.btnDeleteCommission.AllowAnimations = true;
            this.btnDeleteCommission.AllowMouseEffects = true;
            this.btnDeleteCommission.AllowToggling = false;
            this.btnDeleteCommission.AnimationSpeed = 200;
            this.btnDeleteCommission.AutoGenerateColors = false;
            this.btnDeleteCommission.AutoRoundBorders = false;
            this.btnDeleteCommission.AutoSizeLeftIcon = true;
            this.btnDeleteCommission.AutoSizeRightIcon = true;
            this.btnDeleteCommission.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteCommission.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteCommission.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCommission.BackgroundImage")));
            this.btnDeleteCommission.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCommission.ButtonText = "Excluir";
            this.btnDeleteCommission.ButtonTextMarginLeft = 0;
            this.btnDeleteCommission.ColorContrastOnClick = 45;
            this.btnDeleteCommission.ColorContrastOnHover = 45;
            this.btnDeleteCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnDeleteCommission.CustomizableEdges = borderEdges3;
            this.btnDeleteCommission.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteCommission.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteCommission.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteCommission.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteCommission.Enabled = false;
            this.btnDeleteCommission.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnDeleteCommission.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCommission.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCommission.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteCommission.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteCommission.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDeleteCommission.IconMarginLeft = 11;
            this.btnDeleteCommission.IconPadding = 10;
            this.btnDeleteCommission.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteCommission.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteCommission.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteCommission.IconSize = 25;
            this.btnDeleteCommission.IdleBorderColor = System.Drawing.Color.Brown;
            this.btnDeleteCommission.IdleBorderRadius = 40;
            this.btnDeleteCommission.IdleBorderThickness = 1;
            this.btnDeleteCommission.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteCommission.IdleIconLeftImage = global::Controle_de_Comissões.Properties.Resources.delete_black;
            this.btnDeleteCommission.IdleIconRightImage = null;
            this.btnDeleteCommission.IndicateFocus = true;
            this.btnDeleteCommission.Location = new System.Drawing.Point(659, 598);
            this.btnDeleteCommission.Name = "btnDeleteCommission";
            this.btnDeleteCommission.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteCommission.OnDisabledState.BorderRadius = 40;
            this.btnDeleteCommission.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCommission.OnDisabledState.BorderThickness = 1;
            this.btnDeleteCommission.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteCommission.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteCommission.OnDisabledState.IconLeftImage = null;
            this.btnDeleteCommission.OnDisabledState.IconRightImage = null;
            this.btnDeleteCommission.onHoverState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteCommission.onHoverState.BorderRadius = 40;
            this.btnDeleteCommission.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCommission.onHoverState.BorderThickness = 1;
            this.btnDeleteCommission.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDeleteCommission.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCommission.onHoverState.IconLeftImage = null;
            this.btnDeleteCommission.onHoverState.IconRightImage = null;
            this.btnDeleteCommission.OnIdleState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteCommission.OnIdleState.BorderRadius = 40;
            this.btnDeleteCommission.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCommission.OnIdleState.BorderThickness = 1;
            this.btnDeleteCommission.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteCommission.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCommission.OnIdleState.IconLeftImage = global::Controle_de_Comissões.Properties.Resources.delete_black;
            this.btnDeleteCommission.OnIdleState.IconRightImage = null;
            this.btnDeleteCommission.OnPressedState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteCommission.OnPressedState.BorderRadius = 40;
            this.btnDeleteCommission.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteCommission.OnPressedState.BorderThickness = 1;
            this.btnDeleteCommission.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteCommission.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCommission.OnPressedState.IconLeftImage = null;
            this.btnDeleteCommission.OnPressedState.IconRightImage = null;
            this.btnDeleteCommission.Size = new System.Drawing.Size(159, 47);
            this.btnDeleteCommission.TabIndex = 12;
            this.btnDeleteCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCommission.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteCommission.TextMarginLeft = 0;
            this.btnDeleteCommission.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteCommission.UseDefaultRadiusAndThickness = true;
            this.btnDeleteCommission.Click += new System.EventHandler(this.BtnDeleteCommission_Click);
            // 
            // PicClose
            // 
            this.PicClose.AccessibleDescription = "Fechar Programa";
            this.PicClose.BackColor = System.Drawing.Color.LightGray;
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = global::Controle_de_Comissões.Properties.Resources.close;
            this.PicClose.Location = new System.Drawing.Point(1035, 3);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(25, 24);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClose.TabIndex = 2;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 17;
            this.bunifuElipse2.TargetControl = this.pnMain;
            // 
            // FrmSuppliers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSuppliers";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSuppliers";
            this.pnMain.ResumeLayout(false);
            this.pnFields.ResumeLayout(false);
            this.pnFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.PictureBox PicClose;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveCommission;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteCommission;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Panel pnFields;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtSite;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnNew;
    }
}