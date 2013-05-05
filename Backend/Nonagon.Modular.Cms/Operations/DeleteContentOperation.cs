using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// Delete content operation.
	/// </summary>
	public class DeleteContentOperation : DataModuleOperation<Int64, Int32>
	{
		/// <summary>
		/// Execute delete content operation.
		/// </summary>
		/// <param name="contentId">Content identifier.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Int64 contentId)
		{
			int rowAffected = 0;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				rowAffected = dbConnection.Update<Content>(
					new { 
						Status = ContentStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.Id == contentId
				);
				
				rowAffected += dbConnection.Update<ContentRevision>(
					new { 
					Status = ContentStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.Id == contentId
				);
			}
			
			return rowAffected;
		}
	}
}

