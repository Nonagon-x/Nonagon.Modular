using System;
using System.Linq;
using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// Get the current content version operation.
	/// </summary>
	public class GetCurrentContentVersionOperation : 
		DataModuleOperation<GetCurrentContentVersionOperation.Param, Int32>
	{
		/// <summary>
		/// Get current content version parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the content identifier.
			/// </summary>
			/// <value>The content identifier.</value>
			public Int64 ContentId { get; set; }
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="param">Parameter.</param>
		/// <returns>The current version number of the content.</returns>
		public override Int32 Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var version = dbConnection.
					GetScalar<ContentRevision, Int32>(
						q => Sql.Max(q.Version), 
						q => q.ContentId == param.ContentId && 
						q.Status == ContentStatus.Active);

				return version;
			}
		}
	}
}

