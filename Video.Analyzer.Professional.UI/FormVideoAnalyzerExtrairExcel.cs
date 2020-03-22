using System;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerExtrairExcel : Form
    {
        private readonly IAnimalComportamentoAppService animalComportamentoAppService;
        private readonly ICaixaAppService caixaAppService;
        private Guid _idCaixa;

        public FormVideoAnalyzerExtrairExcel(ICaixaAppService caixaAppService, IGrupoAppService gruproAppService, IAnimalAppService animalAppService, ITipoAnimalAppService tipoAnimalAppService, IAnimalComportamentoAppService animalComportamentoAppService)
        {
            this.caixaAppService = caixaAppService;
            this.animalComportamentoAppService = animalComportamentoAppService;
            AnimalSelecionado = null;
            InitializeComponent();
        }

        public AnimalViewModel AnimalSelecionado { get; set; }

        public void LimpaCampos()
        {
            comboCaixa.SelectionStart = 0;
            dataGridRelatorio.Rows.Clear();
            dataGridRelatorio.Columns.Clear();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            dataGridRelatorio.ExportaExcel<RelatorioComportamentoLabirintoEmCruz>();
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (AnimalSelecionado == null)
                return;

            var comportamentos = animalComportamentoAppService.GetAll(this._idCaixa, Guid.Parse(Settings.Default.Logado), this.cbAgrupado.Checked);

            dataGridRelatorio.DataSource = comportamentos;
            dataGridRelatorio.AutoGenerateColumns = true;
            btnExportExcel.Enabled = comportamentos.Any();
        }

        private void comboCaixa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbCaixa = sender as ComboBox;
            var caixa = cbCaixa?.SelectedItem as CaixaViewModel;
            if (caixa != null) _idCaixa = caixa.IdCaixa;
        }

        private void FormVideoAnalyzerExtrairExcel_Load(object sender, EventArgs e)
        {
            _idCaixa = Guid.Empty;
            AnimalSelecionado = null;
            LimpaCampos();

            dataGridRelatorio.InitLayout();

            var caixas = caixaAppService.GetAll().Where(_ => _.StatusCaixa && _.IdUsuario == Guid.Parse(Settings.Default.Logado)).OrderBy(_ => _.IdCaixa).ToList();

            comboCaixa.DataSource = caixas;
            comboCaixa.DisplayMember = "NomeCaixa";
            comboCaixa.ValueMember = "IdCaixa";

            AnimalSelecionado = null;

            LimpaCampos();
        }
    }
}