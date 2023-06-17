using Dapper;
using MySqlConnector;
using ProjetoEducar.Modelo;

namespace ProjetoEducar.EndPoints
{
   
    public class QueryUsuarios
    {
        private readonly IConfiguration configuration;

        public QueryUsuarios(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IEnumerable<FuncionarioResponse> Executar(int page, int rows)
        {
            var db = new MySqlConnection(configuration.GetConnectionString("EducandarioData"));
            var query =
            
              @"select Email, ClaimValue as Nome
            from AspNetUsers u 
            inner join AspnetUserClaims c             
            on u.id = c.UserId and claimtype = 'Nome'
            order by nome";
            
            return db.Query<FuncionarioResponse>(
                query,
                new { page, rows }
                );
        }
    }
}
