using ServiceStack.OrmLite;

namespace Nonagon.Modular
{
	/// <summary>
	/// Data module interface base class.
	/// </summary>
	public abstract class DataModuleInterface : ModuleInterface, IDataModuleInterface
	{
		/// <summary>
		/// Gets or sets the db connection factory.
		/// </summary>
		/// <value>The db connection factory.</value>
		public IDbConnectionFactory DbConnectionFactory { get; private set; }

		protected DataModuleInterface(IDbConnectionFactory dbConnectionFactory)
		{
			DbConnectionFactory = dbConnectionFactory;
		}

		/// <summary>
		/// Resolve the instance of operation from type parameter.
		/// </summary>
		/// <typeparam name="TOperation">The IDataModuleOperation to be instantiated.</typeparam>
		protected override TOperation Resolve<TOperation>()
		{
			TOperation opt = base.Resolve<TOperation>();

			var iDataModuleOperation = opt as IDataModuleOperation;
			if(iDataModuleOperation != null)
				iDataModuleOperation.DbConnectionFactory = DbConnectionFactory;

			return opt;
		}
	}
}

