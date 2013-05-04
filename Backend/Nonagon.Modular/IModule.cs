using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// Module interface.
	/// </summary>
	public interface IModule
	{
		/// <summary>
		/// Determines whether this instance is initialized.
		/// </summary>
		/// <returns><c>true</c> if this instance is initialized; otherwise, <c>false</c>.</returns>
		Boolean IsInitialized();

		/// <summary>
		/// Initialize this instance.
		/// </summary>
		void Initialize();
	}

	/// <summary>
	/// Module interface with given functionality interface.
	/// </summary>
	public interface IModule<T> : IModule where T : IModuleInterface
	{
		T GetModuleInterface();
	}
}