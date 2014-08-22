using ServiceStack.OrmLite;

namespace Nonagon.Modular
{
	/// <summary>
	/// Base class for module operation which support data connection.
	/// </summary>
	public interface IDataModuleOperation : IModuleOperation
	{
		/// <summary>
		/// Gets the db connection factory.
		/// </summary>
		/// <value>The db connection factory.</value>
		IDbConnectionFactory DbConnectionFactory { set; }
	}
}

