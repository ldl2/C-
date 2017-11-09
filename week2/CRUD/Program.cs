using System;
using DbConnection;


namespace CRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            DbConnector.Query(Users));
        }
    }
}
