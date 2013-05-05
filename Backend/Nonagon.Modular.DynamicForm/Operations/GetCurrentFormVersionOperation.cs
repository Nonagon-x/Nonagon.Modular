using System;
using System.Linq;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get the current form version operation.
	/// </summary>
	public class GetCurrentFormVersionOperation : 
		DataModuleOperation<GetCurrentFormVersionOperation.Param, Int32>
	{
		/// <summary>
		/// Get current form version parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the form identifier.
			/// </summary>
			/// <value>The form identifier.</value>
			public Int64 FormId { get; set; }
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="param">Parameter.</param>
		/// <returns>The current version number of the Form.</returns>
		public override Int32 Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var version = dbConnection.
					GetScalar<FormRevision, Int32>(
						q => Sql.Max(q.Version), 
						q => q.FormId == param.FormId && 
						q.Status == FormStatus.Active);

				return version;
			}
		}
	}
}

