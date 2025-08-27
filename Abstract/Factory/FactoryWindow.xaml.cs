using System.Data.Common;
using System.Data.OleDb;
using System.Windows;

using Microsoft.Data.SqlClient;

namespace Abstract.Factory
{
	/// <summary>
	/// Interaction logic for FactoryWindow.xaml
	/// </summary>
	public partial class FactoryWindow : Window
	{
		public FactoryWindow()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Database db;

			if (rbSqlServer.IsChecked == true)
			{
				db = new SqlServerDatabase
				{
					Connection = new SqlConnection("your-sqlserver-connection-string"),
					Command = new SqlCommand() { Connection = new SqlConnection("your-sqlserver-connection-string") }
				};
			}
			else
			{
				db = new OleDBDatabase
				{
					Connection = new OleDbConnection("your-oledb-connection-string"),
					Command = new OleDbCommand() { Connection = new OleDbConnection("your-oledb-connection-string") }
				};

				DbCommand command = db.Command;
				// now, we can do something, like:
				//command.CommandType =
				//CommandType.Text;
				//command.CommandText = "SELECT * FROM Customers";
				//command.Connection.Open();
				//DbDataReader reader = command.ExecuteReader();

				// reader.Close();
				//command.Connection.Close();
			}
		}
	}
}
