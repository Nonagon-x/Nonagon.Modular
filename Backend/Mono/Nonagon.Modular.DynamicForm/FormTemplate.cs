using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Form layout template.
	/// </summary>
	public class FormTemplate
	{
		/// <summary>
		/// Gets or sets the Form children.
		/// </summary>
		/// <value>The children.</value>
		public IEnumerable<IFormElement> Children { get; set; }
	}
}

