using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Delete Form operation.
	/// </summary>
	public class DeleteFormOperation : DataModuleOperation<DeleteFormOperation.Param, Int32>
	{
		/// <summary>
		/// DeleteFormOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the Form identifier.
			/// </summary>
			/// <value>The Form identifier.</value>
			public Int64 FormId { get; set; }

			/// <summary>
			/// Gets or sets the revision identifier.
			/// </summary>
			/// <value>The revision identifier.</value>
			public Int64? RevisionId { get; set; }
		}

		/// <summary>
		/// Execute delete Form operation.
		/// </summary>
		/// <param name="param">Parameter.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Param param)
		{
			int rowAffected = 0;

			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				if(param.RevisionId == null) 
				{
					rowAffected = dbConnection.Update<Form>(
						new { 
								Status = FormStatus.Deleted,
								LastUpdatedDate = DateTime.UtcNow
							},
							q => q.Id == param.FormId
						);

					rowAffected += dbConnection.Update<FormRevision>(
						new { 
								Status = FormStatus.Deleted,
								LastUpdatedDate = DateTime.UtcNow
							},
							q => q.FormId == param.FormId
						);
				}
				else
				{
					rowAffected += dbConnection.Update<FormRevision>(
						new { 
								Status = FormStatus.Deleted,
								LastUpdatedDate = DateTime.UtcNow
							},
							q => q.Id == param.RevisionId &&
								 q.FormId == param.FormId
						);
				}
			}
			
			return rowAffected;
		}
	}
}

