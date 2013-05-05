using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// The operation to store the media.
	/// </summary>
	public class StoreMediaOperation : DataModuleOperation<Media, Media>
	{
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="media">Content to be stored.</param>
		public override Media Execute(Media media)
		{
			if(media == null)
				throw new ArgumentException("media");

			// If this is the new media.
			if(media.Id <= 0) {
				media.CreatedDate = DateTime.UtcNow;
				media.Reference = Guid.NewGuid().ToString();
				media.Status = MediaStatus.Available;
			}
			
			media.LastUpdatedDate = DateTime.UtcNow;
			
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				using(var dbTransaction = dbConnection.BeginTransaction())
				{
					// Insert or update Media table depending on if Id presented.
					if(media.Id <= 0)
					{
						dbConnection.Insert(media);
						media.Id = dbConnection.GetLastInsertId();
					}
					else
					{
						dbConnection.Update(media);
					}

					dbTransaction.Commit();
				}
			}
			
			return media;
		}
	}
}

