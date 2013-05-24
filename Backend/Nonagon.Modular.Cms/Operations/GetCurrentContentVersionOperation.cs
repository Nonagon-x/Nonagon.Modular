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
			public Int64? ContentId { get; set; }

			/// <summary>
			/// Gets or sets the content key.
			/// </summary>
			/// <value>The content key.</value>
			public String Key { get; set; }
		}

		/// <summary>
		/// Execute this operation with input parameter.
		/// </summary>
		/// <param name="param">Parameter.</param>
		/// <returns>The current version number of the content.</returns>
		public override Int32 Execute(Param param)
		{
			if(param.ContentId == null && param.Key == null)
				throw(new ArgumentException("param.ContentId or param.Key"));

			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				if(param.ContentId == null && param.Key != null) {

					param.ContentId = dbConnection.GetScalar<Content, Int64>(
						q => q.Id, q => q.Key == param.Key);
				}

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

