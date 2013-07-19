using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Table row for table layout.
	/// </summary>
	public class TableRow : FormElementGroup, IHasChildren
	{
		/// <summary>
		/// Gets or sets the <c>TableCell</c> as children.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }
	}
}