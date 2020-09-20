namespace ShootTheAlien
{
    partial class frmSelecao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelecao));
            this.lbNomes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbNivel = new System.Windows.Forms.GroupBox();
            this.rbDificil = new System.Windows.Forms.RadioButton();
            this.rbMedio = new System.Windows.Forms.RadioButton();
            this.rbFacil = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cbTempo = new System.Windows.Forms.ComboBox();
            this.gbTempo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbNivel.SuspendLayout();
            this.gbTempo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomes
            // 
            this.lbNomes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbNomes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomes.ForeColor = System.Drawing.SystemColors.Menu;
            this.lbNomes.FormattingEnabled = true;
            this.lbNomes.ItemHeight = 32;
            this.lbNomes.Location = new System.Drawing.Point(24, 102);
            this.lbNomes.Name = "lbNomes";
            this.lbNomes.Size = new System.Drawing.Size(404, 484);
            this.lbNomes.TabIndex = 1;
            this.lbNomes.SelectedIndexChanged += new System.EventHandler(this.lbNomes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(98, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escolha o jogador";
            // 
            // gbNivel
            // 
            this.gbNivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gbNivel.Controls.Add(this.rbDificil);
            this.gbNivel.Controls.Add(this.rbMedio);
            this.gbNivel.Controls.Add(this.rbFacil);
            this.gbNivel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNivel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gbNivel.Location = new System.Drawing.Point(584, 102);
            this.gbNivel.Name = "gbNivel";
            this.gbNivel.Size = new System.Drawing.Size(405, 209);
            this.gbNivel.TabIndex = 3;
            this.gbNivel.TabStop = false;
            this.gbNivel.Text = "Nível de jogo";
            this.gbNivel.Visible = false;
            this.gbNivel.Enter += new System.EventHandler(this.gbNivel_Enter);
            // 
            // rbDificil
            // 
            this.rbDificil.AutoSize = true;
            this.rbDificil.Location = new System.Drawing.Point(20, 145);
            this.rbDificil.Name = "rbDificil";
            this.rbDificil.Size = new System.Drawing.Size(97, 33);
            this.rbDificil.TabIndex = 2;
            this.rbDificil.TabStop = true;
            this.rbDificil.Text = "Difícil";
            this.rbDificil.UseVisualStyleBackColor = true;
            // 
            // rbMedio
            // 
            this.rbMedio.AutoSize = true;
            this.rbMedio.Location = new System.Drawing.Point(20, 95);
            this.rbMedio.Name = "rbMedio";
            this.rbMedio.Size = new System.Drawing.Size(106, 33);
            this.rbMedio.TabIndex = 1;
            this.rbMedio.TabStop = true;
            this.rbMedio.Text = "Médio";
            this.rbMedio.UseVisualStyleBackColor = true;
            // 
            // rbFacil
            // 
            this.rbFacil.AutoSize = true;
            this.rbFacil.Location = new System.Drawing.Point(20, 48);
            this.rbFacil.Name = "rbFacil";
            this.rbFacil.Size = new System.Drawing.Size(90, 33);
            this.rbFacil.TabIndex = 0;
            this.rbFacil.TabStop = true;
            this.rbFacil.Text = "Fácil";
            this.rbFacil.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(682, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Escolha o nível";
            // 
            // cmdOk
            // 
            this.cmdOk.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdOk.FlatAppearance.BorderSize = 0;
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOk.ForeColor = System.Drawing.SystemColors.Control;
            this.cmdOk.Location = new System.Drawing.Point(620, 445);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(330, 106);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "Iniciar";
            this.cmdOk.UseVisualStyleBackColor = false;
            this.cmdOk.Visible = false;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cbTempo
            // 
            this.cbTempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cbTempo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTempo.ForeColor = System.Drawing.SystemColors.Control;
            this.cbTempo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbTempo.Location = new System.Drawing.Point(310, 31);
            this.cbTempo.Name = "cbTempo";
            this.cbTempo.Size = new System.Drawing.Size(85, 40);
            this.cbTempo.TabIndex = 5;
            this.cbTempo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gbTempo
            // 
            this.gbTempo.BackColor = System.Drawing.Color.Transparent;
            this.gbTempo.Controls.Add(this.cbTempo);
            this.gbTempo.Controls.Add(this.label3);
            this.gbTempo.Location = new System.Drawing.Point(584, 320);
            this.gbTempo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTempo.Name = "gbTempo";
            this.gbTempo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTempo.Size = new System.Drawing.Size(405, 97);
            this.gbTempo.TabIndex = 6;
            this.gbTempo.TabStop = false;
            this.gbTempo.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(8, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tempo em minutos:";
            // 
            // frmSelecao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootTheAlien.Properties.Resources.back2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1020, 672);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.gbNivel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNomes);
            this.Controls.Add(this.gbTempo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelecao";
            this.Text = "Seleção de Personagem";
            this.Load += new System.EventHandler(this.frmSelecao_Load);
            this.gbNivel.ResumeLayout(false);
            this.gbNivel.PerformLayout();
            this.gbTempo.ResumeLayout(false);
            this.gbTempo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNomes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbNivel;
        private System.Windows.Forms.RadioButton rbDificil;
        private System.Windows.Forms.RadioButton rbMedio;
        private System.Windows.Forms.RadioButton rbFacil;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.ComboBox cbTempo;
        private System.Windows.Forms.GroupBox gbTempo;
        private System.Windows.Forms.Label label3;
    }
}