using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Phone number field attribute.
	/// </summary>
	public class PhoneNumberFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.PhoneNumber; }
		}
	}
}

