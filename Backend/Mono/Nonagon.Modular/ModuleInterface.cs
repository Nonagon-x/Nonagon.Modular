using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// Module interface base class.
	/// </summary>
	public abstract class ModuleInterface : IModuleInterface
	{
		/// <summary>
		/// Resolve the instance of operation from type parameter.
		/// </summary>
		/// <typeparam name="TOperation">The IModuleOperation to be instantiated.</typeparam>
		protected virtual TOperation Resolve<TOperation>()
			where TOperation : IModuleOperation
		{
			return Activator.CreateInstance<TOperation>();
		}
	}
}

