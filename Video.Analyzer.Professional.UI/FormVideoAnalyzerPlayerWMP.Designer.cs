using System.ComponentModel;
using System.Windows.Forms;

namespace Video.Analyzer.Professional.UI
{
    partial class FormVideoAnalyzerPlayerWmp
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
            this.components = new System.ComponentModel.Container();
            this.tracVolume = new System.Windows.Forms.TrackBar();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnTelaInteira = new System.Windows.Forms.Button();
            this.painelVideo = new System.Windows.Forms.Panel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tableLayoutBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProsseguir = new System.Windows.Forms.Button();
            this.btnAbrirDiretorio = new System.Windows.Forms.Button();
            this.txtDiretorio = new System.Windows.Forms.TextBox();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.lblTempoVideo = new System.Windows.Forms.Label();
            this.listaVideos = new System.Windows.Forms.ListBox();
            this.trackBarVideoProgress = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblComportamento = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tracVolume)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // tracVolume
            // 
            this.tracVolume.Location = new System.Drawing.Point(543, 426);
            this.tracVolume.Maximum = 100;
            this.tracVolume.Name = "tracVolume";
            this.tracVolume.Size = new System.Drawing.Size(124, 45);
            this.tracVolume.TabIndex = 36;
            this.tracVolume.Visible = false;
            this.tracVolume.Scroll += new System.EventHandler(this.tracVolume_Scroll);
            // 
            // btnVolume
            // 
            this.btnVolume.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.mix_volume;
            this.btnVolume.Location = new System.Drawing.Point(497, 426);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(40, 40);
            this.btnVolume.TabIndex = 35;
            this.btnVolume.UseVisualStyleBackColor = true;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnTelaInteira
            // 
            this.btnTelaInteira.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.window_fullscreen_small;
            this.btnTelaInteira.Location = new System.Drawing.Point(156, 426);
            this.btnTelaInteira.Name = "btnTelaInteira";
            this.btnTelaInteira.Size = new System.Drawing.Size(40, 40);
            this.btnTelaInteira.TabIndex = 34;
            this.btnTelaInteira.UseVisualStyleBackColor = true;
            this.btnTelaInteira.Click += new System.EventHandler(this.btnTelaInteira_Click);
            // 
            // painelVideo
            // 
            this.painelVideo.Location = new System.Drawing.Point(12, 84);
            this.painelVideo.Name = "painelVideo";
            this.painelVideo.Size = new System.Drawing.Size(560, 290);
            this.painelVideo.TabIndex = 11;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Fast_Rewind;
            this.btnPrevious.Location = new System.Drawing.Point(18, 426);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(40, 40);
            this.btnPrevious.TabIndex = 32;
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Fast_Forward;
            this.btnNext.Location = new System.Drawing.Point(110, 426);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 40);
            this.btnNext.TabIndex = 31;
            this.btnNext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Play_Green;
            this.btnPlay.Location = new System.Drawing.Point(64, 426);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 40);
            this.btnPlay.TabIndex = 30;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tableLayoutBotoes
            // 
            this.tableLayoutBotoes.ColumnCount = 2;
            this.tableLayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.Location = new System.Drawing.Point(12, 472);
            this.tableLayoutBotoes.Name = "tableLayoutBotoes";
            this.tableLayoutBotoes.RowCount = 2;
            this.tableLayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutBotoes.Size = new System.Drawing.Size(760, 186);
            this.tableLayoutBotoes.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProsseguir);
            this.groupBox1.Controls.Add(this.btnAbrirDiretorio);
            this.groupBox1.Controls.Add(this.txtDiretorio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(759, 66);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione o Diretório dos Videos";
            // 
            // btnProsseguir
            // 
            this.btnProsseguir.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.Knob_Valid_Green;
            this.btnProsseguir.Location = new System.Drawing.Point(702, 16);
            this.btnProsseguir.Name = "btnProsseguir";
            this.btnProsseguir.Size = new System.Drawing.Size(46, 44);
            this.btnProsseguir.TabIndex = 2;
            this.btnProsseguir.Tag = "Prosseguir";
            this.btnProsseguir.UseVisualStyleBackColor = true;
            // 
            // btnAbrirDiretorio
            // 
            this.btnAbrirDiretorio.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.folder_video;
            this.btnAbrirDiretorio.Location = new System.Drawing.Point(654, 16);
            this.btnAbrirDiretorio.Name = "btnAbrirDiretorio";
            this.btnAbrirDiretorio.Size = new System.Drawing.Size(42, 44);
            this.btnAbrirDiretorio.TabIndex = 1;
            this.btnAbrirDiretorio.UseVisualStyleBackColor = true;
            this.btnAbrirDiretorio.Click += new System.EventHandler(this.btnAbrirDiretorio_Click);
            // 
            // txtDiretorio
            // 
            this.txtDiretorio.Enabled = false;
            this.txtDiretorio.Location = new System.Drawing.Point(6, 25);
            this.txtDiretorio.Name = "txtDiretorio";
            this.txtDiretorio.Size = new System.Drawing.Size(606, 26);
            this.txtDiretorio.TabIndex = 0;
            // 
            // timerVideo
            // 
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // lblTempoVideo
            // 
            this.lblTempoVideo.AutoSize = true;
            this.lblTempoVideo.Location = new System.Drawing.Point(558, 390);
            this.lblTempoVideo.Name = "lblTempoVideo";
            this.lblTempoVideo.Size = new System.Drawing.Size(102, 13);
            this.lblTempoVideo.TabIndex = 37;
            this.lblTempoVideo.Text = "00:00:00 / 00:00:00";
            // 
            // listaVideos
            // 
            this.listaVideos.FormattingEnabled = true;
            this.listaVideos.Location = new System.Drawing.Point(578, 84);
            this.listaVideos.Name = "listaVideos";
            this.listaVideos.Size = new System.Drawing.Size(193, 290);
            this.listaVideos.TabIndex = 38;
            this.listaVideos.SelectedIndexChanged += new System.EventHandler(this.lstVideos_SelectedIndexChanged);
            // 
            // trackBarVideoProgress
            // 
            this.trackBarVideoProgress.Location = new System.Drawing.Point(12, 380);
            this.trackBarVideoProgress.Name = "trackBarVideoProgress";
            this.trackBarVideoProgress.Size = new System.Drawing.Size(540, 45);
            this.trackBarVideoProgress.TabIndex = 39;
            this.trackBarVideoProgress.Scroll += new System.EventHandler(this.trackBarVideoProgress_Scroll);
            // 
            // btnReset
            // 
            this.btnReset.Image = global::Video.Analyzer.Professional.UI.Properties.Resources.hot;
            this.btnReset.Location = new System.Drawing.Point(202, 426);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(40, 40);
            this.btnReset.TabIndex = 40;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblComportamento
            // 
            this.lblComportamento.AutoSize = true;
            this.lblComportamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComportamento.ForeColor = System.Drawing.Color.Crimson;
            this.lblComportamento.Location = new System.Drawing.Point(248, 431);
            this.lblComportamento.Name = "lblComportamento";
            this.lblComportamento.Size = new System.Drawing.Size(0, 31);
            this.lblComportamento.TabIndex = 42;
            // 
            // FormVideoAnalyzerPlayerWmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 675);
            this.Controls.Add(this.lblComportamento);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.trackBarVideoProgress);
            this.Controls.Add(this.listaVideos);
            this.Controls.Add(this.lblTempoVideo);
            this.Controls.Add(this.tracVolume);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.btnTelaInteira);
            this.Controls.Add(this.painelVideo);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.tableLayoutBotoes);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.Name = "FormVideoAnalyzerPlayerWmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video Analyzer - Player";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVideoAnalyzerPlayerWmp_FormClosing);
            this.Load += new System.EventHandler(this.FormVideoAnalyzerPlayerWmp_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormVideoAnalyzerPlayerWmp_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tracVolume)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVideoProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TrackBar tracVolume;
        private Button btnVolume;
        private Button btnTelaInteira;
        private Panel painelVideo;
        private Button btnPrevious;
        private Button btnNext;
        private Button btnPlay;
        private TableLayoutPanel tableLayoutBotoes;
        private GroupBox groupBox1;
        private Button btnProsseguir;
        private Button btnAbrirDiretorio;
        private TextBox txtDiretorio;
        private Timer timerVideo;
        private Label lblTempoVideo;
        private ListBox listaVideos;
        private TrackBar trackBarVideoProgress;
        private Button btnReset;
        private Label lblComportamento;
    }
}