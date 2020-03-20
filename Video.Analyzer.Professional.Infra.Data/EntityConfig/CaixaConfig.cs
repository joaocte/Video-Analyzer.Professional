using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Caixa;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class CaixaConfig : EntityTypeConfiguration<Caixa>
    {
        public CaixaConfig()
        {
            HasKey(_ => _.IdCaixa);

            HasRequired(p => p.Usuario)
                .WithMany(p => p.Caixas)
                .HasForeignKey(p => p.IdUsuario);
        }
    }
}