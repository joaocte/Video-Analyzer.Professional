using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVideoAnalyzerPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.comportamentoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoAnimalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoComportamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perfilToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.análisesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comportamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maternoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labirintoEmCruzToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labirintoEmCruzToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.análisesToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "Menu";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem,
            this.toolStripSeparator1,
            this.usuárioToolStripMenuItem,
            this.toolStripSeparator2,
            this.perfilToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Add;
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animalToolStripMenuItem1,
            this.caixaToolStripMenuItem1,
            this.comportamentoToolStripMenuItem1,
            this.grupoToolStripMenuItem,
            this.tipoAnimalToolStripMenuItem1,
            this.tipoComportamentoToolStripMenuItem});
            this.animalToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.icons8_Rattata_32;
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.animalToolStripMenuItem.Text = "Animais";
            // 
            // animalToolStripMenuItem1
            // 
            this.animalToolStripMenuItem1.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.icons8_Rattata_32;
            this.animalToolStripMenuItem1.Name = "animalToolStripMenuItem1";
            this.animalToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.animalToolStripMenuItem1.Text = "Animal";
            this.animalToolStripMenuItem1.Click += new System.EventHandler(this.animalToolStripMenuItem1_Click);
            // 
            // caixaToolStripMenuItem1
            // 
            this.caixaToolStripMenuItem1.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.tar1;
            this.caixaToolStripMenuItem1.Name = "caixaToolStripMenuItem1";
            this.caixaToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.caixaToolStripMenuItem1.Text = "Caixa";
            this.caixaToolStripMenuItem1.Click += new System.EventHandler(this.caixaToolStripMenuItem1_Click);
            // 
            // comportamentoToolStripMenuItem1
            // 
            this.comportamentoToolStripMenuItem1.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.rato;
            this.comportamentoToolStripMenuItem1.Name = "comportamentoToolStripMenuItem1";
            this.comportamentoToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.comportamentoToolStripMenuItem1.Text = "Comportamento";
            this.comportamentoToolStripMenuItem1.Click += new System.EventHandler(this.comportamentoToolStripMenuItem1_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.shapes_32;
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // tipoAnimalToolStripMenuItem1
            // 
            this.tipoAnimalToolStripMenuItem1.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Type;
            this.tipoAnimalToolStripMenuItem1.Name = "tipoAnimalToolStripMenuItem1";
            this.tipoAnimalToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.tipoAnimalToolStripMenuItem1.Text = "Tipo Animal";
            this.tipoAnimalToolStripMenuItem1.Click += new System.EventHandler(this.tipoAnimalToolStripMenuItem1_Click);
            // 
            // tipoComportamentoToolStripMenuItem
            // 
            this.tipoComportamentoToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Type;
            this.tipoComportamentoToolStripMenuItem.Name = "tipoComportamentoToolStripMenuItem";
            this.tipoComportamentoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tipoComportamentoToolStripMenuItem.Text = "Tipo Comportamento";
            this.tipoComportamentoToolStripMenuItem.Click += new System.EventHandler(this.tipoComportamentoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem1,
            this.usuárioToolStripMenuItem1});
            this.usuárioToolStripMenuItem.Enabled = false;
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuárioToolStripMenuItem.Text = "Usuários";
            // 
            // perfilToolStripMenuItem1
            // 
            this.perfilToolStripMenuItem1.Name = "perfilToolStripMenuItem1";
            this.perfilToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.perfilToolStripMenuItem1.Text = "Perfil";
            // 
            // usuárioToolStripMenuItem1
            // 
            this.usuárioToolStripMenuItem1.Name = "usuárioToolStripMenuItem1";
            this.usuárioToolStripMenuItem1.Size = new System.Drawing.Size(114, 22);
            this.usuárioToolStripMenuItem1.Text = "Usuário";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Exit;
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perfilToolStripMenuItem.Text = "Sair";
            this.perfilToolStripMenuItem.Click += new System.EventHandler(this.perfilToolStripMenuItem_Click);
            // 
            // análisesToolStripMenuItem
            // 
            this.análisesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comportamentoToolStripMenuItem});
            this.análisesToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Analyzer;
            this.análisesToolStripMenuItem.Name = "análisesToolStripMenuItem";
            this.análisesToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.análisesToolStripMenuItem.Text = "Análises";
            // 
            // comportamentoToolStripMenuItem
            // 
            this.comportamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maternoToolStripMenuItem,
            this.labirintoEmCruzToolStripMenuItem});
            this.comportamentoToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.rato;
            this.comportamentoToolStripMenuItem.Name = "comportamentoToolStripMenuItem";
            this.comportamentoToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.comportamentoToolStripMenuItem.Text = "Comportamento";
            // 
            // maternoToolStripMenuItem
            // 
            this.maternoToolStripMenuItem.Enabled = false;
            this.maternoToolStripMenuItem.Name = "maternoToolStripMenuItem";
            this.maternoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.maternoToolStripMenuItem.Text = "Materno";
            // 
            // labirintoEmCruzToolStripMenuItem
            // 
            this.labirintoEmCruzToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.LCE_2;
            this.labirintoEmCruzToolStripMenuItem.Name = "labirintoEmCruzToolStripMenuItem";
            this.labirintoEmCruzToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.labirintoEmCruzToolStripMenuItem.Text = "Labirinto em Cruz";
            this.labirintoEmCruzToolStripMenuItem.Click += new System.EventHandler(this.labirintoEmCruzToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labirintoEmCruzToolStripMenuItem2});
            this.relatóriosToolStripMenuItem.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.report;
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // labirintoEmCruzToolStripMenuItem2
            // 
            this.labirintoEmCruzToolStripMenuItem2.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.LCE_2;
            this.labirintoEmCruzToolStripMenuItem2.Name = "labirintoEmCruzToolStripMenuItem2";
            this.labirintoEmCruzToolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.labirintoEmCruzToolStripMenuItem2.Text = "Labirinto em Cruz";
            this.labirintoEmCruzToolStripMenuItem2.Click += new System.EventHandler(this.labirintoEmCruzToolStripMenuItem2_Click);
            // 
            // FormVideoAnalyzerPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FormVideoAnalyzerPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Analyzer - 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVideoAnalyzerPrincipal_FormClosing);
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuPrincipal;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem;
        private ToolStripMenuItem animalToolStripMenuItem1;
        private ToolStripMenuItem caixaToolStripMenuItem1;
        private ToolStripMenuItem comportamentoToolStripMenuItem1;
        private ToolStripMenuItem tipoAnimalToolStripMenuItem1;
        private ToolStripMenuItem grupoToolStripMenuItem;
        private ToolStripMenuItem usuárioToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem perfilToolStripMenuItem1;
        private ToolStripMenuItem usuárioToolStripMenuItem1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem análisesToolStripMenuItem;
        private ToolStripMenuItem comportamentoToolStripMenuItem;
        private ToolStripMenuItem maternoToolStripMenuItem;
        private ToolStripMenuItem labirintoEmCruzToolStripMenuItem;
        private ToolStripMenuItem tipoComportamentoToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem labirintoEmCruzToolStripMenuItem2;
    }
}

