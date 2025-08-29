using System.Data.Common;

namespace Abstract.Builder
{
	public abstract class Database
	{
		public virtual required DbConnection Connection { get; set; }
		public virtual required DbCommand Command { get; set; }
	}
}
