using System;
using System.Collections.Generic;

namespace Nonagon.Modular.DynamicForm.FieldAttributes
{
	/// <summary>
	/// Single check field attribute.
	/// </summary>
	public class SingleCheckFieldAttribute : IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		public virtual FieldType SupportedFieldType {
			get { return FieldType.SingleCheck; }
		}

		/// <summary>
		/// Gets or sets the field value.
		/// </summary>
		/// <value>The field value.</value>
		public String FieldValue { get; set; }

		/// <summary>
		/// Gets or sets the name of the group.
		/// </summary>
		/// <value>The name of the group.</value>
		public String GroupName { get; set; }
	}
}

