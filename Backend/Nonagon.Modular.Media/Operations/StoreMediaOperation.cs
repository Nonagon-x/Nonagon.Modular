using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// The operation to store the media.
	/// </summary>
	public class StoreMediaOperation : DataModuleOperation<StoreMediaOperation.Param, Media>
	{
		/// <summary>
		/// Store media parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the media identifier.
			/// </summary>
			/// <value>The media identifier.</value>
			public Int64 MediaId { get; set; }

			/// <summary>
			/// Gets or sets the name.
			/// </summary>
			/// <value>The name.</value>
			public String Name { get; set; }

			/// <summary>
			/// Gets or sets the data.
			/// </summary>
			/// <value>The byte data.</value>
			public Byte[] Data { get; set; }

			/// <summary>
			/// Gets or sets the tag.
			/// </summary>
			/// <value>The tag.</value>
			public String Tag { get; set; }
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="media">Content to be stored.</param>
		public override Media Execute(Param param)
		{
			if(param == null)
				throw new ArgumentException("param");

			Media media;

			// If this is the new media.
			if(param.MediaId <= 0) {

				media = new Media {
					
					Id = param.MediaId,
					Data = param.Data,
					Name = param.Name,
					Tag = param.Tag
				};

				media.CreatedDate = DateTime.UtcNow;
				media.Reference = Guid.NewGuid().ToString();
				media.Status = MediaStatus.Available;

			} else {

				using(var dbConnection = DbConnectionFactory.OpenDbConnection())
				{
					media = dbConnection.
						FirstOrDefault<Media>(q => q.Id == param.MediaId);
				}
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

