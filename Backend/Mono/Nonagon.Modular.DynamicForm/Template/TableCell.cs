using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Table cell for table row layout.
	/// </summary>
	public class TableCell : FormElementGroup
	{
		/// <summary>
		/// Gets or sets the <c>TableCell</c> as children.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }
	}
}