using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Form section.
	/// </summary>
	public class Section : FormElementGroup, IHasChildren
	{
		/// <summary>
		/// Gets or sets the list of <c>IFormElement</c>.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }
	}
}

