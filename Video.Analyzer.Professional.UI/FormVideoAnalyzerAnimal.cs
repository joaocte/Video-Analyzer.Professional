using AutoMapper;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerAnimal : Form
    {
        private readonly IAnimalAppService animalAppService;
        private readonly ICaixaAppService caixaAppService;
        private readonly Container conteiner;
        private readonly IGrupoAppService grupoAppService;
        private readonly IMapper mapper;
        private readonly ITipoAnimalAppService tipoAnimalAppService;

        public FormVideoAnalyzerAnimal(IMapper mapper, IAnimalAppService animalAppService,
            ITipoAnimalAppService tipoAnimalAppService, ICaixaAppService caixaAppService,
            IGrupoAppService grupoAppService, Container conteiner)
        {
            this.mapper = mapper;
            this.animalAppService = animalAppService;
            this.tipoAnimalAppService = tipoAnimalAppService;
            this.caixaAppService = caixaAppService;
            this.grupoAppService = grupoAppService;
            this.conteiner = conteiner;
            InitializeComponent();
        }

        private void AtualizaComboCaixa()
        {
            var caixas = mapper.Map<IEnumerable<CaixaViewModel>>(caixaAppService.GetAll().Where(c => c.StatusCaixa && c.IdUsuario == Guid.Parse(Settings.Default.Logado)));
            comboCaixa.DataSource = caixas;
            comboCaixa.DisplayMember = "NomeCaixa";
            comboCaixa.ValueMember = "IdCaixa";
        }

        private void AtualizaComboGrupo()
        {
            var grupos = mapper.Map<IEnumerable<GrupoViewModel>>(grupoAppService.GetAll());
            comboGrupo.DataSource = grupos;
            comboGrupo.DisplayMember = "NomeGrupo";
            comboGrupo.ValueMember = "IdGrupo";
        }

        private void AtualizaComboTipoAnimal()
        {
            var tipoAnimais = mapper.Map<IEnumerable<TipoAnimalViewModel>>(tipoAnimalAppService.GetAll()
                .Where(t => t.StatusTipoAnimal && t.IdUsuario == Guid.Parse(Settings.Default.Logado)));

            comboTipoAnimal.DataSource = tipoAnimais;
            comboTipoAnimal.DisplayMember = "NomeTipoAnimal";
            comboTipoAnimal.ValueMember = "IdTipoAnimal";
        }

        private void AtualizaGrid()
        {
            var animais =
                mapper.Map<IEnumerable<GridAnimalViewModel>>(animalAppService.GetAll(Guid.Parse(Settings.Default.Logado)));
            gridViewAnimaisCadastrados.DataSource = animais;
            gridViewAnimaisCadastrados.AutoGenerateColumns = true;
        }

        private void btnAdicionarCaixa_Click(object sender, EventArgs e)
        {
            conteiner.GetInstance<FrmCadastrarCaixa>().ShowDialog();
            AtualizaComboCaixa();
        }

        private void btnAdicionarGrupo_Click(object sender, EventArgs e)
        {
            conteiner.GetInstance<FromVideoAnalyzerGrupo>().ShowDialog();
            AtualizaComboGrupo();
        }

        private void btnAdicionarTipoAnimal_Click(object sender, EventArgs e)
        {
            conteiner.GetInstance<FormVideoAnalyzerTipoAnimal>().ShowDialog();

            AtualizaComboTipoAnimal();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaComponetes();
            checkNomeAutomatico_CheckedChanged(sender, e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var tipoAnimal = comboTipoAnimal.SelectedItem as TipoAnimalViewModel;
            var caixa = comboCaixa.SelectedItem as CaixaViewModel;
            var grupo = comboGrupo.SelectedItem as GrupoViewModel;

            var animal = new AnimalViewModel();

            animal.IdAnimal = Guid.NewGuid();
            if (caixa != null) animal.IdCaixa = caixa.IdCaixa;
            animal.Fezes = (double)numericQuantidadeDeFezes.Value;
            if (tipoAnimal != null) animal.IdTipoAnimal = tipoAnimal.IdTipoAnimal;

            animal.Peso = txtPeso.Text ?? "0g";
            animal.Sexo = comboSexo.SelectedItem.ToString();
            animal.StatusAnimal = comboStatus.RetornoComboBox("Habilitado");
            animal.IdUsuario = Guid.Parse(Settings.Default.Logado);
            if (grupo != null) animal.IdGrupo = grupo.IdGrupo;
            animal.NomeAnimal = checkNomeAutomatico.Checked
                ? (caixa.NomeCaixa + grupo.NomeGrupo + animal.Sexo).Trim()
                : txtNomeAnimal.Text;
            animalAppService.Add(animal);
            LimpaComponentes();
            DesabilitaComponetes();
            AtualizaGrid();
        }

        private void checkNomeAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            txtNomeAnimal.Enabled = !checkNomeAutomatico.Checked;
        }

        private void DesabilitaComponetes()
        {
            comboStatus.SelectedIndex = 0;
            comboCaixa.SelectionStart = 0;
            comboTipoAnimal.SelectionStart = 0;
            comboSexo.SelectedIndex = 0;

            this.DesabilitaComponetes(typeof(TextBox));
            this.DesabilitaComponetes(typeof(ComboBox));
            this.DesabilitaComponetes(typeof(NumericUpDown));
            this.DesabilitaComponetes(typeof(CheckBox));
        }

        private void FormVideoAnalyzerAnimal_Load(object sender, EventArgs e)
        {
            AtualizaComboCaixa();
            AtualizaComboGrupo();
            AtualizaComboTipoAnimal();

            AtualizaGrid();
            DesabilitaComponetes();
            gridViewAnimaisCadastrados.InitLayout();
        }

        private void HabilitaComponetes()
        {
            this.HabilitaComponetes(typeof(TextBox));
            this.HabilitaComponetes(typeof(ComboBox));
            this.HabilitaComponetes(typeof(NumericUpDown));
            this.HabilitaComponetes(typeof(CheckBox));
        }

        private void LimpaComponentes()
        {
            this.LimpaComponentes(typeof(TextBox));
        }
    }
}