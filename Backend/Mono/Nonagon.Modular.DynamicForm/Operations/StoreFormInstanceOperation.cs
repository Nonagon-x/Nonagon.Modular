using System;
using System.Collections.Generic;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// The operation to store form instance.
	/// </summary>
	public class StoreFormInstanceOperation : DataModuleOperation<StoreFormInstanceOperation.Param, FormInstance>
	{
		/// <summary>
		/// Store form instance parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the form instance.
			/// </summary>
			/// <value>The form instance.</value>
			public FormInstance FormInstance { get; set; }
		}

		public override FormInstance Execute(Param param)
		{
			if(param == null)
				throw new ArgumentException("param");

			if(param.FormInstance == null)
				throw new ArgumentException("param.FormInstance");

			FormInstance formInstance = param.FormInstance;

			// If this is the new Form.
			if(formInstance.Id <= 0)
			{
				formInstance.CreatedDate = DateTime.UtcNow;
				formInstance.Reference = Guid.NewGuid().ToString();
				formInstance.Status = FormStatus.Inactive;
			}
			
			formInstance.LastUpdatedDate = DateTime.UtcNow;

			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				using(var dbTransaction = dbConnection.BeginTransaction())
				{
					// Insert or update FormInstance table depending on if Id presented.
					if(formInstance.Id <= 0)
					{
						dbConnection.Insert(formInstance);
						formInstance.Id = dbConnection.GetLastInsertId();
					}
					else
					{
						dbConnection.Update(formInstance);
					}

					// Manipulate FormInstanceValues.
					if(formInstance.Values != null)
					{
						List<Int64> currentIds = new List<Int64>();
						
						foreach(var value in formInstance.Values)
						{
							value.FormInstanceId = formInstance.Id;

							if(value.Id <= 0)
							{
								dbConnection.Insert(value);
								value.Id = dbConnection.GetLastInsertId();
							}
							else
							{
								dbConnection.Update(value);
							}
							
							currentIds.Add(value.Id);
						}
						
						// Delete all fields that are not exists in currentIds collection.
						SqlExpressionVisitor<FormInstanceValue> ev = 
							OrmLiteConfig.DialectProvider.ExpressionVisitor<FormInstanceValue>();
						
						ev.Where(rn=> !Sql.In(rn.Id, currentIds) && rn.FormInstanceId == formInstance.Id);
						dbConnection.Delete(ev);
					}

					dbTransaction.Commit();
				}
			}

			return formInstance;
		}
	}
}