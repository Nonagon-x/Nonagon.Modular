using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// The module operation interface with output only.
	/// </summary>
	public interface IModuleOperation
	{
		Object Execute(Object input);
	}

	/// <summary>
	/// The module operation interface with output only.
	/// </summary>
	public interface IModuleOperation<TOutput> : IModuleOperation
	{
		/// <summary>
		/// Execute this operation.
		/// </summary>
		TOutput Execute();
	}

	/// <summary>
	/// The module operation interface with input and output.
	/// </summary>
	public interface IModuleOperation<TInput, TOutput> : IModuleOperation
	{
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">The input.</param>
		TOutput Execute(TInput input);
	}
}

