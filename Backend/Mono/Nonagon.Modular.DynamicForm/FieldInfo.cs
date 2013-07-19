using System;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Field info class.
	/// </summary>
	public class FieldInfo
	{
		/// <summary>
		/// Gets or sets the default value for the field.
		/// </summary>
		/// <value>The default value.</value>
		public Object DefaultValue { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether the field is required.
		/// </summary>
		/// <value><c>true</c> if is required; otherwise, <c>false</c>.</value>
		public Boolean IsRequired { get; set; }

		/// <summary>
		/// Gets or sets the field attribute.
		/// </summary>
		/// <value>The field attribute.</value>
		public IFieldAttribute FieldAttribute { get; set; }
	}
}

