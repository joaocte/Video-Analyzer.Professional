using SimpleInjector;
using System;
using System.Windows.Forms;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerPrincipal : Form
    {
        private readonly Container container;

        public FormVideoAnalyzerPrincipal(Container container)
        {
            this.container = container;
            InitializeComponent();
        }

        private void animalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerAnimal>().ShowDialog();
        }

        private void caixaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            container.GetInstance<FrmCadastrarCaixa>().ShowDialog();
        }

        private void comportamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerComportamento>().ShowDialog();
        }

        private void FormVideoAnalyzerPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.User = string.Empty;
            Settings.Default.Logado = string.Empty;
            Settings.Default.Save();
            System.Windows.Forms.Application.Exit();
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.GetInstance<FromVideoAnalyzerGrupo>().ShowDialog();
        }

        private void labirintoEmCruzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerPlayerWmp>().ShowDialog();
        }

        private void labirintoEmCruzToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerExtrairExcel>().ShowDialog();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tipoAnimalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerTipoAnimal>().ShowDialog();
        }

        private void tipoComportamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerTipoComportamento>().ShowDialog();
        }
    }
}