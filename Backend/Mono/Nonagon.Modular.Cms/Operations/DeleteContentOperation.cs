using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// Delete content operation.
	/// </summary>
	public class DeleteContentOperation : DataModuleOperation<DeleteContentOperation.Param, Int32>
	{
		/// <summary>
		/// DeleteContentOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the content identifier.
			/// </summary>
			/// <value>The Form identifier.</value>
			public Int64 ContentId { get; set; }
			
			/// <summary>
			/// Gets or sets the revision identifier.
			/// </summary>
			/// <value>The revision identifier.</value>
			public Int64? RevisionId { get; set; }
		}

		/// <summary>
		/// Execute delete content operation.
		/// </summary>
		/// <param name="contentId">Content identifier.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Param param)
		{
			int rowAffected = 0;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				if(param.RevisionId == null) 
				{
					rowAffected = dbConnection.Update<Content>(
						new { 
							Status = ContentStatus.Deleted,
							LastUpdatedDate = DateTime.UtcNow
						},
						q => q.Id == param.ContentId
					);
					
					rowAffected += dbConnection.Update<ContentRevision>(
						new { 
							Status = ContentStatus.Deleted,
							LastUpdatedDate = DateTime.UtcNow
						},
						q => q.ContentId == param.ContentId
					);
				}
				else
				{
					rowAffected += dbConnection.Update<ContentRevision>(
						new { 
							Status = ContentStatus.Deleted,
							LastUpdatedDate = DateTime.UtcNow
						},
						q => q.Id == param.RevisionId &&
						q.ContentId == param.ContentId
					);
				}
			}
			
			return rowAffected;
		}
	}
}

