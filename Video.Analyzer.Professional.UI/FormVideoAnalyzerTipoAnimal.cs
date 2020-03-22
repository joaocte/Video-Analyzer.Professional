using System;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerTipoAnimal : Form
    {
        private readonly ITipoAnimalAppService _tipoAnimalAppService;

        public FormVideoAnalyzerTipoAnimal(ITipoAnimalAppService tipoAnimalAppService)
        {
            _tipoAnimalAppService = tipoAnimalAppService;
            InitializeComponent();
            DesabilitaComponetes();
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
            var tipoAnimal = new TipoAnimalViewModel
            {
                IdTipoAnimal = Guid.NewGuid(),
                NomeTipoAnimal = txtNomeTipoAnimal.Text,
                IdUsuario = Guid.Parse(Settings.Default.Logado),
                StatusTipoAnimal = comboStatus.RetornoComboBox("Habilitado")
            };
            _tipoAnimalAppService.Add(tipoAnimal);
            LimpaComponentes();
            DesabilitaComponetes();
        }

        private void DesabilitaComponetes()
        {
            comboStatus.SelectedIndex = 0;
            this.DesabilitaComponetes(typeof(TextBox));
            this.DesabilitaComponetes(typeof(ComboBox));
        }

        private void FormVideoAnalyzerTipoAnimal_Load(object sender, EventArgs e)
        {
            var tipos = _tipoAnimalAppService.GetAll();
        }

        private void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(TextBox));
            this.HabilitaComponetes(typeof(ComboBox));
        }

        private void LimpaComponentes()
        {
            this.LimpaComponentes(typeof(TextBox));
        }
    }
}