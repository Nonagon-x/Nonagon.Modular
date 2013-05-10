using System;
using System.Linq;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get Form details operation.
	/// </summary>
	public class GetFormDetailsOperation : DataModuleOperation<GetFormDetailsOperation.Param, Form>
	{
		/// <summary>
		/// GetFormDetailsOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the Form identifier.
			/// </summary>
			/// <value>The Form identifier.</value>
			public Int64 FormId { get; set; }

			/// <summary>
			/// Gets or sets the version.
			/// </summary>
			/// <value>The version.</value>
			public Int32? Version { get; set; }
		}

		public override Form Execute(Param input)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var form =
					dbConnection.FirstOrDefault<Form>(q => q.Id == input.FormId);

				var formRevision = 
					dbConnection.FirstOrDefault<FormRevision>(
						q => q.FormId == input.FormId && q.Version == input.Version);

				if(formRevision != null) {

					form.Revision = formRevision;

					var formFields =
						dbConnection.Select<FormField>(
							q => q.FormRevisionId == formRevision.Id);
					
					formRevision.Fields = formFields.Select(q => (FormField)q);
				}

				return form;
			}
		}
	}
}

