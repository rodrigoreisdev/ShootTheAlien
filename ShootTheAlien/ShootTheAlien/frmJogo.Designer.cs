namespace ShootTheAlien
{
    partial class frmJogo
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
            this.pnFacil = new System.Windows.Forms.Panel();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.prbNivel = new System.Windows.Forms.ProgressBar();
            this.prbTempo = new System.Windows.Forms.ProgressBar();
            this.timerSel = new System.Windows.Forms.Timer(this.components);
            this.timerTempo = new System.Windows.Forms.Timer(this.components);
            this.lblAcerto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnFacil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnFacil
            // 
            this.pnFacil.BackColor = System.Drawing.Color.Transparent;
            this.pnFacil.Controls.Add(this.pb5);
            this.pnFacil.Controls.Add(this.pb4);
            this.pnFacil.Controls.Add(this.pb3);
            this.pnFacil.Controls.Add(this.pb2);
            this.pnFacil.Controls.Add(this.pb1);
            this.pnFacil.Location = new System.Drawing.Point(114, 165);
            this.pnFacil.Name = "pnFacil";
            this.pnFacil.Size = new System.Drawing.Size(1096, 404);
            this.pnFacil.TabIndex = 0;
            this.pnFacil.Visible = false;
            // 
            // pb5
            // 
            this.pb5.BackgroundImage = global::ShootTheAlien.Properties.Resources.top;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(861, 67);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(178, 270);
            this.pb5.TabIndex = 0;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb5_Click);
            // 
            // pb4
            // 
            this.pb4.BackgroundImage = global::ShootTheAlien.Properties.Resources.top;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(657, 67);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(178, 270);
            this.pb4.TabIndex = 0;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb4_Click);
            // 
            // pb3
            // 
            this.pb3.BackgroundImage = global::ShootTheAlien.Properties.Resources.top;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(458, 67);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(178, 270);
            this.pb3.TabIndex = 0;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb3_Click);
            // 
            // pb2
            // 
            this.pb2.BackgroundImage = global::ShootTheAlien.Properties.Resources.top;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(257, 67);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(178, 270);
            this.pb2.TabIndex = 0;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb2_Click);
            // 
            // pb1
            // 
            this.pb1.BackgroundImage = global::ShootTheAlien.Properties.Resources.top;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(55, 67);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(178, 270);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb1_Click);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.BackColor = System.Drawing.Color.Transparent;
            this.lblNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNivel.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNivel.Location = new System.Drawing.Point(153, 29);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(84, 32);
            this.lblNivel.TabIndex = 3;
            this.lblNivel.Text = "Nível";
            // 
            // prbNivel
            // 
            this.prbNivel.Location = new System.Drawing.Point(153, 68);
            this.prbNivel.Maximum = 10;
            this.prbNivel.Name = "prbNivel";
            this.prbNivel.Size = new System.Drawing.Size(302, 23);
            this.prbNivel.TabIndex = 4;
            // 
            // prbTempo
            // 
            this.prbTempo.Location = new System.Drawing.Point(908, 68);
            this.prbTempo.Name = "prbTempo";
            this.prbTempo.Size = new System.Drawing.Size(302, 23);
            this.prbTempo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prbTempo.TabIndex = 4;
            // 
            // timerSel
            // 
            this.timerSel.Tick += new System.EventHandler(this.timerSel_Tick);
            // 
            // timerTempo
            // 
            this.timerTempo.Enabled = true;
            this.timerTempo.Interval = 1000;
            this.timerTempo.Tick += new System.EventHandler(this.timerTempo_Tick);
            // 
            // lblAcerto
            // 
            this.lblAcerto.AutoSize = true;
            this.lblAcerto.BackColor = System.Drawing.Color.Transparent;
            this.lblAcerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcerto.ForeColor = System.Drawing.Color.Green;
            this.lblAcerto.Location = new System.Drawing.Point(566, 655);
            this.lblAcerto.Name = "lblAcerto";
            this.lblAcerto.Size = new System.Drawing.Size(0, 32);
            this.lblAcerto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1102, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tempo";
            // 
            // frmJogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootTheAlien.Properties.Resources.backjogo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 797);
            this.Controls.Add(this.lblAcerto);
            this.Controls.Add(this.prbTempo);
            this.Controls.Add(this.prbNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.pnFacil);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoot the Alien";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmJogo_Load);
            this.pnFacil.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnFacil;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ProgressBar prbNivel;
        private System.Windows.Forms.ProgressBar prbTempo;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Timer timerSel;
        private System.Windows.Forms.Timer timerTempo;
        private System.Windows.Forms.Label lblAcerto;
        private System.Windows.Forms.Label label1;
    }
}