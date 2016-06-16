using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace FactoryMethod
{
    public class SqlServerDatabase : IDatabase
    {
        #region private fields
        private IDbConnection _Connection;
        private IDbCommand _Command;
        #endregion

        #region properties
        public IDbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return _Connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if (_Command == null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = (SqlConnection)Connection;
                }
                return _Command;
            }
        }
        #endregion
    }
}
