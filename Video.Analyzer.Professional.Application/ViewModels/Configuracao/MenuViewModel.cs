using System;

namespace Video.Analyzer.Professional.Application.ViewModels.Configuracao
{
    public class MenuViewModel
    {
        public MenuViewModel()
        {
            IdMenu = Guid.NewGuid();
        }

        public string Formulario { get; set; }
        public Guid IdMenu { get; set; }

        public string NomeMenu { get; set; }

        public int OrderMenu { get; set; }
        public Guid? ParenteMenu { get; set; }
        public bool StatusMenu { get; set; }
    }
}