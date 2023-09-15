namespace Controle_de_Comissões
{
    partial class FrmCommNProd
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCommNProd));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClearCommissions = new System.Windows.Forms.LinkLabel();
            this.chkStdCommission = new System.Windows.Forms.CheckBox();
            this.btnSaveCommission = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnDeleteCommission = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.dgvCommissions = new System.Windows.Forms.DataGridView();
            this.txtCommValue = new System.Windows.Forms.TextBox();
            this.txtCommName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.PicClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdValue = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnDeleteProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSaveProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblClearProducts = new System.Windows.Forms.LinkLabel();
            this.chkStdProduct = new System.Windows.Forms.CheckBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissions)).BeginInit();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblClearCommissions);
            this.panel1.Controls.Add(this.chkStdCommission);
            this.panel1.Controls.Add(this.btnSaveCommission);
            this.panel1.Controls.Add(this.btnDeleteCommission);
            this.panel1.Controls.Add(this.dgvCommissions);
            this.panel1.Controls.Add(this.txtCommValue);
            this.panel1.Controls.Add(this.txtCommName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(17, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 450);
            this.panel1.TabIndex = 0;
            // 
            // lblClearCommissions
            // 
            this.lblClearCommissions.AutoSize = true;
            this.lblClearCommissions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearCommissions.Location = new System.Drawing.Point(177, 88);
            this.lblClearCommissions.Name = "lblClearCommissions";
            this.lblClearCommissions.Size = new System.Drawing.Size(119, 23);
            this.lblClearCommissions.TabIndex = 5;
            this.lblClearCommissions.TabStop = true;
            this.lblClearCommissions.Text = "Limpar / Novo";
            this.lblClearCommissions.Click += new System.EventHandler(this.ClearFields);
            // 
            // chkStdCommission
            // 
            this.chkStdCommission.AutoSize = true;
            this.chkStdCommission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStdCommission.Location = new System.Drawing.Point(343, 88);
            this.chkStdCommission.Name = "chkStdCommission";
            this.chkStdCommission.Size = new System.Drawing.Size(162, 27);
            this.chkStdCommission.TabIndex = 2;
            this.chkStdCommission.Text = "Comissão Padrão";
            this.chkStdCommission.UseVisualStyleBackColor = true;
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnSaveCommission.CustomizableEdges = borderEdges3;
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
            this.btnSaveCommission.Location = new System.Drawing.Point(17, 392);
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
            this.btnSaveCommission.TabIndex = 3;
            this.btnSaveCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCommission.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveCommission.TextMarginLeft = 0;
            this.btnSaveCommission.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSaveCommission.UseDefaultRadiusAndThickness = true;
            this.btnSaveCommission.Click += new System.EventHandler(this.SaveOperation);
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
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnDeleteCommission.CustomizableEdges = borderEdges4;
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
            this.btnDeleteCommission.Location = new System.Drawing.Point(346, 389);
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
            this.btnDeleteCommission.TabIndex = 4;
            this.btnDeleteCommission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCommission.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteCommission.TextMarginLeft = 0;
            this.btnDeleteCommission.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteCommission.UseDefaultRadiusAndThickness = true;
            this.btnDeleteCommission.Click += new System.EventHandler(this.DeleteOperation);
            // 
            // dgvCommissions
            // 
            this.dgvCommissions.AllowUserToAddRows = false;
            this.dgvCommissions.AllowUserToDeleteRows = false;
            this.dgvCommissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCommissions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCommissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCommissions.EnableHeadersVisualStyles = false;
            this.dgvCommissions.Location = new System.Drawing.Point(15, 120);
            this.dgvCommissions.Name = "dgvCommissions";
            this.dgvCommissions.ReadOnly = true;
            this.dgvCommissions.RowHeadersVisible = false;
            this.dgvCommissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCommissions.Size = new System.Drawing.Size(490, 260);
            this.dgvCommissions.TabIndex = 7;
            this.dgvCommissions.TabStop = false;
            this.dgvCommissions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Click);
            // 
            // txtCommValue
            // 
            this.txtCommValue.ForeColor = System.Drawing.Color.Black;
            this.txtCommValue.Location = new System.Drawing.Point(181, 51);
            this.txtCommValue.Name = "txtCommValue";
            this.txtCommValue.Size = new System.Drawing.Size(324, 30);
            this.txtCommValue.TabIndex = 1;
            this.txtCommValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_KeyDown);
            this.txtCommValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            this.txtCommValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkButtonsConditions);
            // 
            // txtCommName
            // 
            this.txtCommName.ForeColor = System.Drawing.Color.Black;
            this.txtCommName.Location = new System.Drawing.Point(181, 15);
            this.txtCommName.Name = "txtCommName";
            this.txtCommName.Size = new System.Drawing.Size(324, 30);
            this.txtCommName.TabIndex = 0;
            this.txtCommName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_KeyDown);
            this.txtCommName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkButtonsConditions);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nome da Comissão:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor da Comissão:";
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.DarkGray;
            this.pnTitle.Controls.Add(this.PicClose);
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Controls.Add(this.pictureBox1);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1098, 72);
            this.pnTitle.TabIndex = 0;
            // 
            // PicClose
            // 
            this.PicClose.AccessibleDescription = "Fechar Programa";
            this.PicClose.BackColor = System.Drawing.Color.DarkGray;
            this.PicClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicClose.Image = global::Controle_de_Comissões.Properties.Resources.close;
            this.PicClose.Location = new System.Drawing.Point(1058, 12);
            this.PicClose.Name = "PicClose";
            this.PicClose.Size = new System.Drawing.Size(30, 30);
            this.PicClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicClose.TabIndex = 5;
            this.PicClose.TabStop = false;
            this.PicClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 26F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(146, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(859, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro de Tipos de Comissões e Produtos Promocionais";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.pictureBox1.InitialImage = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipos de Comissões";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(559, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipos de Produtos Promocionais";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 14F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor do Produto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Nome do Produto:";
            // 
            // txtProdName
            // 
            this.txtProdName.ForeColor = System.Drawing.Color.Black;
            this.txtProdName.Location = new System.Drawing.Point(181, 15);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(324, 30);
            this.txtProdName.TabIndex = 0;
            this.txtProdName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_KeyDown);
            this.txtProdName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkButtonsConditions);
            // 
            // txtProdValue
            // 
            this.txtProdValue.ForeColor = System.Drawing.Color.Black;
            this.txtProdValue.Location = new System.Drawing.Point(181, 51);
            this.txtProdValue.Name = "txtProdValue";
            this.txtProdValue.Size = new System.Drawing.Size(324, 30);
            this.txtProdValue.TabIndex = 1;
            this.txtProdValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtBox_KeyDown);
            this.txtProdValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers_KeyPress);
            this.txtProdValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ChkButtonsConditions);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.EnableHeadersVisualStyles = false;
            this.dgvProducts.Location = new System.Drawing.Point(15, 120);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(490, 260);
            this.dgvProducts.TabIndex = 7;
            this.dgvProducts.TabStop = false;
            this.dgvProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.AllowAnimations = true;
            this.btnDeleteProduct.AllowMouseEffects = true;
            this.btnDeleteProduct.AllowToggling = false;
            this.btnDeleteProduct.AnimationSpeed = 200;
            this.btnDeleteProduct.AutoGenerateColors = false;
            this.btnDeleteProduct.AutoRoundBorders = false;
            this.btnDeleteProduct.AutoSizeLeftIcon = true;
            this.btnDeleteProduct.AutoSizeRightIcon = true;
            this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteProduct.BackgroundImage")));
            this.btnDeleteProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.ButtonText = "Excluir";
            this.btnDeleteProduct.ButtonTextMarginLeft = 0;
            this.btnDeleteProduct.ColorContrastOnClick = 45;
            this.btnDeleteProduct.ColorContrastOnHover = 45;
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnDeleteProduct.CustomizableEdges = borderEdges2;
            this.btnDeleteProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDeleteProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteProduct.Enabled = false;
            this.btnDeleteProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDeleteProduct.IconMarginLeft = 11;
            this.btnDeleteProduct.IconPadding = 10;
            this.btnDeleteProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDeleteProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDeleteProduct.IconSize = 25;
            this.btnDeleteProduct.IdleBorderColor = System.Drawing.Color.Brown;
            this.btnDeleteProduct.IdleBorderRadius = 40;
            this.btnDeleteProduct.IdleBorderThickness = 1;
            this.btnDeleteProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteProduct.IdleIconLeftImage = global::Controle_de_Comissões.Properties.Resources.delete_black;
            this.btnDeleteProduct.IdleIconRightImage = null;
            this.btnDeleteProduct.IndicateFocus = true;
            this.btnDeleteProduct.Location = new System.Drawing.Point(346, 389);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDeleteProduct.OnDisabledState.BorderRadius = 40;
            this.btnDeleteProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnDisabledState.BorderThickness = 1;
            this.btnDeleteProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDeleteProduct.OnDisabledState.IconLeftImage = null;
            this.btnDeleteProduct.OnDisabledState.IconRightImage = null;
            this.btnDeleteProduct.onHoverState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteProduct.onHoverState.BorderRadius = 40;
            this.btnDeleteProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.onHoverState.BorderThickness = 1;
            this.btnDeleteProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnDeleteProduct.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.onHoverState.IconLeftImage = null;
            this.btnDeleteProduct.onHoverState.IconRightImage = null;
            this.btnDeleteProduct.OnIdleState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteProduct.OnIdleState.BorderRadius = 40;
            this.btnDeleteProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnIdleState.BorderThickness = 1;
            this.btnDeleteProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteProduct.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.OnIdleState.IconLeftImage = global::Controle_de_Comissões.Properties.Resources.delete_black;
            this.btnDeleteProduct.OnIdleState.IconRightImage = null;
            this.btnDeleteProduct.OnPressedState.BorderColor = System.Drawing.Color.Brown;
            this.btnDeleteProduct.OnPressedState.BorderRadius = 40;
            this.btnDeleteProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnDeleteProduct.OnPressedState.BorderThickness = 1;
            this.btnDeleteProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDeleteProduct.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteProduct.OnPressedState.IconLeftImage = null;
            this.btnDeleteProduct.OnPressedState.IconRightImage = null;
            this.btnDeleteProduct.Size = new System.Drawing.Size(159, 47);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDeleteProduct.TextMarginLeft = 0;
            this.btnDeleteProduct.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDeleteProduct.UseDefaultRadiusAndThickness = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.DeleteOperation);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.AllowAnimations = true;
            this.btnSaveProduct.AllowMouseEffects = true;
            this.btnSaveProduct.AllowToggling = false;
            this.btnSaveProduct.AnimationSpeed = 200;
            this.btnSaveProduct.AutoGenerateColors = false;
            this.btnSaveProduct.AutoRoundBorders = false;
            this.btnSaveProduct.AutoSizeLeftIcon = true;
            this.btnSaveProduct.AutoSizeRightIcon = true;
            this.btnSaveProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveProduct.BackColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveProduct.BackgroundImage")));
            this.btnSaveProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProduct.ButtonText = "Salvar";
            this.btnSaveProduct.ButtonTextMarginLeft = 0;
            this.btnSaveProduct.ColorContrastOnClick = 45;
            this.btnSaveProduct.ColorContrastOnHover = 45;
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSaveProduct.CustomizableEdges = borderEdges1;
            this.btnSaveProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnSaveProduct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProduct.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSaveProduct.IconMarginLeft = 11;
            this.btnSaveProduct.IconPadding = 10;
            this.btnSaveProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSaveProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSaveProduct.IconSize = 25;
            this.btnSaveProduct.IdleBorderColor = System.Drawing.Color.Green;
            this.btnSaveProduct.IdleBorderRadius = 40;
            this.btnSaveProduct.IdleBorderThickness = 1;
            this.btnSaveProduct.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveProduct.IdleIconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.btnSaveProduct.IdleIconRightImage = null;
            this.btnSaveProduct.IndicateFocus = true;
            this.btnSaveProduct.Location = new System.Drawing.Point(17, 389);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSaveProduct.OnDisabledState.BorderRadius = 40;
            this.btnSaveProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProduct.OnDisabledState.BorderThickness = 1;
            this.btnSaveProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSaveProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSaveProduct.OnDisabledState.IconLeftImage = null;
            this.btnSaveProduct.OnDisabledState.IconRightImage = null;
            this.btnSaveProduct.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveProduct.onHoverState.BorderRadius = 40;
            this.btnSaveProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProduct.onHoverState.BorderThickness = 1;
            this.btnSaveProduct.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnSaveProduct.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.onHoverState.IconLeftImage = null;
            this.btnSaveProduct.onHoverState.IconRightImage = null;
            this.btnSaveProduct.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveProduct.OnIdleState.BorderRadius = 40;
            this.btnSaveProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProduct.OnIdleState.BorderThickness = 1;
            this.btnSaveProduct.OnIdleState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSaveProduct.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.OnIdleState.IconLeftImage = global::Controle_de_Comissões.Properties.Resources.save_black;
            this.btnSaveProduct.OnIdleState.IconRightImage = null;
            this.btnSaveProduct.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnSaveProduct.OnPressedState.BorderRadius = 40;
            this.btnSaveProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSaveProduct.OnPressedState.BorderThickness = 1;
            this.btnSaveProduct.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnSaveProduct.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnSaveProduct.OnPressedState.IconLeftImage = null;
            this.btnSaveProduct.OnPressedState.IconRightImage = null;
            this.btnSaveProduct.Size = new System.Drawing.Size(159, 47);
            this.btnSaveProduct.TabIndex = 3;
            this.btnSaveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveProduct.TextMarginLeft = 0;
            this.btnSaveProduct.TextPadding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnSaveProduct.UseDefaultRadiusAndThickness = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.SaveOperation);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblClearProducts);
            this.panel2.Controls.Add(this.chkStdProduct);
            this.panel2.Controls.Add(this.btnSaveProduct);
            this.panel2.Controls.Add(this.btnDeleteProduct);
            this.panel2.Controls.Add(this.dgvProducts);
            this.panel2.Controls.Add(this.txtProdValue);
            this.panel2.Controls.Add(this.txtProdName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(559, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 450);
            this.panel2.TabIndex = 10;
            // 
            // lblClearProducts
            // 
            this.lblClearProducts.AutoSize = true;
            this.lblClearProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClearProducts.Location = new System.Drawing.Point(177, 89);
            this.lblClearProducts.Name = "lblClearProducts";
            this.lblClearProducts.Size = new System.Drawing.Size(119, 23);
            this.lblClearProducts.TabIndex = 5;
            this.lblClearProducts.TabStop = true;
            this.lblClearProducts.Text = "Limpar / Novo";
            this.lblClearProducts.Click += new System.EventHandler(this.ClearFields);
            // 
            // chkStdProduct
            // 
            this.chkStdProduct.AutoSize = true;
            this.chkStdProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkStdProduct.Location = new System.Drawing.Point(354, 88);
            this.chkStdProduct.Name = "chkStdProduct";
            this.chkStdProduct.Size = new System.Drawing.Size(151, 27);
            this.chkStdProduct.TabIndex = 2;
            this.chkStdProduct.Text = "Produto Padrão";
            this.chkStdProduct.UseVisualStyleBackColor = true;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Controls.Add(this.pnTitle);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(1, 1);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1098, 588);
            this.pnMain.TabIndex = 12;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 13;
            this.bunifuElipse2.TargetControl = this.pnMain;
            // 
            // FrmCommNProd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1100, 590);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Calibri", 14F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCommNProd";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCommissionsNProducts";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCommissions)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox PicClose;
        private System.Windows.Forms.TextBox txtCommValue;
        private System.Windows.Forms.TextBox txtCommName;
        private System.Windows.Forms.DataGridView dgvCommissions;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveCommission;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteCommission;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSaveProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnDeleteProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TextBox txtProdValue;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkStdCommission;
        private System.Windows.Forms.CheckBox chkStdProduct;
        private System.Windows.Forms.Panel pnMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.LinkLabel lblClearCommissions;
        private System.Windows.Forms.LinkLabel lblClearProducts;
    }
}