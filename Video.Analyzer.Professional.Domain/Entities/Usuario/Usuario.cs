using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;

namespace Video.Analyzer.Professional.Domain.Entities.Usuario
{
    public class Usuario
    {
        public Usuario()
        {
            IdUsuario = Guid.NewGuid();
            Animais = new List<Animal.Animal>();
            Caixas = new List<Caixa.Caixa>();
            TiposAnimais = new List<TipoAnimal>();
            Comportamentos = new List<Comportamento.Comportamento>();
            AnimaisComportamento = new List<AnimalComportamento>();
            Grupos = new List<Grupo.Grupo>();
        }

        public virtual ICollection<Animal.Animal> Animais { get; set; }
        public virtual ICollection<AnimalComportamento> AnimaisComportamento { get; set; }
        public virtual ICollection<Caixa.Caixa> Caixas { get; set; }
        public virtual ICollection<Comportamento.Comportamento> Comportamentos { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Grupo.Grupo> Grupos { get; set; }
        public Guid IdPerfil { get; set; }
        public Guid IdUsuario { get; set; }

        public string NomeUsuario { get; set; }
        public virtual Perfil Perfil { get; set; }
        public string Salt { get; set; }
        public string Senha { get; set; }
        public bool StatusUsuario { get; set; }
        public virtual ICollection<TipoAnimal> TiposAnimais { get; set; }
    }
}