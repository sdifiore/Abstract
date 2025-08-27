using System.Configuration;
using System.Data.Common;

using Microsoft.Data.SqlClient;

namespace Abstract.Factory
{
	internal class SqlServerDatabase : Database
	{
		private DbConnection _Connection = null!;
		private DbCommand _Command = null!;


		public override required DbConnection Connection
		{
			get
			{
				if (_Connection == null)
				{
					var connectionString = ConfigurationManager.AppSettings["SqlServerConnectionString"];
					_Connection = new SqlConnection(connectionString);
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
					_Command = new SqlCommand();
					_Command.Connection = Connection;
				}

				return _Command;
			}

			set => _Command = value;
		}
	}
}
