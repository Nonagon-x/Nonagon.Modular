using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Digits field attribute.
	/// </summary>
	public class DigitsFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.Digits; }
		}

		/// <summary>
		/// Gets or sets the minimum value.
		/// </summary>
		/// <value>The minimum value.</value>
		public Int64 MinValue { get; set; }

		/// <summary>
		/// Gets or sets the max value.
		/// </summary>
		/// <value>The max value.</value>
		public Int64 MaxValue { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.DecimalFieldAttribute"/> enable minimum range.
		/// </summary>
		/// <value><c>true</c> if enable minimum range; otherwise, <c>false</c>.</value>
		public Boolean EnableMinRange { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.DecimalFieldAttribute"/> enable max range.
		/// </summary>
		/// <value><c>true</c> if enable max range; otherwise, <c>false</c>.</value>
		public Boolean EnableMaxRange { get; set; }
	}
}

