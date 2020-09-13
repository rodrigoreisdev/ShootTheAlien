namespace ShootTheAlien
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rankingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdIniciar = new System.Windows.Forms.Button();
            this.cmdRegras = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmdCadastro = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ink Free", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shoot the Allien";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rankingToolStripMenuItem,
            this.cadastrarToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(856, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rankingToolStripMenuItem
            // 
            this.rankingToolStripMenuItem.Name = "rankingToolStripMenuItem";
            this.rankingToolStripMenuItem.Size = new System.Drawing.Size(62, 22);
            this.rankingToolStripMenuItem.Text = "Ranking";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.cadastrarToolStripMenuItem.Text = "História";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(49, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // cmdIniciar
            // 
            this.cmdIniciar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdIniciar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIniciar.Location = new System.Drawing.Point(35, 161);
            this.cmdIniciar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdIniciar.Name = "cmdIniciar";
            this.cmdIniciar.Size = new System.Drawing.Size(203, 54);
            this.cmdIniciar.TabIndex = 2;
            this.cmdIniciar.Text = "Iniciar";
            this.cmdIniciar.UseVisualStyleBackColor = false;
            this.cmdIniciar.Click += new System.EventHandler(this.cmdIniciar_Click);
            // 
            // cmdRegras
            // 
            this.cmdRegras.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdRegras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdRegras.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegras.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdRegras.Location = new System.Drawing.Point(35, 287);
            this.cmdRegras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdRegras.Name = "cmdRegras";
            this.cmdRegras.Size = new System.Drawing.Size(134, 36);
            this.cmdRegras.TabIndex = 2;
            this.cmdRegras.Text = "Regras";
            this.cmdRegras.UseVisualStyleBackColor = false;
            this.cmdRegras.Click += new System.EventHandler(this.cmdRegras_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(125, 400);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 181);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Location = new System.Drawing.Point(51, 11);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(449, 159);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // cmdCadastro
            // 
            this.cmdCadastro.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCadastro.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdCadastro.Location = new System.Drawing.Point(35, 233);
            this.cmdCadastro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmdCadastro.Name = "cmdCadastro";
            this.cmdCadastro.Size = new System.Drawing.Size(167, 36);
            this.cmdCadastro.TabIndex = 2;
            this.cmdCadastro.Text = "Cadastro";
            this.cmdCadastro.UseVisualStyleBackColor = false;
            this.cmdCadastro.Click += new System.EventHandler(this.cmdCadastro_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootTheAlien.Properties.Resources.backini;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdCadastro);
            this.Controls.Add(this.cmdRegras);
            this.Controls.Add(this.cmdIniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Shoot  the Allien!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Button cmdIniciar;
        private System.Windows.Forms.Button cmdRegras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button cmdCadastro;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rankingToolStripMenuItem;
    }
}

