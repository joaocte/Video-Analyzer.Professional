using AutoMapper;
using SimpleInjector;
using System;
using System.Linq;
using System.Windows.Forms;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.UI.Properties;

namespace Video.Analyzer.Professional.UI
{
    public partial class FormVideoAnalyzerLogin : Form
    {
        private readonly IUsuarioAppService usuarioAppService;

        public FormVideoAnalyzerLogin(IUsuarioAppService usuarioAppService)
        {
            this.usuarioAppService = usuarioAppService;
            Logado = false;
            InitializeComponent();
        }

        public bool Logado { get; set; }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.LimpaComponentes(typeof(TextBox));
            Settings.Default.User = string.Empty;
            Settings.Default.Logado = string.Empty;
            Settings.Default.Save();
        }

        private void FormVideoAnalyzerLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Login();
        }

        private void FormVideoAnalyzerLogin_Load(object sender, EventArgs e)
        {
        }

        private void Login()
        {
            var usuario = usuarioAppService.GetAll().FirstOrDefault(u => u.StatusUsuario
                                                                       && u.Email == txtEmail.Text);

            if (usuario != null)
            {
                if (txtSenha.Text.GenerateSaltedHash(usuario.Salt) == usuario.Senha)
                {
                    Visible = false;
                    Settings.Default.User = usuario.NomeUsuario;
                    Settings.Default.Logado = usuario.IdUsuario.ToString();
                    Settings.Default.Save();
                    Logado = true;
                }
            }
            if (!Logado)
            {
                MessageBox.Show(@"Usuário ou senha Inválidos", @"ATENÇÃO", MessageBoxButtons.OK);
                txtEmail.Focus();
            }
        }
    }
}