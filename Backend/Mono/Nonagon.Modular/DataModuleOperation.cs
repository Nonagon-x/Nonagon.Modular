using System;
using ServiceStack.OrmLite;

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

		Object IModuleOperation.Execute(Object input)
		{
			return Execute();
		}
		
		/// <summary>
		/// Execute this operation.
		/// </summary>
		/// <param name="input">Input.</param>
		public abstract TOutput Execute();
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

		Object IModuleOperation.Execute(Object input)
		{
			return Execute((TInput)input);
		}
		
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">Input.</param>
		public abstract TOutput Execute(TInput input);
	}
}

