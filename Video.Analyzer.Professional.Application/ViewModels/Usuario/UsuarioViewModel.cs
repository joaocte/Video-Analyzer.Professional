using System;
using Video.Analyzer.Professional.Application.ViewModels.Configuracao;

namespace Video.Analyzer.Professional.Application.ViewModels.Usuario
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            IdUsuario = Guid.NewGuid();
            //Animais = new List<AnimalViewModel>();
            //Caixas = new List<Caixa.CaixaViewModel>();
            //TiposAnimais = new List<TipoAnimalViewModel>();
            //Comportamentos = new List<Comportamento.ComportamentoViewModel>();
            //Grupos = new List<Grupo.GrupoViewModel>();
        }

        public string Email { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid IdUsuario { get; set; }

        public string NomeUsuario { get; set; }
        public virtual PerfilViewModel Perfil { get; set; }
        public string Salt { get; set; }
        public string Senha { get; set; }
        public bool StatusUsuario { get; set; }

        //public  virtual ICollection<AnimalViewModel> Animais { get; set; }

        //public virtual ICollection<Caixa.CaixaViewModel> Caixas { get; set; }

        //public virtual ICollection<TipoAnimalViewModel> TiposAnimais { get; set; }

        //public virtual ICollection<Comportamento.ComportamentoViewModel> Comportamentos { get; set; }

        //public virtual ICollection<Grupo.GrupoViewModel> Grupos { get; set; }
    }
}