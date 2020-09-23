namespace ShootTheAlien
{
    partial class frmFim
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPts = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdJogar = new System.Windows.Forms.Button();
            this.cmdVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lblPts);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmdJogar);
            this.panel1.Controls.Add(this.cmdVoltar);
            this.panel1.Location = new System.Drawing.Point(162, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 251);
            this.panel1.TabIndex = 0;
            // 
            // lblPts
            // 
            this.lblPts.AutoSize = true;
            this.lblPts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPts.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPts.Location = new System.Drawing.Point(37, 89);
            this.lblPts.Name = "lblPts";
            this.lblPts.Size = new System.Drawing.Size(74, 24);
            this.lblPts.TabIndex = 1;
            this.lblPts.Text = "Pontos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(138, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jogo encerrado";
            // 
            // cmdJogar
            // 
            this.cmdJogar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdJogar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdJogar.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdJogar.Location = new System.Drawing.Point(226, 192);
            this.cmdJogar.Name = "cmdJogar";
            this.cmdJogar.Size = new System.Drawing.Size(206, 35);
            this.cmdJogar.TabIndex = 0;
            this.cmdJogar.Text = "Jogar novamente";
            this.cmdJogar.UseVisualStyleBackColor = false;
            this.cmdJogar.Click += new System.EventHandler(this.cmdJogar_Click);
            // 
            // cmdVoltar
            // 
            this.cmdVoltar.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVoltar.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdVoltar.Location = new System.Drawing.Point(12, 192);
            this.cmdVoltar.Name = "cmdVoltar";
            this.cmdVoltar.Size = new System.Drawing.Size(206, 35);
            this.cmdVoltar.TabIndex = 0;
            this.cmdVoltar.Text = "Voltar ao início";
            this.cmdVoltar.UseVisualStyleBackColor = false;
            this.cmdVoltar.Click += new System.EventHandler(this.cmdVoltar_Click);
            // 
            // frmFim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootTheAlien.Properties.Resources.backjogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 619);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFim";
            this.Text = "frmFim";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdJogar;
        private System.Windows.Forms.Button cmdVoltar;
    }
}