using System.Configuration;
using System.Data;
using Oracle.DataAccess.Client;

namespace Builder
{
    public class OracleDatabaseBuilder : IDatabaseBuilder
    {
        #region private fields
        private Database _Database;
        #endregion

        #region properties
        public Database Database
        {
            get
            {
                return _Database;
            }
        }
        #endregion

        #region constructor
        public OracleDatabaseBuilder()
        {
            _Database = new OracleDatabase();
        }
        #endregion

        #region Build Methods
        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["OracleConnectionString"].ConnectionString;
            _Database.Connection = new OracleConnection(connectionString);
        }

        public void BuildCommand()
        {
            _Database.Command = new OracleCommand();
            _Database.Command.Connection = _Database.Connection;
        }

        public void SetSettings()
        {
            _Database.Command.CommandTimeout = 360;
            _Database.Command.CommandType = CommandType.Text;
        }
        #endregion
    }
}
