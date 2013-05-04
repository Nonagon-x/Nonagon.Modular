using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Free Text field attribute.
	/// </summary>
	public class FreeTextFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.FreeText; }
		}

		/// <summary>
		/// Gets or sets the maximum length.
		/// </summary>
		/// <value>The maximum length.</value>
		public Int32 MaxLength { get; set; }
	}
}

