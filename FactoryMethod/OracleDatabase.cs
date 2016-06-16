using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Oracle.DataAccess.Client;

namespace FactoryMethod
{
    public class OracleDatabase : IDatabase
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
                if(_Connection ==null )
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString;
                    _Connection = new OracleConnection(connectionString);
                }
                return _Connection;
            }
        }

        public IDbCommand Command
        {
            get
            {
                if(_Command ==null)
                {
                    _Command = new OracleCommand();
                    _Command.Connection = (OracleConnection)Connection;
                }
                return _Command;
            }
        }
        #endregion
    }
}
