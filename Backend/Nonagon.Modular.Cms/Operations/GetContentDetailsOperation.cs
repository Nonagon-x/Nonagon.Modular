using System;
using System.Linq;

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
			public Int64 ContentId { get; set; }
			
			/// <summary>
			/// Gets or sets the version.
			/// </summary>
			/// <value>The version.</value>
			public Int32 Version { get; set; }
		}
		
		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="input">The input parameter.</param>
		public override Content Execute(Param input)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var form =
					dbConnection.FirstOrDefault<Content>(q => q.Id == input.ContentId);
				
				var contentRevision = 
					dbConnection.FirstOrDefault<ContentRevision>(
						q => q.ContentId == input.ContentId && q.Version == input.Version);
				
				if(contentRevision != null) {
					
					form.Revision = contentRevision;
				}
				
				return form;
			}
		}
	}
}

