using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoLeague.Models;
 
namespace DojoLeague.Factory
{
    public class ValidateNinjaFactory : IFactory<ValidateNinja>
    {
        private string connectionString;
        public ValidateNinjaFactory()
        {
            connectionString = "server=localhost;userid=root;password=Amino600;port=3306;database=DojoLeagueDB;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get 
            {
                return new MySqlConnection(connectionString);
            }
        }
        public IEnumerable<ValidateNinja> PlayersForTeamById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                var query = $"SELECT * FROM ninjas JOIN dojos ON ninjas.dojo_id WHERE dojos.id = ninjas.dojo_id AND dojos.id = {id}";
                dbConnection.Open();
        
                var myValidateNinjas = dbConnection.Query<ValidateNinja, ValidateDojo, ValidateNinja>(query, (ValidateNinja, ValidateDojo) => { ValidateNinja.dojo = ValidateDojo; return ValidateNinja; });
                return myValidateNinjas;
            }
        }
    }
}
