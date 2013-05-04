using System;

using ServiceStack.DesignPatterns.Model;

using Nonagon.Reflection;
using Nonagon.Modular.Strings;

namespace Nonagon.Modular.DynamicForm
{
	/// <summary>
	/// The field definition interface of Form
	/// </summary>
	public interface IFormField : IDuplicable
	{
		/// <summary>
		/// Gets the identifier of field.
		/// </summary>
		/// <value>The identifier.</value>
		Int64 Id { get; }

		/// <summary>
		/// Gets or sets the Form version identifier.
		/// </summary>
		/// <value>The Form version identifier.</value>
		Int64 FormRevisionId { get; set; }

		/// <summary>
		/// Gets or sets the field code. The field code is the key of field.
		/// </summary>
		/// <value>The field code.</value>
		String FieldCode { get; set; }

		/// <summary>
		/// Gets or sets the name key.
		/// </summary>
		/// <value>The name key.</value>
		LocalizedString Name { get; set; }

		/// <summary>
		/// Gets or sets the type of the field.
		/// </summary>
		/// <value>The type of the field.</value>
		FieldType FieldType { get; set; }

		/// <summary>
		/// Gets or sets the details of field definition.
		/// </summary>
		/// <value>The field info.</value>
		FieldInfo FieldInfo { get; set; }
	}
}

