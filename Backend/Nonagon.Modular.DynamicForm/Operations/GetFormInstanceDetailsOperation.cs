using System;
using System.Linq;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get form instance details operation.
	/// </summary>
	public class GetFormInstanceDetailsOperation : 
		DataModuleOperation<GetFormInstanceDetailsOperation.Param, FormInstance>
	{
		/// <summary>
		/// GetFormInstanceDetailsOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the form instance identifier.
			/// </summary>
			/// <value>The form instance identifier.</value>
			public Int64 FormInstanceId { get; set; }
		}

		public override FormInstance Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var formInstance = dbConnection.
					Select<FormInstance>(
						q => q.Id == param.FormInstanceId).FirstOrDefault();

				if(formInstance != null) {
					formInstance.Values = dbConnection.
						Select<FormInstanceValue>(
							q => q.FormInstanceId == param.FormInstanceId).
								Select(q => (FormInstanceValue)q);
				}
				
				return formInstance;
			}
		}
	}
}

