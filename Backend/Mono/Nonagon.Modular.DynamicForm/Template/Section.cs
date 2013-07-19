using Nonagon.Modular.Strings;

namespace Nonagon.Modular.DynamicForm.Template
{
	/// <summary>
	/// Form section.
	/// </summary>
	public class Section : FormElementGroup, IHasChildren
	{
		/// <summary>
		/// Gets or sets the title of section.
		/// </summary>
		/// <value>The title.</value>
		public LocalizedString Title { get; set; }
	}
}

