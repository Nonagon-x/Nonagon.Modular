using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Multiline text field attribute.
	/// </summary>
	public class MultilineTextFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.MultilineText; }
		}
		
		/// <summary>
		/// Gets or sets the maximum length.
		/// </summary>
		/// <value>The maximum length.</value>
		public Int32 MaxLength { get; set; }

		/// <summary>
		/// Gets or sets the maximum lines allow.
		/// </summary>
		/// <value>The maximum lines.</value>
		public Int32 MaxLines { get; set; }
	}
}

