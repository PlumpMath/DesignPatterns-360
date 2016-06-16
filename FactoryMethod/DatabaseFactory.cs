using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            switch(databaseType)
            {
                case DatabaseType.Oracle:
                default:
                    return new OracleDatabase();// using return instead of break
                case DatabaseType.SqlServer:
                    return new SqlServerDatabase(); 
            }
        }
    }
}
