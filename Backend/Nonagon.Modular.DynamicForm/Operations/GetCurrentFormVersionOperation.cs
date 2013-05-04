using System;
using System.Linq;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get the current Form version operation.
	/// </summary>
	public class GetCurrentFormVersionOperation : DataModuleOperation<Int64, Int32>
	{
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="FormId">Form identifier.</param>
		/// <returns>The current version number of the Form.</returns>
		public override Int32 Execute(Int64 FormId)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var version = dbConnection.
					GetScalar<FormRevision, Int32>(
						q => Sql.Max(q.Version), 
						q => q.FormId == FormId && 
						q.Status == FormStatus.Active);

				return version;
			}
		}
	}
}

