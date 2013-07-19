using System;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Time picker field attribute.
	/// </summary>
	public class TimePickerFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public FieldType SupportedFieldType {
			get { return FieldType.TimePicker; }
		}

		/// <summary>
		/// Gets or sets the minimum time.
		/// </summary>
		/// <value>The minimum time.</value>
		public Double MinTime { get; set; }

		/// <summary>
		/// Gets or sets the max time.
		/// </summary>
		/// <value>The max time.</value>
		public Double MaxTime { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.TimePickerFieldAttribute"/> enable minimum range.
		/// </summary>
		/// <value><c>true</c> if enable minimum range; otherwise, <c>false</c>.</value>
		public Boolean EnableMinRange { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether this
		/// <see cref="Nonagon.Modular.DynamicForm.FieldAttributes.TimePickerFieldAttribute"/> enable max range.
		/// </summary>
		/// <value><c>true</c> if enable max range; otherwise, <c>false</c>.</value>
		public Boolean EnableMaxRange { get; set; }
	}
}

