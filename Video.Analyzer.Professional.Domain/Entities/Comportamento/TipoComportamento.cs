using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Entities.Comportamento
{
    public class TipoComportamento
    {
        public TipoComportamento()
        {
            IdTipoComportamento = Guid.NewGuid();
            Comportamentos = new List<Comportamento>();
        }

        public ICollection<Comportamento> Comportamentos { get; set; }
        public Guid IdTipoComportamento { get; set; }

        public Guid IdUsuario { get; set; }
        public string NomeTipoComportamento { get; set; }
        public bool StatusTipoComportamento { get; set; }
        public virtual Usuario.Usuario Usuario { get; set; }
    }
}