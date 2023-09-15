namespace Controle_de_Comissões
{
    partial class FrmSplash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSplash));
            this.logo = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnMain = new System.Windows.Forms.Panel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.ErrorImage = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.logo.Image = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.logo.InitialImage = global::Controle_de_Comissões.Properties.Resources.LOGO;
            this.logo.Location = new System.Drawing.Point(137, 46);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(175, 125);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 15;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor: Marcelo Bastos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "v.1.0.1";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(65, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "Controle de Comissões";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14F);
            this.label4.Location = new System.Drawing.Point(170, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "carregando..";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(40, 182);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(369, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 5;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this.progressBar;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.Silver;
            this.pnMain.Controls.Add(this.progressBar);
            this.pnMain.Controls.Add(this.label3);
            this.pnMain.Controls.Add(this.label4);
            this.pnMain.Controls.Add(this.logo);
            this.pnMain.Controls.Add(this.label1);
            this.pnMain.Controls.Add(this.label2);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(2, 2);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(444, 278);
            this.pnMain.TabIndex = 6;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 12;
            this.bunifuElipse3.TargetControl = this.pnMain;
            // 
            // FrmSplash
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(448, 282);
            this.Controls.Add(this.pnMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSplash";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Timer Timer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel pnMain;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}

