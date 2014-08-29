using System;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Content.Operations
{
	/// <summary>
	/// The operation to store the content.
	/// </summary>
	public class StoreContentOperation : DataModuleOperation<StoreContentOperation.Param, Content>
	{
		/// <summary>
		/// Store content parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the content to be stored.
			/// </summary>
			/// <value>The content.</value>
			public Content Content { get; set; }
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="content">Content to be stored.</param>
		public override Content Execute(Param param)
		{
			if(param == null)
				throw new ArgumentException("param");

			if(param.Content == null)
				throw new ArgumentException("param.Content");
			
			if(param.Content.Revision == null)
				throw new ArgumentException("param.Content.Revision");

			Content content = param.Content;
			
			// If this is the new content.
			if(content.Id <= 0) {
				content.CreatedDate = DateTime.UtcNow;
				content.Reference = Guid.NewGuid().ToString();
			}
			
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
					content.Revision.LastUpdatedDate = DateTime.UtcNow;

					// TODO: The keyword extractor is necessary here.
					content.Revision.Keywords = "";
					
					if(content.Revision.Id <= 0)
					{
						content.Revision.CreatedDate = DateTime.UtcNow;

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

