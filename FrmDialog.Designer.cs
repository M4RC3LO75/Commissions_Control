namespace Controle_de_Comissões
{
    partial class FrmDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDialog));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.pnMain = new System.Windows.Forms.Panel();
            this.lblDialog = new System.Windows.Forms.Label();
            this.btnYes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnNo = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.LightGray;
            this.pnMain.Controls.Add(this.lblDialog);
            this.pnMain.Controls.Add(this.btnYes);
            this.pnMain.Controls.Add(this.btnNo);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(558, 200);
            this.pnMain.TabIndex = 0;
            // 
            // lblDialog
            // 
            this.lblDialog.Font = new System.Drawing.Font("Calibri", 18F);
            this.lblDialog.Location = new System.Drawing.Point(22, 15);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(512, 82);
            this.lblDialog.TabIndex = 5;
            this.lblDialog.Text = "Deseja mesmo fazer o Fechamento?";
            this.lblDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            this.btnYes.AllowAnimations = true;
            this.btnYes.AllowMouseEffects = true;
            this.btnYes.AllowToggling = false;
            this.btnYes.AnimationSpeed = 200;
            this.btnYes.AutoGenerateColors = false;
            this.btnYes.AutoRoundBorders = false;
            this.btnYes.AutoSizeLeftIcon = true;
            this.btnYes.AutoSizeRightIcon = true;
            this.btnYes.BackColor = System.Drawing.Color.Transparent;
            this.btnYes.BackColor1 = System.Drawing.Color.MediumSeaGreen;
            this.btnYes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYes.BackgroundImage")));
            this.btnYes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.ButtonText = "Sim";
            this.btnYes.ButtonTextMarginLeft = 0;
            this.btnYes.ColorContrastOnClick = 45;
            this.btnYes.ColorContrastOnHover = 45;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnYes.CustomizableEdges = borderEdges1;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnYes.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYes.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnYes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnYes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnYes.IconMarginLeft = 11;
            this.btnYes.IconPadding = 10;
            this.btnYes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnYes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnYes.IconSize = 25;
            this.btnYes.IdleBorderColor = System.Drawing.Color.Green;
            this.btnYes.IdleBorderRadius = 40;
            this.btnYes.IdleBorderThickness = 1;
            this.btnYes.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYes.IdleIconLeftImage = null;
            this.btnYes.IdleIconRightImage = null;
            this.btnYes.IndicateFocus = true;
            this.btnYes.Location = new System.Drawing.Point(54, 118);
            this.btnYes.Name = "btnYes";
            this.btnYes.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnYes.OnDisabledState.BorderRadius = 40;
            this.btnYes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnDisabledState.BorderThickness = 1;
            this.btnYes.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnYes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnYes.OnDisabledState.IconLeftImage = null;
            this.btnYes.OnDisabledState.IconRightImage = null;
            this.btnYes.onHoverState.BorderColor = System.Drawing.Color.Green;
            this.btnYes.onHoverState.BorderRadius = 40;
            this.btnYes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.onHoverState.BorderThickness = 1;
            this.btnYes.onHoverState.FillColor = System.Drawing.Color.Lime;
            this.btnYes.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnYes.onHoverState.IconLeftImage = null;
            this.btnYes.onHoverState.IconRightImage = null;
            this.btnYes.OnIdleState.BorderColor = System.Drawing.Color.Green;
            this.btnYes.OnIdleState.BorderRadius = 40;
            this.btnYes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnIdleState.BorderThickness = 1;
            this.btnYes.OnIdleState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnYes.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnYes.OnIdleState.IconLeftImage = null;
            this.btnYes.OnIdleState.IconRightImage = null;
            this.btnYes.OnPressedState.BorderColor = System.Drawing.Color.Green;
            this.btnYes.OnPressedState.BorderRadius = 40;
            this.btnYes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnYes.OnPressedState.BorderThickness = 1;
            this.btnYes.OnPressedState.FillColor = System.Drawing.Color.Green;
            this.btnYes.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnYes.OnPressedState.IconLeftImage = null;
            this.btnYes.OnPressedState.IconRightImage = null;
            this.btnYes.Size = new System.Drawing.Size(159, 47);
            this.btnYes.TabIndex = 3;
            this.btnYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnYes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnYes.TextMarginLeft = 0;
            this.btnYes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnYes.UseDefaultRadiusAndThickness = true;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.AllowAnimations = true;
            this.btnNo.AllowMouseEffects = true;
            this.btnNo.AllowToggling = false;
            this.btnNo.AnimationSpeed = 200;
            this.btnNo.AutoGenerateColors = false;
            this.btnNo.AutoRoundBorders = false;
            this.btnNo.AutoSizeLeftIcon = true;
            this.btnNo.AutoSizeRightIcon = true;
            this.btnNo.BackColor = System.Drawing.Color.Transparent;
            this.btnNo.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNo.BackgroundImage")));
            this.btnNo.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.ButtonText = "Não";
            this.btnNo.ButtonTextMarginLeft = 0;
            this.btnNo.ColorContrastOnClick = 45;
            this.btnNo.ColorContrastOnHover = 45;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnNo.CustomizableEdges = borderEdges2;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Hover;
            this.btnNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnNo.IconMarginLeft = 11;
            this.btnNo.IconPadding = 10;
            this.btnNo.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNo.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnNo.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnNo.IconSize = 25;
            this.btnNo.IdleBorderColor = System.Drawing.Color.Brown;
            this.btnNo.IdleBorderRadius = 40;
            this.btnNo.IdleBorderThickness = 1;
            this.btnNo.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNo.IdleIconLeftImage = null;
            this.btnNo.IdleIconRightImage = null;
            this.btnNo.IndicateFocus = true;
            this.btnNo.Location = new System.Drawing.Point(347, 118);
            this.btnNo.Name = "btnNo";
            this.btnNo.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnNo.OnDisabledState.BorderRadius = 40;
            this.btnNo.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnDisabledState.BorderThickness = 1;
            this.btnNo.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnNo.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnNo.OnDisabledState.IconLeftImage = null;
            this.btnNo.OnDisabledState.IconRightImage = null;
            this.btnNo.onHoverState.BorderColor = System.Drawing.Color.Brown;
            this.btnNo.onHoverState.BorderRadius = 40;
            this.btnNo.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.onHoverState.BorderThickness = 1;
            this.btnNo.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnNo.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNo.onHoverState.IconLeftImage = null;
            this.btnNo.onHoverState.IconRightImage = null;
            this.btnNo.OnIdleState.BorderColor = System.Drawing.Color.Brown;
            this.btnNo.OnIdleState.BorderRadius = 40;
            this.btnNo.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnIdleState.BorderThickness = 1;
            this.btnNo.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNo.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnNo.OnIdleState.IconLeftImage = null;
            this.btnNo.OnIdleState.IconRightImage = null;
            this.btnNo.OnPressedState.BorderColor = System.Drawing.Color.Brown;
            this.btnNo.OnPressedState.BorderRadius = 40;
            this.btnNo.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnNo.OnPressedState.BorderThickness = 1;
            this.btnNo.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnNo.OnPressedState.ForeColor = System.Drawing.Color.Black;
            this.btnNo.OnPressedState.IconLeftImage = null;
            this.btnNo.OnPressedState.IconRightImage = null;
            this.btnNo.Size = new System.Drawing.Size(159, 47);
            this.btnNo.TabIndex = 4;
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNo.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnNo.TextMarginLeft = 0;
            this.btnNo.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnNo.UseDefaultRadiusAndThickness = true;
            this.btnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.pnMain;
            // 
            // FrmClosureDialog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(562, 204);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmClosureDialog";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClosureDialog";
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Label lblDialog;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnYes;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnNo;
    }
}