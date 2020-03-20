using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerAnimal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblNomeAnimla = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblFezes = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.txtNomeAnimal = new System.Windows.Forms.TextBox();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.numericQuantidadeDeFezes = new System.Windows.Forms.NumericUpDown();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTipoAnimal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.comboCaixa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridViewAnimaisCadastrados = new System.Windows.Forms.DataGridView();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.checkNomeAutomatico = new System.Windows.Forms.CheckBox();
            this.btnAdicionarTipoAnimal = new System.Windows.Forms.Button();
            this.btnAdicionarCaixa = new System.Windows.Forms.Button();
            this.btnAdicionarGrupo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeDeFezes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimaisCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeAnimla
            // 
            this.lblNomeAnimla.AutoSize = true;
            this.lblNomeAnimla.Location = new System.Drawing.Point(13, 13);
            this.lblNomeAnimla.Name = "lblNomeAnimla";
            this.lblNomeAnimla.Size = new System.Drawing.Size(72, 13);
            this.lblNomeAnimla.TabIndex = 0;
            this.lblNomeAnimla.Text = "Nome Animal:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(361, 13);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblFezes
            // 
            this.lblFezes.AutoSize = true;
            this.lblFezes.Location = new System.Drawing.Point(531, 13);
            this.lblFezes.Name = "lblFezes";
            this.lblFezes.Size = new System.Drawing.Size(111, 13);
            this.lblFezes.TabIndex = 2;
            this.lblFezes.Text = "Quantidade de Fezes:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(13, 49);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 3;
            this.lblPeso.Text = "Peso:";
            // 
            // txtNomeAnimal
            // 
            this.txtNomeAnimal.Location = new System.Drawing.Point(92, 13);
            this.txtNomeAnimal.Name = "txtNomeAnimal";
            this.txtNomeAnimal.Size = new System.Drawing.Size(120, 20);
            this.txtNomeAnimal.TabIndex = 4;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Macho",
            "Fêmia"});
            this.comboSexo.Location = new System.Drawing.Point(401, 13);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(120, 21);
            this.comboSexo.TabIndex = 5;
            // 
            // numericQuantidadeDeFezes
            // 
            this.numericQuantidadeDeFezes.Location = new System.Drawing.Point(648, 13);
            this.numericQuantidadeDeFezes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericQuantidadeDeFezes.Name = "numericQuantidadeDeFezes";
            this.numericQuantidadeDeFezes.Size = new System.Drawing.Size(120, 20);
            this.numericQuantidadeDeFezes.TabIndex = 6;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(53, 49);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(67, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(219, 49);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Status Animal:";
            // 
            // comboTipoAnimal
            // 
            this.comboTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoAnimal.FormattingEnabled = true;
            this.comboTipoAnimal.Location = new System.Drawing.Point(415, 49);
            this.comboTipoAnimal.Name = "comboTipoAnimal";
            this.comboTipoAnimal.Size = new System.Drawing.Size(105, 21);
            this.comboTipoAnimal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(344, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo Animal:";
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(549, 52);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(36, 13);
            this.lblCaixa.TabIndex = 12;
            this.lblCaixa.Text = "Caixa:";
            // 
            // comboCaixa
            // 
            this.comboCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaixa.FormattingEnabled = true;
            this.comboCaixa.Location = new System.Drawing.Point(591, 49);
            this.comboCaixa.Name = "comboCaixa";
            this.comboCaixa.Size = new System.Drawing.Size(108, 21);
            this.comboCaixa.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridViewAnimaisCadastrados);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(16, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 401);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Animais Cadastrados";
            // 
            // gridViewAnimaisCadastrados
            // 
            this.gridViewAnimaisCadastrados.AllowUserToAddRows = false;
            this.gridViewAnimaisCadastrados.AllowUserToDeleteRows = false;
            this.gridViewAnimaisCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewAnimaisCadastrados.Location = new System.Drawing.Point(7, 25);
            this.gridViewAnimaisCadastrados.Name = "gridViewAnimaisCadastrados";
            this.gridViewAnimaisCadastrados.ReadOnly = true;
            this.gridViewAnimaisCadastrados.Size = new System.Drawing.Size(743, 430);
            this.gridViewAnimaisCadastrados.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(198, 119);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 18;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(117, 118);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.Location = new System.Drawing.Point(25, 118);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Grupo:";
            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(59, 80);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(121, 21);
            this.comboGrupo.TabIndex = 20;
            // 
            // checkNomeAutomatico
            // 
            this.checkNomeAutomatico.AutoSize = true;
            this.checkNomeAutomatico.Checked = true;
            this.checkNomeAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNomeAutomatico.Location = new System.Drawing.Point(219, 15);
            this.checkNomeAutomatico.Name = "checkNomeAutomatico";
            this.checkNomeAutomatico.Size = new System.Drawing.Size(145, 17);
            this.checkNomeAutomatico.TabIndex = 21;
            this.checkNomeAutomatico.Text = "Gerar Nome Automatico?";
            this.checkNomeAutomatico.UseVisualStyleBackColor = true;
            this.checkNomeAutomatico.CheckedChanged += new System.EventHandler(this.checkNomeAutomatico_CheckedChanged);
            // 
            // btnAdicionarTipoAnimal
            // 
            this.btnAdicionarTipoAnimal.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.bullet_add;
            this.btnAdicionarTipoAnimal.Location = new System.Drawing.Point(526, 49);
            this.btnAdicionarTipoAnimal.Name = "btnAdicionarTipoAnimal";
            this.btnAdicionarTipoAnimal.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarTipoAnimal.TabIndex = 22;
            this.btnAdicionarTipoAnimal.Tag = "Adicionar Tipo Animal";
            this.btnAdicionarTipoAnimal.UseVisualStyleBackColor = true;
            this.btnAdicionarTipoAnimal.Click += new System.EventHandler(this.btnAdicionarTipoAnimal_Click);
            // 
            // btnAdicionarCaixa
            // 
            this.btnAdicionarCaixa.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.bullet_add;
            this.btnAdicionarCaixa.Location = new System.Drawing.Point(705, 49);
            this.btnAdicionarCaixa.Name = "btnAdicionarCaixa";
            this.btnAdicionarCaixa.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarCaixa.TabIndex = 23;
            this.btnAdicionarCaixa.Tag = "Adicionar Caixa";
            this.btnAdicionarCaixa.UseVisualStyleBackColor = true;
            this.btnAdicionarCaixa.Click += new System.EventHandler(this.btnAdicionarCaixa_Click);
            // 
            // btnAdicionarGrupo
            // 
            this.btnAdicionarGrupo.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.bullet_add;
            this.btnAdicionarGrupo.Location = new System.Drawing.Point(186, 80);
            this.btnAdicionarGrupo.Name = "btnAdicionarGrupo";
            this.btnAdicionarGrupo.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarGrupo.TabIndex = 24;
            this.btnAdicionarGrupo.Tag = "Adicionar Grupo";
            this.btnAdicionarGrupo.UseVisualStyleBackColor = true;
            this.btnAdicionarGrupo.Click += new System.EventHandler(this.btnAdicionarGrupo_Click);
            // 
            // FormVideoAnalyzerAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdicionarGrupo);
            this.Controls.Add(this.btnAdicionarCaixa);
            this.Controls.Add(this.btnAdicionarTipoAnimal);
            this.Controls.Add(this.checkNomeAutomatico);
            this.Controls.Add(this.comboGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboCaixa);
            this.Controls.Add(this.lblCaixa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTipoAnimal);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.numericQuantidadeDeFezes);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.txtNomeAnimal);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblFezes);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNomeAnimla);
            this.MaximizeBox = false;
            this.Name = "FormVideoAnalyzerAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzer - Animal";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidadeDeFezes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewAnimaisCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNomeAnimla;
        private Label lblSexo;
        private Label lblFezes;
        private Label lblPeso;
        private TextBox txtNomeAnimal;
        private ComboBox comboSexo;
        private NumericUpDown numericQuantidadeDeFezes;
        private TextBox txtPeso;
        private ComboBox comboStatus;
        private Label label2;
        private ComboBox comboTipoAnimal;
        private Label label1;
        private Label lblCaixa;
        private ComboBox comboCaixa;
        private GroupBox groupBox1;
        private DataGridView gridViewAnimaisCadastrados;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnNovo;
        private Label label3;
        private ComboBox comboGrupo;
        private CheckBox checkNomeAutomatico;
        private Button btnAdicionarTipoAnimal;
        private Button btnAdicionarCaixa;
        private Button btnAdicionarGrupo;
    }
}