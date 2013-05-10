using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// Delete media operation.
	/// </summary>
	public class DeleteMediaOperation : DataModuleOperation<DeleteMediaOperation.Param, Int32>
	{
		/// <summary>
		/// Delete media parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the media identifier.
			/// </summary>
			/// <value>The media identifier.</value>
			public Int64 MediaId { get; set; }
		}	

		/// <summary>
		/// Execute delete media operation.
		/// </summary>
		/// <param name="mediaId">Media identifier.</param>
		/// <returns>The number of records affected by the delete.</returns>
		public override Int32 Execute(Param param)
		{
			int rowAffected = 0;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				rowAffected = dbConnection.Update<Media>(
					new { 
						Status = MediaStatus.Deleted,
						LastUpdatedDate = DateTime.UtcNow
					},
					q => q.Id == param.MediaId
				);
			}
			
			return rowAffected;
		}
	}
}

