using AutoMapper;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.Domain.Exceptions;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerPlayerWmp : Form
    {
        private readonly IAnimalComportamentoAppService _animalComportamentoAppService;
        private readonly IComportamentoAppService _comportamentoAppService;
        private readonly Container _container;
        private readonly IMapper _mapper;
        private readonly ITipoComportamentoAppService _tipoComportamentoAppService;
        private ComportamentoViewModel _comportamento;
        private List<ComportamentoViewModel> _comportamentos;
        private Size _formSize;
        private Size _pnlSize;
        private int _selectedIndex = 0;
        private List<Stopwatch> _transacoes;
        private string[] _videoPaths;
        private Microsoft.DirectX.AudioVideoPlayback.Video video;

        public FormVideoAnalyzerPlayerWmp(IComportamentoAppService comportamentoAppService, ITipoComportamentoAppService tipoComportamentoAppService, IAnimalComportamentoAppService animalComportamentoAppService, IMapper mapper, Container container)
        {
            _comportamentoAppService = comportamentoAppService;
            _tipoComportamentoAppService = tipoComportamentoAppService;
            _animalComportamentoAppService = animalComportamentoAppService;
            _mapper = mapper;
            _container = container;
            InitializeComponent();
        }

        public Guid IdAnimalEmAnalise { get; set; }

        private void AdicionaBotoes()
        {
            tableLayoutBotoes.Controls.Clear();
            var rowCount = (_comportamentos.Count % 2) == 0 ? (_comportamentos.Count / 2) : (_comportamentos.Count / 2) + 1;
            var columnCount = (_comportamentos.Count % 2) == 0 ? (_comportamentos.Count / 2) : (_comportamentos.Count / 2) + 1;

            tableLayoutBotoes.ColumnCount = columnCount;
            tableLayoutBotoes.RowCount = rowCount;

            tableLayoutBotoes.ColumnStyles.Clear();
            tableLayoutBotoes.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutBotoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                tableLayoutBotoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < _comportamentos.Count; i++)
            {
                var novoBotao = new Button();
                novoBotao.Text = _comportamentos[i].LetraTeclado + @" - " + _comportamentos[i].NomeComportamento;
                novoBotao.Name = $"button_{_comportamentos[i].NomeComportamento}";
                novoBotao.Click += ButtonClick;
                novoBotao.Dock = DockStyle.Fill;
                tableLayoutBotoes.Controls.Add(novoBotao);
            }
        }

        private void btnAbrirDiretorio_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog openFile = new FolderBrowserDialog())
            {
                if (openFile.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFile.SelectedPath))
                {
                    _videoPaths = Directory.GetFiles(openFile.SelectedPath, "*.*", SearchOption.AllDirectories)
                        .Where(s => s.EndsWith(".mpg")
                                    || s.EndsWith(".avi")
                                    || s.EndsWith(".wma")
                                    || s.EndsWith(".mov")
                                    || s.EndsWith(".wav")).ToArray<string>();

                    foreach (string path in _videoPaths)
                    {
                        string caminhoVideo = path.Replace(openFile.SelectedPath, string.Empty);
                        caminhoVideo = caminhoVideo.Replace(".mpg", string.Empty);
                        caminhoVideo = caminhoVideo.Replace(".avi", string.Empty);
                        caminhoVideo = caminhoVideo.Replace(".wma", string.Empty);
                        caminhoVideo = caminhoVideo.Replace(".mov", string.Empty);
                        caminhoVideo = caminhoVideo.Replace(".wav", string.Empty);
                        listaVideos.Items.Add(caminhoVideo);
                    }
                    if (listaVideos.Items.Count > 0)
                        listaVideos.SelectedIndex = _selectedIndex;
                }
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
                timerVideo.Enabled = true;
                btnPlay.Image = Resources.Knob_Pause;
            }
            else if (video.Playing)
            {
                video.Pause();
                timerVideo.Enabled = false;
                btnPlay.Image = Resources.Knob_Play_Green;
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (_animalComportamentoAppService.GetAll().Where(x => x.IdAnimal == this.IdAnimalEmAnalise).Any())
                {
                    if (MessageBox.Show("Existe Comportamento para este animal, deseja Excluir?", "Encontramos comportamento para o animal Selecionado", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        this._animalComportamentoAppService.DeleteComportamentoAnimal(this.IdAnimalEmAnalise);
                        MessageBox.Show("Comportamentos Excluídos com Sucesso");
                    }
                }
                this.timerVideo.Enabled = false;
                this.trackBarVideoProgress.Value = 0;
                this.tracVolume.Value = 5;
                this.lblTempoVideo.Text = "00:00:00 / 00:00:00";
                this.video.Stop();
                this.lblComportamento.Text = string.Empty;
                this.video.Dispose();
            }
            catch
            {
            }
        }

        private void btnTelaInteira_Click(object sender, EventArgs e)
        {
            try
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                video.Owner = this;
            }
            catch (Exception)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            tracVolume.Visible = !tracVolume.Visible;
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            FormVideoAnalyzerPlayerWmp_KeyDown(sender, null);
        }

        private void FormVideoAnalyzerPlayerWmp_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                timerVideo.Enabled = false;
                listaVideos.Items.Clear();
                txtDiretorio.Text = string.Empty;
                trackBarVideoProgress.Value = 0;
                tracVolume.Value = 5;
                this.lblComportamento.Text = string.Empty;
                lblTempoVideo.Text = "00:00:00 / 00:00:00";
                video.Stop();
                video.Dispose();
            }
            catch
            {
            }
        }

        private void FormVideoAnalyzerPlayerWmp_KeyDown(object sender, KeyEventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            string empty = string.Empty;
            Button button = sender as Button;
            if ((e == null ? true : e.KeyCode != Keys.Space))
            {
                try
                {
                    if (e == null)
                    {
                        empty = button.Text.Substring(0, 1);
                    }
                    this.lblComportamento.Text = string.Concat("Tecla: ", (string.IsNullOrEmpty(empty) ? (new KeysConverter()).ConvertToString(e.KeyCode) : empty.ToString()));
                    if ((this._comportamento == null ? true : this._comportamento.BotaoPressionado))
                    {
                        if (this._comportamento == null)
                        {
                            throw new CustomException("Erro ao inserir comportamento do animal!");
                        }
                        stopwatch.Stop();
                        this._transacoes.Add(stopwatch);
                        this._comportamento.Cronometro.Stop();
                        double totalSeconds = this._comportamento.Cronometro.Elapsed.TotalSeconds;
                        double num = totalSeconds + this._transacoes.Sum<Stopwatch>((Stopwatch t) => t.Elapsed.TotalSeconds);
                        AnimalComportamentoViewModel animalComportamentoViewModel = new AnimalComportamentoViewModel()
                        {
                            Quantidade = (long)1,
                            DataAnalise = DateTime.Now,
                            IdUsuario = Guid.Parse(Settings.Default.Logado),
                            Tempo = num,
                            IdAnimalComportamento = Guid.NewGuid(),
                            IdAnimal = this.IdAnimalEmAnalise,
                            IdComportamento = this._comportamento.IdComportamento
                        };
                        this._animalComportamentoAppService.Add(animalComportamentoViewModel);
                        this.lblComportamento.Text = string.Empty;
                        this._comportamento.BotaoPressionado = false;
                    }
                    else
                    {
                        this._comportamento = this._comportamentos.FirstOrDefault<ComportamentoViewModel>((ComportamentoViewModel _) => (empty == null ? false : _.LetraTeclado.Equals((empty == string.Empty ? (new KeysConverter()).ConvertToString(e.KeyCode) : empty.ToString()), StringComparison.CurrentCultureIgnoreCase)));
                        if (this._comportamento != null)
                        {
                            stopwatch.Stop();
                            this._comportamento.Cronometro = new Stopwatch();
                            this._comportamento.Cronometro.Start();
                            this._transacoes.Add(stopwatch);
                            this._comportamento.BotaoPressionado = true;
                        }
                        else
                        {
                            this._comportamento = new ComportamentoViewModel();
                            return;
                        }
                    }
                }
                catch
                {
                }
            }
            else
            {
                base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                base.WindowState = FormWindowState.Normal;
                base.Size = this._formSize;
                this.video.Owner = this.painelVideo;
                this.painelVideo.Size = this._pnlSize;
            }
        }

        private void FormVideoAnalyzerPlayerWmp_Load(object sender, EventArgs e)
        {
            _formSize = new Size(Width, Height);
            _pnlSize = new Size(painelVideo.Width, painelVideo.Height);
            tracVolume.Maximum = 100;
            _comportamento = new ComportamentoViewModel();
            //Adicionando os botões a tela.
            var tipoComportamentoLCE = _tipoComportamentoAppService.GetAll(
            ).FirstOrDefault(_ => _.StatusTipoComportamento &&
                                                                                        _.IdUsuario ==
                                                                                        Guid.Parse(Settings
                                                                                            .Default.Logado) &&
                                                                                        _.NomeTipoComportamento == "LCE");
            _comportamentos = _mapper.Map<List<ComportamentoViewModel>>(_comportamentoAppService.GetAll().Where(_ =>
                {
                    return tipoComportamentoLCE != null && (_.StatusComportamento && _.IdUsuario == Guid.Parse(Settings.Default.Logado) &&
                                                            _.IdTipoComportamento == tipoComportamentoLCE.IdTipoComportamento);
                }));

            AdicionaBotoes();
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch { }

            timerVideo.Enabled = false;
            int index = listaVideos.SelectedIndex;
            _selectedIndex = index;
            video = new Microsoft.DirectX.AudioVideoPlayback.Video(_videoPaths[index], false);
            video.Owner = painelVideo;
            painelVideo.Size = _pnlSize;

            do
            {
                var currentAnimal = _container.GetInstance<FormVideoAnalyzerSelecionaAnimal>();
                currentAnimal.ShowDialog();
                if (currentAnimal.AnimalSelecionado == null)
                    return;
                IdAnimalEmAnalise = currentAnimal.AnimalSelecionado.IdAnimal;
            } while (IdAnimalEmAnalise == Guid.Empty);
            video.Play();
            btnPlay.Image = Resources.Knob_Pause;
            video.Ending += Video_Ending;
            txtDiretorio.Text = listaVideos.Text;
            trackBarVideoProgress.Maximum = Convert.ToInt32(video.Duration);
            timerVideo.Enabled = true;
        }

        private void NextVideo()
        {
            //SelecionaAnimal();
            int index = listaVideos.SelectedIndex;
            index++;
            if (index > _videoPaths.Length - 1)
                index = 0;
            _selectedIndex = index;
            listaVideos.SelectedIndex = index;
        }

        private void PreviousVideo()
        {
            int index = listaVideos.SelectedIndex;
            index--;
            if (index == -1)
                index = _videoPaths.Length - 1;
            _selectedIndex = index;
            listaVideos.SelectedIndex = index;
        }

        private void timerVideo_Tick(object sender, EventArgs e)
        {
            var currentTime = Convert.ToInt32(video.CurrentPosition);
            var maxTime = Convert.ToInt32(video.Duration);
            trackBarVideoProgress.Value = currentTime;
            lblTempoVideo.Text = $"{currentTime / 3600:00}:{(currentTime / 60) % 60:00}:{currentTime % 60:00}"
                                 + " / " +
                                 $"{maxTime / 3600:00}:{(maxTime / 60) % 60:00}:{maxTime % 60:00}";
        }

        private void trackBarVideoProgress_Scroll(object sender, EventArgs e)
        {
            video.CurrentPosition = trackBarVideoProgress.Value;
        }

        private void tracVolume_Scroll(object sender, EventArgs e)
        {
            try
            {
                video.Audio.Volume = tracVolume.Value;
            }
            catch
            {
            }
        }

        private void Video_Ending(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);

                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        NextVideo();
                    }));
                }
            });
        }
    }
}