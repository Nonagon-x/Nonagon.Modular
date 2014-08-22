using System;
using System.Linq;
using System.Linq.Expressions;

namespace Nonagon.Modular.Params
{
	/// <summary>
	/// Base class of Get List operation parameter.
	/// </summary>
	public abstract class ListOperationParam<T>
	{
		/// <summary>
		/// Gets or sets the predicate (not visible for client).
		/// </summary>
		/// <value>The predicate.</value>
		public Expression<Func<T, Boolean>> Predicate { get; set; }

		/// <summary>
		/// Gets or sets the order by expression.
		/// </summary>
		/// <value>The order by.</value>
		public String OrderBy { get; set; }

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
}