using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Form element container base class.
	/// </summary>
	public abstract class FormElementGroup : FormElement, IFormElementGroup
	{
		/// <summary>
		/// Gets or sets the layout type this element will use.
		/// </summary>
		/// <value>The layout type.</value>
		public FormLayoutType LayoutType { get; set; }
		
		/// <summary>
		/// Gets or sets the orientation.
		/// </summary>
		/// <value>The orientation.</value>
		public FormLayoutOrientation Orientation { get; set; }
		
		/// <summary>
		/// Gets or sets the list of <c>IFormElement</c>.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }
	}
}