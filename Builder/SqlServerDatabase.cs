using System.Data.Common;

namespace Builder
{
    public class SqlServerDatabase : Database
    {
        #region private fields
        private DbCommand _Command = null;
        private DbConnection _Connection = null;
        #endregion

        #region properties
        public override DbCommand Command
        {
            get
            {
                return _Command;
            }

            set
            {
                _Command = value;
            }
        }

        public override DbConnection Connection
        {
            get
            {
                return _Connection;
            }

            set
            {
                _Connection = value;
            }
        }
        #endregion

    }

}
