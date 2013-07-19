using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The interface for all Form element which will have multiple child.
	/// </summary>
	public interface IHasChildren
	{
		/// <summary>
		/// Gets or sets the children elements.
		/// </summary>
		/// <value>The children elements.</value>
		IEnumerable<IFormElement> Children { get; set; }
	}
}

