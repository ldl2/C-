using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using DojoLeague.Models;
 
namespace DojoLeague.Factory
{
    public class ValidateDojoFactory : IFactory<ValidateDojo>
    {
        private string connectionString;
        public ValidateDojoFactory()
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
        public ValidateDojo FindById(long id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var query =
                @"
            SELECT * FROM dojos WHERE id = @Id;
            SELECT * FROM ninjas WHERE team_id = @Id;
            ";
 
                using (var multi = dbConnection.QueryMultiple(query, new {Id = id}))
                {
                    var ValidateDojo = multi.Read<ValidateDojo>().Single();
                    ValidateDojo.ValidateNinjas = multi.Read<ValidateNinja>().ToList();
                    return ValidateDojo;
                }
            }
        }
    }
}
