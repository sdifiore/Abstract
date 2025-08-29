using Abstract.Builder;
using System.Windows;

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
			var director = new Director();
			IDatabaseBuilder builder;

			if (rbSqlServer.IsChecked == true)
				builder = new SqlServerDatabaseBuilder();
			else
				builder = new OleDbDatabaseBuilder();

			director.Build(builder);
			var database = builder.Database;

			var command = database.Command;
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
