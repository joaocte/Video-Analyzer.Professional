using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerTipoAnimal
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
            this.GridTipoAnimais = new System.Windows.Forms.DataGridView();
            this.grupoCaixas = new System.Windows.Forms.GroupBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.labelStatusCaixa = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.txtNomeTipoAnimal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoAnimais)).BeginInit();
            this.grupoCaixas.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridTipoAnimais
            // 
            this.GridTipoAnimais.AllowUserToAddRows = false;
            this.GridTipoAnimais.AllowUserToDeleteRows = false;
            this.GridTipoAnimais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridTipoAnimais.Location = new System.Drawing.Point(6, 19);
            this.GridTipoAnimais.Name = "GridTipoAnimais";
            this.GridTipoAnimais.ReadOnly = true;
            this.GridTipoAnimais.Size = new System.Drawing.Size(751, 348);
            this.GridTipoAnimais.TabIndex = 7;
            // 
            // grupoCaixas
            // 
            this.grupoCaixas.Controls.Add(this.GridTipoAnimais);
            this.grupoCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCaixas.Location = new System.Drawing.Point(9, 160);
            this.grupoCaixas.Name = "grupoCaixas";
            this.grupoCaixas.Size = new System.Drawing.Size(766, 385);
            this.grupoCaixas.TabIndex = 18;
            this.grupoCaixas.TabStop = false;
            this.grupoCaixas.Text = "Tipos de Animais Cadastradas";
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(110, 48);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 17;
            // 
            // labelStatusCaixa
            // 
            this.labelStatusCaixa.AutoSize = true;
            this.labelStatusCaixa.Location = new System.Drawing.Point(15, 48);
            this.labelStatusCaixa.Name = "labelStatusCaixa";
            this.labelStatusCaixa.Size = new System.Drawing.Size(98, 13);
            this.labelStatusCaixa.TabIndex = 16;
            this.labelStatusCaixa.Text = "Status Tipo Animal:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(191, 131);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 15;
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
            this.btnSalvar.TabIndex = 14;
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
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // txtNomeTipoAnimal
            // 
            this.txtNomeTipoAnimal.Location = new System.Drawing.Point(152, 15);
            this.txtNomeTipoAnimal.Name = "txtNomeTipoAnimal";
            this.txtNomeTipoAnimal.Size = new System.Drawing.Size(222, 20);
            this.txtNomeTipoAnimal.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome do TIpo de Animal";
            // 
            // FormVideoAnalyzerTipoAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.grupoCaixas);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.labelStatusCaixa);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtNomeTipoAnimal);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormVideoAnalyzerTipoAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzer - Tipo Animal";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerTipoAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridTipoAnimais)).EndInit();
            this.grupoCaixas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView GridTipoAnimais;
        private GroupBox grupoCaixas;
        private ComboBox comboStatus;
        private Label labelStatusCaixa;
        private Button btnLimpar;
        private Button btnSalvar;
        private Button btnNovo;
        private TextBox txtNomeTipoAnimal;
        private Label label1;
    }
}