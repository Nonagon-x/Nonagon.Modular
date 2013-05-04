using System;
using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Table layout.
	/// </summary>
	public class Table : FormElementGroup, IHasChildren
	{
		/// <summary>
		/// Gets or sets a value indicating whether this instance has borders.
		/// </summary>
		/// <value><c>true</c> if this instance has borders; otherwise, <c>false</c>.</value>
		public Boolean HasBorders { get; set; }

		/// <summary>
		/// Gets or sets the <c>TableRow</c> as children.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }

		/// <summary>
		/// Gets or sets the column count.
		/// </summary>
		/// <value>The column count.</value>
		public Int32 ColumnCount { get; set; }
	}
}