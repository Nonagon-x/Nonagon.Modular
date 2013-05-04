using System;
using System.Linq;
using System.Collections.Generic;

using ServiceStack.OrmLite;

namespace Nonagon.Modular.DynamicForm.Operations
{
	/// <summary>
	/// Get all Forms operation.
	/// </summary>
	public class GetFormsOperation : DataModuleOperation<GetFormsOperation.Param, IEnumerable<IForm>>
	{
		/// <summary>
		/// Get all Forms parameter.
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
		/// <returns>List of Forms.</returns>
		public override IEnumerable<IForm> Execute(Param param)
		{
			using(var dbConnection = DbConnectionFactory.OpenDbConnection())
			{
				var ev = OrmLiteConfig.DialectProvider.ExpressionVisitor<Form>();

				ev.Where(q => q.Status == FormStatus.Active);

				if(param != null)
					ev.Limit(param.Skip, param.Take);

				return dbConnection.Select<Form>(ev).Select(f => (IForm)f);
			}
		}
	}
}

