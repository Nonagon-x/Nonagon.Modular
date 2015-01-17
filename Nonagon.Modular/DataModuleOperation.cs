using System;

using ServiceStack.OrmLite;
using ServiceStack.Configuration;
using ServiceStack.WebHost.Endpoints;

namespace Nonagon.Modular
{
	/// <summary>
	/// Base class for module operation which accept no input parameter.
	/// </summary>
	public abstract class DataModuleOperation<TOutput> : IDataModuleOperation, IModuleOperation<TOutput>
	{
		/// <summary>
		/// Gets the db connection factory.
		/// </summary>
		/// <value>The db connection factory.</value>
		public IDbConnectionFactory DbConnectionFactory { protected get; set; }

		/// <summary>
		/// Gets or sets the resource manager.
		/// </summary>
		/// <value>The resource manager.</value>
		public IResourceManager ResourceManager { protected get; set; }

		Object IModuleOperation.Execute(Object input)
		{
			return Execute();
		}

		/// <summary>
		/// Execute this operation.
		/// </summary>
		public TOutput Execute()
		{
			ModuleOperation.ExecutePreOperations(GetType(), null);
			var result = Run();
			ModuleOperation.ExecutePostOperations(GetType(), null, result);

			return result;
		}

		protected abstract TOutput Run();

		protected DataModuleOperation() {

			ResourceManager = AppHostBase.Instance.Container.Resolve<IResourceManager>();
		}
	}

	/// <summary>
	/// Base class for module operation which accept input parameter.
	/// </summary>
	public abstract class DataModuleOperation<TInput, TOutput> : IDataModuleOperation, IModuleOperation<TInput, TOutput>
	{
		/// <summary>
		/// Gets the db connection factory.
		/// </summary>
		/// <value>The db connection factory.</value>
		public IDbConnectionFactory DbConnectionFactory { protected get; set; }

		/// <summary>
		/// Gets or sets the resource manager.
		/// </summary>
		/// <value>The resource manager.</value>
		public IResourceManager ResourceManager { protected get; set; }

		Object IModuleOperation.Execute(Object input)
		{
			return Execute((TInput)input);
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">Input.</param>
		public TOutput Execute(TInput input)
		{
			ModuleOperation.ExecutePreOperations(GetType(), input);
			var result = Run(input);
			ModuleOperation.ExecutePostOperations(GetType(), input, result);

			return result;
		}

		protected abstract TOutput Run(TInput input);

		protected DataModuleOperation() {

			ResourceManager = AppHostBase.Instance.Container.Resolve<IResourceManager>();
		}
	}
}

