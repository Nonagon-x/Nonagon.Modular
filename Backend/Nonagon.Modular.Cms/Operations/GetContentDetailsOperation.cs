using System;
using System.Linq;
using System.Linq.Expressions;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// Get content details operation.
	/// </summary>
	public class GetContentDetailsOperation : DataModuleOperation<GetContentDetailsOperation.Param, Content>
	{
		/// <summary>
		/// GetContentDetailsOperation parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the content identifier.
			/// </summary>
			/// <value>The content identifier.</value>
			public Int64? ContentId { get; set; }

			/// <summary>
			/// Gets or sets the content key.
			/// </summary>
			/// <value>The content key.</value>
			public String Key { get; set; }
			
			/// <summary>
			/// Gets or sets the version.
			/// </summary>
			/// <value>The version.</value>
			public Int32? Version { get; set; }
		}
		
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">The input parameter.</param>
		public override Content Execute(Param param)
		{
			if(param.ContentId == null && param.Key == null)
				throw(new ArgumentException("param.ContentId or param.Key"));

			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				Expression<Func<Content, Boolean>> predicate = null;

				if(param.ContentId != null) {
					predicate = q => q.Id == param.ContentId;
				}

				if(param.Key != null) {
					predicate = q => q.Key == param.Key;
				}

				var content =
					dbConnection.FirstOrDefault<Content>(predicate);

				var contentRevision = 
					dbConnection.FirstOrDefault<ContentRevision>(
						q => q.ContentId == content.Id && q.Version == param.Version);
				
				if(contentRevision != null) {
					
					content.Revision = contentRevision;
				}
				
				return content;
			}
		}
	}
}

