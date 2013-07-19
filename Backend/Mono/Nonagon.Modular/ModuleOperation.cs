using System;

namespace Nonagon.Modular
{
	/// <summary>
	/// Base class for module operation which accept no input parameter.
	/// </summary>
	public abstract class ModuleOperation<TOutput> : IModuleOperation<TOutput>
	{
		Object IModuleOperation.Execute(Object input)
		{
			return Execute();
		}

		public abstract TOutput Execute();
	}

	/// <summary>
	/// Base class for module operation which accept input parameter.
	/// </summary>
	public abstract class ModuleOperation<TInput, TOutput> : IModuleOperation<TInput, TOutput>
	{
		Object IModuleOperation.Execute(Object input)
		{
			return Execute((TInput)input);
		}
		
		public abstract TOutput Execute(TInput input);
	}
}

