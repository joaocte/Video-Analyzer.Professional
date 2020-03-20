using System;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FrmCadastrarCaixa : Form
    {
        private readonly ICaixaAppService _caixaAppService;

        public FrmCadastrarCaixa(ICaixaAppService caixaAppService)
        {
            _caixaAppService = caixaAppService;
            InitializeComponent();
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
            var caixa = new CaixaViewModel
            {
                IdCaixa = Guid.NewGuid(),
                NomeCaixa = txtNomeCaixa.Text,
                IdUsuario = Guid.Parse(Settings.Default.Logado),
                StatusCaixa = comboStatus.RetornoComboBox("Habilitado")
            };
            _caixaAppService.Add(caixa);
            LimpaComponentes();
            DesabilitaComponetes();
        }

        private void DesabilitaComponetes()
        {
            comboStatus.SelectedIndex = 0;
            this.DesabilitaComponetes(typeof(TextBox));
            this.DesabilitaComponetes(typeof(ComboBox));
        }

        private void FrmCadastrarCaixa_Load(object sender, EventArgs e)
        {
            DesabilitaComponetes();
            var caixas = _caixaAppService.GetAll().Where(c => c.IdUsuario == Guid.Parse(Settings.Default.Logado)).ToList();

            GridCaixas.AutoGenerateColumns = true;
            GridCaixas.DataSource = caixas;
            GridCaixas.InitLayout();
        }

        private void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(TextBox));
            this.HabilitaComponetes(typeof(ComboBox));
        }

        private void LimpaComponentes()
        {
            this.LimpaComponentes(typeof(TextBox));
            comboStatus.SelectedIndex = 0;
        }
    }
}