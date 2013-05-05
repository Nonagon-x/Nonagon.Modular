namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Field type to define the field.
	/// </summary>
	public enum FieldType
	{
		/// <summary>
		/// The free text input box.
		/// </summary>
		FreeText,

		/// <summary>
		/// The multiline text input box.
		/// </summary>
		MultilineText,

		/// <summary>
		/// The email only input box.
		/// </summary>
		Email,

		/// <summary>
		/// The phone number only input box.
		/// </summary>
		PhoneNumber,

		/// <summary>
		/// The decimal number input box.
		/// </summary>
		Decimal,

		/// <summary>
		/// The number only input box.
		/// </summary>
		Digits,

		/// <summary>
		/// The url input box.
		/// </summary>
		Url,

		/// <summary>
		/// The choices (select only one item).
		/// </summary>
		Choices,

		/// <summary>
		/// The checkbox which only one item can be checked.
		/// </summary>
		SingleCheck,

		/// <summary>
		/// The checkbox which multiple items can be checked.
		/// </summary>
		MultiChecks,

		/// <summary>
		/// The date picker.
		/// </summary>
		DatePicker,

		/// <summary>
		/// The time picker.
		/// </summary>
		TimePicker,

		/// <summary>
		/// The date and time picker.
		/// </summary>
		DateTimePicker,

		/// <summary>
		/// The picture field.
		/// </summary>
		Picture
	}
}

