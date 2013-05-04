using System;
using System.Collections.Generic;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	public class StoreFormInstanceOperation : DataModuleOperation<FormInstance, FormInstance>
	{
		public override FormInstance Execute(FormInstance formInstance)
		{
			if(formInstance == null)
				throw new ArgumentException("formInstance");

			// If this is the new Form.
			if(formInstance.Id <= 0) {
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