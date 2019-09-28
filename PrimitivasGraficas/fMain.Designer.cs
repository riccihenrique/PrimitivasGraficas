namespace PrimitivasGraficas
{
    partial class fMain
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
            this.pbArea = new System.Windows.Forms.PictureBox();
            this.gbReta = new System.Windows.Forms.GroupBox();
            this.rbPontMedio = new System.Windows.Forms.RadioButton();
            this.rbDda = new System.Windows.Forms.RadioButton();
            this.rbEqFundReta = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCircu = new System.Windows.Forms.GroupBox();
            this.rbPontoMedioCirc = new System.Windows.Forms.RadioButton();
            this.rbTrigonometria = new System.Windows.Forms.RadioButton();
            this.rbEqGeralCirc = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbPontoMedioElipse = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbP2 = new System.Windows.Forms.Label();
            this.lbP1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).BeginInit();
            this.gbReta.SuspendLayout();
            this.gbCircu.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbArea
            // 
            this.pbArea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArea.Location = new System.Drawing.Point(12, 27);
            this.pbArea.Name = "pbArea";
            this.pbArea.Size = new System.Drawing.Size(960, 585);
            this.pbArea.TabIndex = 0;
            this.pbArea.TabStop = false;
            this.pbArea.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PbArea_MouseClick);
            this.pbArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbArea_MouseDown);
            this.pbArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbArea_MouseMove);
            this.pbArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbArea_MouseUp);
            // 
            // gbReta
            // 
            this.gbReta.Controls.Add(this.rbPontMedio);
            this.gbReta.Controls.Add(this.rbDda);
            this.gbReta.Controls.Add(this.rbEqFundReta);
            this.gbReta.Controls.Add(this.groupBox2);
            this.gbReta.Location = new System.Drawing.Point(978, 27);
            this.gbReta.Name = "gbReta";
            this.gbReta.Size = new System.Drawing.Size(240, 95);
            this.gbReta.TabIndex = 1;
            this.gbReta.TabStop = false;
            this.gbReta.Text = "Retas";
            // 
            // rbPontMedio
            // 
            this.rbPontMedio.AutoSize = true;
            this.rbPontMedio.Location = new System.Drawing.Point(7, 66);
            this.rbPontMedio.Name = "rbPontMedio";
            this.rbPontMedio.Size = new System.Drawing.Size(78, 17);
            this.rbPontMedio.TabIndex = 5;
            this.rbPontMedio.TabStop = true;
            this.rbPontMedio.Tag = "1";
            this.rbPontMedio.Text = "Bresenham";
            this.rbPontMedio.UseVisualStyleBackColor = true;
            this.rbPontMedio.CheckedChanged += new System.EventHandler(this.RbEqFundReta_CheckedChanged);
            // 
            // rbDda
            // 
            this.rbDda.AutoSize = true;
            this.rbDda.Location = new System.Drawing.Point(7, 43);
            this.rbDda.Name = "rbDda";
            this.rbDda.Size = new System.Drawing.Size(48, 17);
            this.rbDda.TabIndex = 4;
            this.rbDda.TabStop = true;
            this.rbDda.Tag = "1";
            this.rbDda.Text = "DDA";
            this.rbDda.UseVisualStyleBackColor = true;
            this.rbDda.CheckedChanged += new System.EventHandler(this.RbEqFundReta_CheckedChanged);
            // 
            // rbEqFundReta
            // 
            this.rbEqFundReta.AutoSize = true;
            this.rbEqFundReta.Location = new System.Drawing.Point(7, 20);
            this.rbEqFundReta.Name = "rbEqFundReta";
            this.rbEqFundReta.Size = new System.Drawing.Size(173, 17);
            this.rbEqFundReta.TabIndex = 3;
            this.rbEqFundReta.TabStop = true;
            this.rbEqFundReta.Tag = "1";
            this.rbEqFundReta.Text = "Equação Fundamental da Reta";
            this.rbEqFundReta.UseVisualStyleBackColor = true;
            this.rbEqFundReta.CheckedChanged += new System.EventHandler(this.RbEqFundReta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(6, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 196);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // gbCircu
            // 
            this.gbCircu.Controls.Add(this.rbPontoMedioCirc);
            this.gbCircu.Controls.Add(this.rbTrigonometria);
            this.gbCircu.Controls.Add(this.rbEqGeralCirc);
            this.gbCircu.Controls.Add(this.groupBox4);
            this.gbCircu.Location = new System.Drawing.Point(978, 128);
            this.gbCircu.Name = "gbCircu";
            this.gbCircu.Size = new System.Drawing.Size(240, 111);
            this.gbCircu.TabIndex = 3;
            this.gbCircu.TabStop = false;
            this.gbCircu.Text = "Circunfêrencia";
            // 
            // rbPontoMedioCirc
            // 
            this.rbPontoMedioCirc.AutoSize = true;
            this.rbPontoMedioCirc.Location = new System.Drawing.Point(12, 80);
            this.rbPontoMedioCirc.Name = "rbPontoMedioCirc";
            this.rbPontoMedioCirc.Size = new System.Drawing.Size(85, 17);
            this.rbPontoMedioCirc.TabIndex = 8;
            this.rbPontoMedioCirc.TabStop = true;
            this.rbPontoMedioCirc.Tag = "1";
            this.rbPontoMedioCirc.Text = "Ponto Médio";
            this.rbPontoMedioCirc.UseVisualStyleBackColor = true;
            this.rbPontoMedioCirc.CheckedChanged += new System.EventHandler(this.RbEqGeralCirc_CheckedChanged);
            // 
            // rbTrigonometria
            // 
            this.rbTrigonometria.AutoSize = true;
            this.rbTrigonometria.Location = new System.Drawing.Point(12, 57);
            this.rbTrigonometria.Name = "rbTrigonometria";
            this.rbTrigonometria.Size = new System.Drawing.Size(89, 17);
            this.rbTrigonometria.TabIndex = 7;
            this.rbTrigonometria.TabStop = true;
            this.rbTrigonometria.Tag = "1";
            this.rbTrigonometria.Text = "Trigonometria";
            this.rbTrigonometria.UseVisualStyleBackColor = true;
            this.rbTrigonometria.CheckedChanged += new System.EventHandler(this.RbEqGeralCirc_CheckedChanged);
            // 
            // rbEqGeralCirc
            // 
            this.rbEqGeralCirc.AutoSize = true;
            this.rbEqGeralCirc.Location = new System.Drawing.Point(12, 34);
            this.rbEqGeralCirc.Name = "rbEqGeralCirc";
            this.rbEqGeralCirc.Size = new System.Drawing.Size(182, 17);
            this.rbEqGeralCirc.TabIndex = 6;
            this.rbEqGeralCirc.TabStop = true;
            this.rbEqGeralCirc.Tag = "1";
            this.rbEqGeralCirc.Text = "Equação Geral da Circunferência";
            this.rbEqGeralCirc.UseVisualStyleBackColor = true;
            this.rbEqGeralCirc.CheckedChanged += new System.EventHandler(this.RbEqGeralCirc_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(6, 202);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 196);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbPontoMedioElipse);
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(978, 248);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(240, 47);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elipse";
            // 
            // rbPontoMedioElipse
            // 
            this.rbPontoMedioElipse.AutoSize = true;
            this.rbPontoMedioElipse.Location = new System.Drawing.Point(12, 20);
            this.rbPontoMedioElipse.Name = "rbPontoMedioElipse";
            this.rbPontoMedioElipse.Size = new System.Drawing.Size(85, 17);
            this.rbPontoMedioElipse.TabIndex = 3;
            this.rbPontoMedioElipse.TabStop = true;
            this.rbPontoMedioElipse.Text = "Ponto Médio";
            this.rbPontoMedioElipse.UseVisualStyleBackColor = true;
            this.rbPontoMedioElipse.CheckedChanged += new System.EventHandler(this.RbPontoMedioElipse_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(6, 202);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(327, 196);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1230, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.NovoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.SalvarToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como...";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.SalvarComoToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.FecharToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbP2);
            this.groupBox1.Controls.Add(this.lbP1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(978, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pontos";
            // 
            // lbP2
            // 
            this.lbP2.AutoSize = true;
            this.lbP2.Location = new System.Drawing.Point(59, 58);
            this.lbP2.Name = "lbP2";
            this.lbP2.Size = new System.Drawing.Size(0, 13);
            this.lbP2.TabIndex = 3;
            // 
            // lbP1
            // 
            this.lbP1.AutoSize = true;
            this.lbP1.Location = new System.Drawing.Point(59, 29);
            this.lbP1.Name = "lbP1";
            this.lbP1.Size = new System.Drawing.Size(0, 13);
            this.lbP1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ponto 2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ponto 1:";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 631);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.gbCircu);
            this.Controls.Add(this.gbReta);
            this.Controls.Add(this.pbArea);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Primititvas Gráficas";
            ((System.ComponentModel.ISupportInitialize)(this.pbArea)).EndInit();
            this.gbReta.ResumeLayout(false);
            this.gbReta.PerformLayout();
            this.gbCircu.ResumeLayout(false);
            this.gbCircu.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbArea;
        private System.Windows.Forms.GroupBox gbReta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbCircu;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbDda;
        private System.Windows.Forms.RadioButton rbEqFundReta;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbPontMedio;
        private System.Windows.Forms.RadioButton rbPontoMedioCirc;
        private System.Windows.Forms.RadioButton rbTrigonometria;
        private System.Windows.Forms.RadioButton rbEqGeralCirc;
        private System.Windows.Forms.RadioButton rbPontoMedioElipse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbP2;
        private System.Windows.Forms.Label lbP1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

