using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Delete Form operation.
	/// </summary>
	public class DeleteFormOperation : DataModuleOperation<Int64, Int32>
	{
		/// <summary>
		/// Execute delete Form operation.
		/// </summary>
		/// <param name="formId">Form identifier.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Int64 formId)
		{
			int rowAffected = 0;

			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				rowAffected = dbConnection.Update<Form>(
					new { 
							Status = FormStatus.Deleted,
							LastUpdatedDate = DateTime.UtcNow
						},
						q => q.Id == formId
					);

				rowAffected += dbConnection.Update<FormRevision>(
					new { 
							Status = FormStatus.Deleted,
							LastUpdatedDate = DateTime.UtcNow
						},
						q => q.Id == formId
					);
			}
			
			return rowAffected;
		}
	}
}

