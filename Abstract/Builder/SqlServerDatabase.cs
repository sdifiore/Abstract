using System.Data.Common;

namespace Abstract.Builder
{
	internal class SqlServerDatabase : Database
	{
		private DbConnection _connection = null!;
		private DbCommand _command = null!;

		public override required DbConnection Connection
		{
			get { return _connection; }
			set { _connection = value; }
		}
		public override required DbCommand Command
		{
			get { return _command; }
			set { _command = value; }
		}
	}
}
