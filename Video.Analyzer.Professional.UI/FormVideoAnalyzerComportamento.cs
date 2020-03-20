using AutoMapper;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerComportamento : Form
    {
        private readonly IComportamentoAppService comportamentoAppService;
        private readonly Container container;
        private readonly IMapper mapper;
        private readonly ITipoComportamentoAppService tipoComportamentoAppService;

        public FormVideoAnalyzerComportamento(IComportamentoAppService comportamentoAppService, ITipoComportamentoAppService tipoComportamentoAppService, IMapper mapper, Container container)
        {
            this.comportamentoAppService = comportamentoAppService;
            this.tipoComportamentoAppService = tipoComportamentoAppService;
            this.mapper = mapper;
            this.container = container;
            InitializeComponent();
            DesabilitaComponetes();
        }

        private void AtualizaComboTipoComportamento()
        {
            var tiposComportamentos = mapper.Map<IEnumerable<TipoComportamentoViewModel>>
                (tipoComportamentoAppService.GetAll().Where(_ => _.StatusTipoComportamento && _.IdUsuario == Guid.Parse(Settings.Default.Logado)));

            comboTipoComportamento.DataSource = tiposComportamentos;
            comboTipoComportamento.DisplayMember = "NomeTipoComportamento";
            comboTipoComportamento.ValueMember = "IdTipoComportamento";
        }

        private void btnAdicionarTipoComportamento_Click(object sender, EventArgs e)
        {
            container.GetInstance<FormVideoAnalyzerTipoComportamento>().ShowDialog();
            AtualizaComboTipoComportamento();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaComponentes();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaComponetes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tipoComportamento = comboTipoComportamento.SelectedItem as TipoComportamentoViewModel;
            var caixa = new ComportamentoViewModel
            {
                IdComportamento = Guid.NewGuid(),
                NomeComportamento = txtNomeComportamento.Text,
                IdUsuario = Guid.Parse(Settings.Default.Logado),
                LetraTeclado = txtTeclaComportamento.Text,
                StatusComportamento = comboStatus.RetornoComboBox("Habilitado"),
                IdTipoComportamento = tipoComportamento?.IdTipoComportamento ?? Guid.Empty
            };
            comportamentoAppService.Add(caixa);
            LimpaComponentes();
            DesabilitaComponetes();
        }

        private void DesabilitaComponetes()
        {
            comboStatus.SelectedIndex = 0;
            this.DesabilitaComponetes(typeof(ComboBox));
            this.DesabilitaComponetes(typeof(TextBox));
        }

        private void FormVideoAnalyzerComportamento_Load(object sender, EventArgs e)
        {
            gridComportamentos.InitLayout();
            AtualizaComboTipoComportamento();
        }

        private void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(ComboBox));
            this.HabilitaComponetes(typeof(TextBox));
        }

        private void LimpaComponentes()
        {
            this.LimpaComponentes(typeof(TextBox));
            comboStatus.SelectedIndex = 0;
            comboTipoComportamento.SelectedIndex = 0;
        }

        private void txtTeclaComportamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtTeclaComportamento.Text = string.Empty;
            txtTeclaComportamento.Text = e.KeyChar.ToString();
        }
    }
}