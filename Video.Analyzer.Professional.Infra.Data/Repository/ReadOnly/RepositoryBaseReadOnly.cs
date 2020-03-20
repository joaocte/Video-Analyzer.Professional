using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace Video.Analyzer.Professional.Infra.Data.Repository.ReadOnly
{
    public class RepositoryBaseReadOnly
    {
        public IDbConnection Connection
        {
            get
            {
                //return new SqlConnection(ConfigurationManager.ConnectionStrings["VideoAnalyzer.Local"].ConnectionString);
                return new MySqlConnection(ConfigurationManager.ConnectionStrings["VideoAnalyzer.Local"]
                    .ConnectionString);
            }
        }
    }
}