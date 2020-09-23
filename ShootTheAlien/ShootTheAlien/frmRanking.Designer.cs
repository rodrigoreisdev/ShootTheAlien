namespace ShootTheAlien
{
    partial class frmRanking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRanking));
            this.lsbJogadores = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbJogadores
            // 
            this.lsbJogadores.BackColor = System.Drawing.Color.MidnightBlue;
            this.lsbJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsbJogadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbJogadores.ForeColor = System.Drawing.SystemColors.Control;
            this.lsbJogadores.FormattingEnabled = true;
            this.lsbJogadores.ItemHeight = 29;
            this.lsbJogadores.Location = new System.Drawing.Point(177, 130);
            this.lsbJogadores.MultiColumn = true;
            this.lsbJogadores.Name = "lsbJogadores";
            this.lsbJogadores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lsbJogadores.Size = new System.Drawing.Size(641, 551);
            this.lsbJogadores.Sorted = true;
            this.lsbJogadores.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(378, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hall da fama";
            // 
            // frmRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootTheAlien.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 783);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbJogadores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRanking";
            this.Text = "Ranking";
            this.Load += new System.EventHandler(this.frmRanking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbJogadores;
        private System.Windows.Forms.Label label1;
    }
}