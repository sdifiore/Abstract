using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace Abstract.Factory
{
	internal class SqlServerDatabase : Database
	{
		private DbConnection _connection = null!;
		private DbCommand _command = null!;

		public override required DbConnection Connection
		{
			get
			{
				if (_connection == null)
				{
					var connectionString = ConfigurationManager.AppSettings["SqlServerConnectionString"];
					_connection = new SqlConnection(connectionString);
				}

				return _connection;
			}

			set => _connection = value;
		}
		public override required DbCommand Command
		{
			get

			{
				if (_command == null)
				{
					_command = new SqlCommand();
					_command.Connection = Connection;
				}

				return _command;
			}

			set => _command = value;
		}
	}
}
