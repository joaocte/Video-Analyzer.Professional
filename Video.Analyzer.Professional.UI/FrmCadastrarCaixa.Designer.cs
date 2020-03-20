using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FrmCadastrarCaixa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastrarCaixa));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCaixa = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.GridCaixas = new System.Windows.Forms.DataGridView();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.labelStatusCaixa = new System.Windows.Forms.Label();
            this.grupoCaixas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixas)).BeginInit();
            this.grupoCaixas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome / Número da Caixa:";
            // 
            // txtNomeCaixa
            // 
            this.txtNomeCaixa.Location = new System.Drawing.Point(149, 19);
            this.txtNomeCaixa.Name = "txtNomeCaixa";
            this.txtNomeCaixa.Size = new System.Drawing.Size(222, 20);
            this.txtNomeCaixa.TabIndex = 1;
            // 
            // btnNovo
            // 
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.Location = new System.Drawing.Point(15, 134);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 2;
            this.btnNovo.Text = "Novo(a)";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.Location = new System.Drawing.Point(107, 134);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.Location = new System.Drawing.Point(188, 135);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // GridCaixas
            // 
            this.GridCaixas.AllowUserToAddRows = false;
            this.GridCaixas.AllowUserToDeleteRows = false;
            this.GridCaixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCaixas.Location = new System.Drawing.Point(6, 19);
            this.GridCaixas.Name = "GridCaixas";
            this.GridCaixas.ReadOnly = true;
            this.GridCaixas.Size = new System.Drawing.Size(751, 348);
            this.GridCaixas.TabIndex = 7;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(107, 52);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 9;
            // 
            // labelStatusCaixa
            // 
            this.labelStatusCaixa.AutoSize = true;
            this.labelStatusCaixa.Location = new System.Drawing.Point(12, 52);
            this.labelStatusCaixa.Name = "labelStatusCaixa";
            this.labelStatusCaixa.Size = new System.Drawing.Size(81, 13);
            this.labelStatusCaixa.TabIndex = 8;
            this.labelStatusCaixa.Text = "Status da Caixa";
            // 
            // grupoCaixas
            // 
            this.grupoCaixas.Controls.Add(this.GridCaixas);
            this.grupoCaixas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupoCaixas.Location = new System.Drawing.Point(6, 164);
            this.grupoCaixas.Name = "grupoCaixas";
            this.grupoCaixas.Size = new System.Drawing.Size(766, 385);
            this.grupoCaixas.TabIndex = 10;
            this.grupoCaixas.TabStop = false;
            this.grupoCaixas.Text = "Caixas Cadastradas";
            // 
            // FrmCadastrarCaixa
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
            this.Controls.Add(this.txtNomeCaixa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmCadastrarCaixa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzer - Cadastrar Caixa";
            this.Load += new System.EventHandler(this.FrmCadastrarCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCaixas)).EndInit();
            this.grupoCaixas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNomeCaixa;
        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLimpar;
        private DataGridView GridCaixas;
        private ComboBox comboStatus;
        private Label labelStatusCaixa;
        private GroupBox grupoCaixas;
    }
}