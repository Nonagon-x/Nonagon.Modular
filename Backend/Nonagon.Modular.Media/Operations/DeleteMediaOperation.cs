using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// Delete media operation.
	/// </summary>
	public class DeleteMediaOperation : DataModuleOperation<Int64, Int32>
	{
		/// <summary>
		/// Execute delete media operation.
		/// </summary>
		/// <param name="mediaId">Media identifier.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Int64 mediaId)
		{
			int rowAffected = 0;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				rowAffected = dbConnection.Update<Media>(
					new { 
						Status = MediaStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.Id == mediaId
				);
			}
			
			return rowAffected;
		}
	}
}

