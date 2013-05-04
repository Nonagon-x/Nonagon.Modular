using ServiceStack.OrmLite;

namespace Nonagon.Modular
{
	/// <summary>
	/// The data module functionality base interface. 
	/// All data module functionality classes must derive from this interface.
	/// </summary>
	public interface IDataModuleInterface : IModuleInterface
	{
		/// <summary>
		/// Gets the db connection factory.
		/// </summary>
		/// <value>The db connection factory.</value>
		IDbConnectionFactory DbConnectionFactory { get; }
	}
}