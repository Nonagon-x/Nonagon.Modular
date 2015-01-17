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

		/// <summary>
		/// Determines whether this module is up to date.
		/// </summary>
		/// <returns><c>true</c> if this instance is up to date; otherwise, <c>false</c>.</returns>
		Boolean IsUpToDate();

		/// <summary>
		/// Update this module.
		/// </summary>
		void Update();

		/// <summary>
		/// Register the module.
		/// </summary>
		void Register();
	}

	/// <summary>
	/// Module interface with given functionality interface.
	/// </summary>
	public interface IModule<T> : IModule where T : IModuleInterface
	{
		T GetModuleInterface();
	}
}