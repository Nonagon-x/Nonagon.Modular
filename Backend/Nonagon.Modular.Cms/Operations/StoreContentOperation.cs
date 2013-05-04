using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// The operation to store the content.
	/// </summary>
	public class StoreContentOperation : DataModuleOperation<Content, Content>
	{
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="content">Content to be stored.</param>
		public override Content Execute(Content content)
		{
			if(content == null)
				throw new ArgumentException("content");
			
			if(content.Revision == null)
				throw new ArgumentException("content.Revision");
			
			// If this is the new content.
			if(content.Id <= 0) {
				content.CreatedDate = DateTime.UtcNow;
				content.Reference = Guid.NewGuid().ToString();
				content.Status = ContentStatus.Inactive;
			}
			
			content.LastUpdatedDate = DateTime.UtcNow;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				using(var dbTransaction = dbConnection.BeginTransaction())
				{
					// Insert or update Content table depending on if Id presented.
					if(content.Id <= 0)
					{
						dbConnection.Insert(content);
						content.Id = dbConnection.GetLastInsertId();
					}
					else
					{
						dbConnection.Update(content);
					}
					
					// Insert or update ContentRevision table depending on if Id presented.
					content.Revision.ContentId = content.Id;
					content.Revision.LastUpdatedDate = content.LastUpdatedDate;
					
					if(content.Revision.Id <= 0)
					{
						content.Revision.CreatedDate = DateTime.Now;
						content.Status = ContentStatus.Inactive;
						
						dbConnection.Insert(content.Revision);
						content.Revision.Id = dbConnection.GetLastInsertId();
					}
					else
					{
						dbConnection.Update(content.Revision);
					}
					
					dbTransaction.Commit();
				}
			}
			
			return content;
		}
	}
}

