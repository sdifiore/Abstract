using System.Configuration;
using System.Data;
using System.Data.OleDb;

namespace Abstract.Builder
{
	class OleDbDatabaseBuilder : IDatabaseBuilder
	{
		// Fix: Set required properties in object initializer
		private Database _database = new OleDbDatabase
		{
			Connection = null!, // Will be set in BuildConnection
			Command = null!     // Will be set in BuildCommand
		};

		public void BuildConnection()
		{
			var connection = ConfigurationManager.AppSettings["OleDbConnectionString"];
			_database.Connection = new OleDbConnection(connection);
		}

		public void BuildCommand()
		{
			_database.Command = new OleDbCommand();
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
