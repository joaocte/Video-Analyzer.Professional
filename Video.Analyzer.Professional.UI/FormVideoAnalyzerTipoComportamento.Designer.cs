using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerTipoComportamento
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
            this.grupoTipoComportamentos = new System.Windows.Forms.GroupBox();
            this.GridTipoComportamentos = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.labelStatusCaixa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNomeTipoComportamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grupoTipoComportamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoComportamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // grupoTipoComportamentos
            // 
            this.grupoTipoComportamentos.Controls.Add(this.GridTipoComportamentos);
            this.grupoTipoComportamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoTipoComportamentos.Location = new System.Drawing.Point(9, 160);
            this.grupoTipoComportamentos.Name = "grupoTipoComportamentos";
            this.grupoTipoComportamentos.Size = new System.Drawing.Size(766, 385);
            this.grupoTipoComportamentos.TabIndex = 26;
            this.grupoTipoComportamentos.TabStop = false;
            this.grupoTipoComportamentos.Text = "Tipos de Comportamentos Cadastradas";
            // 
            // GridTipoComportamentos
            // 
            this.GridTipoComportamentos.AllowUserToAddRows = false;
            this.GridTipoComportamentos.AllowUserToDeleteRows = false;
            this.GridTipoComportamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoComportamentos.Location = new System.Drawing.Point(6, 19);
            this.GridTipoComportamentos.Name = "GridTipoComportamentos";
            this.GridTipoComportamentos.ReadOnly = true;
            this.GridTipoComportamentos.Size = new System.Drawing.Size(751, 348);
            this.GridTipoComportamentos.TabIndex = 7;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(162, 48);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 25;
            // 
            // labelStatusCaixa
            // 
            this.labelStatusCaixa.AutoSize = true;
            this.labelStatusCaixa.Location = new System.Drawing.Point(15, 48);
            this.labelStatusCaixa.Name = "labelStatusCaixa";
            this.labelStatusCaixa.Size = new System.Drawing.Size(141, 13);
            this.labelStatusCaixa.TabIndex = 24;
            this.labelStatusCaixa.Text = "Status Tipo Comportamento:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(191, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(110, 130);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 22;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.Location = new System.Drawing.Point(18, 130);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 21;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNomeTipoComportamento
            // 
            this.txtNomeTipoComportamento.Location = new System.Drawing.Point(191, 12);
            this.txtNomeTipoComportamento.Name = "txtNomeTipoComportamento";
            this.txtNomeTipoComportamento.Size = new System.Drawing.Size(222, 20);
            this.txtNomeTipoComportamento.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome do TIpo do Comportamento:";
            // 
            // FormVideoAnalyzerTipoComportamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grupoTipoComportamentos);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labelStatusCaixa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNomeTipoComportamento);
            this.Controls.Add(this.label1);
            this.Name = "FormVideoAnalyzerTipoComportamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzer - Tipo Comportamento ";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerTipoComportamento_Load);
            this.grupoTipoComportamentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoComportamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grupoTipoComportamentos;
        private DataGridView GridTipoComportamentos;
        private ComboBox comboStatus;
        private Label labelStatusCaixa;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox txtNomeTipoComportamento;
        private Label label1;
    }
}