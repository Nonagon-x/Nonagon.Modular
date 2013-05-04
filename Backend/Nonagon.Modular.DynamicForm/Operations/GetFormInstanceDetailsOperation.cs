using System;
using System.Linq;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get form instance details operation.
	/// </summary>
	public class GetFormInstanceDetailsOperation : DataModuleOperation<Int64, FormInstance>
	{
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="FormInstanceId">The Form instance identifier.</param>
		public override FormInstance Execute(Int64 formInstanceId)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var FormInstance = dbConnection.
					Select<FormInstance>(
						q => q.Id == formInstanceId).FirstOrDefault();

				if(FormInstance != null) {
					FormInstance.Values = dbConnection.
						Select<FormInstanceValue>(
							q => q.FormInstanceId == formInstanceId).
								Select(q => (FormInstanceValue)q);
				}
				
				return FormInstance;
			}
		}
	}
}

