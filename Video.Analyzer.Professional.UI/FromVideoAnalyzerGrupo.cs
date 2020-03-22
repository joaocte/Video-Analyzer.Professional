using System;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FromVideoAnalyzerGrupo : Form
    {
        private readonly IGrupoAppService _grupoAppService;

        public FromVideoAnalyzerGrupo(IGrupoAppService grupoAppService)
        {
            _grupoAppService = grupoAppService;
            InitializeComponent();
            DesabilitaComponetes();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaComponetes();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var grupo = new GrupoViewModel
            {
                IdGrupo = Guid.NewGuid(),
                NomeGrupo = txtNomeGrupo.Text,
                IdUsuario = Guid.Parse(Settings.Default.Logado),
                StatusGrupo = comboStatus.RetornoComboBox("Habilitado")
            };
            _grupoAppService.Add(grupo);
            LimpaCampos();
            DesabilitaComponetes();
        }

        private void DesabilitaComponetes()
        {
            comboStatus.SelectedIndex = 0;
            this.DesabilitaComponetes(typeof(TextBox));
            this.DesabilitaComponetes(typeof(ComboBox));
        }

        private void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(ComboBox));
            this.HabilitaComponetes(typeof(TextBox));
        }

        private void LimpaCampos()
        {
            this.LimpaComponentes(typeof(TextBox));
            comboStatus.SelectedIndex = 0;
        }
    }
}