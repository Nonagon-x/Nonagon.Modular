using System;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// Field attribute interface.
	/// </summary>
	public interface IFieldAttribute
	{
		/// <summary>
		/// Gets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		FieldType SupportedFieldType { get; }
	}
}

