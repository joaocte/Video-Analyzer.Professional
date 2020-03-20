using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly;

namespace Video.Analyzer.Professional.Infra.Data.Repository.ReadOnly
{
    public class AnimalRepositoryReadOnly : RepositoryBaseReadOnly, IAnimalRepository
    {
        public IEnumerable<dynamic> GetAll(Guid idUsuario)
        {
            using (IDbConnection cn = Connection)
            {
                var sql = @"SELECT A.NomeAnimal, C.NomeCaixa, G.NomeGrupo,	A.Sexo,	A.Fezes, A.Peso
                          FROM ANIMAL A INNER JOIN TipoAnimal TA ON A.IdTipoAnimal = TA.IdTipoAnimal
                          INNER JOIN CAIXA C ON A.IdCaixa = C.IdCaixa
                          INNER JOIN Grupo G ON A.IdGrupo = G.IdGrupo
                          INNER JOIN Usuario U ON A.IdUsuario = U.IdUsuario "
                          + "WHERE A.IdUsuario =  @sidUsusario " +
                          "AND A.StatusAnimal = 1";

                cn.Open();

                var parameters = new Dictionary<string, object>();
                parameters.Add("sidUsusario", idUsuario);

                DynamicParameters dbParams = new DynamicParameters();
                dbParams.AddDynamicParams(parameters);

                return cn.Query(sql, dbParams);
            }
        }
    }
}