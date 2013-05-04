using System;
using System.Linq;
using System.Collections.Generic;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.Cms.Operations
{
	/// <summary>
	/// Get all contents operation.
	/// </summary>
	public class GetContentsOperation : DataModuleOperation<GetContentsOperation.Param, IEnumerable<IContent>>
	{
		/// <summary>
		/// Get all contents parameter.
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
		public override IEnumerable<IContent> Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<Content>();
				
				ev.Where(q => q.Status == ContentStatus.Active);
				
				if(param != null)
					ev.Limit(param.Skip, param.Take);
				
				return dbConnection.Select<Content>(ev).Select(f => (IContent)f);
			}
		}
	}
}

