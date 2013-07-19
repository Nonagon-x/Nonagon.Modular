using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	public class DeleteFormInstanceOperation : 
		DataModuleOperation<DeleteFormInstanceOperation.Param, Int32>
	{
		/// <summary>
		/// DeleteFormInstanceOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the form instance identifier.
			/// </summary>
			/// <value>The form instance identifier.</value>
			public Int64 FormInstanceId { get; set; }
		}

		/// <summary>
		/// Execute delete form instance operation.
		/// </summary>
		/// <param name="param">Parameter.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Param param)
		{
			int rowAffected = 0;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				rowAffected = dbConnection.Update<FormInstance>(
					new { 
						Status = FormStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.Id == param.FormInstanceId
				);

				rowAffected += dbConnection.Update<FormInstanceValue>(
					new { 
						Status = FormStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.FormInstanceId == param.FormInstanceId
				);
			}
			
			return rowAffected;
		}
	}
}

