﻿using System.Data.SqlClient;
using System.Data.Common;
using System.Configuration;

namespace AbstractFactory
{
    public class SqlServerDatabase : Database
    {
        private DbConnection _Connection = null;
        private DbCommand _Command = null;

        public override DbConnection Connection
        {
            get
            {
                if (_Connection == null)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["SQLServerConnectionString"].ConnectionString;
                    _Connection = new SqlConnection(connectionString);
                }
                return _Connection;
            }

            set
            {
                _Connection = value;
            }
        }

        public override DbCommand Command
        {
            get
            {
                if(_Command==null)
                {
                    _Command = new SqlCommand();
                    _Command.Connection = Connection;
                }
                return _Command;
            }

            set
            {
                _Command = value;
            }
        }
    }
}
