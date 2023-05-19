using System.Data.SqlClient;

namespace ProiectMTP_FotaBianca
{
    internal class SqlCpmmand
    {
        private string v;
        private SqlConnection com;

        public SqlCpmmand(string v, SqlConnection com)
        {
            this.v = v;
            this.com = com;
        }

        public object Parameters { get; internal set; }
    }
}