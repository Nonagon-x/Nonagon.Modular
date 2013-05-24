using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

using ServiceStack.OrmLite;

using Nonagon.Modular.Params;
using System;

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
		public class Param : ListOperationParam<Content> {}

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

				if(param != null) {
					
					if(param.Predicate != null) {
						
						ev.Where(param.Predicate);
					}
					
					ev.OrderByExpression = param.OrderBy;
					ev.Limit(param.Skip, param.Take);
				}

				return dbConnection.Select<Content>(ev).Select(c => (IContent)c);;
			}
		}

		/// <summary>
		/// Gets the default parameter.
		/// </summary>
		/// <value>The default parameter.</value>
		public static Param DefaultParam
		{
			get
			{
				var param = new Param {
					Skip = 0,
					Take = Int32.MaxValue
				};

				return param;
			}
		}
	}
}

