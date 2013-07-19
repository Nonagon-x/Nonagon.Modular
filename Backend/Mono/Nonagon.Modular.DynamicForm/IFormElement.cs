using System;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The interface for all Form element.
	/// </summary>
	public interface IFormElement
	{
		/// <summary>
		/// Gets or sets the width of the element.
		/// </summary>
		/// <value>The width.</value>
		FormLayoutWidth Width { get; set; }

		/// <summary>
		/// Gets or sets the height of the element
		/// </summary>
		/// <value>The height.</value>
		FormLayoutHeight Height { get; set; }

		/// <summary>
		/// Gets or sets the margin of the element.
		/// </summary>
		/// <value>The margin.</value>
		FormLayoutThickness Margin { get; set; }

		/// <summary>
		/// Gets or sets the padding of the element.
		/// </summary>
		/// <value>The padding.</value>
		FormLayoutThickness Padding { get; set; }
	}
}

