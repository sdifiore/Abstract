using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Runtime.Versioning;

namespace Abstract.Factory
{
	[SupportedOSPlatform("windows")]
	internal class OleDBDatabase : Database
	{
		private DbConnection _Connection = null!;
		private DbCommand _Command = null!;

		public override required DbConnection Connection
		{
			get
			{
				if (_Connection == null)
				{
					var connectionString = ConfigurationManager.AppSettings["OleDbConnectionString"];
					_Connection = new OleDbConnection(connectionString);
				}

				return _Connection;
			}

			set => _Connection = value;
		}

		public override required DbCommand Command
		{
			get
			{
				if (_Command == null)
				{
					_Command = new OleDbCommand();
					_Command.Connection = Connection;
				}

				return _Command;
			}

			set => _Command = value;
		}
	}
}
