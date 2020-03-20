using System;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerTipoComportamento : Form
    {
        private readonly ITipoComportamentoAppService _tipoComportamentoAppService;

        public FormVideoAnalyzerTipoComportamento(ITipoComportamentoAppService tipoComportamentoAppService)
        {
            _tipoComportamentoAppService = tipoComportamentoAppService;
            InitializeComponent();
        }

        public void DesabilitaComponetes()
        {
            this.DesabilitaComponetes(typeof(TextBox));
            this.DesabilitaComponetes(typeof(ComboBox));
        }

        public void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(TextBox));
            this.HabilitaComponetes(typeof(ComboBox));
        }

        public void LimpaComponentes()
        {
            comboStatus.SelectedIndex = 0;
            this.LimpaComponentes(typeof(TextBox));
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaComponentes();
            DesabilitaComponetes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaComponetes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tipoComportamento = new TipoComportamentoViewModel
            {
                IdTipoComportamento = Guid.NewGuid(),
                NomeTipoComportamento = txtNomeTipoComportamento.Text,
                IdUsuario = Guid.Parse(Settings.Default.Logado),
                StatusTipoComportamento = comboStatus.RetornoComboBox("Habilitado")
            };
            _tipoComportamentoAppService.Add(tipoComportamento);
            LimpaComponentes();
            DesabilitaComponetes();
        }

        private void FormVideoAnalyzerTipoComportamento_Load(object sender, EventArgs e)
        {
            DesabilitaComponetes();
            LimpaComponentes();
        }
    }
}