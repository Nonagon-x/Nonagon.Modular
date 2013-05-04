using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// Module base class.
	/// </summary>
	public abstract class ModuleBase<T> : IModule<T> where T : IModuleInterface
	{
		/// <summary>
		/// Determines whether this instance is initialized.
		/// </summary>
		/// <returns><c>true</c> if this instance is initialized; otherwise, <c>false</c>.</returns>
		public abstract Boolean IsInitialized();

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		public abstract void Initialize();

		/// <summary>
		/// Gets the module interface.
		/// </summary>
		/// <returns>The module interface.</returns>
		public virtual T GetModuleInterface()
		{
			return Activator.CreateInstance<T>();
		}
	}
}

