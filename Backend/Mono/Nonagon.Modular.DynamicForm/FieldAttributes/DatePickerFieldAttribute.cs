using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Date picker field attribute.
	/// </summary>
	public class DatePickerFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.DatePicker; }
		}

		/// <summary>
		/// Gets or sets the minimum date.
		/// </summary>
		/// <value>The minimum date.</value>
		public DateTimeOffset MinDate { get; set; }

		/// <summary>
		/// Gets or sets the maximum date.
		/// </summary>
		/// <value>The maximum date.</value>
		public DateTimeOffset MaxDate { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.DateRangeFieldAttribute"/> enable minimum range.
		/// </summary>
		/// <value><c>true</c> if enable minimum range; otherwise, <c>false</c>.</value>
		public Boolean EnableMinRange { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.DateRangeFieldAttribute"/> enable max range.
		/// </summary>
		/// <value><c>true</c> if enable max range; otherwise, <c>false</c>.</value>
		public Boolean EnableMaxRange { get; set; }
	}
}

