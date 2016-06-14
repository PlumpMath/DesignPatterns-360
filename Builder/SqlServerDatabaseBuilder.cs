using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Builder
{
    public class SqlServerDatabaseBuilder : IDatabaseBuilder
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

        #region Constructors
        public SqlServerDatabaseBuilder()
        {
            _Database = new SqlServerDatabase();
        }
        #endregion

        #region Build Methods
        public void BuildConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SqlServerConnectionString"].ConnectionString;
            _Database.Connection = new SqlConnection(connectionString);
        }
        public void BuildCommand()
        {
            _Database.Command = new SqlCommand();
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
