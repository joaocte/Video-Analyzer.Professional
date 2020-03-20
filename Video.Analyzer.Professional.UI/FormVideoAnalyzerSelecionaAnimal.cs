using System;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerSelecionaAnimal : Form
    {
        private readonly IAnimalAppService _animalAppService;
        private readonly IAnimalComportamentoAppService _animalComportamentoAppService;
        private readonly ICaixaAppService _caixaAppService;
        private readonly IGrupoAppService _gruproAppService;
        private readonly ITipoAnimalAppService _tipoAnimalAppService;
        private Guid _idCaixa;
        private Guid _idGrupo;
        private Guid _idTipoAnimal;

        public FormVideoAnalyzerSelecionaAnimal(ICaixaAppService caixaAppService, IGrupoAppService gruproAppService, IAnimalAppService animalAppService, ITipoAnimalAppService tipoAnimalAppService, IAnimalComportamentoAppService animalComportamentoAppService)
        {
            _caixaAppService = caixaAppService;
            _gruproAppService = gruproAppService;
            _animalAppService = animalAppService;
            _tipoAnimalAppService = tipoAnimalAppService;
            _animalComportamentoAppService = animalComportamentoAppService;
            AnimalSelecionado = null;
            InitializeComponent();
        }

        public AnimalViewModel AnimalSelecionado { get; set; }

        public void LimpaCampos()
        {
            comboCaixa.SelectionStart = 0;
            comboAnimal.SelectionStart = 0;
            comboGrupo.SelectionStart = 0;
            comboTipoAnimal.SelectionStart = 0;
        }

        private void btnProsseguir_Click(object sender, EventArgs e)
        {
            if (!this._animalComportamentoAppService.GetAll().Where(x => x.IdAnimal == AnimalSelecionado.IdAnimal).Any())
                SetVisibleCore(false);
            else
            {
                var dialogResult = MessageBox.Show("Existe Comportamento para este animal, deseja Excluir?", "Encontramos comportamento para o animal Selecionado", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this._animalComportamentoAppService.DeleteComportamentoAnimal(this.AnimalSelecionado.IdAnimal);
                    MessageBox.Show("Comportamentos Excluídos com Sucesso");
                    this.SetVisibleCore(false);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.SetVisibleCore(false);
                }
            }
        }

        private void comboAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbAnimal = sender as ComboBox;
            AnimalSelecionado = cbAnimal?.SelectedItem as AnimalViewModel;
        }

        private void comboCaixa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbCaixa = sender as ComboBox;
            var caixa = cbCaixa?.SelectedItem as CaixaViewModel;
            if (caixa != null) _idCaixa = caixa.IdCaixa;
            MontaComboAnimal();
        }

        private void comboGrupo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbGrupo = sender as ComboBox;
            var grupo = cbGrupo?.SelectedItem as GrupoViewModel;
            if (grupo != null) _idGrupo = grupo.IdGrupo;
            MontaComboAnimal();
        }

        private void comboTipoAnimal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var cbTipoAnimal = sender as ComboBox;
            var tipoAnimal = cbTipoAnimal?.SelectedItem as TipoAnimalViewModel;
            if (tipoAnimal != null) _idTipoAnimal = tipoAnimal.IdTipoAnimal;
            MontaComboAnimal();
        }

        private void FormVideoAnalyzerSelecionaAnimal_Load(object sender, EventArgs e)
        {
            _idCaixa = Guid.Empty;
            _idTipoAnimal = Guid.Empty;
            _idGrupo = Guid.Empty;
            AnimalSelecionado = null;

            var grupos = _gruproAppService.GetAll().Where(_ => _.StatusGrupo && _.IdUsuario == Guid.Parse(Settings.Default.Logado)).OrderBy(_ => _.IdGrupo).ToList();
            var tipoAnimais = _tipoAnimalAppService.GetAll().Where(_ => _.StatusTipoAnimal && _.IdUsuario == Guid.Parse(Settings.Default.Logado)).OrderBy(_ => _.IdTipoAnimal).ToList();
            var caixas = _caixaAppService.GetAll().Where(_ => _.StatusCaixa && _.IdUsuario == Guid.Parse(Settings.Default.Logado)).OrderBy(_ => _.IdCaixa).ToList();

            comboGrupo.DataSource = grupos;
            comboGrupo.DisplayMember = "NomeGrupo";
            comboGrupo.ValueMember = "IdGrupo";

            comboTipoAnimal.DataSource = tipoAnimais;
            comboTipoAnimal.DisplayMember = "NomeTipoAnimal";
            comboTipoAnimal.ValueMember = "IdTipoAnimal";

            comboCaixa.DataSource = caixas;
            comboCaixa.DisplayMember = "NomeCaixa";
            comboCaixa.ValueMember = "IdCaixa";

            AnimalSelecionado = null;

            MontaComboAnimal();
            LimpaCampos();
        }

        private void MontaComboAnimal()
        {
            var animais = _animalAppService.GetAll().Where(
                    _ => _.StatusAnimal
                    && _.IdUsuario == Guid.Parse(Settings.Default.Logado)
                         && (_idGrupo == Guid.Empty ? true : _.IdGrupo == _idGrupo)
                         && (_idCaixa == Guid.Empty ? true : _.IdCaixa == _idCaixa)
                         && (_idTipoAnimal == Guid.Empty ? true : _.IdTipoAnimal == _idTipoAnimal)).OrderBy(_ => _.IdAnimal).ToList();

            comboAnimal.DataSource = animais;
            comboAnimal.DisplayMember = "NomeAnimal";
            comboAnimal.ValueMember = "IdAnimal";
        }
    }
}