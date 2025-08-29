using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Abstract.Builder
{
	class SqlServerDatabaseBuilder : IDatabaseBuilder
	{
		// Fix: Set required properties in object initializer
		private Database _database = new SqlServerDatabase
		{
			Connection = null!, // Will be set in BuildConnection
			Command = null!     // Will be set in BuildCommand
		};

		public void BuildConnection()
		{
			var connection = ConfigurationManager.AppSettings["SqlServerConnectionString"];
			_database.Connection = new SqlConnection(connection);
		}

		public void BuildCommand()
		{
			_database.Command = new SqlCommand();
			_database.Command.Connection = _database.Connection;
		}

		public void SetSetting()
		{
			_database.Command.CommandTimeout = 360;
			_database.Command.CommandType = CommandType.Text;
		}

		public Database Database => _database;
	}
}
