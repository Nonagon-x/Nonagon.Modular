using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	public class ChoicesFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.Choices; }
		}

		/// <summary>
		/// Gets or sets the selectable items.
		/// </summary>
		/// <value>The selectable items.</value>
		public IEnumerable<SelectableItem> SelectableItems { get; set; }
	}
}

