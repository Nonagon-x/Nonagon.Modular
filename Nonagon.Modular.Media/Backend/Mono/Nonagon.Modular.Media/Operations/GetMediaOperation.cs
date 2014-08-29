using System;
using System.Linq;
using System.Collections.Generic;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Media.Operations
{
	/// <summary>
	/// Get all media operation.
	/// </summary>
	public class GetMediaOperation : DataModuleOperation<GetMediaOperation.Param, IEnumerable<IMedia>>
	{
		/// <summary>
		/// Get all media parameter.
		/// </summary>
		public class Param
		{
			/// <summary>
			/// Gets or sets the number of records to skip.
			/// </summary>
			/// <value>The number of records to skip.</value>
			public Int32 Skip { get; set; }
			
			/// <summary>
			/// Gets or sets the number of records to take.
			/// </summary>
			/// <value>The number of records to take.</value>
			public Int32 Take { get; set; }
		}
		
		/// <summary>
		/// Execute this operation.
		/// </summary>
		/// <returns>List of forms.</returns>
		public override IEnumerable<IMedia> Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<Media>();
				
				ev.Where(q => q.Status == MediaStatus.Available);
				
				if(param != null)
					ev.Limit(param.Skip, param.Take);
				
				return dbConnection.Select<Media>(ev).Select(m => (IMedia)m);
			}
		}
	}
}