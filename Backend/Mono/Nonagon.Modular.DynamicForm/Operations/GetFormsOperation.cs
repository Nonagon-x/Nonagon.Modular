using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;

using ServiceStack.OrmLite;

using Nonagon.Modular.Params;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get all Forms operation.
	/// </summary>
	public class GetFormsOperation : DataModuleOperation<GetFormsOperation.Param, IEnumerable<IForm>>
	{
		/// <summary>
		/// Get all forms parameter.
		/// </summary>
		public class Param : ListOperationParam<Form> {}

		public override IEnumerable<IForm> Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<Form>();
				//ev.Where(q => q.Status == FormStatus.Active);

				if(param != null) {

					if(param.Predicate != null) {

						ev.Where(param.Predicate);
					}

					ev.OrderByExpression = param.OrderBy;
					ev.Limit(param.Skip, param.Take);
				}

				return dbConnection.Select<Form>(ev).Select(f => (IForm)f);
			}
		}
	}
}