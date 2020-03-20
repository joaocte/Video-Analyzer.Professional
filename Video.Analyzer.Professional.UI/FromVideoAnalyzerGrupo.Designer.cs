using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FromVideoAnalyzerGrupo
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
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GrupoGruposCadastrados = new System.Windows.Forms.GroupBox();
            this.lnlNome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GrupoGruposCadastrados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(15, 93);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(103, 93);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(197, 93);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(748, 316);
            this.dataGridView1.TabIndex = 3;
            // 
            // GrupoGruposCadastrados
            // 
            this.GrupoGruposCadastrados.Controls.Add(this.dataGridView1);
            this.GrupoGruposCadastrados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupoGruposCadastrados.Location = new System.Drawing.Point(12, 194);
            this.GrupoGruposCadastrados.Name = "GrupoGruposCadastrados";
            this.GrupoGruposCadastrados.Size = new System.Drawing.Size(760, 355);
            this.GrupoGruposCadastrados.TabIndex = 4;
            this.GrupoGruposCadastrados.TabStop = false;
            this.GrupoGruposCadastrados.Text = "Grupos Cadastrados";
            // 
            // lnlNome
            // 
            this.lnlNome.AutoSize = true;
            this.lnlNome.Location = new System.Drawing.Point(12, 13);
            this.lnlNome.Name = "lnlNome";
            this.lnlNome.Size = new System.Drawing.Size(85, 13);
            this.lnlNome.TabIndex = 5;
            this.lnlNome.Text = "Nome do Grupo:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 41);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(87, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status do Grupo:";
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(103, 10);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(186, 20);
            this.txtNomeGrupo.TabIndex = 7;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Selecione",
            "Habilitado",
            "Desabilitado"});
            this.comboStatus.Location = new System.Drawing.Point(103, 36);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(100, 21);
            this.comboStatus.TabIndex = 10;
            // 
            // FromVideoAnalyzerGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.comboStatus);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lnlNome);
            this.Controls.Add(this.GrupoGruposCadastrados);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.MaximizeBox = false;
            this.Name = "FromVideoAnalyzerGrupo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VideoAnalyzer - Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GrupoGruposCadastrados.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNovo;
        private Button btnSalvar;
        private Button btnLimpar;
        private DataGridView dataGridView1;
        private GroupBox GrupoGruposCadastrados;
        private Label lnlNome;
        private Label lblStatus;
        private TextBox txtNomeGrupo;
        private ComboBox comboStatus;
    }
}