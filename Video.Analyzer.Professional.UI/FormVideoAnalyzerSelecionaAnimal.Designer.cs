using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerSelecionaAnimal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.comboAnimal = new System.Windows.Forms.ComboBox();
            this.comboGrupo = new System.Windows.Forms.ComboBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipoAnimal = new System.Windows.Forms.ComboBox();
            this.comboCaixa = new System.Windows.Forms.ComboBox();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnimal);
            this.groupBox1.Controls.Add(this.comboAnimal);
            this.groupBox1.Controls.Add(this.comboGrupo);
            this.groupBox1.Controls.Add(this.lblGrupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboTipoAnimal);
            this.groupBox1.Controls.Add(this.comboCaixa);
            this.groupBox1.Controls.Add(this.lblCaixa);
            this.groupBox1.Controls.Add(this.btnProsseguir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Animal a Ser Analisado";
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(221, 88);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(61, 20);
            this.lblAnimal.TabIndex = 26;
            this.lblAnimal.Text = "Animal:";
            // 
            // comboAnimal
            // 
            this.comboAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAnimal.FormattingEnabled = true;
            this.comboAnimal.Location = new System.Drawing.Point(288, 80);
            this.comboAnimal.Name = "comboAnimal";
            this.comboAnimal.Size = new System.Drawing.Size(228, 28);
            this.comboAnimal.TabIndex = 25;
            this.comboAnimal.SelectionChangeCommitted += new System.EventHandler(this.comboAnimal_SelectionChangeCommitted);
            // 
            // comboGrupo
            // 
            this.comboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGrupo.FormattingEnabled = true;
            this.comboGrupo.Location = new System.Drawing.Point(64, 80);
            this.comboGrupo.Name = "comboGrupo";
            this.comboGrupo.Size = new System.Drawing.Size(151, 28);
            this.comboGrupo.TabIndex = 24;
            this.comboGrupo.SelectionChangeCommitted += new System.EventHandler(this.comboGrupo_SelectionChangeCommitted);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(6, 88);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(58, 20);
            this.lblGrupo.TabIndex = 23;
            this.lblGrupo.Text = "Grupo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Tipo Animal:";
            // 
            // comboTipoAnimal
            // 
            this.comboTipoAnimal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoAnimal.FormattingEnabled = true;
            this.comboTipoAnimal.Location = new System.Drawing.Point(371, 45);
            this.comboTipoAnimal.Name = "comboTipoAnimal";
            this.comboTipoAnimal.Size = new System.Drawing.Size(144, 28);
            this.comboTipoAnimal.TabIndex = 21;
            this.comboTipoAnimal.SelectionChangeCommitted += new System.EventHandler(this.comboTipoAnimal_SelectionChangeCommitted);
            // 
            // comboCaixa
            // 
            this.comboCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaixa.FormattingEnabled = true;
            this.comboCaixa.Location = new System.Drawing.Point(64, 37);
            this.comboCaixa.Name = "comboCaixa";
            this.comboCaixa.Size = new System.Drawing.Size(200, 28);
            this.comboCaixa.TabIndex = 15;
            this.comboCaixa.SelectionChangeCommitted += new System.EventHandler(this.comboCaixa_SelectionChangeCommitted);
            // 
            // lblCaixa
            // 
            this.lblCaixa.AutoSize = true;
            this.lblCaixa.Location = new System.Drawing.Point(6, 40);
            this.lblCaixa.Name = "lblCaixa";
            this.lblCaixa.Size = new System.Drawing.Size(52, 20);
            this.lblCaixa.TabIndex = 14;
            this.lblCaixa.Text = "Caixa:";
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Valid_Green;
            this.btnProsseguir.Location = new System.Drawing.Point(469, 119);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(46, 44);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Tag = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // FormVideoAnalyzerSelecionaAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 194);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVideoAnalyzerSelecionaAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Analyzer - Selecionar Animal";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerSelecionaAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProsseguir;
        private ComboBox comboCaixa;
        private Label lblCaixa;
        private ComboBox comboGrupo;
        private Label lblGrupo;
        private Label label1;
        private ComboBox comboTipoAnimal;
        private Label lblAnimal;
        private ComboBox comboAnimal;
    }
}