using System;
using System.Linq;
using System.Collections.Generic;

using ServiceStack.Configuration;
using ServiceStack.WebHost.Endpoints;

namespace Nonagon.Modular
{
	public static class ModuleOperation
	{
		static List<IOperationListener> listeners = new List<IOperationListener>();

		internal static List<IOperationListener> Listeners 
		{
			get { return listeners; }
		}

		internal static void ExecutePreOperations(Type operationType, Object input)
		{
			foreach (var listener in Listeners.
				Where(l => l.OperationType == operationType && l.OnPreExecute != null))
			{
				listener.OnPreExecute.Invoke(input);
			}
		}

		internal static void ExecutePostOperations(Type operationType, Object input, Object output)
		{
			foreach (var listener in Listeners.
				Where(l => l.OperationType == operationType && l.OnPostExecute != null))
			{
				listener.OnPostExecute.Invoke(input, output);
			}
		}

		public static void AddListener<T>(OperationListener<T> listener)
			where T : IModuleOperation
		{
			ModuleOperation.Listeners.Add(listener);
		}

		public static void RemoveListener<T>(OperationListener<T> listener)
			where T : IModuleOperation
		{
			ModuleOperation.Listeners.Remove(listener);
		}
	}

	/// <summary>
	/// Base class for module operation which accept no input parameter.
	/// </summary>
	public abstract class ModuleOperation<TOutput> : IModuleOperation<TOutput>
	{
		/// <summary>
		/// Gets or sets the resource manager.
		/// </summary>
		/// <value>The resource manager.</value>
		public IResourceManager ResourceManager { protected get; set; }

		Object IModuleOperation.Execute(Object input)
		{
			return Execute();
		}

		public TOutput Execute()
		{
			ModuleOperation.ExecutePreOperations(GetType(), null);
			var result = Run();
			ModuleOperation.ExecutePostOperations(GetType(), null, result);

			return result;
		}

		protected abstract TOutput Run();

		protected ModuleOperation() {

			ResourceManager = AppHostBase.Instance.Container.Resolve<IResourceManager>();
		}
	}

	/// <summary>
	/// Base class for module operation which accept input parameter.
	/// </summary>
	public abstract class ModuleOperation<TInput, TOutput> : IModuleOperation<TInput, TOutput>
	{
		/// <summary>
		/// Gets or sets the resource manager.
		/// </summary>
		/// <value>The resource manager.</value>
		public IResourceManager ResourceManager { protected get; set; }

		Object IModuleOperation.Execute(Object input)
		{
			return Execute((TInput)input);
		}

		public TOutput Execute(TInput input)
		{
			ModuleOperation.ExecutePreOperations(GetType(), input);
			var result = Run(input);
			ModuleOperation.ExecutePostOperations(GetType(), input, result);

			return result;
		}

		protected abstract TOutput Run(TInput input);

		protected ModuleOperation() {

			ResourceManager = AppHostBase.Instance.Container.Resolve<IResourceManager>();
		}
	}
}

