namespace ProjetoCursos.View
{
    partial class FrmCadCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCursos));
            BarraAplicacao = new ToolStrip();
            BtnBarraNovo = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            BtnBarraSalvar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            BtnBarraListar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            BtnBarraApagar = new ToolStripButton();
            LblNomeCurso = new Label();
            TxtNomeCurso = new TextBox();
            LblTurmas = new Label();
            CmbTurma = new ComboBox();
            GrpbTipo = new GroupBox();
            RdMobile = new RadioButton();
            RdWeb = new RadioButton();
            GrpbStatus = new GroupBox();
            RdDesativado = new RadioButton();
            RdAtivo = new RadioButton();
            DgvCursos = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            ColNomeCurso = new DataGridViewTextBoxColumn();
            ColTurma = new DataGridViewTextBoxColumn();
            ColTipo = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            TxtIdCurso = new TextBox();
            BarraAplicacao.SuspendLayout();
            GrpbTipo.SuspendLayout();
            GrpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCursos).BeginInit();
            SuspendLayout();
            // 
            // BarraAplicacao
            // 
            BarraAplicacao.ImageScalingSize = new Size(20, 20);
            BarraAplicacao.Items.AddRange(new ToolStripItem[] { BtnBarraNovo, toolStripSeparator1, BtnBarraSalvar, toolStripSeparator2, BtnBarraListar, toolStripSeparator3, BtnBarraApagar });
            BarraAplicacao.Location = new Point(0, 0);
            BarraAplicacao.Name = "BarraAplicacao";
            BarraAplicacao.Size = new Size(1449, 71);
            BarraAplicacao.TabIndex = 0;
            BarraAplicacao.Text = "toolStrip1";
            // 
            // BtnBarraNovo
            // 
            BtnBarraNovo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnBarraNovo.Image = (Image)resources.GetObject("BtnBarraNovo.Image");
            BtnBarraNovo.ImageScaling = ToolStripItemImageScaling.None;
            BtnBarraNovo.ImageTransparentColor = Color.Magenta;
            BtnBarraNovo.Name = "BtnBarraNovo";
            BtnBarraNovo.Size = new Size(68, 68);
            BtnBarraNovo.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 71);
            // 
            // BtnBarraSalvar
            // 
            BtnBarraSalvar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnBarraSalvar.Image = (Image)resources.GetObject("BtnBarraSalvar.Image");
            BtnBarraSalvar.ImageScaling = ToolStripItemImageScaling.None;
            BtnBarraSalvar.ImageTransparentColor = Color.Magenta;
            BtnBarraSalvar.Name = "BtnBarraSalvar";
            BtnBarraSalvar.Size = new Size(68, 68);
            BtnBarraSalvar.Text = "toolStripButton1";
            BtnBarraSalvar.Click += BtnBarraSalvar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 71);
            // 
            // BtnBarraListar
            // 
            BtnBarraListar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnBarraListar.Image = (Image)resources.GetObject("BtnBarraListar.Image");
            BtnBarraListar.ImageScaling = ToolStripItemImageScaling.None;
            BtnBarraListar.ImageTransparentColor = Color.Magenta;
            BtnBarraListar.Name = "BtnBarraListar";
            BtnBarraListar.Size = new Size(68, 68);
            BtnBarraListar.Text = "toolStripButton1";
            BtnBarraListar.Click += BtnBarraListar_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 71);
            // 
            // BtnBarraApagar
            // 
            BtnBarraApagar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BtnBarraApagar.Image = (Image)resources.GetObject("BtnBarraApagar.Image");
            BtnBarraApagar.ImageScaling = ToolStripItemImageScaling.None;
            BtnBarraApagar.ImageTransparentColor = Color.Magenta;
            BtnBarraApagar.Name = "BtnBarraApagar";
            BtnBarraApagar.Size = new Size(68, 68);
            BtnBarraApagar.Text = "toolStripButton1";
            // 
            // LblNomeCurso
            // 
            LblNomeCurso.AutoSize = true;
            LblNomeCurso.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNomeCurso.Location = new Point(12, 99);
            LblNomeCurso.Name = "LblNomeCurso";
            LblNomeCurso.Size = new Size(231, 35);
            LblNomeCurso.TabIndex = 1;
            LblNomeCurso.Text = "Nome do Curso:";
            // 
            // TxtNomeCurso
            // 
            TxtNomeCurso.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNomeCurso.Location = new Point(249, 90);
            TxtNomeCurso.Name = "TxtNomeCurso";
            TxtNomeCurso.Size = new Size(509, 39);
            TxtNomeCurso.TabIndex = 2;
            // 
            // LblTurmas
            // 
            LblTurmas.AutoSize = true;
            LblTurmas.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblTurmas.Location = new Point(12, 165);
            LblTurmas.Name = "LblTurmas";
            LblTurmas.Size = new Size(109, 35);
            LblTurmas.TabIndex = 3;
            LblTurmas.Text = "Turma:";
            // 
            // CmbTurma
            // 
            CmbTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            CmbTurma.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CmbTurma.FormattingEnabled = true;
            CmbTurma.Items.AddRange(new object[] { "MANHÃ", "TARDE", "NOITE" });
            CmbTurma.Location = new Point(127, 158);
            CmbTurma.Name = "CmbTurma";
            CmbTurma.Size = new Size(273, 40);
            CmbTurma.TabIndex = 4;
            // 
            // GrpbTipo
            // 
            GrpbTipo.Controls.Add(RdMobile);
            GrpbTipo.Controls.Add(RdWeb);
            GrpbTipo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbTipo.Location = new Point(12, 238);
            GrpbTipo.Name = "GrpbTipo";
            GrpbTipo.Size = new Size(502, 84);
            GrpbTipo.TabIndex = 5;
            GrpbTipo.TabStop = false;
            GrpbTipo.Text = "Tipo";
            // 
            // RdMobile
            // 
            RdMobile.AutoSize = true;
            RdMobile.Location = new Point(287, 35);
            RdMobile.Name = "RdMobile";
            RdMobile.Size = new Size(116, 36);
            RdMobile.TabIndex = 1;
            RdMobile.Text = "Mobile";
            RdMobile.UseVisualStyleBackColor = true;
            // 
            // RdWeb
            // 
            RdWeb.AutoSize = true;
            RdWeb.Checked = true;
            RdWeb.Location = new Point(88, 35);
            RdWeb.Name = "RdWeb";
            RdWeb.Size = new Size(93, 36);
            RdWeb.TabIndex = 0;
            RdWeb.TabStop = true;
            RdWeb.Text = "Web";
            RdWeb.UseVisualStyleBackColor = true;
            // 
            // GrpbStatus
            // 
            GrpbStatus.Controls.Add(RdDesativado);
            GrpbStatus.Controls.Add(RdAtivo);
            GrpbStatus.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GrpbStatus.Location = new Point(12, 354);
            GrpbStatus.Name = "GrpbStatus";
            GrpbStatus.Size = new Size(502, 84);
            GrpbStatus.TabIndex = 6;
            GrpbStatus.TabStop = false;
            GrpbStatus.Text = "Status";
            // 
            // RdDesativado
            // 
            RdDesativado.AutoSize = true;
            RdDesativado.Location = new Point(287, 35);
            RdDesativado.Name = "RdDesativado";
            RdDesativado.Size = new Size(172, 36);
            RdDesativado.TabIndex = 1;
            RdDesativado.Text = "Desativado";
            RdDesativado.UseVisualStyleBackColor = true;
            // 
            // RdAtivo
            // 
            RdAtivo.AutoSize = true;
            RdAtivo.Checked = true;
            RdAtivo.Location = new Point(88, 35);
            RdAtivo.Name = "RdAtivo";
            RdAtivo.Size = new Size(96, 36);
            RdAtivo.TabIndex = 0;
            RdAtivo.TabStop = true;
            RdAtivo.Text = "Ativo";
            RdAtivo.UseVisualStyleBackColor = true;
            // 
            // DgvCursos
            // 
            DgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCursos.Columns.AddRange(new DataGridViewColumn[] { ColID, ColNomeCurso, ColTurma, ColTipo, ColStatus });
            DgvCursos.Location = new Point(774, 90);
            DgvCursos.Name = "DgvCursos";
            DgvCursos.ReadOnly = true;
            DgvCursos.RowHeadersWidth = 51;
            DgvCursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvCursos.Size = new Size(663, 348);
            DgvCursos.TabIndex = 7;
            DgvCursos.CellDoubleClick += DgvCursos_CellDoubleClick;
            // 
            // ColID
            // 
            ColID.HeaderText = "ID";
            ColID.MinimumWidth = 6;
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            ColID.Width = 50;
            // 
            // ColNomeCurso
            // 
            ColNomeCurso.HeaderText = "Curso";
            ColNomeCurso.MinimumWidth = 6;
            ColNomeCurso.Name = "ColNomeCurso";
            ColNomeCurso.ReadOnly = true;
            ColNomeCurso.Width = 200;
            // 
            // ColTurma
            // 
            ColTurma.HeaderText = "Turma";
            ColTurma.MinimumWidth = 6;
            ColTurma.Name = "ColTurma";
            ColTurma.ReadOnly = true;
            ColTurma.Width = 125;
            // 
            // ColTipo
            // 
            ColTipo.HeaderText = "Tipo";
            ColTipo.MinimumWidth = 6;
            ColTipo.Name = "ColTipo";
            ColTipo.ReadOnly = true;
            ColTipo.Width = 125;
            // 
            // ColStatus
            // 
            ColStatus.HeaderText = "Status";
            ColStatus.MinimumWidth = 6;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            ColStatus.Width = 125;
            // 
            // TxtIdCurso
            // 
            TxtIdCurso.Location = new Point(633, 158);
            TxtIdCurso.Name = "TxtIdCurso";
            TxtIdCurso.Size = new Size(125, 27);
            TxtIdCurso.TabIndex = 8;
            // 
            // FrmCadCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1449, 450);
            Controls.Add(TxtIdCurso);
            Controls.Add(DgvCursos);
            Controls.Add(GrpbStatus);
            Controls.Add(GrpbTipo);
            Controls.Add(CmbTurma);
            Controls.Add(LblTurmas);
            Controls.Add(TxtNomeCurso);
            Controls.Add(LblNomeCurso);
            Controls.Add(BarraAplicacao);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCadCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            BarraAplicacao.ResumeLayout(false);
            BarraAplicacao.PerformLayout();
            GrpbTipo.ResumeLayout(false);
            GrpbTipo.PerformLayout();
            GrpbStatus.ResumeLayout(false);
            GrpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip BarraAplicacao;
        private ToolStripButton BtnBarraNovo;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton BtnBarraSalvar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton BtnBarraListar;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton BtnBarraApagar;
        private Label LblNomeCurso;
        private TextBox TxtNomeCurso;
        private Label LblTurmas;
        private ComboBox CmbTurma;
        private GroupBox GrpbTipo;
        private RadioButton RdMobile;
        private RadioButton RdWeb;
        private GroupBox GrpbStatus;
        private RadioButton RdDesativado;
        private RadioButton RdAtivo;
        private DataGridView DgvCursos;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn ColNomeCurso;
        private DataGridViewTextBoxColumn ColTurma;
        private DataGridViewTextBoxColumn ColTipo;
        private DataGridViewTextBoxColumn ColStatus;
        private TextBox TxtIdCurso;
    }
}