using System;
using ServiceStack.OrmLite;

namespace Nonagon.Modular
{
	public abstract class DataModuleBase<T> : ModuleBase<T> where T : IModuleInterface
	{
		protected IDbConnectionFactory DbConnectionFactory { get; private set; }

		protected DataModuleBase(IDbConnectionFactory dbConnectionFactory) 
		{
			if (dbConnectionFactory == null) {
				throw new ArgumentException("The " + GetType().Name + 
				                            " require dbConnectionFactory parameter to load.");
			}
			
			DbConnectionFactory = dbConnectionFactory;
		}

		/// <summary>
		/// Gets the module interface.
		/// </summary>
		/// <returns>The module interface.</returns>
		public override T GetModuleInterface()
		{
			return (T)Activator.CreateInstance(typeof(T), new [] { DbConnectionFactory });
		}
	}
}

