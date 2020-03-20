using System;
using Video.Analyzer.Professional.CrossCuttin.Extension;
using Video.Analyzer.Professional.Domain.Entities.Usuario;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class UsuarioRepository : RepositoryBase<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(IDbContext context) : base(context)
        {
        }

        public override void Add(Usuario obj)
        {
            Random r = new Random(100);
            obj.Salt = obj.Salt.CreateSalt(r.Next());
            obj.Senha = obj.Senha.GenerateSaltedHash(obj.Salt);
            base.Add(obj);
        }
    }
}