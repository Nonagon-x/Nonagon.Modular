using System;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Form element base class.
	/// </summary>
	public abstract class FormElement : IFormElement
	{
		/// <summary>
		/// Gets or sets the width of the element.
		/// </summary>
		/// <value>The width.</value>
		public FormLayoutWidth Width { get; set; }
		
		/// <summary>
		/// Gets or sets the height of the element
		/// </summary>
		/// <value>The height.</value>
		public FormLayoutHeight Height { get; set; }
		
		/// <summary>
		/// Gets or sets the margin of the element.
		/// </summary>
		/// <value>The margin.</value>
		public FormLayoutThickness Margin { get; set; }
		
		/// <summary>
		/// Gets or sets the padding of the element.
		/// </summary>
		/// <value>The padding.</value>
		public FormLayoutThickness Padding { get; set; }
	}
}