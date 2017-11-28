using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LostintheWoods.Models;
 
namespace LostintheWoods.Factory
{
    public class ValidateTrailFactory : IFactory<ValidateTrail>
    {
        private string connectionString;
        public ValidateTrailFactory()
        {
            connectionString = "server=localhost;userid=root;password=Amino600;port=3306;database=TrailsDB;SslMode=None";
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(connectionString);
            }
        }
    public void Added(Trail dbstrail)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  $"INSERT INTO `TrailsDB`.`Trails` (`id`, `Name`, `desc`, `length`, `elevation`, `longitude`, `latitude`, `created_at`, `updated_at`) VALUES ('', '{dbstrail.Name}', '{dbstrail.desc}', '{dbstrail.length}', '{dbstrail.elevation}', '{dbstrail.longitude}', '{dbstrail.latitude}', '{dbstrail.created_at.ToString("yyyy-MM-dd HH:mm:ss")}', '{dbstrail.updated_at.ToString("yyyy-MM-dd HH:mm:ss")}')";
                dbConnection.Open();
                dbConnection.Execute(query, dbstrail);
            }
        }
    public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                IEnumerable<Trail> lob =dbConnection.Query<Trail>("SELECT Trails.id, Trails.name, Trails.length, Trails.elevation FROM TrailsDB.Trails;");
                return lob;
            }
        }
    public Trail FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                List<Trail> details = (List<Trail>)dbConnection.Query<Trail>($"SELECT * FROM TrailsDB.Trails where id=id;");
                return details[0];
            }
        }
    }
}