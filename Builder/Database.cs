using System.Data.Common;

namespace Builder
{
    public abstract class Database
    {
        public virtual DbCommand Command { get; set; }
        public virtual DbConnection Connection { get; set; }
    }
}
