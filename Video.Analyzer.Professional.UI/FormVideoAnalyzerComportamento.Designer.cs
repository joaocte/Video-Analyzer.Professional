using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerComportamento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeComportamento = new System.Windows.Forms.TextBox();
            this.txtTeclaComportamento = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.gridComportamentos = new System.Windows.Forms.DataGridView();
            this.grupoComportamentos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboTipoComportamento = new System.Windows.Forms.ComboBox();
            this.btnAdicionarTipoComportamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridComportamentos)).BeginInit();
            this.grupoComportamentos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Comportamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Status do Comportamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tecla do Comportamento:";
            // 
            // txtNomeComportamento
            // 
            this.txtNomeComportamento.Location = new System.Drawing.Point(146, 10);
            this.txtNomeComportamento.Name = "txtNomeComportamento";
            this.txtNomeComportamento.Size = new System.Drawing.Size(300, 20);
            this.txtNomeComportamento.TabIndex = 3;
            // 
            // txtTeclaComportamento
            // 
            this.txtTeclaComportamento.Location = new System.Drawing.Point(408, 50);
            this.txtTeclaComportamento.MaxLength = 1;
            this.txtTeclaComportamento.Name = "txtTeclaComportamento";
            this.txtTeclaComportamento.Size = new System.Drawing.Size(38, 20);
            this.txtTeclaComportamento.TabIndex = 4;
            this.txtTeclaComportamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTeclaComportamento_KeyPress);
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(146, 45);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 5;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(13, 110);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(129, 110);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(258, 110);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // gridComportamentos
            // 
            this.gridComportamentos.AllowUserToAddRows = false;
            this.gridComportamentos.AllowUserToDeleteRows = false;
            this.gridComportamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridComportamentos.Location = new System.Drawing.Point(6, 38);
            this.gridComportamentos.Name = "gridComportamentos";
            this.gridComportamentos.ReadOnly = true;
            this.gridComportamentos.Size = new System.Drawing.Size(747, 340);
            this.gridComportamentos.TabIndex = 9;
            // 
            // grupoComportamentos
            // 
            this.grupoComportamentos.Controls.Add(this.gridComportamentos);
            this.grupoComportamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoComportamentos.Location = new System.Drawing.Point(13, 153);
            this.grupoComportamentos.Name = "grupoComportamentos";
            this.grupoComportamentos.Size = new System.Drawing.Size(759, 384);
            this.grupoComportamentos.TabIndex = 10;
            this.grupoComportamentos.TabStop = false;
            this.grupoComportamentos.Text = "Comportamentos Cadastrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tipo Comportamento:";
            // 
            // comboTipoComportamento
            // 
            this.comboTipoComportamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoComportamento.FormattingEnabled = true;
            this.comboTipoComportamento.Location = new System.Drawing.Point(129, 82);
            this.comboTipoComportamento.Name = "comboTipoComportamento";
            this.comboTipoComportamento.Size = new System.Drawing.Size(105, 21);
            this.comboTipoComportamento.TabIndex = 12;
            // 
            // btnAdicionarTipoComportamento
            // 
            this.btnAdicionarTipoComportamento.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.bullet_add;
            this.btnAdicionarTipoComportamento.Location = new System.Drawing.Point(240, 82);
            this.btnAdicionarTipoComportamento.Name = "btnAdicionarTipoComportamento";
            this.btnAdicionarTipoComportamento.Size = new System.Drawing.Size(20, 20);
            this.btnAdicionarTipoComportamento.TabIndex = 23;
            this.btnAdicionarTipoComportamento.Tag = "Adicionar Tipo Comportamento";
            this.btnAdicionarTipoComportamento.UseVisualStyleBackColor = true;
            this.btnAdicionarTipoComportamento.Click += new System.EventHandler(this.btnAdicionarTipoComportamento_Click);
            // 
            // FormVideoAnalyzerComportamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAdicionarTipoComportamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboTipoComportamento);
            this.Controls.Add(this.grupoComportamentos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.txtTeclaComportamento);
            this.Controls.Add(this.txtNomeComportamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormVideoAnalyzerComportamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzerProfessional - Comportamento";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerComportamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridComportamentos)).EndInit();
            this.grupoComportamentos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNomeComportamento;
        private TextBox txtTeclaComportamento;
        private ComboBox comboStatus;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLimpar;
        private DataGridView gridComportamentos;
        private GroupBox grupoComportamentos;
        private Label label4;
        private ComboBox comboTipoComportamento;
        private Button btnAdicionarTipoComportamento;
    }
}