namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerExtrairExcel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.cbAgrupado = new System.Windows.Forms.CheckBox();
            this.dataGridRelatorio = new System.Windows.Forms.DataGridView();
            this.comboCaixa = new System.Windows.Forms.ComboBox();
            this.lblCaixa = new System.Windows.Forms.Label();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportExcel);
            this.groupBox1.Controls.Add(this.cbAgrupado);
            this.groupBox1.Controls.Add(this.dataGridRelatorio);
            this.groupBox1.Controls.Add(this.comboCaixa);
            this.groupBox1.Controls.Add(this.lblCaixa);
            this.groupBox1.Controls.Add(this.btnProsseguir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 537);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Animal a Ser Analisado";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Enabled = false;
            this.btnExportExcel.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.excel5;
            this.btnExportExcel.Location = new System.Drawing.Point(708, 493);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(34, 34);
            this.btnExportExcel.TabIndex = 33;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // cbAgrupado
            // 
            this.cbAgrupado.AutoSize = true;
            this.cbAgrupado.Location = new System.Drawing.Point(589, 40);
            this.cbAgrupado.Name = "cbAgrupado";
            this.cbAgrupado.Size = new System.Drawing.Size(107, 24);
            this.cbAgrupado.TabIndex = 32;
            this.cbAgrupado.Text = "Agrupado?";
            this.cbAgrupado.UseVisualStyleBackColor = true;
            // 
            // dataGridRelatorio
            // 
            this.dataGridRelatorio.AllowUserToAddRows = false;
            this.dataGridRelatorio.AllowUserToDeleteRows = false;
            this.dataGridRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRelatorio.Location = new System.Drawing.Point(10, 78);
            this.dataGridRelatorio.Name = "dataGridRelatorio";
            this.dataGridRelatorio.ReadOnly = true;
            this.dataGridRelatorio.Size = new System.Drawing.Size(732, 409);
            this.dataGridRelatorio.TabIndex = 31;
            // 
            // comboCaixa
            // 
            this.comboCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCaixa.FormattingEnabled = true;
            this.comboCaixa.Location = new System.Drawing.Point(64, 32);
            this.comboCaixa.Name = "comboCaixa";
            this.comboCaixa.Size = new System.Drawing.Size(169, 28);
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
            this.btnProsseguir.Location = new System.Drawing.Point(708, 32);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(46, 40);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Tag = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            this.btnProsseguir.Click += new System.EventHandler(this.btnProsseguir_Click);
            // 
            // FormVideoAnalyzerExtrairExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVideoAnalyzerExtrairExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar Excel";
            this.Load += new System.EventHandler(this.FormVideoAnalyzerExtrairExcel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRelatorio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCaixa;
        private System.Windows.Forms.Label lblCaixa;
        private System.Windows.Forms.Button btnProsseguir;
        private System.Windows.Forms.DataGridView dataGridRelatorio;
        private System.Windows.Forms.CheckBox cbAgrupado;
        private System.Windows.Forms.Button btnExportExcel;
    }
}