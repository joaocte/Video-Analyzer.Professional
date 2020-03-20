using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class MenuConfig : EntityTypeConfiguration<Menu>
    {
        public MenuConfig()
        {
            HasKey(_ => _.IdMenu);
        }
    }
}