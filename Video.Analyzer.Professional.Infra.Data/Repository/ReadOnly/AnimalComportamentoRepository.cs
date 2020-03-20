using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly;

namespace Video.Analyzer.Professional.Infra.Data.Repository.ReadOnly
{
    public class AnimalComportamentoRepository : RepositoryBaseReadOnly, IAnimalComportamentoRepository
    {
        public void DeleteComportamentoAnimal(Guid idAnimal)
        {
            using (IDbConnection connection = base.Connection)
            {
                string str = "delete from animalcomportamento where idAnimal =  @sidAnimal";
                connection.Open();
                Dictionary<string, object> strs = new Dictionary<string, object>()
                {
                    { "sidAnimal", idAnimal }
                };
                DynamicParameters dynamicParameter = new DynamicParameters();
                dynamicParameter.AddDynamicParams(strs);
                int? nullable = null;
                CommandType? nullable1 = null;
                connection.ExecuteScalar(str, dynamicParameter, null, nullable, nullable1);
            }
        }

        public IEnumerable<dynamic> GetAll(Guid idCaixa, Guid idUsuario, bool agrupado = true)
        {
            IEnumerable<object> objs;
            using (IDbConnection connection = base.Connection)
            {
                string str = " SELECT  CA.NomeCaixa,\tG.NomeGrupo, A.Sexo, A.NomeAnimal, C.NomeComportamento,\tAC.Quantidade,\tAC.Tempo FROM ANIMALCOMPORTAMENTO AC  INNER JOIN USUARIO U ON AC.IdUsuario = U.IdUsuario INNER JOIN Comportamento C ON AC.IdComportamento = C.IdComportamento INNER JOIN Animal A ON AC.IdAnimal = A.IdAnimal  INNER JOIN Caixa Ca ON CA.IdCaixa = A.IdCaixa INNER JOIN Grupo G ON G.IdGrupo = A.IdGrupo WHERE AC.IdUsuario =  @sidUsusario And Ca.IdCaixa = @sidCaixa order by NomeAnimal";
                if (agrupado)
                {
                    str = " SELECT  CA.NomeCaixa,\tG.NomeGrupo, A.Sexo, A.NomeAnimal, C.NomeComportamento,\tCOUNT(AC.Quantidade) AS Quantidade,\tSUM(AC.Tempo) AS Tempo FROM ANIMALCOMPORTAMENTO AC  INNER JOIN USUARIO U ON AC.IdUsuario = U.IdUsuario INNER JOIN Comportamento C ON AC.IdComportamento = C.IdComportamento INNER JOIN Animal A ON AC.IdAnimal = A.IdAnimal  INNER JOIN Caixa Ca ON CA.IdCaixa = A.IdCaixa INNER JOIN Grupo G ON G.IdGrupo = A.IdGrupo WHERE AC.IdUsuario =  @sidUsusario And Ca.IdCaixa = @sidCaixa  GROUP BY C.NomeComportamento, CA.NomeCaixa, G.NomeGrupo, A.Sexo, A.NomeAnimal order by NomeAnimal";
                }
                connection.Open();
                Dictionary<string, object> strs = new Dictionary<string, object>()
                {
                    { "sidCaixa", idCaixa },
                    { "sidUsusario", idUsuario }
                };
                DynamicParameters dynamicParameter = new DynamicParameters();
                dynamicParameter.AddDynamicParams(strs);
                int? nullable = null;
                CommandType? nullable1 = null;
                objs = connection.Query(str, dynamicParameter, null, true, nullable, nullable1);
            }
            return objs;
        }

        public IEnumerable<dynamic> GetAll(Guid idAnimal, Guid idUsuario, DateTime? dataInicio, DateTime? dataFim, bool agrupado = true)
        {
            using (IDbConnection cn = Connection)
            {
                var sql = @" SELECT  CA.NomeCaixa,	G.NomeGrupo, A.Sexo, A.NomeAnimal, C.NomeComportamento,	" +
                            "AC.Quantidade,	AC.Tempo " +
                            "FROM ANIMALCOMPORTAMENTO AC  " +
                    "INNER JOIN USUARIO U ON AC.IdUsuario = U.IdUsuario " +
                    "INNER JOIN Comportamento C ON AC.IdComportamento = C.IdComportamento " +
                    "INNER JOIN Animal A ON AC.IdAnimal = A.IdAnimal " +
                    " INNER JOIN Caixa Ca ON CA.IdCaixa = A.IdCaixa " +
                          "INNER JOIN Grupo G ON G.IdGrupo = A.IdGrupo " +
                "WHERE AC.IdUsuario =  @sidUsusario " +
                    "And AC.IdAnimal = @sidAnimal " +
                          "and AC.DataAnalise >= @dtInicio and AC.DataAnalise <= @dtFim";

                if (agrupado)
                {
                    sql = @" SELECT  CA.NomeCaixa,	G.NomeGrupo, A.Sexo, A.NomeAnimal, C.NomeComportamento,	" +
                        "COUNT(AC.Quantidade) AS Quantidade,	SUM(AC.Tempo) AS Tempo " +
                        "FROM ANIMALCOMPORTAMENTO AC  " +
                        "INNER JOIN USUARIO U ON AC.IdUsuario = U.IdUsuario " +
                        "INNER JOIN Comportamento C ON AC.IdComportamento = C.IdComportamento " +
                        "INNER JOIN Animal A ON AC.IdAnimal = A.IdAnimal " +
                        " INNER JOIN Caixa Ca ON CA.IdCaixa = A.IdCaixa " +
                        "INNER JOIN Grupo G ON G.IdGrupo = A.IdGrupo " +
                        "WHERE AC.IdUsuario =  @sidUsusario " +
                        "And AC.IdAnimal = @sidAnimal " +
                        "and AC.DataAnalise Between @dtInicio and @dtFim"
                        + " GROUP BY C.NomeComportamento, CA.NomeCaixa, G.NomeGrupo, A.Sexo, A.NomeAnimal";
                }

                cn.Open();

                var parameters = new Dictionary<string, object>();
                parameters.Add("sidAnimal", idAnimal);
                parameters.Add("sidUsusario", idUsuario);
                parameters.Add("dtInicio", dataInicio);
                parameters.Add("dtFim", dataFim);

                DynamicParameters dbParams = new DynamicParameters();
                dbParams.AddDynamicParams(parameters);

                return cn.Query(sql, dbParams);
            }
        }
    }
}